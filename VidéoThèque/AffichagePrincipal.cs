using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VidéoThèque
{
    public partial class AffichagePrincipal : Form
    {
        private int page = 1;
        private string annee = null;
        private List<ObjetsDataGridView> objetsDataGridView;
        private bool affichageFilms;
        private bool affichageSeries;
        private string lienAPI = null;
        private TreeNode couleurText = null;
        private TreeNode couleurFont = null;

        /// <summary>
        /// Initialisation de la fenêtre
        /// </summary>
        public AffichagePrincipal()
        {
            InitializeComponent();
            CreationAnneesTreewview();
           
        }
        /// <summary>
        /// Désactive les boutons de navigations de pages quand nécessaire
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
        /// Boucle pour créer les noeuds enfants avec les années de 1990 à maintenant
        /// </summary>
        public void CreationAnneesTreewview()
        {
            for (int i = DateTime.Now.Year; i>=1990; i--)
            {
                TreeNode tn = new TreeNode(i.ToString());
                treeViewFilmSeries.Nodes["Nœud0"].Nodes.Add(tn);

            }
            for (int i = DateTime.Now.Year; i >= 1990; i--)
            {
                TreeNode tn = new TreeNode(i.ToString());
                treeViewFilmSeries.Nodes["Nœud1"].Nodes.Add(tn);
            }
           
        }
        /// <summary>
        /// Permet de raffraichir le DGV
        /// </summary>
        public void RafraichirFilm()
        {
            BoutonTriParVote.Text = "Nombre de votes";
            JsonFilm json = new JsonFilm(annee, page, lienAPI );
            objetsDataGridView = json.CreationObjets();
            LabelNombreDePages.Text = page.ToString() + "/" + objetsDataGridView[0].MaxPage.ToString();
            LabelNombreDeResultats.Text = "Résultats : " + objetsDataGridView[0].NombreResultat.ToString();
            DataTable dt = new DataTable();
            dt.Columns.Add("Nom");
            dt.Columns.Add("Genre");
            dt.Columns.Add("Nombre de Votes");
            dt.Columns.Add("Popularité");
            foreach (var v in objetsDataGridView)
                dt.Rows.Add(v.Nom, v.Genre, v.Vote, v.Popularite);
            {
            }
            dataGridView1.DataSource = dt;
            DesactiverBoutons(Convert.ToInt32(objetsDataGridView[0].MaxPage));
        }
        /// <summary>
        /// Permet de raffraichir le DGV
        /// </summary>
        public void RafraichirSeries()
        {
            BoutonTriParVote.Text = "Moyenne des votes";

            JsonSerie json = new JsonSerie(annee, page, lienAPI);
            objetsDataGridView = json.CreationObjets();
            LabelNombreDePages.Text = page.ToString() + "/" + objetsDataGridView[0].MaxPage.ToString();
            LabelNombreDeResultats.Text = "Résultats : " + objetsDataGridView[0].NombreResultat.ToString();
            DataTable dt = new DataTable();
            dt.Columns.Add("Nom");
            dt.Columns.Add("Genre");
            dt.Columns.Add("Moyenne des Votes");
            dt.Columns.Add("Popularité");
            foreach (var v in objetsDataGridView)
            {
                dt.Rows.Add(v.Nom, v.Genre, v.Vote, v.Popularite);
            }
            dataGridView1.DataSource = dt;
            DesactiverBoutons(Convert.ToInt32(objetsDataGridView[0].MaxPage));
        }
        /// <summary>
        /// Evénement click sur le noeud du TreeView 
        /// </summary>
        private void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Node.Parent != null && e.Node.Parent.Text == "Films")
            {
                if (couleurFont != null && couleurText != null)
                {
                    couleurFont.BackColor = Color.White;
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
                lienAPI = "https://api.themoviedb.org/3/discover/movie?api_key=d63d007af8c7f4d8beb5206b14594b47&language=fr-FR&sort_by=popularity.desc";
                RafraichirFilm();
            }
            if (e.Node.Parent != null && e.Node.Parent.Text == "Séries TV")
            {
                if (couleurFont != null && couleurText != null)
                {
                    couleurFont.BackColor = Color.White;
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
                    "https://api.themoviedb.org/3/discover/tv?api_key=d63d007af8c7f4d8beb5206b14594b47&language=fr-FR&sort_by=popularity.desc";
                RafraichirSeries();
            }
        }
        /// <summary>
        /// Evénement click bouton page suivante
        /// </summary>
        private void BoutonSuivant_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (affichageSeries == true)
                {
                    page++;
                    RafraichirSeries();
                }

                if (affichageFilms == true)
                {
                    page++;
                    RafraichirFilm(); 
                }
            }
        }
        /// <summary>
        /// Evénement click bouton dernière page
        /// </summary>
        private void BoutonFin_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (affichageSeries == true)
                {
                    page = Convert.ToInt32(objetsDataGridView[0].MaxPage);
                    RafraichirSeries();
                }

                if (affichageFilms == true)
                {
                    page = Convert.ToInt32(objetsDataGridView[0].MaxPage);
                    RafraichirFilm();
                }
                
            }
            
        }
        /// <summary>
        /// Evénement click bouton page précédente 
        /// </summary>
        private void BoutonPrecedent_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && page > 1)
            {
                if (affichageSeries == true)
                {
                    page--;
                    RafraichirSeries();
                }

                if (affichageFilms == true)
                {
                    page--;
                    RafraichirFilm();
                }
                
            }
        }
        /// <summary>
        /// Evénement click bouton première page
        /// </summary>
        private void BoutonDebut_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && page >= 1)
            {
                if (affichageSeries == true)
                {
                    page = 1;
                    RafraichirSeries();
                }

                if (affichageFilms == true)
                {
                    page = 1;
                    RafraichirFilm();
                }
            }
        }
        /// <summary>
        ///  Evénement click bouton Tri par titre
        /// </summary>
        private void BoutonTriParTitre_MouseClick(object sender, MouseEventArgs e)
        {
            
            if (affichageSeries == true)
            {
                lienAPI = "https://api.themoviedb.org/3/discover/tv?api_key=30666db2f7a024c11b30b58b88983362&language=fr-FR&sort_by=original_title.asc";
                RafraichirSeries();
            }

            if (affichageFilms == true)
            {
                lienAPI = "https://api.themoviedb.org/3/discover/movie?api_key=30666db2f7a024c11b30b58b88983362&language=fr-FR&sort_by=title.asc";
                RafraichirFilm();
            }
        }
        /// <summary>
        /// Evénement click bouton Tri par popularité 
        /// </summary>
        private void BoutonTriParPopularité_MouseClick(object sender, MouseEventArgs e)
        {
           
            if (affichageSeries == true)
            {
                lienAPI = "https://api.themoviedb.org/3/discover/tv?api_key=30666db2f7a024c11b30b58b88983362&language=fr-FR&sort_by=popularity.desc";
                RafraichirSeries();
            }

            if (affichageFilms == true)
            {
                lienAPI = "https://api.themoviedb.org/3/discover/movie?api_key=30666db2f7a024c11b30b58b88983362&language=fr-FR&sort_by=popularity.desc";
                RafraichirFilm();
            }

        }
        /// <summary>
        ///  Evénement click bouton Tri par nombre de votes
        /// </summary>
        private void TriParVote_Click(object sender, EventArgs e)
        {
            
            if (affichageSeries == true)
            {
                lienAPI = "https://api.themoviedb.org/3/discover/tv?api_key=30666db2f7a024c11b30b58b88983362&language=fr-FR&sort_by=vote_average.desc";
                
                RafraichirSeries();
            }

            if (affichageFilms == true)
            {
                lienAPI = "https://api.themoviedb.org/3/discover/movie?api_key=30666db2f7a024c11b30b58b88983362&language=fr-FR&sort_by=vote_count.desc";
                RafraichirFilm();
            }
        }
        /// <summary>
        ///  Evénement double click sur une cellule du DGV 
        /// </summary>
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (affichageFilms == true)
            {
                int colonne = e.ColumnIndex;
                int ligne = e.RowIndex;
                if (e.RowIndex >= 0)
                {
                    string doubleClick = dataGridView1[0, ligne].Value.ToString();
                    for (int i = 0; i < objetsDataGridView.Count; i++)
                    {
                        if (objetsDataGridView[i].Nom == doubleClick)
                        {
                            JsonResumeFilm jr = new JsonResumeFilm(objetsDataGridView[i].Id);
                            ObjetsDataGridView odgv = jr.creationDObjet();
                            AffichageResumeFilm ar = new AffichageResumeFilm(odgv);
                            ar.ShowDialog();
                        }
                    }
                }
            }
            if (affichageSeries == true)
            {
                int colonne = e.ColumnIndex;
                int ligne = e.RowIndex;
                if (e.RowIndex >= 0)
                {
                    string doubleClick = dataGridView1[0, ligne].Value.ToString();
                    for (int i = 0; i < objetsDataGridView.Count; i++)
                    {
                        if (objetsDataGridView[i].Nom == doubleClick)
                        {
                            JsonResumeSerie jrs = new JsonResumeSerie(objetsDataGridView[i].Id);
                            ObjetsDataGridView odgv = jrs.CreationObjet();
                            AffichageResumeSerie ars = new AffichageResumeSerie(odgv);
                            ars.ShowDialog();
                        }
                    }
                }
            }
            
        }
        /// <summary>
        /// Initialisation des cellules du DGV
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
            //this.dataGridView1.ClearSelection();
        }

        private void BoutonFavoris_Click(object sender, EventArgs e)
        {
            AffichageFavoris af = new AffichageFavoris();
            af.ShowDialog();
        }
    }
}
