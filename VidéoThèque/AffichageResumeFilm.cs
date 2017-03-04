using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace VidéoThèque
{
    /// <summary>
    ///     Affichage du résumé du film
    /// </summary>
    internal class AffichageResumeFilm : Form
    {
        public Button BoutonAjouterAuxFavoris;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label labelAffichageBudget;
        private Label LabelAffichageDateDeSortie;
        private Label labelAffichageDuree;
        private Label labelAffichageMoyenneDesNotes;
        private Label labelAffichageNombreDeVotes;
        private Label labelAffichageRevenue;
        private Label labelAffichageSlogan;
        private Label labelAffichageSynopsis;
        private Label labelAffichageTitre;
        private Label labelAffichageTitreOriginal;

        /// <summary>
        ///     Objets dans l'AffichageResume
        /// </summary>
        private PictureBox pictureBox1;

        /// <summary>
        ///     Afficher les infos du film dans l'AffichageResume
        /// </summary>
        /// <param name="odgv">Objet ObjetsDataGridView</param>
        public AffichageResumeFilm(ObjetsDataGridView odgv)
        {
            InitializeComponent();
            Odgv = odgv;
            try
            {
                pictureBox1.Load("https://image.tmdb.org/t/p/w500" + Odgv.Poster);
            }
            catch (Exception)
            {
                pictureBox1.Load(@".\Images\Image non trouvé.jpg");
            }
            labelAffichageTitre.Text = Odgv.Nom1;
            labelAffichageTitreOriginal.Text = Convert.ToString(Odgv.TitreOrigine);
            labelAffichageSlogan.Text = Odgv.Slogan;
            labelAffichageTitreOriginal.Text = Odgv.TitreOrigine;
            LabelAffichageDateDeSortie.Text = Convert.ToDateTime(Odgv.DateDeSortie).ToLongDateString();
            labelAffichageDuree.Text = Odgv.Duree + " minutes";
            labelAffichageNombreDeVotes.Text = Odgv.NombreDeVotes;
            labelAffichageMoyenneDesNotes.Text = Odgv.MoyenneDesVotes;
            labelAffichageBudget.Text = Odgv.Budget + "$";
            labelAffichageRevenue.Text = Odgv.Revenue + "$";
            labelAffichageSynopsis.Text = Odgv.Synopsis;
        }

        internal ObjetsDataGridView Odgv { get; set; }

        /// <summary>
        ///     Initialisation des composants AffichageResume
        /// </summary>
        private void InitializeComponent()
        {
            var resources = new ComponentResourceManager(typeof(AffichageResumeFilm));
            pictureBox1 = new PictureBox();
            labelAffichageTitre = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            labelAffichageSlogan = new Label();
            labelAffichageTitreOriginal = new Label();
            LabelAffichageDateDeSortie = new Label();
            labelAffichageDuree = new Label();
            labelAffichageNombreDeVotes = new Label();
            labelAffichageMoyenneDesNotes = new Label();
            labelAffichageBudget = new Label();
            labelAffichageRevenue = new Label();
            labelAffichageSynopsis = new Label();
            BoutonAjouterAuxFavoris = new Button();
            ((ISupportInitialize) pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(13, 13);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(278, 454);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // labelAffichageTitre
            // 
            labelAffichageTitre.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelAffichageTitre.Location = new Point(295, 13);
            labelAffichageTitre.Name = "labelAffichageTitre";
            labelAffichageTitre.Size = new Size(370, 53);
            labelAffichageTitre.TabIndex = 1;
            labelAffichageTitre.Text = "labelAffichageTitre";
            labelAffichageTitre.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(297, 98);
            label2.Name = "label2";
            label2.Size = new Size(139, 28);
            label2.TabIndex = 2;
            label2.Text = "Titre d\'origine";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            label3.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(297, 126);
            label3.Name = "label3";
            label3.Size = new Size(139, 28);
            label3.TabIndex = 3;
            label3.Text = "Date de sortie";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            label4.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(297, 154);
            label4.Name = "label4";
            label4.Size = new Size(139, 28);
            label4.TabIndex = 4;
            label4.Text = "Durée";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            label5.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(297, 182);
            label5.Name = "label5";
            label5.Size = new Size(139, 28);
            label5.TabIndex = 5;
            label5.Text = "Nombre de votes";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            label6.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(297, 210);
            label6.Name = "label6";
            label6.Size = new Size(139, 28);
            label6.TabIndex = 6;
            label6.Text = "Moyenne des votes";
            label6.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            label7.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(297, 70);
            label7.Name = "label7";
            label7.Size = new Size(139, 28);
            label7.TabIndex = 7;
            label7.Text = "Slogan";
            label7.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            label8.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(297, 238);
            label8.Name = "label8";
            label8.Size = new Size(139, 28);
            label8.TabIndex = 8;
            label8.Text = "Budget";
            label8.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            label9.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(297, 266);
            label9.Name = "label9";
            label9.Size = new Size(139, 28);
            label9.TabIndex = 9;
            label9.Text = "Revenue";
            label9.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelAffichageSlogan
            // 
            labelAffichageSlogan.BorderStyle = BorderStyle.FixedSingle;
            labelAffichageSlogan.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelAffichageSlogan.Location = new Point(440, 70);
            labelAffichageSlogan.Name = "labelAffichageSlogan";
            labelAffichageSlogan.Size = new Size(411, 28);
            labelAffichageSlogan.TabIndex = 17;
            labelAffichageSlogan.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelAffichageTitreOriginal
            // 
            labelAffichageTitreOriginal.BorderStyle = BorderStyle.FixedSingle;
            labelAffichageTitreOriginal.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular,
                GraphicsUnit.Point, 0);
            labelAffichageTitreOriginal.Location = new Point(440, 98);
            labelAffichageTitreOriginal.Name = "labelAffichageTitreOriginal";
            labelAffichageTitreOriginal.Size = new Size(411, 28);
            labelAffichageTitreOriginal.TabIndex = 16;
            labelAffichageTitreOriginal.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // LabelAffichageDateDeSortie
            // 
            LabelAffichageDateDeSortie.BorderStyle = BorderStyle.FixedSingle;
            LabelAffichageDateDeSortie.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular,
                GraphicsUnit.Point, 0);
            LabelAffichageDateDeSortie.Location = new Point(440, 126);
            LabelAffichageDateDeSortie.Name = "LabelAffichageDateDeSortie";
            LabelAffichageDateDeSortie.Size = new Size(411, 28);
            LabelAffichageDateDeSortie.TabIndex = 15;
            LabelAffichageDateDeSortie.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelAffichageDuree
            // 
            labelAffichageDuree.BorderStyle = BorderStyle.FixedSingle;
            labelAffichageDuree.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelAffichageDuree.Location = new Point(440, 154);
            labelAffichageDuree.Name = "labelAffichageDuree";
            labelAffichageDuree.Size = new Size(411, 28);
            labelAffichageDuree.TabIndex = 14;
            labelAffichageDuree.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelAffichageNombreDeVotes
            // 
            labelAffichageNombreDeVotes.BorderStyle = BorderStyle.FixedSingle;
            labelAffichageNombreDeVotes.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular,
                GraphicsUnit.Point, 0);
            labelAffichageNombreDeVotes.Location = new Point(440, 182);
            labelAffichageNombreDeVotes.Name = "labelAffichageNombreDeVotes";
            labelAffichageNombreDeVotes.Size = new Size(411, 28);
            labelAffichageNombreDeVotes.TabIndex = 13;
            labelAffichageNombreDeVotes.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelAffichageMoyenneDesNotes
            // 
            labelAffichageMoyenneDesNotes.BorderStyle = BorderStyle.FixedSingle;
            labelAffichageMoyenneDesNotes.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular,
                GraphicsUnit.Point, 0);
            labelAffichageMoyenneDesNotes.Location = new Point(440, 210);
            labelAffichageMoyenneDesNotes.Name = "labelAffichageMoyenneDesNotes";
            labelAffichageMoyenneDesNotes.Size = new Size(411, 28);
            labelAffichageMoyenneDesNotes.TabIndex = 12;
            labelAffichageMoyenneDesNotes.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelAffichageBudget
            // 
            labelAffichageBudget.BorderStyle = BorderStyle.FixedSingle;
            labelAffichageBudget.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelAffichageBudget.Location = new Point(440, 238);
            labelAffichageBudget.Name = "labelAffichageBudget";
            labelAffichageBudget.Size = new Size(411, 28);
            labelAffichageBudget.TabIndex = 11;
            labelAffichageBudget.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelAffichageRevenue
            // 
            labelAffichageRevenue.BorderStyle = BorderStyle.FixedSingle;
            labelAffichageRevenue.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelAffichageRevenue.Location = new Point(440, 266);
            labelAffichageRevenue.Name = "labelAffichageRevenue";
            labelAffichageRevenue.Size = new Size(411, 28);
            labelAffichageRevenue.TabIndex = 10;
            labelAffichageRevenue.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelAffichageSynopsis
            // 
            labelAffichageSynopsis.BorderStyle = BorderStyle.FixedSingle;
            labelAffichageSynopsis.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelAffichageSynopsis.Location = new Point(299, 308);
            labelAffichageSynopsis.Name = "labelAffichageSynopsis";
            labelAffichageSynopsis.Size = new Size(552, 159);
            labelAffichageSynopsis.TabIndex = 18;
            labelAffichageSynopsis.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // BoutonAjouterAuxFavoris
            // 
            BoutonAjouterAuxFavoris.Location = new Point(671, 13);
            BoutonAjouterAuxFavoris.Name = "BoutonAjouterAuxFavoris";
            BoutonAjouterAuxFavoris.Size = new Size(180, 53);
            BoutonAjouterAuxFavoris.TabIndex = 19;
            BoutonAjouterAuxFavoris.Text = "Ajouter aux favoris";
            BoutonAjouterAuxFavoris.UseVisualStyleBackColor = true;
            BoutonAjouterAuxFavoris.MouseClick += BoutonAjouterAyxFavoris_MouseClick;
            // 
            // AffichageResumeFilm
            // 
            BackColor = Color.Gray;
            ClientSize = new Size(865, 479);
            Controls.Add(BoutonAjouterAuxFavoris);
            Controls.Add(labelAffichageSynopsis);
            Controls.Add(labelAffichageSlogan);
            Controls.Add(labelAffichageTitreOriginal);
            Controls.Add(LabelAffichageDateDeSortie);
            Controls.Add(labelAffichageDuree);
            Controls.Add(labelAffichageNombreDeVotes);
            Controls.Add(labelAffichageMoyenneDesNotes);
            Controls.Add(labelAffichageBudget);
            Controls.Add(labelAffichageRevenue);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(labelAffichageTitre);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Icon = (Icon) resources.GetObject("$this.Icon");
            Name = "AffichageResumeFilm";
            StartPosition = FormStartPosition.CenterScreen;
            ((ISupportInitialize) pictureBox1).EndInit();
            ResumeLayout(false);
        }

        /// <summary>
        ///     Evénement quand on click sur le bouton favoris
        /// </summary>
        private void BoutonAjouterAyxFavoris_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                var test = new JsonResumeFilm();
                test.Serialisation(Odgv);
                MessageBox.Show("\"" + Odgv.Nom1 + "\"" + " a bien était ajouté aux favoris");
            }
        }
    }
}