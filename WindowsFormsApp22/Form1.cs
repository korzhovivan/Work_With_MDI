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
        public bool File_Open = false;
        public string fileName;

        public List<Product> products = null;

        private void CreateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            products = new List<Product>();
            ItemForm item_form = new ItemForm(this);
            item_form.MdiParent = this;
            item_form.Show();
            this.LayoutMdi(MdiLayout.TileVertical);
            File_Open = true;
            fileName = "";
        }

        private void addProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (File_Open)
            {
                AddProductForm addProduct = new AddProductForm(this);
                addProduct.MdiParent = this;
                addProduct.Show();
                this.LayoutMdi(MdiLayout.TileVertical);
            }
            else
            {
                MessageBox.Show("Create or open file");

            }
            
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                fileName = dialog.FileName;
                Stream stream = File.Open(fileName, FileMode.Create);
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(stream, products);
                stream.Close();
            }
           
        }

        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Stream stream = File.Open(fileName, FileMode.Create);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(stream, products);
            stream.Close();
        }

        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                fileName = dialog.FileName;
                Stream stream = File.Open(fileName, FileMode.Open);
                BinaryFormatter bf = new BinaryFormatter();
                products = (List<Product>)bf.Deserialize(stream);
                stream.Close();

                ItemForm item_form = new ItemForm(this);
                item_form.MdiParent = this;
                item_form.Show();
                this.LayoutMdi(MdiLayout.TileVertical);
                File_Open = true;
            }
        }
    }
}
