using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cinema_kiosk_sales
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
        int cashtotal = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            int popcorn, ticket, water, tea, Total;
            popcorn = Convert.ToInt16(Txtpopcorn.Text);
            ticket = Convert.ToInt16(txtticket.Text);
            water = Convert.ToInt16(txtwater.Text);
            tea = Convert.ToInt16(txttea.Text);

            Total = popcorn * 4 + tea * 2 + water * 1 + ticket * 8 ;
            lbltotal.Text = Total.ToString() + " € ";

            cashtotal = cashtotal + Total;
            lblcash.Text = cashtotal.ToString() + " € ";
        }

        private void lblcash_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtticket.Text = ""; 
            txttea.Text = "";
            txtwater.Text = "";
            Txtpopcorn.Focus();
            
        }
    }
}
