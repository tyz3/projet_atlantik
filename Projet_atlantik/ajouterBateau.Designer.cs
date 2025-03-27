namespace Projet_atlantik
{
    partial class ajouterBateau
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
            this.gbxAjoutBateau = new System.Windows.Forms.GroupBox();
            this.tbxAjoutBateau = new System.Windows.Forms.TextBox();
            this.lblAjouterBateau = new System.Windows.Forms.Label();
            this.btnAjoutBateau = new System.Windows.Forms.Button();
            this.lblPassager = new System.Windows.Forms.Label();
            this.lblVehiculeB = new System.Windows.Forms.Label();
            this.lblVehiculeC = new System.Windows.Forms.Label();
            this.tbxPassager = new System.Windows.Forms.TextBox();
            this.tbxVehiculeB = new System.Windows.Forms.TextBox();
            this.tbxVehiculeC = new System.Windows.Forms.TextBox();
            this.gbxAjoutBateau.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxAjoutBateau
            // 
            this.gbxAjoutBateau.BackColor = System.Drawing.SystemColors.Info;
            this.gbxAjoutBateau.Controls.Add(this.tbxVehiculeC);
            this.gbxAjoutBateau.Controls.Add(this.tbxVehiculeB);
            this.gbxAjoutBateau.Controls.Add(this.tbxPassager);
            this.gbxAjoutBateau.Controls.Add(this.lblVehiculeC);
            this.gbxAjoutBateau.Controls.Add(this.lblVehiculeB);
            this.gbxAjoutBateau.Controls.Add(this.lblPassager);
            this.gbxAjoutBateau.Location = new System.Drawing.Point(229, 44);
            this.gbxAjoutBateau.Name = "gbxAjoutBateau";
            this.gbxAjoutBateau.Size = new System.Drawing.Size(289, 262);
            this.gbxAjoutBateau.TabIndex = 0;
            this.gbxAjoutBateau.TabStop = false;
            this.gbxAjoutBateau.Text = "Capacités Maximales";
            // 
            // tbxAjoutBateau
            // 
            this.tbxAjoutBateau.BackColor = System.Drawing.SystemColors.Info;
            this.tbxAjoutBateau.Location = new System.Drawing.Point(90, 41);
            this.tbxAjoutBateau.Name = "tbxAjoutBateau";
            this.tbxAjoutBateau.Size = new System.Drawing.Size(100, 20);
            this.tbxAjoutBateau.TabIndex = 1;
            // 
            // lblAjouterBateau
            // 
            this.lblAjouterBateau.AutoSize = true;
            this.lblAjouterBateau.Location = new System.Drawing.Point(13, 44);
            this.lblAjouterBateau.Name = "lblAjouterBateau";
            this.lblAjouterBateau.Size = new System.Drawing.Size(71, 13);
            this.lblAjouterBateau.TabIndex = 2;
            this.lblAjouterBateau.Text = "Nom bateau: ";
            // 
            // btnAjoutBateau
            // 
            this.btnAjoutBateau.Location = new System.Drawing.Point(69, 283);
            this.btnAjoutBateau.Name = "btnAjoutBateau";
            this.btnAjoutBateau.Size = new System.Drawing.Size(133, 23);
            this.btnAjoutBateau.TabIndex = 3;
            this.btnAjoutBateau.Text = "Ajouter";
            this.btnAjoutBateau.UseVisualStyleBackColor = true;
            this.btnAjoutBateau.Click += new System.EventHandler(this.btnAjoutBateau_Click);
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
            // lblVehiculeB
            // 
            this.lblVehiculeB.AutoSize = true;
            this.lblVehiculeB.Location = new System.Drawing.Point(17, 109);
            this.lblVehiculeB.Name = "lblVehiculeB";
            this.lblVehiculeB.Size = new System.Drawing.Size(105, 13);
            this.lblVehiculeB.TabIndex = 1;
            this.lblVehiculeB.Text = "B (Véhicule Inf. 2m) :";
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
            // tbxPassager
            // 
            this.tbxPassager.Location = new System.Drawing.Point(141, 40);
            this.tbxPassager.Name = "tbxPassager";
            this.tbxPassager.Size = new System.Drawing.Size(100, 20);
            this.tbxPassager.TabIndex = 3;
            // 
            // tbxVehiculeB
            // 
            this.tbxVehiculeB.Location = new System.Drawing.Point(141, 109);
            this.tbxVehiculeB.Name = "tbxVehiculeB";
            this.tbxVehiculeB.Size = new System.Drawing.Size(100, 20);
            this.tbxVehiculeB.TabIndex = 4;
            // 
            // tbxVehiculeC
            // 
            this.tbxVehiculeC.Location = new System.Drawing.Point(141, 181);
            this.tbxVehiculeC.Name = "tbxVehiculeC";
            this.tbxVehiculeC.Size = new System.Drawing.Size(100, 20);
            this.tbxVehiculeC.TabIndex = 5;
            // 
            // ajouterBateau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 478);
            this.Controls.Add(this.btnAjoutBateau);
            this.Controls.Add(this.lblAjouterBateau);
            this.Controls.Add(this.tbxAjoutBateau);
            this.Controls.Add(this.gbxAjoutBateau);
            this.Name = "ajouterBateau";
            this.Text = "ajouterBateau";
            this.gbxAjoutBateau.ResumeLayout(false);
            this.gbxAjoutBateau.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxAjoutBateau;
        private System.Windows.Forms.TextBox tbxAjoutBateau;
        private System.Windows.Forms.Label lblAjouterBateau;
        private System.Windows.Forms.Button btnAjoutBateau;
        private System.Windows.Forms.TextBox tbxVehiculeB;
        private System.Windows.Forms.TextBox tbxPassager;
        private System.Windows.Forms.Label lblVehiculeC;
        private System.Windows.Forms.Label lblVehiculeB;
        private System.Windows.Forms.Label lblPassager;
        private System.Windows.Forms.TextBox tbxVehiculeC;
    }
}