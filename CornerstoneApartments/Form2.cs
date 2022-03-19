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
    public partial class Form2 : Form
    {
        public static Form2 confirmation;
        public Label output;
        public Form2()
        {
            InitializeComponent();
            confirmation = this;
            output = lblForm2output;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btnForm2Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
