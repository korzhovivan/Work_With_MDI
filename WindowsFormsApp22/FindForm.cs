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
    public partial class FindForm : Form
    {
        ItemForm item;
        Form1 form1;
        public FindForm(Form1 form1)
        {
            InitializeComponent();
            item = form1.item_form;
            this.form1 = form1;
            txtBox_Seach.TextChanged += TxtBox_Seach_TextChanged;
            
        }

        private void TxtBox_Seach_TextChanged(object sender, EventArgs e)
        {
            item.DeleteAllProduct = true;
            for (int i = 0; i < form1.products.Count; i++)
            {
                if (form1.products[i].Name.Contains(txtBox_Seach.Text))
                {
                    item.Visible = form1.products[i];
                }
            }
        }
    }
}
