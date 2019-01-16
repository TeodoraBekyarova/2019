using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicketManager
{
    public partial class Form1 : Form
    {
        int Children = 3, School = 4, Student = 5, numberOftickets, price;

        private void btnPrice_Click(object sender, EventArgs e)
        {
            numberOftickets = int.Parse(txbNumber.Text);
            if (rbtChildren.Checked)
            {
                price = numberOftickets * Children;
                money.Text = price.ToString();
                rbtChildren.Checked = false;
                txbNumber.Text = "";

            }
            else if (rbtSchool.Checked)
            {
                price = numberOftickets * School;
                money.Text = price.ToString();
                rbtSchool.Checked = false;
                txbNumber.Text = "";
            }
            else if (rbtStudent.Checked)
            {
                price = numberOftickets * Student;
                money.Text = price.ToString();
                rbtStudent.Checked = false;
                txbNumber.Text = "";
            }

        }

        public Form1()
        {
            InitializeComponent();
        }
    }
}
