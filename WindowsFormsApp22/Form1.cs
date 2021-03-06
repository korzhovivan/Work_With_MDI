﻿using System;
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
            for (int i = 0; i < FindToolStripMenuItem.DropDownItems.Count; i++)
            {
                FindToolStripMenuItem.DropDownItems[i].Click += Form1_Click;
            }
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            if (File_Open)
            {
                FindForm addProduct = new FindForm(this);
                addProduct.MdiParent = this;
                addProduct.Show();
                this.LayoutMdi(MdiLayout.TileVertical);
            }
            else
            {
                MessageBox.Show("Create or open file");
            }
        }

        public int FindFilter;
        public ItemForm item_form;

        public bool File_Open = false;
        public string fileName = "";

        public List<Product> products = null;

        private void CreateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!File_Open)
            {
                products = new List<Product>();
                item_form = new ItemForm(this);
                item_form.MdiParent = this;
                item_form.Show();
                this.LayoutMdi(MdiLayout.TileVertical);
                File_Open = true;
                fileName = "";
            }
            else
            {
                MessageBox.Show("You can work only with one file");
            }
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
            if (File_Open)
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
            else
            {
                MessageBox.Show("Create or open file");
            }
        }

        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (File_Open)
            {
                if (fileName == "")
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
                else
                {
                    Stream stream = File.Open(fileName, FileMode.Create);
                    BinaryFormatter bf = new BinaryFormatter();
                    bf.Serialize(stream, products);
                    stream.Close();
                }
            }
            else
            {
                MessageBox.Show("Create or open file");
            }
            
            
        }

        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!File_Open)
            {
                OpenFileDialog dialog = new OpenFileDialog();
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    fileName = dialog.FileName;
                    Stream stream = File.Open(fileName, FileMode.Open);
                    BinaryFormatter bf = new BinaryFormatter();
                    products = (List<Product>)bf.Deserialize(stream);
                    stream.Close();

                    item_form = new ItemForm(this);
                    item_form.MdiParent = this;
                    item_form.Show();
                    this.LayoutMdi(MdiLayout.TileVertical);
                    File_Open = true;
                }
            }
            else
            {
                MessageBox.Show("You can work only with one file");
            }
        }

        private void DeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            item_form.Deleter = 0;
        }

        private void EditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (File_Open)
            {
                EditProductForm addProduct = new EditProductForm(this);
                addProduct.MdiParent = this;
                addProduct.Show();
                this.LayoutMdi(MdiLayout.TileVertical);
            }
            else
            {
                MessageBox.Show("Create or open file");
            }
        }

        private void ToolStripMenuItem_FindGroup_Click(object sender, EventArgs e)
        {
            FindFilter = 1;
        }
        private void ToolStripMenuItem_FindName_Click(object sender, EventArgs e)
        {
            FindFilter = 2;
        }
        private void ToolStripMenuItem_FindManufacturer_Click(object sender, EventArgs e)
        {
            FindFilter = 3;
        }
        private void ToolStripMenuItem_FindDateManuf_Click(object sender, EventArgs e)
        {
            FindFilter = 4;
        }
        private void ToolStripMenuItem_FindDate_Click(object sender, EventArgs e)
        {
            FindFilter = 5;
        }
    }
}
