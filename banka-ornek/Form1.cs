using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace banka_ornek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double bakiye;

        private void lblTutar_Click(object sender, EventArgs e)
        {
            double yatiralacakTutar = Convert.ToDouble(txtTutar.Text);
            bakiye += yatiralacakTutar;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            bakiye = 0;
            lblBakiye.Text="Bakiye"+bakiye.ToString();
        }

        private void btnCek_Click(object sender, EventArgs e)
        {
            double cekilecekTutar = Convert.ToDouble(txtTutar.Text);


            if (cekilecekTutar <= bakiye)
            {
                bakiye -= cekilecekTutar;
            }
            else
            {
                MessageBox.Show("YETERSİZ BAKİYE!!!");
            }




            lblBakiye.Text = "Bakiye: " + bakiye.ToString() + " ₺";
        }
    }
}
