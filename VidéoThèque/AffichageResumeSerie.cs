using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

///

namespace VidéoThèque
{
    /// <summary>
    ///     Afficher le résumé d'une série au doubleclick sur le DGV
    /// </summary>
    internal class AffichageResumeSerie : Form
    {
        public Button BoutonAjouterAyxFavoris;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label labelAffichageTitre;
        private Label labelMoyenneDesVotes;
        private Label labelNombreDeVotes;
        private Label labelNombreEpisodes;
        private Label labelNombreSaisons;
        private Label labelNomOrigine;
        private Label labelStatutDeProduction;
        private Label labelSynopsis;
        private readonly ObjetsDataGridView odgv;
        private PictureBox pictureBox1;

        /// <summary>
        ///     Constructeur pour afficher le résumé
        /// </summary>
        /// <param name="odgv">Objet ObjetsDataGridView</param>
        public AffichageResumeSerie(ObjetsDataGridView odgv)
        {
            InitializeComponent();
            this.odgv = odgv;
            try
            {
                pictureBox1.Load("https://image.tmdb.org/t/p/w500/" + odgv.PosterSerie);
            }
            catch (Exception)
            {
                pictureBox1.Load(@".\Images\Image non trouvé.jpg");
            }
            labelAffichageTitre.Text = odgv.NomSerie;
            labelMoyenneDesVotes.Text = odgv.MoyenneDesVotesSerie;
            labelNombreDeVotes.Text = odgv.NombreDeVotesSerie;
            labelNombreEpisodes.Text = odgv.NombreDEpisodesSerie;
            labelNombreSaisons.Text = odgv.NombreDeSaisonsSerie;
            labelStatutDeProduction.Text = odgv.EnCoursDeProduction;
            labelNomOrigine.Text = odgv.TitreOrigineSerie;
            labelSynopsis.Text = odgv.SynopsisSerie;
        }

