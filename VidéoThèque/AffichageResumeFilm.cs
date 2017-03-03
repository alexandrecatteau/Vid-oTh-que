using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using  System.Windows.Forms;
using Newtonsoft.Json;

namespace VidéoThèque
{
    class AffichageResumeFilm : Form
    {
        /// <summary>
        /// Objets dans l'AffichageResume
        /// </summary>
        private PictureBox pictureBox1;
        private Label labelAffichageTitre;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label labelAffichageSlogan;
        private Label labelAffichageTitreOriginal;
        private Label LabelAffichageDateDeSortie;
        private Label labelAffichageDuree;
        private Label labelAffichageNombreDeVotes;
        private Label labelAffichageMoyenneDesNotes;
        private Label labelAffichageBudget;
        private Label labelAffichageRevenue;
        private Label label9;
        private Label labelAffichageSynopsis;
        public Button BoutonAjouterAuxFavoris;
        private ObjetsDataGridView odgv;

        internal ObjetsDataGridView Odgv
        {
            get
            {
                return odgv;
            }

            set
            {
                odgv = value;
            }
        }
        /// <summary>
        /// Afficher les infos du film dans l'AffichageResume
        /// </summary>
        /// <param name="odgv">Objet ObjetsDataGridView</param>
        public AffichageResumeFilm(ObjetsDataGridView odgv)
        {
            InitializeComponent();
            this.Odgv = odgv;
            try
            {
                pictureBox1.Load("https://image.tmdb.org/t/p/w500" + Odgv.Poster);
            }
            catch (Exception)
            {
                pictureBox1.Load(@".\Images\Image non trouvé.jpg");
                
            }
            labelAffichageTitre.Text = Odgv.Nom1.ToString();
            labelAffichageTitreOriginal.Text = Convert.ToString(Odgv.TitreOrigine.ToString());
            labelAffichageSlogan.Text = Odgv.Slogan;
            labelAffichageTitreOriginal.Text = Odgv.TitreOrigine;
            LabelAffichageDateDeSortie.Text = Convert.ToDateTime(Odgv.DateDeSortie).ToLongDateString().ToString();
            labelAffichageDuree.Text = Odgv.Duree + " minutes";
            labelAffichageNombreDeVotes.Text = Odgv.NombreDeVotes;
            labelAffichageMoyenneDesNotes.Text = Odgv.MoyenneDesVotes;
            labelAffichageBudget.Text = Odgv.Budget + "$";
            labelAffichageRevenue.Text = Odgv.Revenue + "$";
            labelAffichageSynopsis.Text = Odgv.Synopsis;
        }
        /// <summary>
        /// Initialisation des composants AffichageResume
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AffichageResumeFilm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelAffichageTitre = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.labelAffichageSlogan = new System.Windows.Forms.Label();
            this.labelAffichageTitreOriginal = new System.Windows.Forms.Label();
            this.LabelAffichageDateDeSortie = new System.Windows.Forms.Label();
            this.labelAffichageDuree = new System.Windows.Forms.Label();
            this.labelAffichageNombreDeVotes = new System.Windows.Forms.Label();
            this.labelAffichageMoyenneDesNotes = new System.Windows.Forms.Label();
            this.labelAffichageBudget = new System.Windows.Forms.Label();
            this.labelAffichageRevenue = new System.Windows.Forms.Label();
            this.labelAffichageSynopsis = new System.Windows.Forms.Label();
            this.BoutonAjouterAuxFavoris = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(13, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(278, 454);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // labelAffichageTitre
            // 
            this.labelAffichageTitre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAffichageTitre.Location = new System.Drawing.Point(295, 13);
            this.labelAffichageTitre.Name = "labelAffichageTitre";
            this.labelAffichageTitre.Size = new System.Drawing.Size(370, 53);
            this.labelAffichageTitre.TabIndex = 1;
            this.labelAffichageTitre.Text = "labelAffichageTitre";
            this.labelAffichageTitre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(297, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 28);
            this.label2.TabIndex = 2;
            this.label2.Text = "Titre d\'origine";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(297, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 28);
            this.label3.TabIndex = 3;
            this.label3.Text = "Date de sortie";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(297, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 28);
            this.label4.TabIndex = 4;
            this.label4.Text = "Durée";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(297, 182);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 28);
            this.label5.TabIndex = 5;
            this.label5.Text = "Nombre de votes";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(297, 210);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(139, 28);
            this.label6.TabIndex = 6;
            this.label6.Text = "Moyenne des votes";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(297, 70);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(139, 28);
            this.label7.TabIndex = 7;
            this.label7.Text = "Slogan";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(297, 238);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(139, 28);
            this.label8.TabIndex = 8;
            this.label8.Text = "Budget";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(297, 266);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(139, 28);
            this.label9.TabIndex = 9;
            this.label9.Text = "Revenue";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelAffichageSlogan
            // 
            this.labelAffichageSlogan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelAffichageSlogan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAffichageSlogan.Location = new System.Drawing.Point(440, 70);
            this.labelAffichageSlogan.Name = "labelAffichageSlogan";
            this.labelAffichageSlogan.Size = new System.Drawing.Size(411, 28);
            this.labelAffichageSlogan.TabIndex = 17;
            this.labelAffichageSlogan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelAffichageTitreOriginal
            // 
            this.labelAffichageTitreOriginal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelAffichageTitreOriginal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAffichageTitreOriginal.Location = new System.Drawing.Point(440, 98);
            this.labelAffichageTitreOriginal.Name = "labelAffichageTitreOriginal";
            this.labelAffichageTitreOriginal.Size = new System.Drawing.Size(411, 28);
            this.labelAffichageTitreOriginal.TabIndex = 16;
            this.labelAffichageTitreOriginal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LabelAffichageDateDeSortie
            // 
            this.LabelAffichageDateDeSortie.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LabelAffichageDateDeSortie.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelAffichageDateDeSortie.Location = new System.Drawing.Point(440, 126);
            this.LabelAffichageDateDeSortie.Name = "LabelAffichageDateDeSortie";
            this.LabelAffichageDateDeSortie.Size = new System.Drawing.Size(411, 28);
            this.LabelAffichageDateDeSortie.TabIndex = 15;
            this.LabelAffichageDateDeSortie.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelAffichageDuree
            // 
            this.labelAffichageDuree.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelAffichageDuree.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAffichageDuree.Location = new System.Drawing.Point(440, 154);
            this.labelAffichageDuree.Name = "labelAffichageDuree";
            this.labelAffichageDuree.Size = new System.Drawing.Size(411, 28);
            this.labelAffichageDuree.TabIndex = 14;
            this.labelAffichageDuree.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelAffichageNombreDeVotes
            // 
            this.labelAffichageNombreDeVotes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelAffichageNombreDeVotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAffichageNombreDeVotes.Location = new System.Drawing.Point(440, 182);
            this.labelAffichageNombreDeVotes.Name = "labelAffichageNombreDeVotes";
            this.labelAffichageNombreDeVotes.Size = new System.Drawing.Size(411, 28);
            this.labelAffichageNombreDeVotes.TabIndex = 13;
            this.labelAffichageNombreDeVotes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelAffichageMoyenneDesNotes
            // 
            this.labelAffichageMoyenneDesNotes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelAffichageMoyenneDesNotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAffichageMoyenneDesNotes.Location = new System.Drawing.Point(440, 210);
            this.labelAffichageMoyenneDesNotes.Name = "labelAffichageMoyenneDesNotes";
            this.labelAffichageMoyenneDesNotes.Size = new System.Drawing.Size(411, 28);
            this.labelAffichageMoyenneDesNotes.TabIndex = 12;
            this.labelAffichageMoyenneDesNotes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelAffichageBudget
            // 
            this.labelAffichageBudget.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelAffichageBudget.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAffichageBudget.Location = new System.Drawing.Point(440, 238);
            this.labelAffichageBudget.Name = "labelAffichageBudget";
            this.labelAffichageBudget.Size = new System.Drawing.Size(411, 28);
            this.labelAffichageBudget.TabIndex = 11;
            this.labelAffichageBudget.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelAffichageRevenue
            // 
            this.labelAffichageRevenue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelAffichageRevenue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAffichageRevenue.Location = new System.Drawing.Point(440, 266);
            this.labelAffichageRevenue.Name = "labelAffichageRevenue";
            this.labelAffichageRevenue.Size = new System.Drawing.Size(411, 28);
            this.labelAffichageRevenue.TabIndex = 10;
            this.labelAffichageRevenue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelAffichageSynopsis
            // 
            this.labelAffichageSynopsis.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelAffichageSynopsis.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAffichageSynopsis.Location = new System.Drawing.Point(299, 308);
            this.labelAffichageSynopsis.Name = "labelAffichageSynopsis";
            this.labelAffichageSynopsis.Size = new System.Drawing.Size(552, 159);
            this.labelAffichageSynopsis.TabIndex = 18;
            this.labelAffichageSynopsis.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // BoutonAjouterAuxFavoris
            // 
            this.BoutonAjouterAuxFavoris.Location = new System.Drawing.Point(671, 13);
            this.BoutonAjouterAuxFavoris.Name = "BoutonAjouterAuxFavoris";
            this.BoutonAjouterAuxFavoris.Size = new System.Drawing.Size(180, 53);
            this.BoutonAjouterAuxFavoris.TabIndex = 19;
            this.BoutonAjouterAuxFavoris.Text = "Ajouter aux favoris";
            this.BoutonAjouterAuxFavoris.UseVisualStyleBackColor = true;
            this.BoutonAjouterAuxFavoris.MouseClick += new System.Windows.Forms.MouseEventHandler(this.BoutonAjouterAyxFavoris_MouseClick);
            // 
            // AffichageResumeFilm
            // 
            this.ClientSize = new System.Drawing.Size(865, 479);
            this.Controls.Add(this.BoutonAjouterAuxFavoris);
            this.Controls.Add(this.labelAffichageSynopsis);
            this.Controls.Add(this.labelAffichageSlogan);
            this.Controls.Add(this.labelAffichageTitreOriginal);
            this.Controls.Add(this.LabelAffichageDateDeSortie);
            this.Controls.Add(this.labelAffichageDuree);
            this.Controls.Add(this.labelAffichageNombreDeVotes);
            this.Controls.Add(this.labelAffichageMoyenneDesNotes);
            this.Controls.Add(this.labelAffichageBudget);
            this.Controls.Add(this.labelAffichageRevenue);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelAffichageTitre);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AffichageResumeFilm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
        }
        /// <summary>
        /// Evénement quand on click sur le bouton favoris
        /// </summary>
        private void BoutonAjouterAyxFavoris_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                JsonResumeFilm test = new JsonResumeFilm();
                test.Serialisation(Odgv);
                MessageBox.Show("\"" + Odgv.Nom1 + "\"" + " a bien était ajouté aux favoris");
            }
        }
        
    }
}
