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
    public partial class StepOne : Form
    {
        public StepOne()
        {
            InitializeComponent();
        }

        private void missButton_Click(object sender, EventArgs e)
        {
            /*string s;
            s = "AAA";
            StepTwo _frm = new StepTwo(s);
            _frm.a = "BBB";*/
            StepTwo _frm = new StepTwo();
            _frm.Show();
            this.Hide();
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            StepTwo _frm = new StepTwo();
            _frm.Show();
            this.Hide();
        }
    }
}
