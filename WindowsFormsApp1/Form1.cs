using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void hesaplaButton_Click(object sender, EventArgs e)
        {
            var KSLabel = Convert.ToInt32(textBox1.Text);
            var ASLabel = Convert.ToInt32(textBox2.Text);
            var ODLabel = Convert.ToInt32(textBox3.Text);
            var YSLabel = Convert.ToInt32(textBox4.Text);

            var ortalama = KSLabel * 0.1 + ODLabel * 0.1 + ASLabel * 0.3 + YSLabel * 0.5;
            ortLabel.Text = ortalama.ToString();

            if (ortalama < 40)
            {
                harfnotLabel.Text = "FF";
            }
            else if (ortalama < 50)
            {
                harfnotLabel.Text = "DD";
            }
            else if (ortalama < 60)
            {
                harfnotLabel.Text = "DC";
            }
            else if (ortalama < 65)
            {
                harfnotLabel.Text = "CC";
            }
            else if (ortalama < 70)
            {
                harfnotLabel.Text = "CB";
            }
            else if (ortalama < 75)
            {
                harfnotLabel.Text = "BB";
            }
            else if (ortalama < 85)
            {
                harfnotLabel.Text = "BA";
            }
            else
            {
                harfnotLabel.Text = "AA";
            }


        }

       
    }
}
