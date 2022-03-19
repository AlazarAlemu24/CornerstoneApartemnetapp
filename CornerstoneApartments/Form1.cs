using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CornerstoneApartments
{
    public partial class Form1 : Form
    {
        public static Form1 confirmation;
        public int price = 0;
        public int total = 0;
        public const int lake_view = 50;
        public const int bath_per_room = 75;
        public Form1()
        {
            InitializeComponent();
            confirmation = this;
        }

        
        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnreset_Click(object sender, EventArgs e)
        {
            price = 0;
            radiobtn1bath.Checked = false;
            radiobtn2bath.Checked = false;
            radiobtn3bath.Checked = false;
        }
        private void bedRoomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            price = 0;
            price = 450;
        }
        private void bedRoomToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            price = 0;
            price = 550;
        }
        private void bedRoomToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            price = 0;
            price = 700;
        }
        private void lakeViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            price = price + 50;
        }
        private void normalViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lakeViewToolStripMenuItem.Enabled)
                price = price - 50;
            else
                price = price + 0;
        }
        private void btncalculate_Click(object sender, EventArgs e)
        {
            if (radiobtn1bath.Checked == true)
                price = price + 0;
            else if (radiobtn2bath.Checked == true)
                price = price + 75;
            else if (radiobtn3bath.Checked == true)
                price = price + 150;

            Form2 form = new Form2();
            form.Show();
            Form2.confirmation.output.Text = "Your estimated monthly price is: " + price;
        }

       
    }
}
