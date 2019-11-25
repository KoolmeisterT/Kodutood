using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Koolmeister_Tiina_Matemaatika
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void arvestada_Click(object sender, EventArgs e)
        {
            try
            {
                double arv1 = Convert.ToDouble(nr1.Text);
                double arv2 = Convert.ToDouble(nr2.Text);

                if(liitmine.Checked)
                {
                    double tulemus = arv1 + arv2;
                    vastus.Text = arv1 + " + " + arv2 + " = " + tulemus.ToString();
                }
                if(lahutamine.Checked)
                {
                    double tulemus = arv1 - arv2;
                    vastus.Text = arv1 + " - " + arv2 + " = " + tulemus.ToString();
                }
                if(korrutamine.Checked)
                {
                    double tulemus = arv1 * arv2;
                    vastus.Text = arv1 + " * " + arv2 + " = " + tulemus.ToString();
                }
                if(jagamine.Checked)
                {
                    if (arv2 == 0)
                    {
                        MessageBox.Show("Nulliga ei saa jagada! Sisesta uus arv.", "Viga!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        double tulemus = arv1 / arv2;
                        vastus.Text = arv1 + " / " + arv2 + " = " + tulemus.ToString();
                    }
                }
                else if (!liitmine.Checked && !lahutamine.Checked && !korrutamine.Checked && !jagamine.Checked)
                {
                    MessageBox.Show("Palun vali tehe!", "Viga!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                if (vastus.Text == "")
                {
                    MessageBox.Show("Palun sisestada arv/arvud õigesti", "Viga!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    vastus.Focus();
                }
            }
        }
    }
}
