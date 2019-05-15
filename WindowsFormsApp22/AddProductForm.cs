using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp22
{
    public partial class AddProductForm : Form
    {
        public AddProductForm()
        {
            InitializeComponent();
        }

        public AddProductForm(Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;
        }

        private Product newProduct = new Product();
        private Form1 form1;

        internal Product NewProduct { get => newProduct; set => newProduct = value; }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            NewProduct.Group = txtBox_Group.Text;
            NewProduct.Name = txtBox_Name.Name;
            NewProduct.Manufecturer = txtBox_Manufacturer.Text;
            NewProduct.Date = txtBox_Date.Text;
            NewProduct.Expiration = txtBox_ExpirationDate.Text;
            foreach (Form item in form1.MdiChildren)
            {
                if(item.GetType().Name == "ItemForm")
                {
                    (item as ItemForm).NameForm = NewProduct;
                }
            }
        }
    }
}
