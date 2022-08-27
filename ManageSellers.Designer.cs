namespace ShopRite_IMS
{
    partial class ManageSellers
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.DGV3 = new System.Windows.Forms.DataGridView();
            this.SellerPass = new Guna.UI2.WinForms.Guna2TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SellerMobile = new Guna.UI2.WinForms.Guna2TextBox();
            this.SellerAge = new Guna.UI2.WinForms.Guna2TextBox();
            this.SellerName = new Guna.UI2.WinForms.Guna2TextBox();
            this.SellerId = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV3)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Crimson;
            this.label1.Location = new System.Drawing.Point(259, 172);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 22);
            this.label1.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Crimson;
            this.panel1.Controls.Add(this.DGV3);
            this.panel1.Controls.Add(this.SellerPass);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.SellerMobile);
            this.panel1.Controls.Add(this.SellerAge);
            this.panel1.Controls.Add(this.SellerName);
            this.panel1.Controls.Add(this.SellerId);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(105, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(788, 504);
            this.panel1.TabIndex = 5;
            // 
            // DGV3
            // 
            this.DGV3.AllowUserToOrderColumns = true;
            this.DGV3.BackgroundColor = System.Drawing.Color.White;
            this.DGV3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGV3.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DGV3.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV3.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DGV3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGV3.DefaultCellStyle = dataGridViewCellStyle2;
            this.DGV3.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.DGV3.EnableHeadersVisualStyles = false;
            this.DGV3.Location = new System.Drawing.Point(302, 57);
            this.DGV3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DGV3.MultiSelect = false;
            this.DGV3.Name = "DGV3";
            this.DGV3.RowHeadersVisible = false;
            this.DGV3.RowHeadersWidth = 51;
            this.DGV3.RowTemplate.Height = 24;
            this.DGV3.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV3.Size = new System.Drawing.Size(454, 415);
            this.DGV3.TabIndex = 16;
            this.DGV3.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV3_CellContentClick);
            // 
            // SellerPass
            // 
            this.SellerPass.Animated = true;
            this.SellerPass.BorderColor = System.Drawing.Color.White;
            this.SellerPass.BorderThickness = 3;
            this.SellerPass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.SellerPass.DefaultText = "";
            this.SellerPass.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.SellerPass.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.SellerPass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.SellerPass.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.SellerPass.FillColor = System.Drawing.Color.Crimson;
            this.SellerPass.FocusedState.BorderColor = System.Drawing.Color.White;
            this.SellerPass.FocusedState.FillColor = System.Drawing.Color.Crimson;
            this.SellerPass.FocusedState.ForeColor = System.Drawing.Color.White;
            this.SellerPass.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.SellerPass.ForeColor = System.Drawing.Color.White;
            this.SellerPass.HoverState.BorderColor = System.Drawing.Color.Crimson;
            this.SellerPass.Location = new System.Drawing.Point(25, 262);
            this.SellerPass.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SellerPass.Name = "SellerPass";
            this.SellerPass.PasswordChar = '\0';
            this.SellerPass.PlaceholderForeColor = System.Drawing.Color.White;
            this.SellerPass.PlaceholderText = "Password";
            this.SellerPass.SelectedText = "";
            this.SellerPass.Size = new System.Drawing.Size(192, 29);
            this.SellerPass.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.SellerPass.TabIndex = 14;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.White;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Bauhaus 93", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.Crimson;
            this.button4.Location = new System.Drawing.Point(98, 330);
            this.button4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(66, 33);
            this.button4.TabIndex = 13;
            this.button4.Text = "EDIT";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Bauhaus 93", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Crimson;
            this.button2.Location = new System.Drawing.Point(168, 330);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(70, 33);
            this.button2.TabIndex = 11;
            this.button2.Text = "DELETE";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Bauhaus 93", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Crimson;
            this.button1.Location = new System.Drawing.Point(25, 330);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(55, 33);
            this.button1.TabIndex = 10;
            this.button1.Text = "ADD";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // SellerMobile
            // 
            this.SellerMobile.Animated = true;
            this.SellerMobile.BorderColor = System.Drawing.Color.White;
            this.SellerMobile.BorderThickness = 3;
            this.SellerMobile.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.SellerMobile.DefaultText = "";
            this.SellerMobile.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.SellerMobile.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.SellerMobile.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.SellerMobile.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.SellerMobile.FillColor = System.Drawing.Color.Crimson;
            this.SellerMobile.FocusedState.BorderColor = System.Drawing.Color.White;
            this.SellerMobile.FocusedState.FillColor = System.Drawing.Color.Crimson;
            this.SellerMobile.FocusedState.ForeColor = System.Drawing.Color.White;
            this.SellerMobile.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.SellerMobile.ForeColor = System.Drawing.Color.White;
            this.SellerMobile.HoverState.BorderColor = System.Drawing.Color.Crimson;
            this.SellerMobile.Location = new System.Drawing.Point(25, 211);
            this.SellerMobile.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SellerMobile.Name = "SellerMobile";
            this.SellerMobile.PasswordChar = '\0';
            this.SellerMobile.PlaceholderForeColor = System.Drawing.Color.White;
            this.SellerMobile.PlaceholderText = "Mobile";
            this.SellerMobile.SelectedText = "";
            this.SellerMobile.Size = new System.Drawing.Size(192, 29);
            this.SellerMobile.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.SellerMobile.TabIndex = 6;
            // 
            // SellerAge
            // 
            this.SellerAge.Animated = true;
            this.SellerAge.BorderColor = System.Drawing.Color.White;
            this.SellerAge.BorderThickness = 3;
            this.SellerAge.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.SellerAge.DefaultText = "";
            this.SellerAge.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.SellerAge.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.SellerAge.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.SellerAge.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.SellerAge.FillColor = System.Drawing.Color.Crimson;
            this.SellerAge.FocusedState.BorderColor = System.Drawing.Color.White;
            this.SellerAge.FocusedState.FillColor = System.Drawing.Color.Crimson;
            this.SellerAge.FocusedState.ForeColor = System.Drawing.Color.White;
            this.SellerAge.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.SellerAge.ForeColor = System.Drawing.Color.White;
            this.SellerAge.HoverState.BorderColor = System.Drawing.Color.Crimson;
            this.SellerAge.Location = new System.Drawing.Point(25, 160);
            this.SellerAge.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SellerAge.Name = "SellerAge";
            this.SellerAge.PasswordChar = '\0';
            this.SellerAge.PlaceholderForeColor = System.Drawing.Color.White;
            this.SellerAge.PlaceholderText = "Age";
            this.SellerAge.SelectedText = "";
            this.SellerAge.Size = new System.Drawing.Size(192, 29);
            this.SellerAge.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.SellerAge.TabIndex = 5;
            // 
            // SellerName
            // 
            this.SellerName.Animated = true;
            this.SellerName.BorderColor = System.Drawing.Color.White;
            this.SellerName.BorderThickness = 3;
            this.SellerName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.SellerName.DefaultText = "";
            this.SellerName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.SellerName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.SellerName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.SellerName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.SellerName.FillColor = System.Drawing.Color.Crimson;
            this.SellerName.FocusedState.BorderColor = System.Drawing.Color.White;
            this.SellerName.FocusedState.FillColor = System.Drawing.Color.Crimson;
            this.SellerName.FocusedState.ForeColor = System.Drawing.Color.White;
            this.SellerName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.SellerName.ForeColor = System.Drawing.Color.White;
            this.SellerName.HoverState.BorderColor = System.Drawing.Color.Crimson;
            this.SellerName.Location = new System.Drawing.Point(25, 102);
            this.SellerName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SellerName.Name = "SellerName";
            this.SellerName.PasswordChar = '\0';
            this.SellerName.PlaceholderForeColor = System.Drawing.Color.White;
            this.SellerName.PlaceholderText = "Name";
            this.SellerName.SelectedText = "";
            this.SellerName.Size = new System.Drawing.Size(192, 29);
            this.SellerName.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.SellerName.TabIndex = 4;
            // 
            // SellerId
            // 
            this.SellerId.Animated = true;
            this.SellerId.BorderColor = System.Drawing.Color.White;
            this.SellerId.BorderThickness = 3;
            this.SellerId.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.SellerId.DefaultText = "";
            this.SellerId.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.SellerId.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.SellerId.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.SellerId.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.SellerId.FillColor = System.Drawing.Color.Crimson;
            this.SellerId.FocusedState.BorderColor = System.Drawing.Color.White;
            this.SellerId.FocusedState.FillColor = System.Drawing.Color.Crimson;
            this.SellerId.FocusedState.ForeColor = System.Drawing.Color.White;
            this.SellerId.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.SellerId.ForeColor = System.Drawing.Color.White;
            this.SellerId.HoverState.BorderColor = System.Drawing.Color.Crimson;
            this.SellerId.Location = new System.Drawing.Point(25, 55);
            this.SellerId.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SellerId.Name = "SellerId";
            this.SellerId.PasswordChar = '\0';
            this.SellerId.PlaceholderForeColor = System.Drawing.Color.White;
            this.SellerId.PlaceholderText = "ID";
            this.SellerId.SelectedText = "";
            this.SellerId.Size = new System.Drawing.Size(192, 29);
            this.SellerId.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.SellerId.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(252, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(237, 33);
            this.label2.TabIndex = 2;
            this.label2.Text = "MANAGE SELLERS";
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Transparent;
            this.button7.FlatAppearance.BorderColor = System.Drawing.Color.Crimson;
            this.button7.FlatAppearance.BorderSize = 2;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.Color.Crimson;
            this.button7.Location = new System.Drawing.Point(3, 172);
            this.button7.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(98, 37);
            this.button7.TabIndex = 22;
            this.button7.Text = "Categories";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Transparent;
            this.button6.FlatAppearance.BorderColor = System.Drawing.Color.Crimson;
            this.button6.FlatAppearance.BorderSize = 2;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.Crimson;
            this.button6.Location = new System.Drawing.Point(3, 102);
            this.button6.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(98, 33);
            this.button6.TabIndex = 21;
            this.button6.Text = "Products";
            this.button6.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Transparent;
            this.button5.FlatAppearance.BorderColor = System.Drawing.Color.Crimson;
            this.button5.FlatAppearance.BorderSize = 2;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.Crimson;
            this.button5.Location = new System.Drawing.Point(3, 241);
            this.button5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(98, 40);
            this.button5.TabIndex = 20;
            this.button5.Text = "Selling";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // ManageSellers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 497);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ManageSellers";
            this.Text = "ManageSellers";
            this.Load += new System.EventHandler(this.ManageSellers_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private Guna.UI2.WinForms.Guna2TextBox SellerMobile;
        private Guna.UI2.WinForms.Guna2TextBox SellerAge;
        private Guna.UI2.WinForms.Guna2TextBox SellerName;
        private Guna.UI2.WinForms.Guna2TextBox SellerId;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox SellerPass;
        private System.Windows.Forms.DataGridView DGV3;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
    }
}