using COMP123Assignment5.Views;
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
    public partial class ProductInfo : Form
    {
        public ProductInfo()
        {
            InitializeComponent();
        }

        private void ProductIDLabel_Click(object sender, EventArgs e)
        {

        }

        private void ConditionValue_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void GPUTypeLabel_Click(object sender, EventArgs e)
        {

        }

        private void CPUSpeedLabel_Click(object sender, EventArgs e)
        {

        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            Program.Order.Show();
            this.Hide();

        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }
    }
}
