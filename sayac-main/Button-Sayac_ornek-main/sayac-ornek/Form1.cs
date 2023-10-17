using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sayac_ornek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int sayac = 0; // Global değişken tanımlama .Her yerden ulaşılabilir.


        private void Form1_Load(object sender, EventArgs e)
        {
            lblSayac.Text = sayac.ToString();
        }

        private void btnAzalt_Click(object sender, EventArgs e)
        {
            if (sayac > -10)
            {
                sayac--;
            }
             //Değeri 1 azaltır.
            lblSayac.Text=sayac.ToString();


        }

        private void btnArttir_Click(object sender, EventArgs e)
        {
            if(sayac<10)
            {
                sayac++;
            }

              //Değeri 1 arttır.
            lblSayac.Text = sayac.ToString();
        }
    }
}
