using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
///
namespace VidéoThèque
{
    /// <summary>
    /// Afficher le résumé d'une série au doubleclick sur le DGV
    /// </summary>
    class AffichageResumeSerie : Form
    {
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label labelAffichageTitre;
        private Label labelMoyenneDesVotes;
        private Label labelNomOrigine;
        private Label labelNombreEpisodes;
        private Label labelNombreSaisons;
        private Label labelStatutDeProduction;
        private Label labelNombreDeVotes;
        private Label labelSynopsis;
        private PictureBox pictureBox1;
        private ObjetsDataGridView odgv;
        /// <summary>
        /// Constructeur pour afficher le résumé
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
                pictureBox1.Load(@"E:\documents\Visual Studio\VidéoThèque\VidéoThèque\Images\Image non trouvé.jpg");
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
        /// Initialisation des composants de la fenêtre
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelAffichageTitre = new System.Windows.Forms.Label();
            this.labelMoyenneDesVotes = new System.Windows.Forms.Label();
            this.labelNomOrigine = new System.Windows.Forms.Label();
            this.labelNombreEpisodes = new System.Windows.Forms.Label();
            this.labelNombreSaisons = new System.Windows.Forms.Label();
            this.labelStatutDeProduction = new System.Windows.Forms.Label();
            this.labelNombreDeVotes = new System.Windows.Forms.Label();
            this.labelSynopsis = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(13, 13);
            this.pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(341, 519);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(360, 66);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(139, 28);
            this.label7.TabIndex = 15;
            this.label7.Text = "Nom d\'origine";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(360, 206);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(139, 28);
            this.label6.TabIndex = 14;
            this.label6.Text = "Moyenne des votes";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(360, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 28);
            this.label5.TabIndex = 13;
            this.label5.Text = "Nombre de votes";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(360, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 28);
            this.label4.TabIndex = 12;
            this.label4.Text = "Statut de production";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(360, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 28);
            this.label3.TabIndex = 11;
            this.label3.Text = "Nombre de saisons";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(360, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 28);
            this.label2.TabIndex = 10;
            this.label2.Text = "Nombre d\'épisodes";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelAffichageTitre
            // 
            this.labelAffichageTitre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAffichageTitre.Location = new System.Drawing.Point(359, 9);
            this.labelAffichageTitre.Name = "labelAffichageTitre";
            this.labelAffichageTitre.Size = new System.Drawing.Size(548, 53);
            this.labelAffichageTitre.TabIndex = 18;
            this.labelAffichageTitre.Text = "labelAffichageTitre";
            this.labelAffichageTitre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelMoyenneDesVotes
            // 
            this.labelMoyenneDesVotes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelMoyenneDesVotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMoyenneDesVotes.Location = new System.Drawing.Point(505, 206);
            this.labelMoyenneDesVotes.Name = "labelMoyenneDesVotes";
            this.labelMoyenneDesVotes.Size = new System.Drawing.Size(325, 28);
            this.labelMoyenneDesVotes.TabIndex = 24;
            this.labelMoyenneDesVotes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelNomOrigine
            // 
            this.labelNomOrigine.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelNomOrigine.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNomOrigine.Location = new System.Drawing.Point(505, 66);
            this.labelNomOrigine.Name = "labelNomOrigine";
            this.labelNomOrigine.Size = new System.Drawing.Size(325, 28);
            this.labelNomOrigine.TabIndex = 23;
            this.labelNomOrigine.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelNombreEpisodes
            // 
            this.labelNombreEpisodes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelNombreEpisodes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombreEpisodes.Location = new System.Drawing.Point(505, 94);
            this.labelNombreEpisodes.Name = "labelNombreEpisodes";
            this.labelNombreEpisodes.Size = new System.Drawing.Size(325, 28);
            this.labelNombreEpisodes.TabIndex = 22;
            this.labelNombreEpisodes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelNombreSaisons
            // 
            this.labelNombreSaisons.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelNombreSaisons.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombreSaisons.Location = new System.Drawing.Point(505, 122);
            this.labelNombreSaisons.Name = "labelNombreSaisons";
            this.labelNombreSaisons.Size = new System.Drawing.Size(325, 28);
            this.labelNombreSaisons.TabIndex = 21;
            this.labelNombreSaisons.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelStatutDeProduction
            // 
            this.labelStatutDeProduction.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelStatutDeProduction.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStatutDeProduction.Location = new System.Drawing.Point(505, 150);
            this.labelStatutDeProduction.Name = "labelStatutDeProduction";
            this.labelStatutDeProduction.Size = new System.Drawing.Size(325, 28);
            this.labelStatutDeProduction.TabIndex = 20;
            this.labelStatutDeProduction.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelNombreDeVotes
            // 
            this.labelNombreDeVotes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelNombreDeVotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombreDeVotes.Location = new System.Drawing.Point(505, 178);
            this.labelNombreDeVotes.Name = "labelNombreDeVotes";
            this.labelNombreDeVotes.Size = new System.Drawing.Size(325, 28);
            this.labelNombreDeVotes.TabIndex = 19;
            this.labelNombreDeVotes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelSynopsis
            // 
            this.labelSynopsis.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelSynopsis.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSynopsis.Location = new System.Drawing.Point(363, 266);
            this.labelSynopsis.Name = "labelSynopsis";
            this.labelSynopsis.Size = new System.Drawing.Size(467, 266);
            this.labelSynopsis.TabIndex = 25;
            this.labelSynopsis.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // AffichageResumeSerie
            // 
            this.ClientSize = new System.Drawing.Size(858, 544);
            this.Controls.Add(this.labelSynopsis);
            this.Controls.Add(this.labelMoyenneDesVotes);
            this.Controls.Add(this.labelNomOrigine);
            this.Controls.Add(this.labelNombreEpisodes);
            this.Controls.Add(this.labelNombreSaisons);
            this.Controls.Add(this.labelStatutDeProduction);
            this.Controls.Add(this.labelNombreDeVotes);
            this.Controls.Add(this.labelAffichageTitre);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "AffichageResumeSerie";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }
    }
}
