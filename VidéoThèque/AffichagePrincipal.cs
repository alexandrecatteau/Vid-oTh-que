using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace VidéoThèque
{
    public partial class AffichagePrincipal : Form
    {
        private bool affichageFilms;
        private bool affichageSeries;
        private string annee;
        private readonly string cleAPI = "30666db2f7a024c11b30b58b88983362";
        private TreeNode couleurFont;
        private TreeNode couleurText;
        private readonly string debutURL = "https://api.themoviedb.org/3/discover/";
        private readonly string langueURL = "language=fr-FR";
        private string lienAPI;
        private List<ObjetsDataGridView> objetsDataGridView;
        private int page = 1;

        /// <summary>
        ///     Initialisation de la fenêtre
        /// </summary>
        public AffichagePrincipal()
        {
            InitializeComponent();
            CreationAnneesTreewview();
        }

        /// <summary>
        ///     Désactive les boutons de navigations de pages quand nécessaire
        /// </summary>
        /// <param name="maxPages"></param>
        private void DesactiverBoutons(int maxPages)
        {
            if (page == 1)
            {
                BoutonPrecedent.Enabled = false;
                BoutonDebut.Enabled = false;
            }
            else
            {
                BoutonPrecedent.Enabled = true;
                BoutonDebut.Enabled = true;
            }
            if (page == maxPages)
            {
                BoutonSuivant.Enabled = false;
                BoutonFin.Enabled = false;
            }
            else
            {
                BoutonSuivant.Enabled = true;
                BoutonFin.Enabled = true;
            }
        }

        /// <summary>
        ///     Boucle pour créer les noeuds enfants avec les années de 1990 à maintenant
        /// </summary>
        public void CreationAnneesTreewview()
        {
            for (var i = DateTime.Now.Year; i >= 1990; i--)
            {
                var tn = new TreeNode(i.ToString());
                treeViewFilmSeries.Nodes["Nœud0"].Nodes.Add(tn);
            }
            for (var i = DateTime.Now.Year; i >= 1990; i--)
            {
                var tn = new TreeNode(i.ToString());
                treeViewFilmSeries.Nodes["Nœud1"].Nodes.Add(tn);
            }
        }

        /// <summary>
        ///     Permet de raffraichir le DGV
        /// </summary>
        public void RafraichirFilm()
        {
            try
            {
                
                BoutonTriParVote.Text = "Nombre de votes";
                var json = new JsonFilm(annee, page, lienAPI);


                objetsDataGridView = json.CreationObjets();
                LabelNombreDePages.Text = page + "/" + objetsDataGridView[0].MaxPage;
                LabelNombreDeResultats.Text = "Résultats : " + objetsDataGridView[0].NombreResultat;
                var dt = new DataTable();
                dt.Columns.Add("Nom");
                dt.Columns.Add("GenreSeries");
                dt.Columns.Add("Nombre de Votes");
                dt.Columns.Add("Popularité");

                foreach (var v in objetsDataGridView)
                    dt.Rows.Add(v.Nom, v.Genre, v.Vote, v.Popularite);
                {
                }
                dataGridView1.DataSource = dt;
                DesactiverBoutons(Convert.ToInt32(objetsDataGridView[0].MaxPage));
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                EcritureFichierErreur(e.Message, e.StackTrace);
            }
        }

        /// <summary>
        ///     Permet de raffraichir le DGV
        /// </summary>
        public void RafraichirSeries()
        {
            try
            {
                BoutonTriParVote.Text = "Moyenne des votes";

                var json = new JsonSerie(annee, page, lienAPI);
                objetsDataGridView = json.CreationObjets();
                LabelNombreDePages.Text = page + "/" + objetsDataGridView[0].MaxPage;
                LabelNombreDeResultats.Text = "Résultats : " + objetsDataGridView[0].NombreResultat;
                var dt = new DataTable();
                dt.Columns.Add("Nom");
                dt.Columns.Add("GenreSeries");
                dt.Columns.Add("Moyenne des Votes");
                dt.Columns.Add("Popularité");
                foreach (var v in objetsDataGridView)
                    dt.Rows.Add(v.Nom, v.Genre, v.Vote, v.Popularite);
                dataGridView1.DataSource = dt;
                DesactiverBoutons(Convert.ToInt32(objetsDataGridView[0].MaxPage));
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                EcritureFichierErreur(e.Message, e.StackTrace);
            }
        }

        /// <summary>
        ///     Evénement click sur le noeud du TreeView
        /// </summary>
        private void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Node.Parent != null && e.Node.Parent.Text == "Films")
            {
                if (couleurFont != null && couleurText != null)
                {
                    couleurFont.BackColor = Color.DarkGray;
                    couleurText.ForeColor = Color.Black;
                }
                couleurFont = e.Node;
                couleurText = e.Node;
                page = 1;
                annee = e.Node.Text;
                e.Node.BackColor = SystemColors.Highlight;
                e.Node.ForeColor = SystemColors.HighlightText;
                affichageFilms = true;
                affichageSeries = false;
                lienAPI = debutURL + "movie?api_key=" + cleAPI + "&" + langueURL + "&sort_by=popularity.desc";
                RafraichirFilm();
            }
            if (e.Node.Parent != null && e.Node.Parent.Text == "Séries TV")
            {
                if (couleurFont != null && couleurText != null)
                {
                    couleurFont.BackColor = Color.DarkGray;
                    couleurText.ForeColor = Color.Black;
                }
                couleurFont = e.Node;
                couleurText = e.Node;
                page = 1;
                annee = e.Node.Text;
                e.Node.BackColor = SystemColors.Highlight;
                e.Node.ForeColor = SystemColors.HighlightText;
                affichageFilms = false;
                affichageSeries = true;
                lienAPI =
                    debutURL + "tv?api_key=" + cleAPI + "&" + langueURL + "&sort_by=popularity.desc";
                RafraichirSeries();
            }
        }

        /// <summary>
        ///     Evénement click bouton page suivante
        /// </summary>
        private void BoutonSuivant_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (affichageSeries)
                {
                    page++;
                    RafraichirSeries();
                }

                if (affichageFilms)
                {
                    page++;
                    RafraichirFilm();
                }
            }
        }

        /// <summary>
        ///     Evénement click bouton dernière page
        /// </summary>
        private void BoutonFin_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (affichageSeries)
                {
                    page = Convert.ToInt32(objetsDataGridView[0].MaxPage);
                    RafraichirSeries();
                }

                if (affichageFilms)
                {
                    page = Convert.ToInt32(objetsDataGridView[0].MaxPage);
                    RafraichirFilm();
                }
            }
        }

        /// <summary>
        ///     Evénement click bouton page précédente
        /// </summary>
        private void BoutonPrecedent_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && page > 1)
            {
                if (affichageSeries)
                {
                    page--;
                    RafraichirSeries();
                }

                if (affichageFilms)
                {
                    page--;
                    RafraichirFilm();
                }
            }
        }

        /// <summary>
        ///     Evénement click bouton première page
        /// </summary>
        private void BoutonDebut_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && page >= 1)
            {
                if (affichageSeries)
                {
                    page = 1;
                    RafraichirSeries();
                }

                if (affichageFilms)
                {
                    page = 1;
                    RafraichirFilm();
                }
            }
        }

        /// <summary>
        ///     Evénement click bouton Tri par titre
        /// </summary>
        private void BoutonTriParTitre_MouseClick(object sender, MouseEventArgs e)
        {
            if (affichageSeries)
            {
                lienAPI = debutURL + "tv?api_key=" + cleAPI + "&" + langueURL + "&sort_by=original_title.asc";
                RafraichirSeries();
            }

            if (affichageFilms)
            {
                lienAPI = debutURL + "movie?api_key=" + cleAPI + "&" + langueURL + "&sort_by=title.asc";
                RafraichirFilm();
            }
        }

        /// <summary>
        ///     Evénement click bouton Tri par popularité
        /// </summary>
        private void BoutonTriParPopularité_MouseClick(object sender, MouseEventArgs e)
        {
            if (affichageSeries)
            {
                lienAPI = debutURL + "tv?api_key=" + cleAPI + "&" + langueURL + "&sort_by=popularity.desc";
                RafraichirSeries();
            }

            if (affichageFilms)
            {
                lienAPI = debutURL + "movie?api_key=" + cleAPI + "&" + langueURL + "&sort_by=popularity.desc";
                RafraichirFilm();
            }
        }

        /// <summary>
        ///     Evénement click bouton Tri par nombre de votes
        /// </summary>
        private void TriParVote_Click(object sender, EventArgs e)
        {
            if (affichageSeries)
            {
                lienAPI = debutURL + "tv?api_key=" + cleAPI + "&" + langueURL + "&sort_by=vote_average.desc";

                RafraichirSeries();
            }

            if (affichageFilms)
            {
                lienAPI = debutURL + "movie?api_key=" + cleAPI + "&" + langueURL + "&sort_by=vote_count.desc";
                RafraichirFilm();
            }
        }

        /// <summary>
        ///     Evénement double click sur une cellule du DGV
        /// </summary>
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (affichageFilms)
                {
                    var colonne = e.ColumnIndex;
                    var ligne = e.RowIndex;
                    if (e.RowIndex >= 0)
                    {
                        var doubleClick = dataGridView1[0, ligne].Value.ToString();
                        for (var i = 0; i < objetsDataGridView.Count; i++)
                            if (objetsDataGridView[i].Nom == doubleClick)
                            {
                                var jr = new JsonResumeFilm(objetsDataGridView[i].Id);
                                var odgv = jr.creationDObjet();
                                var ar = new AffichageResumeFilm(odgv);
                                ar.ShowDialog();
                            }
                    }
                }
                if (affichageSeries)
                {
                    var colonne = e.ColumnIndex;
                    var ligne = e.RowIndex;
                    if (e.RowIndex >= 0)
                    {
                        var doubleClick = dataGridView1[0, ligne].Value.ToString();
                        for (var i = 0; i < objetsDataGridView.Count; i++)
                            if (objetsDataGridView[i].Nom == doubleClick)
                            {
                                var jrs = new JsonResumeSerie(objetsDataGridView[i].Id);
                                var odgv = jrs.CreationObjet();
                                var ars = new AffichageResumeSerie(odgv);
                                ars.ShowDialog();
                            }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                EcritureFichierErreur(ex.Message, ex.StackTrace);
            }
        }

        /// <summary>
        ///     Initialisation des cellules du DGV
        /// </summary>
        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            for (var i = 0; i < dataGridView1.ColumnCount; i++)
            {
                var style = new DataGridViewCellStyle();
                style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGridView1.Columns[i].DefaultCellStyle = style;
                dataGridView1.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }

        /// <summary>
        ///     Click sur le bouton favoris pour afficher une nouvelle fenetre
        /// </summary>
        private void BoutonFavoris_Click(object sender, EventArgs e)
        {
            var af = new AffichageFavoris();
            af.ShowDialog();
        }

        /// <summary>
        ///     Ecriture des erreurs dans FichierErreurs.txt
        /// </summary>
        /// <param name="erreur">e.Message</param>
        /// <param name="ligneErreur">e.StackTrace</param>
        public static void EcritureFichierErreur(string erreur, string ligneErreur)
        {
            var sw = new StreamWriter(@".\FichierErreurs.txt", true);
            sw.WriteLine(DateTime.Now + "; " + erreur + "; " + ligneErreur);
            sw.Close();
        }
    }
}