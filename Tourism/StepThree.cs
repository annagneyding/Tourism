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
    public partial class StepThree : Form
    {
        public StepThree()
        {
            InitializeComponent();
        }

        private void missButton_Click(object sender, EventArgs e)
        {
            StepFour _frm = new StepFour();
            _frm.Show();
            this.Hide();
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            StepFour _frm = new StepFour();
            _frm.Show();
            this.Hide();
        }
    }
}
