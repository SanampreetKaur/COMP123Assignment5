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
            // Outputs the value to the Product_info form


            Program.Information.Product_Id = cells[(int)Information.InformationFields.Productid].Value.ToString();
            Program.Information.Condition = cells[(int)Information.InformationFields.Condition].Value.ToString();
            Program.Information.Cost = cells[(int)Information.InformationFields.Cost].Value.ToString();
            Program.Information.Platform = cells[(int)Information.InformationFields.Platform].Value.ToString();
            Program.Information.OS = cells[(int)Information.InformationFields.Os].Value.ToString();
            Program.Information.Manufacturer = cells[(int)Information.InformationFields.Manufacturer].Value.ToString();
            Program.Information.Model = cells[(int)Information.InformationFields.Model].Value.ToString();
            Program.Information.Memory = cells[(int)Information.InformationFields.Memory].Value.ToString();
            Program.Information.LCD_Size = cells[(int)Information.InformationFields.Lcdsize].Value.ToString();
            Program.Information.Hdd = cells[(int)Information.InformationFields.Hdd].Value.ToString();
            Program.Information.CPU_Brand = cells[(int)Information.InformationFields.Cpubrand].Value.ToString();
            Program.Information.CPU_number = cells[(int)Information.InformationFields.Cpunumber].Value.ToString();
            Program.Information.GPU_Type = cells[(int)Information.InformationFields.Gputype].Value.ToString();
            Program.Information.CPU_Type = cells[(int)Information.InformationFields.Cputype].Value.ToString();
            Program.Information.CPU_speed = cells[(int)Information.InformationFields.Cpuspeed].Value.ToString();
            Program.Information.web_cam = cells[(int)Information.InformationFields.Webcam].Value.ToString();

        }
    }
}
