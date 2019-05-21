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
    public partial class ItemForm : Form
    {
        private Form1 form1;

        internal int Selected_Items;

        List<Product> Item_products = new List<Product>();

        public Product NewProduct {
            set
            {
                form1.products.Add(value);
                Item_products.Add(value);
                listBox_Products.Items.Add(value.ToString());
            }
        }

        public int Deleter {
            set
            {
                Item_products.RemoveAt(listBox_Products.SelectedIndex);
                form1.products.RemoveAt(listBox_Products.SelectedIndex);
                listBox_Products.Items.RemoveAt(listBox_Products.SelectedIndex);
            }
        }

        public ItemForm(Form1 form1)
        {
            InitializeComponent();
            this.LayoutMdi(MdiLayout.TileVertical);
            this.form1 = form1;
            this.FormClosing += Close;
            foreach (Product item in form1.products)
            {
                listBox_Products.Items.Add(item.ToString());
                Item_products.Add(item);
            }
        }

        private void Close(object sender, FormClosingEventArgs e)
        {
            form1.File_Open = false;
        }
    }
}
