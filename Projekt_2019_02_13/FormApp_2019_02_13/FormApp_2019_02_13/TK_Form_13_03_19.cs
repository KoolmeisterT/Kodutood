using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO; //selle lisasin nüüd hiljem juurde

namespace FormApp_2019_02_13
{
    public partial class TK_Form_13_03_19 : Form
    {
        string[] mas = new string[10000]; //Selle kirjutame siis, kui ridade arv on lisatud. (4)
        int mas_suurus = 0; //massiivi suurus

        public TK_Form_13_03_19()
        {
            InitializeComponent();
        }


        private void TK_Open_Click(object sender, EventArgs e)
        {
            TK_OpenDialog.Filter = "Tekstifailid|*.txt;*.cs;*.log|Kõik failid|*.*"; //* on suvaline täht
            TK_OpenDialog.FileName = "";
            TK_OpenDialog.ShowDialog();
            string fn = TK_OpenDialog.FileName;
            TK_label.Text = fn;
            if (fn == "") return; //Kui fn on tühi

            DateTime t1, t2; //Need lisasin siis hiljem juurde, kui tegin uue aja labeli
            t1 = DateTime.Now;

            StreamReader sr = new StreamReader(fn); //kasutame while, kuna me ei tea, mitu rida failis on.
            //Kontrollime tsükli alguses, kuna fail võib ka tühi olla. Kasutame while, mitte while do (sellega kontrollitakse lõpus).
            TK_list1.Items.Clear();
            string tekst;
            mas_suurus = 0; //(4)
            while((tekst=sr.ReadLine()) != null)
            {
                TK_list1.Items.Add(tekst);
                if (mas_suurus < 9999) mas[mas_suurus++] = tekst; //(4) Et ei ületaks 10000 rida, siis oleks liiga palju, mida sinna panna.
            }
            sr.Close();

            t2 = DateTime.Now; //Need ka tegin hiljem, kui time labeli panin
            TimeSpan t3 = t2 - t1;
            TK_lbe_time.Text = (t3.Seconds * 1000 + t3.Milliseconds).ToString()+" ms";

            TK_lbl_arv.Text = TK_list1.Items.Count.ToString() + " rida " + mas_suurus.ToString(); //viimane osa (4)
        }

        private void TK_lisada_Click(object sender, EventArgs e) //(5)
        {
            string t = TK_txt1.Text.Trim();
            if (t.Length == 0) return;
            int valitud = TK_list1.SelectedIndex;
            if (valitud < 0)
                TK_list1.Items.Add(t);
            else
                TK_list1.Items.Insert(valitud, t);
            TK_list1.SelectedIndex = -1;
            TK_txt1.Text = "";
            TK_txt1.Focus();
        }

        private void TK_del1_Click(object sender, EventArgs e) //(5)
        {
            int valitud = TK_list1.SelectedIndex;
            if (valitud < 0)
            {
                MessageBox.Show("Valik puudub");
                return;
            }
            string t = "Kas soovite valitud nime kustutada?\n\n" + TK_list1.Items[valitud];
            DialogResult vastus = MessageBox.Show(t, "Hoiatus", MessageBoxButtons.YesNo);
            if (vastus == DialogResult.Yes)
                TK_list1.Items.RemoveAt(valitud);
            else
                TK_list1.SelectedIndex = -1;
        }

        private void TK_muuda_Click(object sender, EventArgs e) //(5)
        {
            int valitud = TK_list1.SelectedIndex;
            if (valitud < 0)
            {
                MessageBox.Show("Valik puudub");
                return;
            }
            string t = TK_txt1.Text.Trim();
            if (t.Length == 0) return;
            TK_list1.Items[valitud] = t;
            TK_list1.SelectedIndex = -1;
        }

        private void TK_list1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int valitud = TK_list1.SelectedIndex;
            if (valitud < 0) return;
            TK_txt1.Text = TK_list1.Items[valitud].ToString(); //Kui valin rea, mida tahan muuta või kustutada, ilmub see tekstiaknassse.
        }

        private void TK_Save_Click(object sender, EventArgs e) //(6)
        {
            TK_save_dialog.Filter = "Tekstifailid|*.txt;*.cs;*.log|Kõik failid|*.*";
            TK_save_dialog.FileName = "";
            TK_save_dialog.ShowDialog();
            string fn = TK_save_dialog.FileName;
            TK_label.Text = fn;
            if (fn == "") return;

            DateTime t1, t2;
            t1 = DateTime.Now;

            StreamWriter sw = new StreamWriter(fn);
            for(int i=0; i<TK_list1.Items.Count; i++)
            {
                sw.WriteLine(TK_list1.Items[i].ToString());
            }
            sw.Close();

            t2 = DateTime.Now;
            TimeSpan t3 = t2 - t1;
            TK_lbe_time.Text = (t3.Seconds * 1000 + t3.Milliseconds).ToString() + " ms";

            TK_lbl_arv.Text = TK_list1.Items.Count.ToString() + " rida " + mas_suurus.ToString();
        }

        private void TK_btn_juhuarvud_Click(object sender, EventArgs e) //(7) Juhuarvude generaator
        {
            int minv = 1;
            int maxv = 1000;
            int arv = 100; // tahame saada 100 juhuarvu vahemikus 1-1000
            //Juhuarvude generaatorit on vaja.
            Random rn = new Random();
            TK_list1.Items.Clear();
            for(int i=0; i<arv; i++)
            {
                int juhuarv = rn.Next(minv, maxv);
                int j = 0; //kui sulgudesse midagi ei pane, siis annab arvu 0-1ni (ujukomaga). Kui paneme sinna arvu, siis genereerib arvu 0-n-1 ehk 999. Kui 2 arvu paneme, siis genereeib nende arvude vahemikus.
                for(j=0; j<TK_list1.Items.Count; j++) //(8) Sorteerimine oleks ok, et 12 on ikka alguses, mitte enne 122.
                {
                    if (juhuarv < (int)TK_list1.Items[j]) break;                 
                }
               
                TK_list1.Items.Insert(j, juhuarv); //enne oli siin add. Aga tahan järjekorda panna, siis panin insert
            }
        }

        private void TK_btn_juhuarv1_Click(object sender, EventArgs e) //(9) Et juhuarvud ei korduks, siis teeme järgmise nupu "Juhuarv 1". Kordusteta
        {
            int minv = 1;
            int maxv = 1000;
            int arv = 500;
            Random rn = new Random();
            TK_list1.Items.Clear();
            for (int i = 0; i < arv; i++)
            {
                int juhuarv = rn.Next(minv, maxv);
                int j = 0;
                for (j = 0; j < TK_list1.Items.Count; j++)
                {
                    if (juhuarv <= (int)TK_list1.Items[j]) break;
                }
                if (j == TK_list1.Items.Count)
                    TK_list1.Items.Add(juhuarv);
                else if (juhuarv < (int)TK_list1.Items[j])
                {
                    TK_list1.Items.Insert(j, juhuarv);
                }
            }
        }
    }
}
