using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace VidéoThèque
{
    class AffichageFavoris : Form
    {
        private DataGridView dataGridViewFilms;
        private DataGridView dataGridViewSeries;
        private Label labelFilm;
        private Label labelSerie;
        private List<RootObjectFilm> rof;
        private List<RootObjectSerie> ros;
        public AffichageFavoris()
        {
            InitializeComponent();
            RemplissageDTVFilms();
            RemplissageDGVSeries();
        }

        private void RemplissageDTVFilms()
        {
            StreamReader sr = new StreamReader(@".\Serialisation\filmsFavoris.json");
            string json = sr.ReadToEnd();
            sr.Close();
            DataTable dt = new DataTable();
            dt.Columns.Add("Nom du film");
            rof = JsonConvert.DeserializeObject<List<RootObjectFilm>>(json);
            for (int i = 0; i < rof.Count; i++)
            {
                dt.Rows.Add(rof[i].Nom1);
            }
            dataGridViewFilms.DataSource = dt;
        }

        private void RemplissageDGVSeries()
        {
            StreamReader sr = new StreamReader(@".\Serialisation\seriesFavoris.json");
            string json = sr.ReadToEnd();
            sr.Close();
            DataTable dt = new DataTable();
            dt.Columns.Add("Nom de la série");
            ros = JsonConvert.DeserializeObject<List<RootObjectSerie>>(json);
            for (int i = 0; i < rof.Count; i++)
            {
                dt.Rows.Add(rof[i].NomSerie);
            }
            dataGridViewSeries.DataSource = dt;
        }

        public class RootObjectFilm
        {
            public object Nom { get; set; }
            public object Genre { get; set; }
            public object Vote { get; set; }
            public object MaxPage { get; set; }
            public object Popularite { get; set; }
            public string Slogan { get; set; }
            public string TitreOrigine { get; set; }
            public string DateDeSortie { get; set; }
            public string Duree { get; set; }
            public string NombreDeVotes { get; set; }
            public string MoyenneDesVotes { get; set; }
            public string Budget { get; set; }
            public string Revenue { get; set; }
            public string Synopsis { get; set; }
            public object Id { get; set; }
            public string Poster { get; set; }
            public string Nom1 { get; set; }
            public object NombreResultat { get; set; }
            public object NomSerie { get; set; }
            public object TitreOrigineSerie { get; set; }
            public object NombreDEpisodesSerie { get; set; }
            public object NombreDeSaisonsSerie { get; set; }
            public object EnCoursDeProduction { get; set; }
            public object NombreDeVotesSerie { get; set; }
            public object MoyenneDesVotesSerie { get; set; }
            public object PosterSerie { get; set; }
            public object SynopsisSerie { get; set; }
        }
        public class RootObjectSerie
        {
            public object Nom { get; set; }
            public object Genre { get; set; }
            public object Vote { get; set; }
            public object MaxPage { get; set; }
            public object Popularite { get; set; }
            public string Slogan { get; set; }
            public string TitreOrigine { get; set; }
            public string DateDeSortie { get; set; }
            public string Duree { get; set; }
            public string NombreDeVotes { get; set; }
            public string MoyenneDesVotes { get; set; }
            public string Budget { get; set; }
            public string Revenue { get; set; }
            public string Synopsis { get; set; }
            public object Id { get; set; }
            public string Poster { get; set; }
            public string Nom1 { get; set; }
            public object NombreResultat { get; set; }
            public object NomSerie { get; set; }
            public object TitreOrigineSerie { get; set; }
            public object NombreDEpisodesSerie { get; set; }
            public object NombreDeSaisonsSerie { get; set; }
            public object EnCoursDeProduction { get; set; }
            public object NombreDeVotesSerie { get; set; }
            public object MoyenneDesVotesSerie { get; set; }
            public object PosterSerie { get; set; }
            public object SynopsisSerie { get; set; }
        }
        private void InitializeComponent()
        {
            this.dataGridViewFilms = new System.Windows.Forms.DataGridView();
            this.dataGridViewSeries = new System.Windows.Forms.DataGridView();
            this.labelFilm = new System.Windows.Forms.Label();
            this.labelSerie = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFilms)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSeries)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewFilms
            // 
            this.dataGridViewFilms.AllowUserToAddRows = false;
            this.dataGridViewFilms.AllowUserToDeleteRows = false;
            this.dataGridViewFilms.AllowUserToResizeColumns = false;
            this.dataGridViewFilms.AllowUserToResizeRows = false;
            this.dataGridViewFilms.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewFilms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFilms.Location = new System.Drawing.Point(12, 66);
            this.dataGridViewFilms.MultiSelect = false;
            this.dataGridViewFilms.Name = "dataGridViewFilms";
            this.dataGridViewFilms.ReadOnly = true;
            this.dataGridViewFilms.RowHeadersVisible = false;
            this.dataGridViewFilms.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewFilms.Size = new System.Drawing.Size(668, 447);
            this.dataGridViewFilms.TabIndex = 0;
            // 
            // dataGridViewSeries
            // 
            this.dataGridViewSeries.AllowUserToAddRows = false;
            this.dataGridViewSeries.AllowUserToDeleteRows = false;
            this.dataGridViewSeries.AllowUserToResizeColumns = false;
            this.dataGridViewSeries.AllowUserToResizeRows = false;
            this.dataGridViewSeries.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewSeries.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSeries.Location = new System.Drawing.Point(686, 66);
            this.dataGridViewSeries.MultiSelect = false;
            this.dataGridViewSeries.Name = "dataGridViewSeries";
            this.dataGridViewSeries.ReadOnly = true;
            this.dataGridViewSeries.RowHeadersVisible = false;
            this.dataGridViewSeries.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewSeries.Size = new System.Drawing.Size(668, 447);
            this.dataGridViewSeries.TabIndex = 1;
            // 
            // labelFilm
            // 
            this.labelFilm.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFilm.Location = new System.Drawing.Point(13, 13);
            this.labelFilm.Name = "labelFilm";
            this.labelFilm.Size = new System.Drawing.Size(667, 50);
            this.labelFilm.TabIndex = 2;
            this.labelFilm.Text = "Films";
            this.labelFilm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelSerie
            // 
            this.labelSerie.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSerie.Location = new System.Drawing.Point(688, 13);
            this.labelSerie.Name = "labelSerie";
            this.labelSerie.Size = new System.Drawing.Size(667, 50);
            this.labelSerie.TabIndex = 3;
            this.labelSerie.Text = "Séries";
            this.labelSerie.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AffichageFavoris
            // 
            this.ClientSize = new System.Drawing.Size(1367, 525);
            this.Controls.Add(this.labelSerie);
            this.Controls.Add(this.labelFilm);
            this.Controls.Add(this.dataGridViewSeries);
            this.Controls.Add(this.dataGridViewFilms);
            this.Name = "AffichageFavoris";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFilms)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSeries)).EndInit();
            this.ResumeLayout(false);

        }
    }
}
