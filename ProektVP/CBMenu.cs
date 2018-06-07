using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProektVP
{
    public partial class CBMenu : Form
    {
        public CBMenu()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string rules = "1. Click the ball before it falls into the water." +
                "\n" + "2. Each click is one point." +
                "\n\n            Try to reach Level 7. GOOD LUCK!";
            MessageBox.Show(rules, "Rules of the game", MessageBoxButtons.OK);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            CBGame cbGame = new CBGame();
            cbGame.ShowDialog();
        }
    }
}
