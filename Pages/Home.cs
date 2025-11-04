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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void Customers_btn_Click(object sender, EventArgs e)
        {
            if (Curent_Page_lbl.Text == "Customers")
            {
                return;
            }
            Custormers_Control Customers_ctrl = new Custormers_Control
            {
                Location = Main_Control.Location,
                Name = "Main_Control"
            };


            Main_Panel.Controls.Clear();

            Main_Panel.Controls.Add(Customers_ctrl);
            Customers_ctrl.BringToFront();

            Curent_Page_lbl.Text = "Customers";
        }

        private void Products_btn_Click(object sender, EventArgs e)
        {
            if (Curent_Page_lbl.Text == "Products")
            {
                return;
            }
            Products_Control Products_ctrl = new Products_Control
            {
                Location = Main_Control.Location,
                Name = "Main_Control"
            };


            Main_Panel.Controls.Clear();

            Main_Panel.Controls.Add(Products_ctrl);
            Products_ctrl.BringToFront();

            Curent_Page_lbl.Text = "Products";
        }

        private void My_Cart_btn_Click(object sender, EventArgs e)
        {
            if (Curent_Page_lbl.Text == "My Cart")
            {
                return;
            }
            Cart_Control Cart_ctrl = new Cart_Control
            {
                Location = Main_Control.Location,
                Name = "Main_Control"
            };


            Main_Panel.Controls.Clear();

            Main_Panel.Controls.Add(Cart_ctrl);
            Cart_ctrl.BringToFront();

            Curent_Page_lbl.Text = "My Cart";
        }

        private void Contact_Us_btn_Click(object sender, EventArgs e)
        {
            if (Curent_Page_lbl.Text == "Contact Us")
            {
                return;
            }
            Contact_Us_Control Contact_Us_ctrl = new Contact_Us_Control
            {
                Location = Main_Control.Location,
                Name = "Main_Control"
            };

            Main_Panel.Controls.Clear();

            Main_Panel.Controls.Add(Contact_Us_ctrl);
            Contact_Us_ctrl.BringToFront();

            Curent_Page_lbl.Text = "Contact Us";

        }

        private void Home_btn_Click(object sender, EventArgs e)
        {
            if (Curent_Page_lbl.Text == "Home")
            {
                return;
            }
            Home_Control Home_ctrl = new Home_Control
            {
                Location = Main_Control.Location,
                Name = "Main_Control"
            };


            Main_Panel.Controls.Clear();

            Main_Panel.Controls.Add(Home_ctrl);
            Home_ctrl.BringToFront();

            Curent_Page_lbl.Text = "Home";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            test t = new test();
            t.Show();
        }
    }
}
