namespace Projet_atlantik
{
    partial class afficherTraversée
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
            this.lvAfficherTraversée = new System.Windows.Forms.ListView();
            this.lstbxSecteursAfficherTraversée = new System.Windows.Forms.ListBox();
            this.cmbbxLiaisonAfficherTraversée = new System.Windows.Forms.ComboBox();
            this.btnAfficherTraversées = new System.Windows.Forms.Button();
            this.dtpAfficherTraversée = new System.Windows.Forms.DateTimePicker();
            this.lblSecteursAfficherTraversée = new System.Windows.Forms.Label();
            this.lblLiaisonAfficherTraversée = new System.Windows.Forms.Label();
            this.lblDateAfficherTraversée = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lvAfficherTraversée
            // 
            this.lvAfficherTraversée.BackColor = System.Drawing.SystemColors.Info;
            this.lvAfficherTraversée.HideSelection = false;
            this.lvAfficherTraversée.Location = new System.Drawing.Point(309, 113);
            this.lvAfficherTraversée.Name = "lvAfficherTraversée";
            this.lvAfficherTraversée.Size = new System.Drawing.Size(468, 300);
            this.lvAfficherTraversée.TabIndex = 0;
            this.lvAfficherTraversée.UseCompatibleStateImageBehavior = false;
            // 
            // lstbxSecteursAfficherTraversée
            // 
            this.lstbxSecteursAfficherTraversée.BackColor = System.Drawing.SystemColors.Info;
            this.lstbxSecteursAfficherTraversée.FormattingEnabled = true;
            this.lstbxSecteursAfficherTraversée.Location = new System.Drawing.Point(31, 41);
            this.lstbxSecteursAfficherTraversée.Name = "lstbxSecteursAfficherTraversée";
            this.lstbxSecteursAfficherTraversée.Size = new System.Drawing.Size(156, 238);
            this.lstbxSecteursAfficherTraversée.TabIndex = 1;
            this.lstbxSecteursAfficherTraversée.SelectedIndexChanged += new System.EventHandler(this.lstbxSecteursAfficherTraversée_SelectedIndexChanged);
            // 
            // cmbbxLiaisonAfficherTraversée
            // 
            this.cmbbxLiaisonAfficherTraversée.BackColor = System.Drawing.SystemColors.Info;
            this.cmbbxLiaisonAfficherTraversée.FormattingEnabled = true;
            this.cmbbxLiaisonAfficherTraversée.Location = new System.Drawing.Point(31, 357);
            this.cmbbxLiaisonAfficherTraversée.Name = "cmbbxLiaisonAfficherTraversée";
            this.cmbbxLiaisonAfficherTraversée.Size = new System.Drawing.Size(156, 21);
            this.cmbbxLiaisonAfficherTraversée.TabIndex = 2;
            // 
            // btnAfficherTraversées
            // 
            this.btnAfficherTraversées.Location = new System.Drawing.Point(395, 79);
            this.btnAfficherTraversées.Name = "btnAfficherTraversées";
            this.btnAfficherTraversées.Size = new System.Drawing.Size(305, 28);
            this.btnAfficherTraversées.TabIndex = 3;
            this.btnAfficherTraversées.Text = "Afficher les traversées";
            this.btnAfficherTraversées.UseVisualStyleBackColor = true;
            this.btnAfficherTraversées.Click += new System.EventHandler(this.btnAfficherTraversées_Click);
            // 
            // dtpAfficherTraversée
            // 
            this.dtpAfficherTraversée.Location = new System.Drawing.Point(553, 32);
            this.dtpAfficherTraversée.Name = "dtpAfficherTraversée";
            this.dtpAfficherTraversée.Size = new System.Drawing.Size(224, 20);
            this.dtpAfficherTraversée.TabIndex = 4;
            // 
            // lblSecteursAfficherTraversée
            // 
            this.lblSecteursAfficherTraversée.AutoSize = true;
            this.lblSecteursAfficherTraversée.Location = new System.Drawing.Point(31, 13);
            this.lblSecteursAfficherTraversée.Name = "lblSecteursAfficherTraversée";
            this.lblSecteursAfficherTraversée.Size = new System.Drawing.Size(55, 13);
            this.lblSecteursAfficherTraversée.TabIndex = 5;
            this.lblSecteursAfficherTraversée.Text = "Secteurs :";
            // 
            // lblLiaisonAfficherTraversée
            // 
            this.lblLiaisonAfficherTraversée.AutoSize = true;
            this.lblLiaisonAfficherTraversée.Location = new System.Drawing.Point(28, 331);
            this.lblLiaisonAfficherTraversée.Name = "lblLiaisonAfficherTraversée";
            this.lblLiaisonAfficherTraversée.Size = new System.Drawing.Size(46, 13);
            this.lblLiaisonAfficherTraversée.TabIndex = 6;
            this.lblLiaisonAfficherTraversée.Text = "Liaison :";
            // 
            // lblDateAfficherTraversée
            // 
            this.lblDateAfficherTraversée.AutoSize = true;
            this.lblDateAfficherTraversée.Location = new System.Drawing.Point(392, 38);
            this.lblDateAfficherTraversée.Name = "lblDateAfficherTraversée";
            this.lblDateAfficherTraversée.Size = new System.Drawing.Size(155, 13);
            this.lblDateAfficherTraversée.TabIndex = 7;
            this.lblDateAfficherTraversée.Text = "Date (par défaut date du jour) : ";
            // 
            // afficherTraversée
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblDateAfficherTraversée);
            this.Controls.Add(this.lblLiaisonAfficherTraversée);
            this.Controls.Add(this.lblSecteursAfficherTraversée);
            this.Controls.Add(this.dtpAfficherTraversée);
            this.Controls.Add(this.btnAfficherTraversées);
            this.Controls.Add(this.cmbbxLiaisonAfficherTraversée);
            this.Controls.Add(this.lstbxSecteursAfficherTraversée);
            this.Controls.Add(this.lvAfficherTraversée);
            this.Name = "afficherTraversée";
            this.Text = "afficherTraversée";
            this.Load += new System.EventHandler(this.afficherTraversée_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvAfficherTraversée;
        private System.Windows.Forms.ListBox lstbxSecteursAfficherTraversée;
        private System.Windows.Forms.ComboBox cmbbxLiaisonAfficherTraversée;
        private System.Windows.Forms.Button btnAfficherTraversées;
        private System.Windows.Forms.DateTimePicker dtpAfficherTraversée;
        private System.Windows.Forms.Label lblSecteursAfficherTraversée;
        private System.Windows.Forms.Label lblLiaisonAfficherTraversée;
        private System.Windows.Forms.Label lblDateAfficherTraversée;
    }
}