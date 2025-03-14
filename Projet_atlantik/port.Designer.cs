namespace Projet_atlantik
{
    partial class port
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
            this.txtNomPort = new System.Windows.Forms.Label();
            this.btnAjoutPort = new System.Windows.Forms.Button();
            this.tbxPort = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtNomPort
            // 
            this.txtNomPort.AutoSize = true;
            this.txtNomPort.Location = new System.Drawing.Point(3, 9);
            this.txtNomPort.Name = "txtNomPort";
            this.txtNomPort.Size = new System.Drawing.Size(69, 13);
            this.txtNomPort.TabIndex = 0;
            this.txtNomPort.Text = "Nom du Port:";
            // 
            // btnAjoutPort
            // 
            this.btnAjoutPort.Location = new System.Drawing.Point(6, 74);
            this.btnAjoutPort.Name = "btnAjoutPort";
            this.btnAjoutPort.Size = new System.Drawing.Size(75, 23);
            this.btnAjoutPort.TabIndex = 1;
            this.btnAjoutPort.Text = "Ajouter";
            this.btnAjoutPort.UseVisualStyleBackColor = true;
            this.btnAjoutPort.Click += new System.EventHandler(this.btnAjoutPort_Click);
            // 
            // tbxPort
            // 
            this.tbxPort.Location = new System.Drawing.Point(6, 38);
            this.tbxPort.Name = "tbxPort";
            this.tbxPort.Size = new System.Drawing.Size(100, 20);
            this.tbxPort.TabIndex = 2;
            this.tbxPort.TextChanged += new System.EventHandler(this.tbxPort_TextChanged);
            // 
            // port
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbxPort);
            this.Controls.Add(this.btnAjoutPort);
            this.Controls.Add(this.txtNomPort);
            this.Name = "port";
            this.Text = "port";
            this.Load += new System.EventHandler(this.port_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtNomPort;
        private System.Windows.Forms.Button btnAjoutPort;
        private System.Windows.Forms.TextBox tbxPort;
    }
}