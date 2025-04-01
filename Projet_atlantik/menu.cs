using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projet_atlantik
{
    public partial class menu : Form
    {


        public menu()
        {
            InitializeComponent();

 
            MenuStrip menu = new MenuStrip();


            ToolStripMenuItem ajouter = new ToolStripMenuItem("Ajouter");
            ToolStripMenuItem modifier = new ToolStripMenuItem("Modifier");
            ToolStripMenuItem afficher = new ToolStripMenuItem("Afficher");
            ToolStripMenuItem apropos = new ToolStripMenuItem("A Propos");

     

            menu.Items.Add(ajouter);
            menu.Items.Add(modifier);
            menu.Items.Add(afficher);
            menu.Items.Add(apropos);

            this.MainMenuStrip = menu;
            this.Controls.Add(menu);

            
        }
        private void ImageExampleForm_Paint(object sender, PaintEventArgs e)
        {
            Image newImage = Image.FromFile("image_menu.jpg");

            Point ulCorner = new Point(100, 100);

            e.Graphics.DrawImage(newImage, ulCorner);
        }

    }
}
