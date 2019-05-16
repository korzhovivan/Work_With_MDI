﻿using System;
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
        
        public Product NewProduct {
            set
            {
                form1.products.Add(value);
                listBox_Products.Items.Add(value.ToString());
                
            }
        }


        public ItemForm()
        {
            InitializeComponent();
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        public ItemForm(Form1 form1)
        {
            InitializeComponent();
            this.LayoutMdi(MdiLayout.TileVertical);
            this.form1 = form1;
            
        }
    }
}
