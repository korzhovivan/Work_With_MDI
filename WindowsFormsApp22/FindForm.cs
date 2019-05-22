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
        public FindForm(Form1 form1)
        {
            InitializeComponent();
            switch (form1.FindFilter)
            {
                case 1: label1.Text = "Find by group"; break;
                

                default:
                    break;
            }
        }
       
    }
}
