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
    public partial class EditProductForm : Form
    {

        ItemForm itemForm;

        public EditProductForm(Form1 form1)
        {
            InitializeComponent();

            this.form1 = form1;

            this.LayoutMdi(MdiLayout.TileVertical);
            itemForm = form1.item_form;

            txtBox_Group.Text = form1.products[itemForm.Selected_Items].Group;
            txtBox_Name.Text = form1.products[itemForm.Selected_Items].Name;
            txtBox_Manufacturer.Text = form1.products[itemForm.Selected_Items].Manufecturer;
            txtBox_Date.Text = form1.products[itemForm.Selected_Items].Date;
            txtBox_ExpirationDate.Text = form1.products[itemForm.Selected_Items].Expiration;

            MessageBox.Show(itemForm.Selected_Items.ToString());
        }

        private Product newProduct = new Product();
        private Form1 form1;

        internal Product NewProduct { get => newProduct; set => newProduct = value; }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            if (form1.File_Open)
            {
                NewProduct = null;
                NewProduct = new Product();

                NewProduct.Group = txtBox_Group.Text;
                NewProduct.Name = txtBox_Name.Text;
                NewProduct.Manufecturer = txtBox_Manufacturer.Text;
                NewProduct.Date = txtBox_Date.Text;
                NewProduct.Expiration = txtBox_ExpirationDate.Text;

                itemForm.EditProduct = newProduct;
            }
            else
            {
                MessageBox.Show("Create or open file");
            }
        }
    }
}
