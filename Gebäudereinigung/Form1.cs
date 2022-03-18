using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gebäudereinigung
{
    public partial class Form1 : Form
    {
        string Kunde;
        int FensterAnzahl;
        int Bodengröße;
        DateTime Datum;

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_kunde__TextChanged(object sender, EventArgs e)
        {
            Kunde = btn_kunde.Texts;
        
        }

        private void tb_fensteranzahl__TextChanged(object sender, EventArgs e)
        {
            try
            {
                FensterAnzahl = int.Parse(tb_fensteranzahl.Texts);
            }
            catch (Exception)
            {
                if (tb_fensteranzahl.Texts != "")
                {
                    //tb_bodengröße.Texts.Substring(0, tb_bodengröße.Texts.Length - 1);
                    MessageBox.Show("Es sind nur Zahlen erlaubt!");
                }   
            }
            //MessageBox.Show(FensterAnzahl.ToString());
        }

        private void tb_bodengröße__TextChanged(object sender, EventArgs e)
        {
            try
            {
                Bodengröße = int.Parse(tb_bodengröße.Texts);
            }
            catch (Exception)
            {
                if (tb_fensteranzahl.Texts != "")
                {
                    //tb_bodengröße.Texts = tb_bodengröße.Texts.Remove(tb_bodengröße.Texts.Length - 1, 1);
                    MessageBox.Show("Es sind nur Zahlen erlaubt!");
                }
            }
            //MessageBox.Show(Bodengröße.ToString());
        }

        private void dp_datum_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                Datum = Convert.ToDateTime(dp_datum.Value);
            }
            catch (Exception)
            {
                dp_datum.Value = DateTime.Today;
            }
            //MessageBox.Show(Datum.ToString());
        }

        private void btn_fenster_Click(object sender, EventArgs e)
        {
            double Kosten = FensterAnzahl * 20;
            Reinigung Fenster = new Fensterreinigung(FensterAnzahl, Kosten, Kunde, Datum, "TEST", "Scheibenreiniger");
            MessageBox.Show(Fenster.ausgabe() , "Eilmeldung", MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
    }
}
