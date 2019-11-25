using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormApp_2019_02_13
{
    public partial class Form1 : Form
    {
        Form F1 = new TK_Form_13_03_19();

        public Form1()
        {
            InitializeComponent();
            TK_timer.Interval = 1000;
            TK_timer.Enabled = false; //alguses seisab
            TK_rb3.Checked = true;
        }

        private void TK_btn_13_03_19_Click(object sender, EventArgs e)
        {
            if (F1.Visible==false) F1 = new TK_Form_13_03_19(); //uus form, mille poole suunab, avaneb nüüd üks kord.
            F1.Visible = true;
            F1.Activate();
        }

        private void TK_timer_Tick(object sender, EventArgs e)
        {
            if (TK_rb1.Checked) //kui raadio nupp on vajutatud,
                TK_lbl_Time.Text = DateTime.Now.ToString(); //siis näitab nii tektsi.
            else if (TK_rb2.Checked) //kui teist nuppu vajutada, siis näitab pikka kuupäeva
                TK_lbl_Time.Text = DateTime.Now.ToLongTimeString();
            else
                TK_lbl_Time.Text = ""; //Teistel juhtudel (stop ja ilma vajutamata, on tühi " "
        }

        private void TK_rb1_CheckedChanged(object sender, EventArgs e)
        {
            TK_timer.Enabled = true;
        }

        private void TK_rb2_CheckedChanged(object sender, EventArgs e)
        {
            TK_timer.Enabled = true;
        }

        private void TK_rb3_CheckedChanged(object sender, EventArgs e)
        {
            TK_timer.Enabled = false;
            TK_lbl_Time.Text = "";
        }

        private void TK_txt1_TextChanged(object sender, EventArgs e) //tekstiakna sisu muutmine
        {
            string tekst = TK_txt1.Text;
            if (TK_check1.Checked)tekst = tekst.ToUpper(); //tähed teeb väikeseks
            else tekst = tekst.ToLower();
            TK_lbl1.Text = tekst;
        }

        private void TK_check1_CheckedChanged(object sender, EventArgs e)
        {
            if (TK_check1.Checked) TK_check1.Text = "Suured Tähed";
            else TK_check1.Text = "Väikesed Tähed";
            TK_txt1_TextChanged(null, null); //tühjad parameetrid, kuna selles funktsioonis ei ole parameetreid, aga siis tuleb panna "null". //siis ta töötab ka siis, kui tekst kirjutatud
            //tik pandud ja võtan ära. Kohe muudab ära. (ilma teksti uuesti kirjutamata)
        }

        private void TK_lisada_Click(object sender, EventArgs e)
        {
            string t = TK_txt2.Text.Trim(); //trim eemaldab tekstis ees ja tagapool tühikuid. Start(eest poolt), End(tagant poolt)
            if (t.Length == 0) return; //loeme tekstiakna sisu ja trimmime seda, Tagastame
            int valitud = TK_list1.SelectedIndex;
            if (valitud < 0) //kui ei ole valikut tehtud on, siis lisad selle kas lõppu, või kui järjesta sees, siis õigesse kohta.
                TK_list1.Items.Add(t);
            else
                TK_list1.Items.Insert(valitud,t); //kui oled valiku teinud, siis paned eelmise reale (-1)
            TK_list1.SelectedIndex = -1;
            TK_txt2.Text = ""; //"clear" ei soovitata
            TK_txt2.Focus(); //kursor on siis tekstiaknas
        }

        private void TK_check2_CheckedChanged(object sender, EventArgs e)
        {
            TK_list1.Sorted = TK_check2.Checked; //saab tähestiku järjekorda, kui paned tiki ette.
        }

        private void TK_del1_Click(object sender, EventArgs e)
        {
            int valitud = TK_list1.SelectedIndex;
            if (valitud < 0)
            {
                MessageBox.Show("Valik puudub");
                return; //lahkun alamprogrammist
            }
            string t = "Kas soovite valitud nime kustutada?\n\n" + TK_list1.Items[valitud];
            DialogResult vastus = MessageBox.Show(t, "Hoiatus", MessageBoxButtons.YesNo);
            if(vastus==DialogResult.Yes)
                TK_list1.Items.RemoveAt(valitud);
            else
                TK_list1.SelectedIndex = -1; //kaotab selecti ära, kui ei lähe kustutamiseks
        }

        private void TK_muuda_Click(object sender, EventArgs e)
        {
            int valitud = TK_list1.SelectedIndex;
            if (valitud < 0)
            {
                MessageBox.Show("Valik puudub");
                return; //lahkun alamprogrammist
            }
            string t = TK_txt2.Text.Trim();
            if (t.Length == 0) return;
            TK_list1.Items[valitud] = t;
            TK_list1.SelectedIndex = -1; //Kui nt parandan mingit nime, siis ei jää see enam aktiivseks.
        }

        
    }
}