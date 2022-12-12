using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace feljegyzes
{
    public partial class feljegyzes : Form
    {
        string kivFile = null;
        public feljegyzes()
        {
            InitializeComponent();
        }

        private void rogzites_Click(object sender, EventArgs e)
        {
            if (nodata())
            {
                return;
            }
            saveFileDialog1.Filter = "egyszerű szöveg fájl| *.txt|vesszövel tagolt szövegfájl (*.csv)|*.csv| minden fájl|*.*";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string szoveg = string.Join(";", nevetxts.Text,datum.Value.ToString(), szovegrich.Text);
                string kivalasztottfajl = saveFileDialog1.FileName;
                File.WriteAllText(kivalasztottfajl, szoveg);
                nevetxts.Text = "";
                szovegrich.Text = "";
            }
            else
            {
                MessageBox.Show("Nincs kiválsztva");
            }
        }
        private bool nodata()
        {
            if (string.IsNullOrEmpty(nevetxts.Text))
            {
                MessageBox.Show("Nem adott meg nevet");
                nevetxts.Focus();
                return true;
            }
            if (string.IsNullOrEmpty(szovegrich.Text))
            {
                MessageBox.Show("Nem adott meg szoveget");
                szovegrich.Focus();
                return true;
            }
            return false;
        }

        private void megnyit_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                kivFile= openFileDialog1.FileName;
                string beolvasottszoveg = File.ReadAllText(kivFile);
                string[] adatok = beolvasottszoveg.Split(';');
                nevetxts.Text = adatok[0];
                datum.Value = DateTime.Parse(adatok[1]);
                szovegrich.Text = adatok[2];
            }
        }

        private void modosit_Click(object sender, EventArgs e)
        {
                string szoveg = string.Join(";", nevetxts.Text, datum.Value.ToString(), szovegrich.Text, Environment.NewLine);
                string kivalasztottfajl = saveFileDialog1.FileName;
                File.WriteAllText(kivFile, szoveg);
                nevetxts.Text = "";
                szovegrich.Text = "";
            MessageBox.Show("Megtörtént a modositasa");
        }
    }
}
