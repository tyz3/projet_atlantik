namespace Projet_atlantik
{
    partial class menu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(menu));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuAjouter = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAjouterSecteur = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAjouterPort = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAjouterLiaison = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAjouterTarif = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAjouterBateau = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAjouterTraversée = new System.Windows.Forms.ToolStripMenuItem();
            this.menuModifier = new System.Windows.Forms.ToolStripMenuItem();
            this.menuModifierBateau = new System.Windows.Forms.ToolStripMenuItem();
            this.menuModifierParametre = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAfficher = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAfficherTraversée = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAfficherRéservation = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAPropos = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuAjouter,
            this.menuModifier,
            this.menuAfficher,
            this.menuAPropos});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(952, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuAjouter
            // 
            this.menuAjouter.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuAjouterSecteur,
            this.menuAjouterPort,
            this.menuAjouterLiaison,
            this.menuAjouterTarif,
            this.menuAjouterBateau,
            this.menuAjouterTraversée});
            this.menuAjouter.Name = "menuAjouter";
            this.menuAjouter.Size = new System.Drawing.Size(58, 20);
            this.menuAjouter.Text = "Ajouter";
            // 
            // menuAjouterSecteur
            // 
            this.menuAjouterSecteur.Name = "menuAjouterSecteur";
            this.menuAjouterSecteur.Size = new System.Drawing.Size(287, 22);
            this.menuAjouterSecteur.Text = "Un secteur";
            this.menuAjouterSecteur.Click += new System.EventHandler(this.unSecteurToolStripMenuItem_Click);
            // 
            // menuAjouterPort
            // 
            this.menuAjouterPort.Name = "menuAjouterPort";
            this.menuAjouterPort.Size = new System.Drawing.Size(287, 22);
            this.menuAjouterPort.Text = "Un port";
            this.menuAjouterPort.Click += new System.EventHandler(this.menuAjouterPort_Click);
            // 
            // menuAjouterLiaison
            // 
            this.menuAjouterLiaison.Name = "menuAjouterLiaison";
            this.menuAjouterLiaison.Size = new System.Drawing.Size(287, 22);
            this.menuAjouterLiaison.Text = "Une liaison";
            this.menuAjouterLiaison.Click += new System.EventHandler(this.menuAjouterLiaison_Click);
            // 
            // menuAjouterTarif
            // 
            this.menuAjouterTarif.Name = "menuAjouterTarif";
            this.menuAjouterTarif.Size = new System.Drawing.Size(287, 22);
            this.menuAjouterTarif.Text = "Les tarifs pour une liaison et une période";
            this.menuAjouterTarif.Click += new System.EventHandler(this.menuAjouterTarif_Click);
            // 
            // menuAjouterBateau
            // 
            this.menuAjouterBateau.Name = "menuAjouterBateau";
            this.menuAjouterBateau.Size = new System.Drawing.Size(287, 22);
            this.menuAjouterBateau.Text = "Un bateau";
            this.menuAjouterBateau.Click += new System.EventHandler(this.menuAjouterBateau_Click);
            // 
            // menuAjouterTraversée
            // 
            this.menuAjouterTraversée.Name = "menuAjouterTraversée";
            this.menuAjouterTraversée.Size = new System.Drawing.Size(287, 22);
            this.menuAjouterTraversée.Text = "Une traversée";
            this.menuAjouterTraversée.Click += new System.EventHandler(this.menuAjouterTraversée_Click);
            // 
            // menuModifier
            // 
            this.menuModifier.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuModifierBateau,
            this.menuModifierParametre});
            this.menuModifier.Name = "menuModifier";
            this.menuModifier.Size = new System.Drawing.Size(64, 20);
            this.menuModifier.Text = "Modifier";
            // 
            // menuModifierBateau
            // 
            this.menuModifierBateau.Name = "menuModifierBateau";
            this.menuModifierBateau.Size = new System.Drawing.Size(191, 22);
            this.menuModifierBateau.Text = "Un bateau";
            this.menuModifierBateau.Click += new System.EventHandler(this.menuModifierBateau_Click);
            // 
            // menuModifierParametre
            // 
            this.menuModifierParametre.Name = "menuModifierParametre";
            this.menuModifierParametre.Size = new System.Drawing.Size(191, 22);
            this.menuModifierParametre.Text = "Les paramètres du site";
            this.menuModifierParametre.Click += new System.EventHandler(this.menuModifierParametre_Click);
            // 
            // menuAfficher
            // 
            this.menuAfficher.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuAfficherTraversée,
            this.menuAfficherRéservation});
            this.menuAfficher.Name = "menuAfficher";
            this.menuAfficher.Size = new System.Drawing.Size(61, 20);
            this.menuAfficher.Text = "Afficher";
            // 
            // menuAfficherTraversée
            // 
            this.menuAfficherTraversée.Name = "menuAfficherTraversée";
            this.menuAfficherTraversée.Size = new System.Drawing.Size(524, 22);
            this.menuAfficherTraversée.Text = "Les traversées pour une liaison et une date donnée avec places restantes par caté" +
    "gorie";
            this.menuAfficherTraversée.Click += new System.EventHandler(this.menuAfficherTraversée_Click);
            // 
            // menuAfficherRéservation
            // 
            this.menuAfficherRéservation.Name = "menuAfficherRéservation";
            this.menuAfficherRéservation.Size = new System.Drawing.Size(524, 22);
            this.menuAfficherRéservation.Text = "Les détails d\'une réservation pour un client";
            this.menuAfficherRéservation.Click += new System.EventHandler(this.menuAfficherRéservation_Click);
            // 
            // menuAPropos
            // 
            this.menuAPropos.Name = "menuAPropos";
            this.menuAPropos.Size = new System.Drawing.Size(67, 20);
            this.menuAPropos.Text = "A Propos";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 45F);
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(290, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(317, 69);
            this.label1.TabIndex = 1;
            this.label1.Text = "ATLANTIK";
            // 
            // menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(952, 580);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "menu";
            this.Text = "Accueil";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuAjouter;
        private System.Windows.Forms.ToolStripMenuItem menuAjouterSecteur;
        private System.Windows.Forms.ToolStripMenuItem menuAjouterPort;
        private System.Windows.Forms.ToolStripMenuItem menuAjouterLiaison;
        private System.Windows.Forms.ToolStripMenuItem menuAjouterTarif;
        private System.Windows.Forms.ToolStripMenuItem menuAjouterBateau;
        private System.Windows.Forms.ToolStripMenuItem menuAjouterTraversée;
        private System.Windows.Forms.ToolStripMenuItem menuModifier;
        private System.Windows.Forms.ToolStripMenuItem menuModifierBateau;
        private System.Windows.Forms.ToolStripMenuItem menuModifierParametre;
        private System.Windows.Forms.ToolStripMenuItem menuAfficher;
        private System.Windows.Forms.ToolStripMenuItem menuAfficherTraversée;
        private System.Windows.Forms.ToolStripMenuItem menuAfficherRéservation;
        private System.Windows.Forms.ToolStripMenuItem menuAPropos;
        private System.Windows.Forms.Label label1;
    }
}