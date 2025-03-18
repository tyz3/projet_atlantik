namespace Projet_atlantik
{
    partial class liaison
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
            this.cmbbxDepartLiaison = new System.Windows.Forms.ComboBox();
            this.cmbbxArriveeLiaison = new System.Windows.Forms.ComboBox();
            this.lstbxSecteursLiaison = new System.Windows.Forms.ListBox();
            this.tbxDistanceLiaison = new System.Windows.Forms.TextBox();
            this.lblDépartLiaison = new System.Windows.Forms.Label();
            this.lblDistanceLiaison = new System.Windows.Forms.Label();
            this.lblArriveeLiaison = new System.Windows.Forms.Label();
            this.lblLiaisonSecteurs = new System.Windows.Forms.Label();
            this.btnAjouterLiaison = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbbxDepartLiaison
            // 
            this.cmbbxDepartLiaison.FormattingEnabled = true;
            this.cmbbxDepartLiaison.Location = new System.Drawing.Point(32, 183);
            this.cmbbxDepartLiaison.Name = "cmbbxDepartLiaison";
            this.cmbbxDepartLiaison.Size = new System.Drawing.Size(121, 21);
            this.cmbbxDepartLiaison.TabIndex = 0;
            this.cmbbxDepartLiaison.SelectedIndexChanged += new System.EventHandler(this.cmbbxDepartLiaison_SelectedIndexChanged);
            // 
            // cmbbxArriveeLiaison
            // 
            this.cmbbxArriveeLiaison.FormattingEnabled = true;
            this.cmbbxArriveeLiaison.Location = new System.Drawing.Point(202, 183);
            this.cmbbxArriveeLiaison.Name = "cmbbxArriveeLiaison";
            this.cmbbxArriveeLiaison.Size = new System.Drawing.Size(121, 21);
            this.cmbbxArriveeLiaison.TabIndex = 1;
            this.cmbbxArriveeLiaison.SelectedIndexChanged += new System.EventHandler(this.cmbbxArriveeLiaison_SelectedIndexChanged);
            // 
            // lstbxSecteursLiaison
            // 
            this.lstbxSecteursLiaison.FormattingEnabled = true;
            this.lstbxSecteursLiaison.Location = new System.Drawing.Point(33, 45);
            this.lstbxSecteursLiaison.Name = "lstbxSecteursLiaison";
            this.lstbxSecteursLiaison.Size = new System.Drawing.Size(120, 108);
            this.lstbxSecteursLiaison.TabIndex = 2;
            this.lstbxSecteursLiaison.SelectedIndexChanged += new System.EventHandler(this.lstbxSecteursLiaison_SelectedIndexChanged);
            // 
            // tbxDistanceLiaison
            // 
            this.tbxDistanceLiaison.Location = new System.Drawing.Point(32, 273);
            this.tbxDistanceLiaison.Name = "tbxDistanceLiaison";
            this.tbxDistanceLiaison.Size = new System.Drawing.Size(100, 20);
            this.tbxDistanceLiaison.TabIndex = 3;
            // 
            // lblDépartLiaison
            // 
            this.lblDépartLiaison.AutoSize = true;
            this.lblDépartLiaison.Location = new System.Drawing.Point(30, 167);
            this.lblDépartLiaison.Name = "lblDépartLiaison";
            this.lblDépartLiaison.Size = new System.Drawing.Size(45, 13);
            this.lblDépartLiaison.TabIndex = 4;
            this.lblDépartLiaison.Text = "Départ: ";
            // 
            // lblDistanceLiaison
            // 
            this.lblDistanceLiaison.AutoSize = true;
            this.lblDistanceLiaison.Location = new System.Drawing.Point(30, 245);
            this.lblDistanceLiaison.Name = "lblDistanceLiaison";
            this.lblDistanceLiaison.Size = new System.Drawing.Size(55, 13);
            this.lblDistanceLiaison.TabIndex = 5;
            this.lblDistanceLiaison.Text = "Distance: ";
            // 
            // lblArriveeLiaison
            // 
            this.lblArriveeLiaison.AutoSize = true;
            this.lblArriveeLiaison.Location = new System.Drawing.Point(199, 167);
            this.lblArriveeLiaison.Name = "lblArriveeLiaison";
            this.lblArriveeLiaison.Size = new System.Drawing.Size(46, 13);
            this.lblArriveeLiaison.TabIndex = 6;
            this.lblArriveeLiaison.Text = "Arrivée: ";
            // 
            // lblLiaisonSecteurs
            // 
            this.lblLiaisonSecteurs.AutoSize = true;
            this.lblLiaisonSecteurs.Location = new System.Drawing.Point(30, 29);
            this.lblLiaisonSecteurs.Name = "lblLiaisonSecteurs";
            this.lblLiaisonSecteurs.Size = new System.Drawing.Size(52, 13);
            this.lblLiaisonSecteurs.TabIndex = 7;
            this.lblLiaisonSecteurs.Text = "Secteurs:";
            // 
            // btnAjouterLiaison
            // 
            this.btnAjouterLiaison.Location = new System.Drawing.Point(33, 324);
            this.btnAjouterLiaison.Name = "btnAjouterLiaison";
            this.btnAjouterLiaison.Size = new System.Drawing.Size(75, 23);
            this.btnAjouterLiaison.TabIndex = 8;
            this.btnAjouterLiaison.Text = "Ajouter";
            this.btnAjouterLiaison.UseVisualStyleBackColor = true;
            this.btnAjouterLiaison.Click += new System.EventHandler(this.btnAjouterLiaison_Click);
            // 
            // liaison
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAjouterLiaison);
            this.Controls.Add(this.lblLiaisonSecteurs);
            this.Controls.Add(this.lblArriveeLiaison);
            this.Controls.Add(this.lblDistanceLiaison);
            this.Controls.Add(this.lblDépartLiaison);
            this.Controls.Add(this.tbxDistanceLiaison);
            this.Controls.Add(this.lstbxSecteursLiaison);
            this.Controls.Add(this.cmbbxArriveeLiaison);
            this.Controls.Add(this.cmbbxDepartLiaison);
            this.Name = "liaison";
            this.Text = "Arrivée: ";
            this.Load += new System.EventHandler(this.liaison_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbbxDepartLiaison;
        private System.Windows.Forms.ComboBox cmbbxArriveeLiaison;
        private System.Windows.Forms.ListBox lstbxSecteursLiaison;
        private System.Windows.Forms.TextBox tbxDistanceLiaison;
        private System.Windows.Forms.Label lblDépartLiaison;
        private System.Windows.Forms.Label lblDistanceLiaison;
        private System.Windows.Forms.Label lblArriveeLiaison;
        private System.Windows.Forms.Label lblLiaisonSecteurs;
        private System.Windows.Forms.Button btnAjouterLiaison;
    }
}