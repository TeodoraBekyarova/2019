using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConfigureMyAuto
{
    public partial class Form1 : Form
    {
        int pricePorsche, priceMercedes, priceJaguar, extraPrice=0;
        double totalprice, thisprice;

        public Form1()
        {
            InitializeComponent();
        }

        private void cbABS_CheckedChanged(object sender, EventArgs e)
        {
            extraPrice += 500;
        }

        private void cbLight_CheckedChanged(object sender, EventArgs e)
        {
            extraPrice += 1000;
        }

        private void cbChains_CheckedChanged(object sender, EventArgs e)
        {
            extraPrice += 1500;
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            totalprice = totalprice + extraPrice;
            lbPrice.Text = totalprice.ToString();

            if (cbABS.Checked==true && cbChains.Checked==true && cbLight.Checked==true)
            {
                thisprice=totalprice*0.10;
                lbDiscount.Text = totalprice.ToString();
            }
        }

        private void rbPorsche_CheckedChanged(object sender, EventArgs e)
        {
            pricePorsche = 100000;
            totalprice = pricePorsche;
            lbPrice.Text = totalprice.ToString();
            pbGallery.Image = ConfigureMyAuto.Properties.Resources.Porsche;
        }

        

        private void rbMercedes_CheckedChanged(object sender, EventArgs e)
        {
            priceMercedes = 150000;
            totalprice = priceMercedes;
            lbPrice.Text = totalprice.ToString();
            pbGallery.Image = ConfigureMyAuto.Properties.Resources.Mercedes;
        }

        private void rbJaguar_CheckedChanged(object sender, EventArgs e)
        {
            priceJaguar = 200000;
            totalprice = priceJaguar;
            lbPrice.Text = totalprice.ToString();
            pbGallery.Image = ConfigureMyAuto.Properties.Resources.Jaguar;
        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
