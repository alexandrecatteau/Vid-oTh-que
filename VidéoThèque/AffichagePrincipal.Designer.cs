using System;
using System.Windows.Forms;

namespace VidéoThèque
{
    partial class AffichagePrincipal
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Films");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Séries TV");
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AffichagePrincipal));
            this.treeViewFilmSeries = new System.Windows.Forms.TreeView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BoutonSuivant = new System.Windows.Forms.Button();
            this.BoutonFin = new System.Windows.Forms.Button();
            this.LabelNombreDePages = new System.Windows.Forms.Label();
            this.BoutonPrecedent = new System.Windows.Forms.Button();
            this.BoutonDebut = new System.Windows.Forms.Button();
            this.BoutonTriParTitre = new System.Windows.Forms.Button();
            this.BoutonTriParPopularité = new System.Windows.Forms.Button();
            this.BoutonTriParVote = new System.Windows.Forms.Button();
            this.LabelNombreDeResultats = new System.Windows.Forms.Label();
            this.BoutonFavoris = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // treeViewFilmSeries
            // 
            this.treeViewFilmSeries.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.treeViewFilmSeries.BackColor = System.Drawing.Color.DarkGray;
            this.treeViewFilmSeries.Cursor = System.Windows.Forms.Cursors.Hand;
            this.treeViewFilmSeries.Location = new System.Drawing.Point(12, 12);
            this.treeViewFilmSeries.Name = "treeViewFilmSeries";
            treeNode1.Name = "Nœud0";
            treeNode1.Text = "Films";
            treeNode2.Name = "Nœud1";
            treeNode2.Text = "Séries TV";
            this.treeViewFilmSeries.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2});
            this.treeViewFilmSeries.Size = new System.Drawing.Size(143, 551);
            this.treeViewFilmSeries.TabIndex = 0;
            this.treeViewFilmSeries.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView1_NodeMouseClick);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(161, 55);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1163, 479);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            this.dataGridView1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView1_CellFormatting);
            // 
            // BoutonSuivant
            // 
            this.BoutonSuivant.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BoutonSuivant.Location = new System.Drawing.Point(1267, 540);
            this.BoutonSuivant.Name = "BoutonSuivant";
            this.BoutonSuivant.Size = new System.Drawing.Size(25, 23);
            this.BoutonSuivant.TabIndex = 2;
            this.BoutonSuivant.Text = ">";
            this.BoutonSuivant.UseVisualStyleBackColor = true;
            this.BoutonSuivant.MouseClick += new System.Windows.Forms.MouseEventHandler(this.BoutonSuivant_MouseClick);
            // 
            // BoutonFin
            // 
            this.BoutonFin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BoutonFin.Location = new System.Drawing.Point(1298, 540);
            this.BoutonFin.Name = "BoutonFin";
            this.BoutonFin.Size = new System.Drawing.Size(25, 23);
            this.BoutonFin.TabIndex = 3;
            this.BoutonFin.Text = ">|";
            this.BoutonFin.UseVisualStyleBackColor = true;
            this.BoutonFin.MouseClick += new System.Windows.Forms.MouseEventHandler(this.BoutonFin_MouseClick);
            // 
            // LabelNombreDePages
            // 
            this.LabelNombreDePages.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelNombreDePages.Location = new System.Drawing.Point(1213, 540);
            this.LabelNombreDePages.Name = "LabelNombreDePages";
            this.LabelNombreDePages.Size = new System.Drawing.Size(48, 23);
            this.LabelNombreDePages.TabIndex = 4;
            this.LabelNombreDePages.Text = "?/?";
            this.LabelNombreDePages.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BoutonPrecedent
            // 
            this.BoutonPrecedent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BoutonPrecedent.Location = new System.Drawing.Point(1182, 540);
            this.BoutonPrecedent.Name = "BoutonPrecedent";
            this.BoutonPrecedent.Size = new System.Drawing.Size(25, 23);
            this.BoutonPrecedent.TabIndex = 5;
            this.BoutonPrecedent.Text = "<";
            this.BoutonPrecedent.UseVisualStyleBackColor = true;
            this.BoutonPrecedent.MouseClick += new System.Windows.Forms.MouseEventHandler(this.BoutonPrecedent_MouseClick);
            // 
            // BoutonDebut
            // 
            this.BoutonDebut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BoutonDebut.Location = new System.Drawing.Point(1151, 540);
            this.BoutonDebut.Name = "BoutonDebut";
            this.BoutonDebut.Size = new System.Drawing.Size(25, 23);
            this.BoutonDebut.TabIndex = 6;
            this.BoutonDebut.Text = "|<";
            this.BoutonDebut.UseVisualStyleBackColor = true;
            this.BoutonDebut.MouseClick += new System.Windows.Forms.MouseEventHandler(this.BoutonDebut_MouseClick);
            // 
            // BoutonTriParTitre
            // 
            this.BoutonTriParTitre.Location = new System.Drawing.Point(161, 13);
            this.BoutonTriParTitre.Name = "BoutonTriParTitre";
            this.BoutonTriParTitre.Size = new System.Drawing.Size(226, 36);
            this.BoutonTriParTitre.TabIndex = 7;
            this.BoutonTriParTitre.Text = "Tri par Titre";
            this.BoutonTriParTitre.UseVisualStyleBackColor = true;
            this.BoutonTriParTitre.MouseClick += new System.Windows.Forms.MouseEventHandler(this.BoutonTriParTitre_MouseClick);
            // 
            // BoutonTriParPopularité
            // 
            this.BoutonTriParPopularité.Location = new System.Drawing.Point(393, 13);
            this.BoutonTriParPopularité.Name = "BoutonTriParPopularité";
            this.BoutonTriParPopularité.Size = new System.Drawing.Size(226, 36);
            this.BoutonTriParPopularité.TabIndex = 8;
            this.BoutonTriParPopularité.Text = "Tri par Popularité";
            this.BoutonTriParPopularité.UseVisualStyleBackColor = true;
            this.BoutonTriParPopularité.MouseClick += new System.Windows.Forms.MouseEventHandler(this.BoutonTriParPopularité_MouseClick);
            // 
            // BoutonTriParVote
            // 
            this.BoutonTriParVote.Location = new System.Drawing.Point(625, 13);
            this.BoutonTriParVote.Name = "BoutonTriParVote";
            this.BoutonTriParVote.Size = new System.Drawing.Size(226, 36);
            this.BoutonTriParVote.TabIndex = 9;
            this.BoutonTriParVote.Text = "Nombre de Votes";
            this.BoutonTriParVote.UseVisualStyleBackColor = true;
            this.BoutonTriParVote.Click += new System.EventHandler(this.TriParVote_Click);
            // 
            // LabelNombreDeResultats
            // 
            this.LabelNombreDeResultats.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelNombreDeResultats.Location = new System.Drawing.Point(837, 540);
            this.LabelNombreDeResultats.Name = "LabelNombreDeResultats";
            this.LabelNombreDeResultats.Size = new System.Drawing.Size(308, 23);
            this.LabelNombreDeResultats.TabIndex = 10;
            this.LabelNombreDeResultats.Text = "?/?";
            this.LabelNombreDeResultats.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // BoutonFavoris
            // 
            this.BoutonFavoris.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BoutonFavoris.Location = new System.Drawing.Point(1084, 13);
            this.BoutonFavoris.Name = "BoutonFavoris";
            this.BoutonFavoris.Size = new System.Drawing.Size(238, 35);
            this.BoutonFavoris.TabIndex = 11;
            this.BoutonFavoris.Text = "Favoris";
            this.BoutonFavoris.UseVisualStyleBackColor = true;
            this.BoutonFavoris.Click += new System.EventHandler(this.BoutonFavoris_Click);
            // 
            // AffichagePrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(1336, 575);
            this.Controls.Add(this.BoutonFavoris);
            this.Controls.Add(this.LabelNombreDeResultats);
            this.Controls.Add(this.BoutonTriParVote);
            this.Controls.Add(this.BoutonTriParPopularité);
            this.Controls.Add(this.BoutonTriParTitre);
            this.Controls.Add(this.BoutonDebut);
            this.Controls.Add(this.BoutonPrecedent);
            this.Controls.Add(this.LabelNombreDePages);
            this.Controls.Add(this.BoutonFin);
            this.Controls.Add(this.BoutonSuivant);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.treeViewFilmSeries);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AffichagePrincipal";
            this.Text = "AffichagePrincipal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeViewFilmSeries;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Button BoutonSuivant;
        private Button BoutonFin;
        private Label LabelNombreDePages;
        private Button BoutonPrecedent;
        private Button BoutonDebut;
        private Button BoutonTriParTitre;
        private Button BoutonTriParPopularité;
        private Button BoutonTriParVote;
        private Label LabelNombreDeResultats;
        private Button BoutonFavoris;
    }
}

