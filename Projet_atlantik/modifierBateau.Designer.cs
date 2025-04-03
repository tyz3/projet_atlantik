namespace Projet_atlantik
{
    partial class modifierBateau
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
            this.gbxModifierBateau = new System.Windows.Forms.GroupBox();
            this.tbxVehiculeCModif = new System.Windows.Forms.TextBox();
            this.tbxVehiculeBModif = new System.Windows.Forms.TextBox();
            this.tbxPassagerModif = new System.Windows.Forms.TextBox();
            this.lblVehiculeC = new System.Windows.Forms.Label();
            this.lblVehiculeB = new System.Windows.Forms.Label();
            this.lblPassager = new System.Windows.Forms.Label();
            this.btnModifBateau = new System.Windows.Forms.Button();
            this.lblModifierBateau = new System.Windows.Forms.Label();
            this.cmbbxBateauNom = new System.Windows.Forms.ComboBox();
            this.gbxModifierBateau.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxModifierBateau
            // 
            this.gbxModifierBateau.BackColor = System.Drawing.SystemColors.Info;
            this.gbxModifierBateau.Controls.Add(this.tbxVehiculeCModif);
            this.gbxModifierBateau.Controls.Add(this.tbxVehiculeBModif);
            this.gbxModifierBateau.Controls.Add(this.tbxPassagerModif);
            this.gbxModifierBateau.Controls.Add(this.lblVehiculeC);
            this.gbxModifierBateau.Controls.Add(this.lblVehiculeB);
            this.gbxModifierBateau.Controls.Add(this.lblPassager);
            this.gbxModifierBateau.Location = new System.Drawing.Point(228, 39);
            this.gbxModifierBateau.Name = "gbxModifierBateau";
            this.gbxModifierBateau.Size = new System.Drawing.Size(289, 262);
            this.gbxModifierBateau.TabIndex = 4;
            this.gbxModifierBateau.TabStop = false;
            this.gbxModifierBateau.Text = "Capacités Maximales";
            // 
            // tbxVehiculeCModif
            // 
            this.tbxVehiculeCModif.Location = new System.Drawing.Point(141, 181);
            this.tbxVehiculeCModif.Name = "tbxVehiculeCModif";
            this.tbxVehiculeCModif.Size = new System.Drawing.Size(100, 20);
            this.tbxVehiculeCModif.TabIndex = 5;
            this.tbxVehiculeCModif.Tag = "C";
            // 
            // tbxVehiculeBModif
            // 
            this.tbxVehiculeBModif.Location = new System.Drawing.Point(141, 109);
            this.tbxVehiculeBModif.Name = "tbxVehiculeBModif";
            this.tbxVehiculeBModif.Size = new System.Drawing.Size(100, 20);
            this.tbxVehiculeBModif.TabIndex = 4;
            this.tbxVehiculeBModif.Tag = "B";
            // 
            // tbxPassagerModif
            // 
            this.tbxPassagerModif.Location = new System.Drawing.Point(141, 40);
            this.tbxPassagerModif.Name = "tbxPassagerModif";
            this.tbxPassagerModif.Size = new System.Drawing.Size(100, 20);
            this.tbxPassagerModif.TabIndex = 3;
            this.tbxPassagerModif.Tag = "A";
            // 
            // lblVehiculeC
            // 
            this.lblVehiculeC.AutoSize = true;
            this.lblVehiculeC.Location = new System.Drawing.Point(17, 181);
            this.lblVehiculeC.Name = "lblVehiculeC";
            this.lblVehiculeC.Size = new System.Drawing.Size(112, 13);
            this.lblVehiculeC.TabIndex = 2;
            this.lblVehiculeC.Text = "C (Véhicule Sup. 2m) :";
            // 
            // lblVehiculeB
            // 
            this.lblVehiculeB.AutoSize = true;
            this.lblVehiculeB.Location = new System.Drawing.Point(17, 109);
            this.lblVehiculeB.Name = "lblVehiculeB";
            this.lblVehiculeB.Size = new System.Drawing.Size(105, 13);
            this.lblVehiculeB.TabIndex = 1;
            this.lblVehiculeB.Text = "B (Véhicule Inf. 2m) :";
            // 
            // lblPassager
            // 
            this.lblPassager.AutoSize = true;
            this.lblPassager.Location = new System.Drawing.Point(17, 40);
            this.lblPassager.Name = "lblPassager";
            this.lblPassager.Size = new System.Drawing.Size(76, 13);
            this.lblPassager.TabIndex = 0;
            this.lblPassager.Text = "A (Passager) : ";
            // 
            // btnModifBateau
            // 
            this.btnModifBateau.Location = new System.Drawing.Point(68, 278);
            this.btnModifBateau.Name = "btnModifBateau";
            this.btnModifBateau.Size = new System.Drawing.Size(133, 23);
            this.btnModifBateau.TabIndex = 7;
            this.btnModifBateau.Text = "Modifier";
            this.btnModifBateau.UseVisualStyleBackColor = true;
            this.btnModifBateau.Click += new System.EventHandler(this.btnModifBateau_Click);
            // 
            // lblModifierBateau
            // 
            this.lblModifierBateau.AutoSize = true;
            this.lblModifierBateau.Location = new System.Drawing.Point(12, 39);
            this.lblModifierBateau.Name = "lblModifierBateau";
            this.lblModifierBateau.Size = new System.Drawing.Size(71, 13);
            this.lblModifierBateau.TabIndex = 6;
            this.lblModifierBateau.Text = "Nom bateau: ";
            // 
            // cmbbxBateauNom
            // 
            this.cmbbxBateauNom.BackColor = System.Drawing.SystemColors.Info;
            this.cmbbxBateauNom.FormattingEnabled = true;
            this.cmbbxBateauNom.Location = new System.Drawing.Point(89, 39);
            this.cmbbxBateauNom.Name = "cmbbxBateauNom";
            this.cmbbxBateauNom.Size = new System.Drawing.Size(121, 21);
            this.cmbbxBateauNom.TabIndex = 8;
            this.cmbbxBateauNom.SelectedIndexChanged += new System.EventHandler(this.cmbbxBateauNom_SelectedIndexChanged_1);
            // 
            // modifierBateau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmbbxBateauNom);
            this.Controls.Add(this.gbxModifierBateau);
            this.Controls.Add(this.btnModifBateau);
            this.Controls.Add(this.lblModifierBateau);
            this.Name = "modifierBateau";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.modifierBateau_Load);
            this.gbxModifierBateau.ResumeLayout(false);
            this.gbxModifierBateau.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxModifierBateau;
        private System.Windows.Forms.TextBox tbxVehiculeCModif;
        private System.Windows.Forms.TextBox tbxVehiculeBModif;
        private System.Windows.Forms.TextBox tbxPassagerModif;
        private System.Windows.Forms.Label lblVehiculeC;
        private System.Windows.Forms.Label lblVehiculeB;
        private System.Windows.Forms.Label lblPassager;
        private System.Windows.Forms.Button btnModifBateau;
        private System.Windows.Forms.Label lblModifierBateau;
        private System.Windows.Forms.ComboBox cmbbxBateauNom;
    }
}