        /// <summary>
        ///     Initialisation des composants de la fenêtre
        /// </summary>
        private void InitializeComponent()
        {
            var resources = new ComponentResourceManager(typeof(AffichageResumeSerie));
            pictureBox1 = new PictureBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            labelAffichageTitre = new Label();
            labelMoyenneDesVotes = new Label();
            labelNomOrigine = new Label();
            labelNombreEpisodes = new Label();
            labelNombreSaisons = new Label();
            labelStatutDeProduction = new Label();
            labelNombreDeVotes = new Label();
            labelSynopsis = new Label();
            BoutonAjouterAyxFavoris = new Button();
            ((ISupportInitialize) pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(13, 13);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(341, 496);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label7
            // 
            label7.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(360, 66);
            label7.Name = "label7";
            label7.Size = new Size(139, 28);
            label7.TabIndex = 15;
            label7.Text = "Nom d\'origine";
            label7.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            label6.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(360, 206);
            label6.Name = "label6";
            label6.Size = new Size(139, 28);
            label6.TabIndex = 14;
            label6.Text = "Moyenne des votes";
            label6.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            label5.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(360, 178);
            label5.Name = "label5";
            label5.Size = new Size(139, 28);
            label5.TabIndex = 13;
            label5.Text = "Nombre de votes";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            label4.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(360, 150);
            label4.Name = "label4";
            label4.Size = new Size(139, 28);
            label4.TabIndex = 12;
            label4.Text = "Statut de production";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            label3.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(360, 122);
            label3.Name = "label3";
            label3.Size = new Size(139, 28);
            label3.TabIndex = 11;
            label3.Text = "Nombre de saisons";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            label2.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(360, 94);
            label2.Name = "label2";
            label2.Size = new Size(139, 28);
            label2.TabIndex = 10;
            label2.Text = "Nombre d\'épisodes";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelAffichageTitre
            // 
            labelAffichageTitre.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelAffichageTitre.Location = new Point(359, 9);
            labelAffichageTitre.Name = "labelAffichageTitre";
            labelAffichageTitre.Size = new Size(347, 53);
            labelAffichageTitre.TabIndex = 18;
            labelAffichageTitre.Text = "labelAffichageTitre";
            labelAffichageTitre.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelMoyenneDesVotes
            // 
            labelMoyenneDesVotes.BorderStyle = BorderStyle.FixedSingle;
            labelMoyenneDesVotes.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelMoyenneDesVotes.Location = new Point(505, 206);
            labelMoyenneDesVotes.Name = "labelMoyenneDesVotes";
            labelMoyenneDesVotes.Size = new Size(381, 28);
            labelMoyenneDesVotes.TabIndex = 24;
            labelMoyenneDesVotes.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelNomOrigine
            // 
            labelNomOrigine.BorderStyle = BorderStyle.FixedSingle;
            labelNomOrigine.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelNomOrigine.Location = new Point(505, 66);
            labelNomOrigine.Name = "labelNomOrigine";
            labelNomOrigine.Size = new Size(381, 28);
            labelNomOrigine.TabIndex = 23;
            labelNomOrigine.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelNombreEpisodes
            // 
            labelNombreEpisodes.BorderStyle = BorderStyle.FixedSingle;
            labelNombreEpisodes.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelNombreEpisodes.Location = new Point(505, 94);
            labelNombreEpisodes.Name = "labelNombreEpisodes";
            labelNombreEpisodes.Size = new Size(381, 28);
            labelNombreEpisodes.TabIndex = 22;
            labelNombreEpisodes.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelNombreSaisons
            // 
            labelNombreSaisons.BorderStyle = BorderStyle.FixedSingle;
            labelNombreSaisons.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelNombreSaisons.Location = new Point(505, 122);
            labelNombreSaisons.Name = "labelNombreSaisons";
            labelNombreSaisons.Size = new Size(381, 28);
            labelNombreSaisons.TabIndex = 21;
            labelNombreSaisons.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelStatutDeProduction
            // 
            labelStatutDeProduction.BorderStyle = BorderStyle.FixedSingle;
            labelStatutDeProduction.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point,
                0);
            labelStatutDeProduction.Location = new Point(505, 150);
            labelStatutDeProduction.Name = "labelStatutDeProduction";
            labelStatutDeProduction.Size = new Size(381, 28);
            labelStatutDeProduction.TabIndex = 20;
            labelStatutDeProduction.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelNombreDeVotes
            // 
            labelNombreDeVotes.BorderStyle = BorderStyle.FixedSingle;
            labelNombreDeVotes.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelNombreDeVotes.Location = new Point(505, 178);
            labelNombreDeVotes.Name = "labelNombreDeVotes";
            labelNombreDeVotes.Size = new Size(381, 28);
            labelNombreDeVotes.TabIndex = 19;
            labelNombreDeVotes.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelSynopsis
            // 
            labelSynopsis.BorderStyle = BorderStyle.FixedSingle;
            labelSynopsis.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelSynopsis.Location = new Point(363, 243);
            labelSynopsis.Name = "labelSynopsis";
            labelSynopsis.Size = new Size(523, 266);
            labelSynopsis.TabIndex = 25;
            labelSynopsis.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // BoutonAjouterAyxFavoris
            // 
            BoutonAjouterAyxFavoris.Location = new Point(712, 9);
            BoutonAjouterAyxFavoris.Name = "BoutonAjouterAyxFavoris";
            BoutonAjouterAyxFavoris.Size = new Size(174, 53);
            BoutonAjouterAyxFavoris.TabIndex = 26;
            BoutonAjouterAyxFavoris.Text = "Ajouter aux favoris";
            BoutonAjouterAyxFavoris.UseVisualStyleBackColor = true;
            BoutonAjouterAyxFavoris.MouseClick += BoutonAjouterAyxFavoris_MouseClick;
            // 
            // AffichageResumeSerie
            // 
            BackColor = Color.Gray;
            ClientSize = new Size(898, 518);
            Controls.Add(BoutonAjouterAyxFavoris);
            Controls.Add(labelSynopsis);
            Controls.Add(labelMoyenneDesVotes);
            Controls.Add(labelNomOrigine);
            Controls.Add(labelNombreEpisodes);
            Controls.Add(labelNombreSaisons);
            Controls.Add(labelStatutDeProduction);
            Controls.Add(labelNombreDeVotes);
            Controls.Add(labelAffichageTitre);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Icon = (Icon) resources.GetObject("$this.Icon");
            Name = "AffichageResumeSerie";
            StartPosition = FormStartPosition.CenterScreen;
            ((ISupportInitialize) pictureBox1).EndInit();
            ResumeLayout(false);
        }

        /// <summary>
        ///     Evenement quand on click sur le bouton Ajouter aux favoris
        /// </summary>
        private void BoutonAjouterAyxFavoris_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                var jsr = new JsonResumeSerie();
                jsr.Serialisation(odgv);
                MessageBox.Show("\"" + odgv.NomSerie + "\"" + " a bien était ajouté aux favoris");
            }
        }
    }
}