using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123Assignment5
{
    public partial class SplashForm : Form
    {
        public SplashForm()
        {
            InitializeComponent();
        }

        private void SplashForm_Load(object sender, EventArgs e)
        {

        }

        private void SplashTimer_Tick(object sender, EventArgs e)
        {
            this.Hide();
            StartForm StartForm = new StartForm();
            StartForm.Show();
            SplashTimer.Enabled = false;
        }
    }
}
