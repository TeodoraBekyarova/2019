using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ButtonCounter
{
    public partial class Form1 : Form
    {
        int click = 0;
        public Form1()
        {
            InitializeComponent();
            Number.Text = " 0 ";
        }

        private void btnClick_Click(object sender, EventArgs e)
        {
            click++;
            Number.Text = click.ToString();
            switch (click)
            {
                case 5:
                    this.BackColor = Color.DarkViolet; break;
                case 10:
                    this.BackColor = Color.Yellow; break;
                case 15:
                    this.BackColor = Color.LightSkyBlue; break;
                default:
                    this.BackColor = Color.BurlyWood; break;
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Number.Text = "0";
            click = 0;
        }
    }
}
