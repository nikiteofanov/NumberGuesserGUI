using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NumberGuesserGUI
{
    public partial class startMenu : Form
    {
        public startMenu()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void startGame_Click(object sender, EventArgs e)
        {
            levelEasy form2 = new levelEasy();
            levelMedium form3 = new levelMedium();
            levelHard form4 = new levelHard();

            if (levelEasy.Checked)
            {
                form2.Show();
                this.Hide();
            }
            else if (levelMedium.Checked)
            {
                form3.Show();
                this.Hide();
            }
            else if (levelHard.Checked)
            {
                form4.Show();
                this.Hide();
            }

        }
    }
}
