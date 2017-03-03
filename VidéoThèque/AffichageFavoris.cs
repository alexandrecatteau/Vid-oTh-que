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
    /// <summary>
    /// Fenetre pour afficher les favoris
    /// </summary>
    class AffichageFavoris : Form
    {
        private DataGridView dataGridViewFilms;
        private DataGridView dataGridViewSeries;
        private Label labelFilm;
        private Label labelSerie;
        private List<RootObjectFilm> rof;
        private List<RootObjectSerie> ros;
        /// <summary>
        /// Constructeur
        /// </summary>
        public AffichageFavoris()
        {
            InitializeComponent();
            RemplissageDTVFilms();
            RemplissageDGVSeries();
        }
        /// <summary>
        /// Remplissage de la DGV Films à partir du fichier .json
        /// </summary>
        private void RemplissageDTVFilms()
        {
            try
            {
                StreamReader sr = new StreamReader(@".\filmsFavoris.json");
                string json = sr.ReadToEnd();
                sr.Close();
                if (json != "")
                {
                    DataTable dt = new DataTable();
                    dt.Columns.Add("Nom du film");
                    rof = JsonConvert.DeserializeObject<List<RootObjectFilm>>(json);
                    for (int i = 0; i < rof.Count; i++)
                    {
                        dt.Rows.Add(rof[i].Nom1);
                    }
                    dataGridViewFilms.DataSource = dt;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        /// <summary>
        /// Affichage de la DGV Serie à partir du fichier .json
        /// </summary>
        private void RemplissageDGVSeries()
        {
            try
            {
                StreamReader sr = new StreamReader(@".\seriesFavoris.json");
                string json = sr.ReadToEnd();
                sr.Close();

                if (json != "")
                {
                    DataTable dt = new DataTable();
                    dt.Columns.Add("Nom de la série");
                    ros = JsonConvert.DeserializeObject<List<RootObjectSerie>>(json);
                    for (int i = 0; i < ros.Count; i++)
                    {
                        dt.Rows.Add(ros[i].NomSerie);
                    }
                    dataGridViewSeries.DataSource = dt;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
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
        /// <summary>
        /// Initialisation des composants de la fenetre
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AffichageFavoris));
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
            this.dataGridViewFilms.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dataGridViewFilms.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewFilms.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewFilms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFilms.Location = new System.Drawing.Point(12, 66);
            this.dataGridViewFilms.MultiSelect = false;
            this.dataGridViewFilms.Name = "dataGridViewFilms";
            this.dataGridViewFilms.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewFilms.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewFilms.RowHeadersVisible = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewFilms.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewFilms.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewFilms.Size = new System.Drawing.Size(668, 447);
            this.dataGridViewFilms.TabIndex = 0;
            this.dataGridViewFilms.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewFilms_CellDoubleClick);
            // 
            // dataGridViewSeries
            // 
            this.dataGridViewSeries.AllowUserToAddRows = false;
            this.dataGridViewSeries.AllowUserToDeleteRows = false;
            this.dataGridViewSeries.AllowUserToResizeColumns = false;
            this.dataGridViewSeries.AllowUserToResizeRows = false;
            this.dataGridViewSeries.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewSeries.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewSeries.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewSeries.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSeries.Location = new System.Drawing.Point(686, 66);
            this.dataGridViewSeries.MultiSelect = false;
            this.dataGridViewSeries.Name = "dataGridViewSeries";
            this.dataGridViewSeries.ReadOnly = true;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewSeries.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewSeries.RowHeadersVisible = false;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewSeries.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewSeries.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewSeries.Size = new System.Drawing.Size(668, 447);
            this.dataGridViewSeries.TabIndex = 1;
            this.dataGridViewSeries.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSeries_CellDoubleClick);
            // 
            // labelFilm
            // 
            this.labelFilm.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelFilm.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFilm.Location = new System.Drawing.Point(12, 13);
            this.labelFilm.Name = "labelFilm";
            this.labelFilm.Size = new System.Drawing.Size(668, 50);
            this.labelFilm.TabIndex = 2;
            this.labelFilm.Text = "Films";
            this.labelFilm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelSerie
            // 
            this.labelSerie.Anchor = System.Windows.Forms.AnchorStyles.Top;
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
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(1367, 525);
            this.Controls.Add(this.labelSerie);
            this.Controls.Add(this.labelFilm);
            this.Controls.Add(this.dataGridViewSeries);
            this.Controls.Add(this.dataGridViewFilms);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AffichageFavoris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Favoris";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFilms)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSeries)).EndInit();
            this.ResumeLayout(false);

        }
        /// <summary>
        /// Affichage de la fenetre Résumé d'un film avec un double click
        /// </summary>
        private void dataGridViewFilms_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                
                for (int i = 0; i < rof.Count; i++)
                {
                    if (dataGridViewFilms[0, e.RowIndex].Value.ToString() == rof[i].Nom1)
                    {
                        ObjetsDataGridView odgv = new ObjetsDataGridView(rof[i].Nom1, rof[i].Poster, rof[i].Slogan, rof[i].TitreOrigine, rof[i].DateDeSortie, rof[i].Duree, rof[i].NombreDeVotes, rof[i].MoyenneDesVotes, rof[i].Budget, rof[i].Revenue, rof[i].Synopsis);
                        AffichageResumeFilm arf = new AffichageResumeFilm(odgv);
                        arf.BoutonAjouterAuxFavoris.Enabled = false;
                        arf.ShowDialog();
                        break;
                    }
                }
            }
        }
        /// <summary>
        /// Affichage de la fenetre Résumé d'une série avec un double click
        /// </summary>
        private void dataGridViewSeries_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                for (int i = 0; i < ros.Count; i++)
                {
                    if (dataGridViewSeries[0, e.RowIndex].Value.ToString() == ros[i].NomSerie.ToString())
                    {
                        ObjetsDataGridView odgv = new ObjetsDataGridView(ros[i].NomSerie.ToString(), ros[i].TitreOrigineSerie.ToString(), ros[i].NombreDEpisodesSerie.ToString(), ros[i].NombreDeSaisonsSerie.ToString(), ros[i].EnCoursDeProduction.ToString(), ros[i].NombreDeVotesSerie.ToString(), ros[i].MoyenneDesVotesSerie.ToString(), ros[i].PosterSerie.ToString(), ros[i].SynopsisSerie.ToString());
                        AffichageResumeSerie ars = new AffichageResumeSerie(odgv);
                        ars.BoutonAjouterAyxFavoris.Enabled = false;
                        ars.ShowDialog();
                        break;
                    }
                }
            }
        }
    }
}
