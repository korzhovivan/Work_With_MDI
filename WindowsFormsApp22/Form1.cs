using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace WindowsFormsApp22
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }
        List<Product> products = new List<Product>();
        private void CreateToolStripMenuItem_Click(object sender, EventArgs e)
        {

            ItemForm item_form = new ItemForm(this);
            item_form.MdiParent = this;
            item_form.Show();
            
        }

        private void addProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddProductForm addProduct = new AddProductForm(this);
            addProduct.Show();



        }
    }
}
