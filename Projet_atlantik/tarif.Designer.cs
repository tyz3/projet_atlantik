namespace Projet_atlantik
{
    partial class tarif
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
            this.gbxTarif = new System.Windows.Forms.GroupBox();
            this.lstbxTarif = new System.Windows.Forms.ListBox();
            this.cmbbxTarifLiaison = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAjouterTarif = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbbxTarifPeriode = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // gbxTarif
            // 
            this.gbxTarif.BackColor = System.Drawing.SystemColors.Info;
            this.gbxTarif.Location = new System.Drawing.Point(339, 21);
            this.gbxTarif.Name = "gbxTarif";
            this.gbxTarif.Size = new System.Drawing.Size(231, 349);
            this.gbxTarif.TabIndex = 0;
            this.gbxTarif.TabStop = false;
            this.gbxTarif.Text = "Tarifs par Catégorie-Type";
            // 
            // lstbxTarif
            // 
            this.lstbxTarif.BackColor = System.Drawing.SystemColors.Info;
            this.lstbxTarif.FormattingEnabled = true;
            this.lstbxTarif.Location = new System.Drawing.Point(42, 21);
            this.lstbxTarif.Name = "lstbxTarif";
            this.lstbxTarif.Size = new System.Drawing.Size(191, 212);
            this.lstbxTarif.TabIndex = 1;
            // 
            // cmbbxTarifLiaison
            // 
            this.cmbbxTarifLiaison.BackColor = System.Drawing.SystemColors.Info;
            this.cmbbxTarifLiaison.FormattingEnabled = true;
            this.cmbbxTarifLiaison.Location = new System.Drawing.Point(42, 281);
            this.cmbbxTarifLiaison.Name = "cmbbxTarifLiaison";
            this.cmbbxTarifLiaison.Size = new System.Drawing.Size(191, 21);
            this.cmbbxTarifLiaison.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 255);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Liaison: ";
            // 
            // btnAjouterTarif
            // 
            this.btnAjouterTarif.Location = new System.Drawing.Point(407, 386);
            this.btnAjouterTarif.Name = "btnAjouterTarif";
            this.btnAjouterTarif.Size = new System.Drawing.Size(75, 23);
            this.btnAjouterTarif.TabIndex = 4;
            this.btnAjouterTarif.Text = "Ajouter";
            this.btnAjouterTarif.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 357);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Période:";
            // 
            // cmbbxTarifPeriode
            // 
            this.cmbbxTarifPeriode.BackColor = System.Drawing.SystemColors.Info;
            this.cmbbxTarifPeriode.FormattingEnabled = true;
            this.cmbbxTarifPeriode.Location = new System.Drawing.Point(42, 386);
            this.cmbbxTarifPeriode.Name = "cmbbxTarifPeriode";
            this.cmbbxTarifPeriode.Size = new System.Drawing.Size(191, 21);
            this.cmbbxTarifPeriode.TabIndex = 6;
            // 
            // tarif
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmbbxTarifPeriode);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAjouterTarif);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbbxTarifLiaison);
            this.Controls.Add(this.lstbxTarif);
            this.Controls.Add(this.gbxTarif);
            this.Name = "tarif";
            this.Text = "tarif";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxTarif;
        private System.Windows.Forms.ListBox lstbxTarif;
        private System.Windows.Forms.ComboBox cmbbxTarifLiaison;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAjouterTarif;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbbxTarifPeriode;
    }
}