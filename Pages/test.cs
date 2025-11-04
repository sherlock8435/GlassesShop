using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GlassesShop.Pages
{
    public partial class test : Form
    {
        public test()
        {
            InitializeComponent();
        }
         
        private void test_Load(object sender, EventArgs e)
        {
            DataTable dt = DBobj.fill_grid("SELECT image FROM products");
            label1.Text = dt.Rows[0][0].ToString(); 
        }
    }
}
