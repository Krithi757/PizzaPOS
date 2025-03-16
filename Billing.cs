using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzaPOS
{
    public partial class Billing : Form
    {
        Functions Con; 
        public Billing()
        {
            Con = new Functions(); 
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Settimgs Obj = new Settimgs();
            Obj.Show();
            this.Hide();
        }
        int Key = 0;
        int Price = 0; 

        private void GetPrice(int Key)
        {
            string Pizza = "";
            if (Key == 1)
            {
                Pizza = "Small";
            }
            else if (Key == 2)
            {
                Pizza = "Medium";
            }
            else if (Key == 3)
            {
                Pizza = "Large";
            }
            else if (Key == 4)
            {
                Pizza = "Extra Large";
            }
            string Query = "select * from PizzaTbl where Item = '{0}'";
            Query = string.Format(Query, Pizza);
            Price = Convert.ToInt32(Con.GetData(Query).Rows[0][1].ToString());
        }
        int n = 0;
        string Items;
        private void OrderBtn_Click(object sender, EventArgs e)
        {
            if (SmallBtn.Checked == true)
            {
                Key = 1;
                Items = "Small Pizza";
            }
            else if (MediumBtn.Checked == true)
            {
                Key = 2;
                Items = "Medium Pizza";
            }
            else if (LargeBtn.Checked == true)
            {
                Key = 3;
                Items = "Large Pizza";
            }
            else if (ExtraLargeBtn.Checked == true)
            {
                Key = 4;
                Items = "Extra Large Pizza";
            }
            GetPrice(Key);
            int Qty = Convert.ToInt32(QtyTb.Text);
            int total=Qty*Price;
            DataGridViewRow newRow = new DataGridViewRow();
            newRow.CreateCells(BillDGV);
            newRow.Cells[0].Value = n + 1;
            newRow.Cells[1].Value = Items;
            newRow.Cells[2].Value = Price;
            newRow.Cells[3].Value = QtyTb.Text;
            newRow.Cells[4].Value = total;

        }
    }
}
