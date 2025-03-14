namespace ProjetAtlantik
{
    partial class Form1
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
            this.tbxSecteur = new System.Windows.Forms.TextBox();
            this.btnSecteur = new System.Windows.Forms.Button();
            this.nomSecteur = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbxSecteur
            // 
            this.tbxSecteur.BackColor = System.Drawing.SystemColors.Info;
            this.tbxSecteur.Location = new System.Drawing.Point(12, 25);
            this.tbxSecteur.Name = "tbxSecteur";
            this.tbxSecteur.Size = new System.Drawing.Size(100, 20);
            this.tbxSecteur.TabIndex = 0;
            this.tbxSecteur.TextChanged += new System.EventHandler(this.tbxSecteur_TextChanged);
            // 
            // btnSecteur
            // 
            this.btnSecteur.Location = new System.Drawing.Point(15, 51);
            this.btnSecteur.Name = "btnSecteur";
            this.btnSecteur.Size = new System.Drawing.Size(75, 23);
            this.btnSecteur.TabIndex = 1;
            this.btnSecteur.Text = "Ajouter";
            this.btnSecteur.UseVisualStyleBackColor = true;
            this.btnSecteur.Click += new System.EventHandler(this.btnSecteur_Click);
            // 
            // nomSecteur
            // 
            this.nomSecteur.AutoSize = true;
            this.nomSecteur.Location = new System.Drawing.Point(12, 9);
            this.nomSecteur.Name = "nomSecteur";
            this.nomSecteur.Size = new System.Drawing.Size(70, 13);
            this.nomSecteur.TabIndex = 2;
            this.nomSecteur.Text = "Nom secteur:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.nomSecteur);
            this.Controls.Add(this.btnSecteur);
            this.Controls.Add(this.tbxSecteur);
            this.Name = "Form1";
            this.Text = "git ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxSecteur;
        private System.Windows.Forms.Button btnSecteur;
        private System.Windows.Forms.Label nomSecteur;
    }
}

