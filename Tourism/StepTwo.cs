using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tourism
{
    public partial class StepTwo : Form
    {
        public string a;
        public StepTwo()
        {
            InitializeComponent();
        }

        /*public StepTwo(string h)
        {
            a = h;
            InitializeComponent();
            label4.Text = h;
        }*/

        private void missButton_Click(object sender, EventArgs e)
        {
            StepThree _frm = new StepThree();
            _frm.Show();
            this.Hide();
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            StepThree _frm = new StepThree();
            _frm.Show();
            this.Hide();
        }

        /*private void label6_Click(object sender, EventArgs e)
        {
            label4.Text = a;
        }*/
    }
}
