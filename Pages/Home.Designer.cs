namespace GlassesShop.Pages
{
    partial class Home
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Curent_Page_lbl = new System.Windows.Forms.Label();
            this.Contact_Us_btn = new System.Windows.Forms.Button();
            this.My_Cart_btn = new System.Windows.Forms.Button();
            this.Products_btn = new System.Windows.Forms.Button();
            this.Customer_btn = new System.Windows.Forms.Button();
            this.Home_btn = new System.Windows.Forms.Button();
            this.Main_Panel = new System.Windows.Forms.Panel();
            this.Main_Control = new GlassesShop.Pages.Home_Control();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.Main_Panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.Curent_Page_lbl);
            this.panel1.Controls.Add(this.Contact_Us_btn);
            this.panel1.Controls.Add(this.My_Cart_btn);
            this.panel1.Controls.Add(this.Products_btn);
            this.panel1.Controls.Add(this.Customer_btn);
            this.panel1.Controls.Add(this.Home_btn);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(875, 92);
            this.panel1.TabIndex = 1;
            // 
            // Curent_Page_lbl
            // 
            this.Curent_Page_lbl.AutoSize = true;
            this.Curent_Page_lbl.Font = new System.Drawing.Font("Modern No. 20", 26.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Curent_Page_lbl.Location = new System.Drawing.Point(50, 13);
            this.Curent_Page_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Curent_Page_lbl.Name = "Curent_Page_lbl";
            this.Curent_Page_lbl.Size = new System.Drawing.Size(100, 36);
            this.Curent_Page_lbl.TabIndex = 22;
            this.Curent_Page_lbl.Text = "Home";
            // 
            // Contact_Us_btn
            // 
            this.Contact_Us_btn.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.Contact_Us_btn.FlatAppearance.BorderColor = System.Drawing.SystemColors.InactiveBorder;
            this.Contact_Us_btn.FlatAppearance.BorderSize = 0;
            this.Contact_Us_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Contact_Us_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Contact_Us_btn.Image = ((System.Drawing.Image)(resources.GetObject("Contact_Us_btn.Image")));
            this.Contact_Us_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Contact_Us_btn.Location = new System.Drawing.Point(519, 51);
            this.Contact_Us_btn.Margin = new System.Windows.Forms.Padding(2);
            this.Contact_Us_btn.Name = "Contact_Us_btn";
            this.Contact_Us_btn.Size = new System.Drawing.Size(111, 38);
            this.Contact_Us_btn.TabIndex = 4;
            this.Contact_Us_btn.Text = "Contact Us ";
            this.Contact_Us_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Contact_Us_btn.UseVisualStyleBackColor = false;
            this.Contact_Us_btn.Click += new System.EventHandler(this.Contact_Us_btn_Click);
            // 
            // My_Cart_btn
            // 
            this.My_Cart_btn.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.My_Cart_btn.FlatAppearance.BorderColor = System.Drawing.SystemColors.InactiveBorder;
            this.My_Cart_btn.FlatAppearance.BorderSize = 0;
            this.My_Cart_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.My_Cart_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.My_Cart_btn.Image = ((System.Drawing.Image)(resources.GetObject("My_Cart_btn.Image")));
            this.My_Cart_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.My_Cart_btn.Location = new System.Drawing.Point(395, 56);
            this.My_Cart_btn.Margin = new System.Windows.Forms.Padding(2);
            this.My_Cart_btn.Name = "My_Cart_btn";
            this.My_Cart_btn.Size = new System.Drawing.Size(93, 31);
            this.My_Cart_btn.TabIndex = 3;
            this.My_Cart_btn.Text = "My Cart";
            this.My_Cart_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.My_Cart_btn.UseVisualStyleBackColor = false;
            this.My_Cart_btn.Click += new System.EventHandler(this.My_Cart_btn_Click);
            // 
            // Products_btn
            // 
            this.Products_btn.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.Products_btn.FlatAppearance.BorderColor = System.Drawing.SystemColors.InactiveBorder;
            this.Products_btn.FlatAppearance.BorderSize = 0;
            this.Products_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Products_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Products_btn.Location = new System.Drawing.Point(284, 51);
            this.Products_btn.Margin = new System.Windows.Forms.Padding(2);
            this.Products_btn.Name = "Products_btn";
            this.Products_btn.Size = new System.Drawing.Size(102, 38);
            this.Products_btn.TabIndex = 2;
            this.Products_btn.Text = "Products";
            this.Products_btn.UseVisualStyleBackColor = false;
            this.Products_btn.Click += new System.EventHandler(this.Products_btn_Click);
            // 
            // Customer_btn
            // 
            this.Customer_btn.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.Customer_btn.FlatAppearance.BorderColor = System.Drawing.SystemColors.InactiveBorder;
            this.Customer_btn.FlatAppearance.BorderSize = 0;
            this.Customer_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Customer_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Customer_btn.Image = ((System.Drawing.Image)(resources.GetObject("Customer_btn.Image")));
            this.Customer_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Customer_btn.Location = new System.Drawing.Point(151, 51);
            this.Customer_btn.Margin = new System.Windows.Forms.Padding(2);
            this.Customer_btn.Name = "Customer_btn";
            this.Customer_btn.Size = new System.Drawing.Size(102, 38);
            this.Customer_btn.TabIndex = 1;
            this.Customer_btn.Text = "Customer";
            this.Customer_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Customer_btn.UseVisualStyleBackColor = false;
            this.Customer_btn.Click += new System.EventHandler(this.Customers_btn_Click);
            // 
            // Home_btn
            // 
            this.Home_btn.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.Home_btn.FlatAppearance.BorderColor = System.Drawing.SystemColors.InactiveBorder;
            this.Home_btn.FlatAppearance.BorderSize = 0;
            this.Home_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Home_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Home_btn.Image = ((System.Drawing.Image)(resources.GetObject("Home_btn.Image")));
            this.Home_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Home_btn.Location = new System.Drawing.Point(21, 51);
            this.Home_btn.Margin = new System.Windows.Forms.Padding(2);
            this.Home_btn.Name = "Home_btn";
            this.Home_btn.Size = new System.Drawing.Size(102, 38);
            this.Home_btn.TabIndex = 0;
            this.Home_btn.Text = "Home";
            this.Home_btn.UseVisualStyleBackColor = false;
            this.Home_btn.Click += new System.EventHandler(this.Home_btn_Click);
            // 
            // Main_Panel
            // 
            this.Main_Panel.Controls.Add(this.Main_Control);
            this.Main_Panel.Location = new System.Drawing.Point(0, 93);
            this.Main_Panel.Name = "Main_Panel";
            this.Main_Panel.Size = new System.Drawing.Size(875, 432);
            this.Main_Panel.TabIndex = 6;
            // 
            // Main_Control
            // 
            this.Main_Control.Location = new System.Drawing.Point(0, 0);
            this.Main_Control.Name = "Main_Control";
            this.Main_Control.Size = new System.Drawing.Size(875, 432);
            this.Main_Control.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(374, 11);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "debug";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 525);
            this.Controls.Add(this.Main_Panel);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Home";
            this.Text = "GlassesShop";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.Main_Panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Contact_Us_btn;
        private System.Windows.Forms.Button My_Cart_btn;
        private System.Windows.Forms.Button Products_btn;
        private System.Windows.Forms.Button Customer_btn;
        private System.Windows.Forms.Button Home_btn;
        private System.Windows.Forms.Panel Main_Panel;
        private Home_Control Main_Control;
        private System.Windows.Forms.Label Curent_Page_lbl;
        private System.Windows.Forms.Button button1;
    }
}