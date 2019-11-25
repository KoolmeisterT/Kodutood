using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Koolmeister_Tiina_Kodutoo2
{
    public partial class Form1 : Form
    {
        int pall1, pall2, pall3, pall4;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            mangi1.Enabled = false;
            mangi2.Enabled = false;
            uus_mang.Enabled = true;
        }

        private void uus_mang_Click(object sender, EventArgs e)
        {
            punktid1.Text = "";
            punktid2.Text = "";
            nr1.Text = "";
            nr2.Text = "";
            nr3.Text = "";
            nr4.Text = "";
            tulemus.Text = "";
            mangi1.Enabled = true;
            mangi2.Enabled = false;
        }

        private void mangi1_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            pall1 = rand.Next(1, 7);
            pall2 = rand.Next(1, 7);
            nr1.Text = Convert.ToString(pall1);
            nr2.Text = Convert.ToString(pall2);
            punktid1.Text = Convert.ToString(pall1 + pall2);
            mangi1.Enabled = false;
            mangi2.Enabled = true;
        }

        private void mangi2_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            pall3 = rand.Next(1, 7);
            pall4 = rand.Next(1, 7);
            nr3.Text = Convert.ToString(pall3);
            nr4.Text = Convert.ToString(pall4);
            punktid2.Text = Convert.ToString(pall3 + pall4);
            mangi1.Enabled = false;
            mangi2.Enabled = false;
            uus_mang.Enabled = true;

            
            int p1 = Convert.ToInt32(punktid1.Text);
            int p2 = Convert.ToInt32(punktid2.Text);

            if (p1 > p2)
            {
                tulemus.Text = "Võitis Juku";
            }
            else if (p2 > p1)
            {
                tulemus.Text = "Võitis Peeter";
            }
            else
            {
                tulemus.Text = "Viik";
            }
        }
    }
}
