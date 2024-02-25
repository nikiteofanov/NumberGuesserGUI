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
    public partial class levelMedium : Form
    {

        private int randomNumber;
        private int attempts = 5;

        public levelMedium()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            GenerateRandomNumber();
            textBox2.Text = "5";
        }
        private void GenerateRandomNumber()
        {
            Random rnd = new Random();
            randomNumber = rnd.Next(0, 101);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string num = textBox1.Text;



            if (int.TryParse(num, out int numINT))
            {

                if (numINT > randomNumber)
                {
                    textBox3.Text = "Go lower!";
                }
                else if (numINT < randomNumber)
                {
                    textBox3.Text = "Go higher!";
                }
                else
                {
                    label7.Show();
                    textBox3.Text = "";
                    return;
                }

                attempts--;
                textBox2.Text = Convert.ToString(attempts);

                if (attempts == 0)
                {
                    label6.Show();
                    label8.Text = $"The number was {randomNumber}.";
                    return;
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid number.");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            startMenu form1 = new startMenu();
            form1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
