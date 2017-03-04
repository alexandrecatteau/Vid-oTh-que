using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace VidéoThèque
{
    /// <summary>
    ///     Fenetre pour afficher les favoris
    /// </summary>
    internal class AffichageFavoris : Form
    {
        private DataGridView dataGridViewFilms;
        private DataGridView dataGridViewSeries;
        private Label labelFilm;
        private Label labelSerie;
        private List<RootObjectFilm> rof;
        private List<RootObjectSerie> ros;

        /// <summary>
        ///     Constructeur
        /// </summary>
        public AffichageFavoris()
        {
            InitializeComponent();
            RemplissageDTVFilms();
            RemplissageDGVSeries();
        }

        /// <summary>
        ///     Remplissage de la DGV Films à partir du fichier .json
        /// </summary>
        private void RemplissageDTVFilms()
        {
            try
            {
                var sr = new StreamReader(@".\filmsFavoris.json");
                var json = sr.ReadToEnd();
                sr.Close();
                if (json != "")
                {
                    var dt = new DataTable();
                    dt.Columns.Add("Nom du film");
                    rof = JsonConvert.DeserializeObject<List<RootObjectFilm>>(json);
                    for (var i = 0; i < rof.Count; i++)
                        dt.Rows.Add(rof[i].Nom1);
                    dataGridViewFilms.DataSource = dt;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                AffichagePrincipal.EcritureFichierErreur(e.Message, e.StackTrace);
            }
        }

        /// <summary>
        ///     Affichage de la DGV Serie à partir du fichier .json
        /// </summary>
        private void RemplissageDGVSeries()
        {
            try
            {
                var sr = new StreamReader(@".\seriesFavoris.json");
                var json = sr.ReadToEnd();
                sr.Close();

                if (json != "")
                {
                    var dt = new DataTable();
                    dt.Columns.Add("Nom de la série");
                    ros = JsonConvert.DeserializeObject<List<RootObjectSerie>>(json);
                    for (var i = 0; i < ros.Count; i++)
                        dt.Rows.Add(ros[i].NomSerie);
                    dataGridViewSeries.DataSource = dt;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                AffichagePrincipal.EcritureFichierErreur(e.Message, e.StackTrace);
            }
        }

        /// <summary>
        /// Initialisation des composants de la fenetre
        /// </summary>
        private void InitializeComponent()
        {
            var dataGridViewCellStyle1 = new DataGridViewCellStyle();
            var dataGridViewCellStyle2 = new DataGridViewCellStyle();
            var dataGridViewCellStyle3 = new DataGridViewCellStyle();
            var dataGridViewCellStyle4 = new DataGridViewCellStyle();
            var dataGridViewCellStyle5 = new DataGridViewCellStyle();
            var dataGridViewCellStyle6 = new DataGridViewCellStyle();
            var resources = new ComponentResourceManager(typeof(AffichageFavoris));
            dataGridViewFilms = new DataGridView();
            dataGridViewSeries = new DataGridView();
            labelFilm = new Label();
            labelSerie = new Label();
            ((ISupportInitialize) dataGridViewFilms).BeginInit();
            ((ISupportInitialize) dataGridViewSeries).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewFilms
            // 
            dataGridViewFilms.AllowUserToAddRows = false;
            dataGridViewFilms.AllowUserToDeleteRows = false;
            dataGridViewFilms.AllowUserToResizeColumns = false;
            dataGridViewFilms.AllowUserToResizeRows = false;
            dataGridViewFilms.Anchor = AnchorStyles.Top | AnchorStyles.Bottom
                                       | AnchorStyles.Left;
            dataGridViewFilms.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold | FontStyle.Underline,
                GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViewFilms.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewFilms.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewFilms.Location = new Point(12, 66);
            dataGridViewFilms.MultiSelect = false;
            dataGridViewFilms.Name = "dataGridViewFilms";
            dataGridViewFilms.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point,
                0);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridViewFilms.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewFilms.RowHeadersVisible = false;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewFilms.RowsDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewFilms.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewFilms.Size = new Size(668, 447);
            dataGridViewFilms.TabIndex = 0;
            dataGridViewFilms.CellDoubleClick += dataGridViewFilms_CellDoubleClick;
            // 
            // dataGridViewSeries
            // 
            dataGridViewSeries.AllowUserToAddRows = false;
            dataGridViewSeries.AllowUserToDeleteRows = false;
            dataGridViewSeries.AllowUserToResizeColumns = false;
            dataGridViewSeries.AllowUserToResizeRows = false;
            dataGridViewSeries.Anchor = AnchorStyles.Top | AnchorStyles.Bottom
                                        | AnchorStyles.Right;
            dataGridViewSeries.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold | FontStyle.Underline,
                GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dataGridViewSeries.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewSeries.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewSeries.Location = new Point(686, 66);
            dataGridViewSeries.MultiSelect = false;
            dataGridViewSeries.Name = "dataGridViewSeries";
            dataGridViewSeries.ReadOnly = true;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = SystemColors.Control;
            dataGridViewCellStyle5.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point,
                0);
            dataGridViewCellStyle5.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dataGridViewSeries.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dataGridViewSeries.RowHeadersVisible = false;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewSeries.RowsDefaultCellStyle = dataGridViewCellStyle6;
            dataGridViewSeries.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewSeries.Size = new Size(668, 447);
            dataGridViewSeries.TabIndex = 1;
            dataGridViewSeries.CellDoubleClick += dataGridViewSeries_CellDoubleClick;
            // 
            // labelFilm
            // 
            labelFilm.Anchor = AnchorStyles.Top;
            labelFilm.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Bold | FontStyle.Underline,
                GraphicsUnit.Point, 0);
            labelFilm.Location = new Point(12, 13);
            labelFilm.Name = "labelFilm";
            labelFilm.Size = new Size(668, 50);
            labelFilm.TabIndex = 2;
            labelFilm.Text = "Films";
            labelFilm.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelSerie
            // 
            labelSerie.Anchor = AnchorStyles.Top;
            labelSerie.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Bold | FontStyle.Underline,
                GraphicsUnit.Point, 0);
            labelSerie.Location = new Point(688, 13);
            labelSerie.Name = "labelSerie";
            labelSerie.Size = new Size(667, 50);
            labelSerie.TabIndex = 3;
            labelSerie.Text = "Séries";
            labelSerie.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // AffichageFavoris
            // 
            BackColor = Color.Gray;
            ClientSize = new Size(1367, 525);
            Controls.Add(labelSerie);
            Controls.Add(labelFilm);
            Controls.Add(dataGridViewSeries);
            Controls.Add(dataGridViewFilms);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Icon = (Icon) resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "AffichageFavoris";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Favoris";
            ((ISupportInitialize) dataGridViewFilms).EndInit();
            ((ISupportInitialize) dataGridViewSeries).EndInit();
            ResumeLayout(false);
        }

        /// <summary>
        ///     Affichage de la fenetre Résumé d'un film avec un double click
        /// </summary>
        private void dataGridViewFilms_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
                for (var i = 0; i < rof.Count; i++)
                    if (dataGridViewFilms[0, e.RowIndex].Value.ToString() == rof[i].Nom1)
                    {
                        var odgv = new ObjetsDataGridView(rof[i].Nom1, rof[i].Poster, rof[i].Slogan, rof[i].TitreOrigine,
                            rof[i].DateDeSortie, rof[i].Duree, rof[i].NombreDeVotes, rof[i].MoyenneDesVotes,
                            rof[i].Budget, rof[i].Revenue, rof[i].Synopsis);
                        var arf = new AffichageResumeFilm(odgv);
                        arf.BoutonAjouterAuxFavoris.Enabled = false;
                        arf.ShowDialog();
                        break;
                    }
        }

        /// <summary>
        ///     Affichage de la fenetre Résumé d'une série avec un double click
        /// </summary>
        private void dataGridViewSeries_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
                for (var i = 0; i < ros.Count; i++)
                    if (dataGridViewSeries[0, e.RowIndex].Value.ToString() == ros[i].NomSerie.ToString())
                    {
                        var odgv = new ObjetsDataGridView(ros[i].NomSerie.ToString(),
                            ros[i].TitreOrigineSerie.ToString(), ros[i].NombreDEpisodesSerie.ToString(),
                            ros[i].NombreDeSaisonsSerie.ToString(), ros[i].EnCoursDeProduction.ToString(),
                            ros[i].NombreDeVotesSerie.ToString(), ros[i].MoyenneDesVotesSerie.ToString(),
                            ros[i].PosterSerie.ToString(), ros[i].SynopsisSerie.ToString());
                        var ars = new AffichageResumeSerie(odgv);
                        ars.BoutonAjouterAyxFavoris.Enabled = false;
                        ars.ShowDialog();
                        break;
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
    }
}