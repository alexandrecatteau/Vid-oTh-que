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
        private string lienAPIE = null;
            
        public AffichagePrincipal()
        {
            
            
            InitializeComponent();
            CreationAnneesTreewview();
        }

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

        public void RafraichirFilm()
        {
            JsonFilm json = new JsonFilm(annee, page, lienAPIE );
            objetsDataGridView = json.CreationObjets();
            LabelNombreDePages.Text = page.ToString() + "/" + objetsDataGridView[0].MaxPage.ToString();
            LabelNombreDeResultats.Text = "Résultats : " + objetsDataGridView[0].NombreResultat.ToString();
            DataTable dt = new DataTable();
            dt.Columns.Add("Nom");
            dt.Columns.Add("Genre");
            dt.Columns.Add("Nombre de Votes");
            dt.Columns.Add("Popularité");
            foreach (var v in objetsDataGridView)
            {
                dt.Rows.Add(v.Nom, v.Genre, v.Vote, v.Popularite);
            }
            dataGridView1.DataSource = dt;
            DesactiverBoutons(Convert.ToInt32(objetsDataGridView[0].MaxPage));
        }
        
        public void RafraichirSeries()
        {
            JsonSerie json = new JsonSerie(annee, page, lienAPIE);
            objetsDataGridView = json.CreationObjets();
            LabelNombreDePages.Text = page.ToString() + "/" + objetsDataGridView[0].MaxPage.ToString();
            DataTable dt = new DataTable();
            dt.Columns.Add("Nom");
            dt.Columns.Add("Genre");
            dt.Columns.Add("Nombre de Votes");
            dt.Columns.Add("Popularité");
            foreach (var v in objetsDataGridView)
            {
                dt.Rows.Add(v.Nom, v.Genre, v.Vote, v.Popularite);
            }
            dataGridView1.DataSource = dt;
            DesactiverBoutons(Convert.ToInt32(objetsDataGridView[0].MaxPage));
        }

        private void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Node.Parent != null && e.Node.Parent.Text == "Films")
            {
                page = 1;
                annee = e.Node.Text;
                affichageFilms = true;
                affichageSeries = false;
                lienAPIE = "https://api.themoviedb.org/3/discover/movie?api_key=d63d007af8c7f4d8beb5206b14594b47&language=fr-FR&sort_by=popularity.desc";
                RafraichirFilm();
            }
            if (e.Node.Parent != null && e.Node.Parent.Text == "Séries TV")
            {
                page = 1;
                annee = e.Node.Text;
                affichageFilms = false;
                affichageSeries = true;
                lienAPIE =
                    "https://api.themoviedb.org/3/discover/tv?api_key=d63d007af8c7f4d8beb5206b14594b47&language=fr-FR&sort_by=popularity.desc";
                RafraichirSeries();
            }
        }

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

        private void BoutonTriParTitre_MouseClick(object sender, MouseEventArgs e)
        {
            
            if (affichageSeries == true)
            {
                lienAPIE = "https://api.themoviedb.org/3/discover/tv?api_key=30666db2f7a024c11b30b58b88983362&language=fr-FR&sort_by=original_title.asc";
                RafraichirSeries();
            }

            if (affichageFilms == true)
            {
                lienAPIE = "https://api.themoviedb.org/3/discover/movie?api_key=30666db2f7a024c11b30b58b88983362&language=fr-FR&sort_by=title.asc";
                RafraichirFilm();
            }
        }

        private void BoutonTriParPopularité_MouseClick(object sender, MouseEventArgs e)
        {
           
            if (affichageSeries == true)
            {
                lienAPIE = "https://api.themoviedb.org/3/discover/tv?api_key=30666db2f7a024c11b30b58b88983362&language=fr-FR&sort_by=popularity.desc";
                RafraichirSeries();
            }

            if (affichageFilms == true)
            {
                lienAPIE =
               "https://api.themoviedb.org/3/discover/movie?api_key=30666db2f7a024c11b30b58b88983362&language=fr-FR&sort_by=popularity.desc";
                RafraichirFilm();
            }

        }

        private void TriParVote_Click(object sender, EventArgs e)
        {
            
            if (affichageSeries == true)
            {
                lienAPIE = "https://api.themoviedb.org/3/discover/tv?api_key=30666db2f7a024c11b30b58b88983362&language=fr-FR&sort_by=vote_average.desc";
                RafraichirSeries();
            }

            if (affichageFilms == true)
            {
                lienAPIE = "https://api.themoviedb.org/3/discover/movie?api_key=30666db2f7a024c11b30b58b88983362&language=fr-FR&sort_by=vote_count.desc";
                RafraichirFilm();
            }
        }

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
                            AffichageResume ar = new AffichageResume(odgv);
                            ar.ShowDialog();
                        }
                    }
                }
            }
            
        }

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
    }
}
