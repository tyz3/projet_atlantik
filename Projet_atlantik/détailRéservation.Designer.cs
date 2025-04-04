namespace ProjetAtlantik
{
    partial class détailRéservation
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
            this.cmbbxClient = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lvRéservation = new System.Windows.Forms.ListView();
            this.gbxRéservation = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // cmbbxClient
            // 
            this.cmbbxClient.FormattingEnabled = true;
            this.cmbbxClient.Location = new System.Drawing.Point(115, 27);
            this.cmbbxClient.Name = "cmbbxClient";
            this.cmbbxClient.Size = new System.Drawing.Size(121, 21);
            this.cmbbxClient.TabIndex = 0;
            this.cmbbxClient.SelectedIndexChanged += new System.EventHandler(this.cmbbxClient_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nom, Prénom";
            // 
            // lvRéservation
            // 
            this.lvRéservation.HideSelection = false;
            this.lvRéservation.Location = new System.Drawing.Point(288, 27);
            this.lvRéservation.Name = "lvRéservation";
            this.lvRéservation.Size = new System.Drawing.Size(479, 165);
            this.lvRéservation.TabIndex = 2;
            this.lvRéservation.UseCompatibleStateImageBehavior = false;
            this.lvRéservation.SelectedIndexChanged += new System.EventHandler(this.lvRéservation_SelectedIndexChanged);
            // 
            // gbxRéservation
            // 
            this.gbxRéservation.ForeColor = System.Drawing.SystemColors.ControlText;
            this.gbxRéservation.Location = new System.Drawing.Point(362, 216);
            this.gbxRéservation.Name = "gbxRéservation";
            this.gbxRéservation.Size = new System.Drawing.Size(335, 222);
            this.gbxRéservation.TabIndex = 3;
            this.gbxRéservation.TabStop = false;
            this.gbxRéservation.Text = "Réservation";
            // 
            // détailRéservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gbxRéservation);
            this.Controls.Add(this.lvRéservation);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbbxClient);
            this.Name = "détailRéservation";
            this.Text = "détailRéservation";
            this.Load += new System.EventHandler(this.détailRéservation_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbbxClient;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lvRéservation;
        private System.Windows.Forms.GroupBox gbxRéservation;
    }
}