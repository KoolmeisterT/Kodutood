using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace AndmeteSisestusVorm
{
    public partial class Form1 : Form
    {
        string[] mas = new string[10000];
        int mas_suurus = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void lisa_Click(object sender, EventArgs e)
        {
            if (isikukood.Text.Length == 11)
            {
                XX_Nimekiri.Items.Add(nimi.Text + "_" + isikukood.Text);
            }
            else if (nimi.Text == "")
            {
                MessageBox.Show("Sisesta nimi");
                return;
            }
            else
            {
                MessageBox.Show("Isikukood peab sisaldama 11 numbrit!");
                return;
            }
            
            isikukood.Text = "";
            isikukood.Focus();
            nimi.Text = "";
            nimi.Focus();
            isikukood.Focus();
        }

        private void uuenda_Click(object sender, EventArgs e)
        {
            int valitud = XX_Nimekiri.SelectedIndex;
            if (valitud < 0)
            {
                MessageBox.Show("Valik puudub");
                return;
            }
            
            else if (isikukood.Text.Length != 11)
            {
                MessageBox.Show("Isikukood peab sisaldama 11 numbrit!");
                return;
            }

            else if (isikukood.Text == "")
            {
                MessageBox.Show("Sisesta nimi");
                return;
            }

            XX_Nimekiri.Items[valitud] = nimi.Text + "_" + isikukood.Text;
            XX_Nimekiri.SelectedIndex = -1;

            isikukood.Text = "";
            isikukood.Focus();
            nimi.Text = "";
            nimi.Focus();
            isikukood.Focus();
        }

        private void kustuta_Click(object sender, EventArgs e)
        {
            int valitud = XX_Nimekiri.SelectedIndex;
            if (valitud < 0)
            {
                MessageBox.Show("Valik puudub");
                return;
            }
            string t = "Kas soovite valitud kirje kustutada?\n\n" + XX_Nimekiri.Items[valitud];
            DialogResult vastus = MessageBox.Show(t, "Hoiatus", MessageBoxButtons.YesNo);
            if (vastus == DialogResult.Yes)
                XX_Nimekiri.Items.RemoveAt(valitud);
            else
                XX_Nimekiri.SelectedIndex = -1;

            isikukood.Focus();
        }

        private void vaata_Click(object sender, EventArgs e)
        {
            openFileDialog.Filter = "Tekstifailid|*.txt;*.cs;*.log|Kõik failid|*.*";
            openFileDialog.FileName = "";
            openFileDialog.ShowDialog();
            string fn = openFileDialog.FileName;
            if (fn == "") return;

            StreamReader sr = new StreamReader(fn);
            XX_Nimekiri.Items.Clear();
            string tekst;
            mas_suurus = 0;
            while ((tekst = sr.ReadLine()) != null)
            {
                XX_Nimekiri.Items.Add(tekst);
                if (mas_suurus < 9999) mas[mas_suurus++] = tekst;
            }
            sr.Close();

            isikukood.Focus();
        }

        private void TK_save_Click(object sender, EventArgs e)
        {
            saveFileDialog.Filter = "Tekstifailid|*.txt;*.cs;*.log|Kõik failid|*.*";
            saveFileDialog.FileName = "";
            saveFileDialog.ShowDialog();
            string fn = saveFileDialog.FileName;
            if (fn == "") return;

            StreamWriter sw = new StreamWriter(fn);
            for (int i = 0; i < XX_Nimekiri.Items.Count; i++)
            {
                sw.WriteLine(XX_Nimekiri.Items[i].ToString());
            }
            sw.Close();

            isikukood.Focus();
        }

        private void XX_Nimekiri_SelectedIndexChanged(object sender, EventArgs e)
        {
            string p = XX_Nimekiri.Text.Trim();
            if (p.Length == 0) return;
            pere2.Text = Convert.ToString(p).Substring(0, 2);
        }
    }
}
