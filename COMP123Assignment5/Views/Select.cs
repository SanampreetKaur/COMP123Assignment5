using COMP123Assignment5.Models;
using COMP123Assignment5.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123Assignment5
{
    public partial class Select : Form
    {
        public Select()
        {
            InitializeComponent();
        }

        private void Select_Load(object sender, EventArgs e)
        {
            using (var db = new DollarComputersContext()) 
            {
                db.products.Load();
                productBindingSource.DataSource = db.products.Local.ToBindingList();

            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            if (OutputLabelSelect.Text == "")
            {
                NextButton.Enabled = false;

              
            }
            else
            {
                Program.ProductInfo.Show();
                this.Hide();
            }
        }

        private void OutputLabelSelect_Click(object sender, EventArgs e)
        {
            
        
        }

        private void ProductDataGridViewSelect(object sender, DataGridViewCellEventArgs e)
        {
            //output result label
            var currentCell = ProductDataGridView.CurrentCell;
            var rowIndex = ProductDataGridView.CurrentCell.RowIndex;
            var currentRow = ProductDataGridView.Rows[rowIndex];
            var columnCount = ProductDataGridView.ColumnCount;
            var cells = currentRow.Cells;



            string outputString = string.Empty;

            for (int index = 0; index < columnCount; index++)
            {
                outputString += cells[index].Value.ToString() + " ";
            }
            OutputLabelSelect.Text = outputString;

        }
    }
}
