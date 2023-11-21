using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace button.ornek._41
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBas_Click(object sender, EventArgs e)
        {
            Kitap kitap = new Kitap();
            kitap.ad = "Meryem'in Hayalleri ";
            kitap.yayinEvi="Meryem.com";
            kitap.cikmaYili = 2019;
            kitap.sayfaSayisi = 500;
            kitap.yazar = "Meryem Aybahar";

            label1.Text = kitap.ad + "   " + kitap.yayinEvi + "   " + kitap.cikmaYili + "   " + kitap.sayfaSayisi + "   " + kitap.yazar + "   ";

        }
    }
}
