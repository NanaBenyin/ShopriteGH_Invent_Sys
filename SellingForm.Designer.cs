namespace ShopRite_IMS
{
    partial class SellingForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle28 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle29 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle30 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle31 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle32 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle33 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle34 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle35 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle36 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SellingForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.DGV7 = new System.Windows.Forms.DataGridView();
            this.Ghc = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.Seller1 = new System.Windows.Forms.Label();
            this.date1 = new System.Windows.Forms.Label();
            this.DGV6 = new System.Windows.Forms.DataGridView();
            this.ORDERDGV = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.ProdQty = new Guna.UI2.WinForms.Guna2TextBox();
            this.ProdPrice = new Guna.UI2.WinForms.Guna2TextBox();
            this.Prodname = new Guna.UI2.WinForms.Guna2TextBox();
            this.BILLID = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ORDERDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Crimson;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.DGV7);
            this.panel1.Controls.Add(this.Ghc);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.Seller1);
            this.panel1.Controls.Add(this.date1);
            this.panel1.Controls.Add(this.DGV6);
            this.panel1.Controls.Add(this.ORDERDGV);
            this.panel1.Controls.Add(this.comboBox2);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.ProdQty);
            this.panel1.Controls.Add(this.ProdPrice);
            this.panel1.Controls.Add(this.Prodname);
            this.panel1.Controls.Add(this.BILLID);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(-5, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1202, 761);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 15.8F);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(657, 442);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 33);
            this.label5.TabIndex = 28;
            this.label5.Text = "SALES LIST";
            // 
            // DGV7
            // 
            this.DGV7.AllowUserToOrderColumns = true;
            this.DGV7.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV7.BackgroundColor = System.Drawing.Color.White;
            this.DGV7.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGV7.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DGV7.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle28.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle28.BackColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle28.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle28.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle28.SelectionBackColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle28.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle28.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV7.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle28;
            this.DGV7.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle29.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle29.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle29.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle29.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle29.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle29.SelectionBackColor = System.Drawing.SystemColors.MenuBar;
            dataGridViewCellStyle29.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle29.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGV7.DefaultCellStyle = dataGridViewCellStyle29;
            this.DGV7.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.DGV7.EnableHeadersVisualStyles = false;
            this.DGV7.Location = new System.Drawing.Point(427, 482);
            this.DGV7.Margin = new System.Windows.Forms.Padding(0);
            this.DGV7.MultiSelect = false;
            this.DGV7.Name = "DGV7";
            this.DGV7.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle30.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle30.BackColor = System.Drawing.Color.Crimson;
            dataGridViewCellStyle30.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle30.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle30.SelectionBackColor = System.Drawing.Color.Crimson;
            dataGridViewCellStyle30.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle30.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGV7.RowHeadersDefaultCellStyle = dataGridViewCellStyle30;
            this.DGV7.RowHeadersVisible = false;
            this.DGV7.RowHeadersWidth = 100;
            this.DGV7.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV7.RowTemplate.Height = 24;
            this.DGV7.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV7.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV7.Size = new System.Drawing.Size(724, 199);
            this.DGV7.TabIndex = 27;
            this.DGV7.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV7_CellContentClick);
            // 
            // Ghc
            // 
            this.Ghc.AutoSize = true;
            this.Ghc.Font = new System.Drawing.Font("Century Gothic", 12.2F);
            this.Ghc.ForeColor = System.Drawing.Color.White;
            this.Ghc.Location = new System.Drawing.Point(782, 401);
            this.Ghc.Name = "Ghc";
            this.Ghc.Size = new System.Drawing.Size(59, 24);
            this.Ghc.TabIndex = 26;
            this.Ghc.Text = "GHC";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12.2F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(617, 401);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 24);
            this.label1.TabIndex = 25;
            this.label1.Text = "AMOUNT";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.White;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Bauhaus 93", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.Crimson;
            this.button4.Location = new System.Drawing.Point(692, 698);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(89, 41);
            this.button4.TabIndex = 24;
            this.button4.Text = "PRINT";
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
            this.button2.Location = new System.Drawing.Point(786, 698);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 41);
            this.button2.TabIndex = 23;
            this.button2.Text = "DELETE";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Bauhaus 93", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Crimson;
            this.button1.Location = new System.Drawing.Point(595, 698);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 41);
            this.button1.TabIndex = 22;
            this.button1.Text = "ADD";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.White;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Bauhaus 93", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.Crimson;
            this.button5.Location = new System.Drawing.Point(110, 298);
            this.button5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(170, 41);
            this.button5.TabIndex = 21;
            this.button5.Text = "Add Product";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Seller1
            // 
            this.Seller1.AutoSize = true;
            this.Seller1.Font = new System.Drawing.Font("Century Gothic", 12.8F);
            this.Seller1.ForeColor = System.Drawing.Color.White;
            this.Seller1.Location = new System.Drawing.Point(95, 35);
            this.Seller1.Name = "Seller1";
            this.Seller1.Size = new System.Drawing.Size(70, 25);
            this.Seller1.TabIndex = 20;
            this.Seller1.Text = "Seller";
            // 
            // date1
            // 
            this.date1.AutoSize = true;
            this.date1.Font = new System.Drawing.Font("Century Gothic", 12.8F);
            this.date1.ForeColor = System.Drawing.Color.White;
            this.date1.Location = new System.Drawing.Point(851, 35);
            this.date1.Name = "date1";
            this.date1.Size = new System.Drawing.Size(65, 25);
            this.date1.TabIndex = 19;
            this.date1.Text = "Date";
            this.date1.Click += new System.EventHandler(this.date1_Click);
            // 
            // DGV6
            // 
            this.DGV6.AllowUserToOrderColumns = true;
            this.DGV6.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV6.BackgroundColor = System.Drawing.Color.White;
            this.DGV6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGV6.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DGV6.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle31.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle31.BackColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle31.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle31.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle31.SelectionBackColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle31.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle31.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV6.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle31;
            this.DGV6.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle32.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle32.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle32.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle32.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle32.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle32.SelectionBackColor = System.Drawing.SystemColors.MenuBar;
            dataGridViewCellStyle32.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle32.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGV6.DefaultCellStyle = dataGridViewCellStyle32;
            this.DGV6.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.DGV6.EnableHeadersVisualStyles = false;
            this.DGV6.Location = new System.Drawing.Point(44, 401);
            this.DGV6.Margin = new System.Windows.Forms.Padding(0);
            this.DGV6.MultiSelect = false;
            this.DGV6.Name = "DGV6";
            this.DGV6.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle33.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle33.BackColor = System.Drawing.Color.Crimson;
            dataGridViewCellStyle33.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle33.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle33.SelectionBackColor = System.Drawing.Color.Crimson;
            dataGridViewCellStyle33.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle33.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGV6.RowHeadersDefaultCellStyle = dataGridViewCellStyle33;
            this.DGV6.RowHeadersVisible = false;
            this.DGV6.RowHeadersWidth = 100;
            this.DGV6.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV6.RowTemplate.Height = 24;
            this.DGV6.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV6.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV6.Size = new System.Drawing.Size(297, 338);
            this.DGV6.TabIndex = 18;
            this.DGV6.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV5_CellContentClick);
            // 
            // ORDERDGV
            // 
            this.ORDERDGV.AllowUserToOrderColumns = true;
            this.ORDERDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ORDERDGV.BackgroundColor = System.Drawing.Color.White;
            this.ORDERDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ORDERDGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.ORDERDGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle34.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle34.BackColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle34.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle34.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle34.SelectionBackColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle34.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle34.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ORDERDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle34;
            this.ORDERDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ORDERDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.PName,
            this.Price,
            this.Qty,
            this.TotalP});
            dataGridViewCellStyle35.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle35.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle35.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle35.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle35.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle35.SelectionBackColor = System.Drawing.SystemColors.MenuBar;
            dataGridViewCellStyle35.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle35.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ORDERDGV.DefaultCellStyle = dataGridViewCellStyle35;
            this.ORDERDGV.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.ORDERDGV.EnableHeadersVisualStyles = false;
            this.ORDERDGV.Location = new System.Drawing.Point(427, 113);
            this.ORDERDGV.Margin = new System.Windows.Forms.Padding(0);
            this.ORDERDGV.MultiSelect = false;
            this.ORDERDGV.Name = "ORDERDGV";
            this.ORDERDGV.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle36.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle36.BackColor = System.Drawing.Color.Crimson;
            dataGridViewCellStyle36.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle36.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle36.SelectionBackColor = System.Drawing.Color.Crimson;
            dataGridViewCellStyle36.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle36.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ORDERDGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle36;
            this.ORDERDGV.RowHeadersVisible = false;
            this.ORDERDGV.RowHeadersWidth = 100;
            this.ORDERDGV.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ORDERDGV.RowTemplate.Height = 24;
            this.ORDERDGV.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ORDERDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ORDERDGV.Size = new System.Drawing.Size(724, 273);
            this.ORDERDGV.TabIndex = 17;
            // 
            // Id
            // 
            this.Id.HeaderText = "ProdId";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            // 
            // PName
            // 
            this.PName.HeaderText = "ProdName";
            this.PName.MinimumWidth = 6;
            this.PName.Name = "PName";
            // 
            // Price
            // 
            this.Price.HeaderText = "ProdPrice";
            this.Price.MinimumWidth = 6;
            this.Price.Name = "Price";
            // 
            // Qty
            // 
            this.Qty.HeaderText = "ProdQty";
            this.Qty.MinimumWidth = 6;
            this.Qty.Name = "Qty";
            // 
            // TotalP
            // 
            this.TotalP.HeaderText = "Total";
            this.TotalP.MinimumWidth = 6;
            this.TotalP.Name = "TotalP";
            // 
            // comboBox2
            // 
            this.comboBox2.BackColor = System.Drawing.Color.White;
            this.comboBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.comboBox2.ForeColor = System.Drawing.Color.Crimson;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Admin",
            "Attendant"});
            this.comboBox2.Location = new System.Drawing.Point(44, 353);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(166, 33);
            this.comboBox2.Sorted = true;
            this.comboBox2.TabIndex = 14;
            this.comboBox2.Text = "Select Category";
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectionChangeCommitted);
            this.comboBox2.SelectionChangeCommitted += new System.EventHandler(this.comboBox2_SelectionChangeCommitted);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Bauhaus 93", 13.4F);
            this.button3.ForeColor = System.Drawing.Color.Crimson;
            this.button3.Location = new System.Drawing.Point(227, 353);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(114, 36);
            this.button3.TabIndex = 12;
            this.button3.Text = "Refresh";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // ProdQty
            // 
            this.ProdQty.Animated = true;
            this.ProdQty.BorderColor = System.Drawing.Color.White;
            this.ProdQty.BorderThickness = 3;
            this.ProdQty.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ProdQty.DefaultText = "";
            this.ProdQty.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.ProdQty.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.ProdQty.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ProdQty.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ProdQty.FillColor = System.Drawing.Color.Crimson;
            this.ProdQty.FocusedState.BorderColor = System.Drawing.Color.White;
            this.ProdQty.FocusedState.FillColor = System.Drawing.Color.Crimson;
            this.ProdQty.FocusedState.ForeColor = System.Drawing.Color.White;
            this.ProdQty.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ProdQty.ForeColor = System.Drawing.Color.White;
            this.ProdQty.HoverState.BorderColor = System.Drawing.Color.Crimson;
            this.ProdQty.Location = new System.Drawing.Point(44, 248);
            this.ProdQty.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ProdQty.Name = "ProdQty";
            this.ProdQty.PasswordChar = '\0';
            this.ProdQty.PlaceholderForeColor = System.Drawing.Color.White;
            this.ProdQty.PlaceholderText = "Quantity";
            this.ProdQty.SelectedText = "";
            this.ProdQty.Size = new System.Drawing.Size(297, 36);
            this.ProdQty.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.ProdQty.TabIndex = 6;
            // 
            // ProdPrice
            // 
            this.ProdPrice.Animated = true;
            this.ProdPrice.BorderColor = System.Drawing.Color.White;
            this.ProdPrice.BorderThickness = 3;
            this.ProdPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ProdPrice.DefaultText = "";
            this.ProdPrice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.ProdPrice.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.ProdPrice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ProdPrice.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ProdPrice.FillColor = System.Drawing.Color.Crimson;
            this.ProdPrice.FocusedState.BorderColor = System.Drawing.Color.White;
            this.ProdPrice.FocusedState.FillColor = System.Drawing.Color.Crimson;
            this.ProdPrice.FocusedState.ForeColor = System.Drawing.Color.White;
            this.ProdPrice.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ProdPrice.ForeColor = System.Drawing.Color.White;
            this.ProdPrice.HoverState.BorderColor = System.Drawing.Color.Crimson;
            this.ProdPrice.Location = new System.Drawing.Point(44, 196);
            this.ProdPrice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ProdPrice.Name = "ProdPrice";
            this.ProdPrice.PasswordChar = '\0';
            this.ProdPrice.PlaceholderForeColor = System.Drawing.Color.White;
            this.ProdPrice.PlaceholderText = "Price";
            this.ProdPrice.SelectedText = "";
            this.ProdPrice.Size = new System.Drawing.Size(297, 37);
            this.ProdPrice.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.ProdPrice.TabIndex = 5;
            // 
            // Prodname
            // 
            this.Prodname.Animated = true;
            this.Prodname.BorderColor = System.Drawing.Color.White;
            this.Prodname.BorderThickness = 3;
            this.Prodname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Prodname.DefaultText = "";
            this.Prodname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Prodname.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Prodname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Prodname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Prodname.FillColor = System.Drawing.Color.Crimson;
            this.Prodname.FocusedState.BorderColor = System.Drawing.Color.White;
            this.Prodname.FocusedState.FillColor = System.Drawing.Color.Crimson;
            this.Prodname.FocusedState.ForeColor = System.Drawing.Color.White;
            this.Prodname.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Prodname.ForeColor = System.Drawing.Color.White;
            this.Prodname.HoverState.BorderColor = System.Drawing.Color.Crimson;
            this.Prodname.Location = new System.Drawing.Point(44, 151);
            this.Prodname.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Prodname.Name = "Prodname";
            this.Prodname.PasswordChar = '\0';
            this.Prodname.PlaceholderForeColor = System.Drawing.Color.White;
            this.Prodname.PlaceholderText = "ProdName";
            this.Prodname.SelectedText = "";
            this.Prodname.Size = new System.Drawing.Size(297, 27);
            this.Prodname.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.Prodname.TabIndex = 4;
            // 
            // BILLID
            // 
            this.BILLID.Animated = true;
            this.BILLID.BorderColor = System.Drawing.Color.White;
            this.BILLID.BorderThickness = 3;
            this.BILLID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.BILLID.DefaultText = "";
            this.BILLID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.BILLID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.BILLID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.BILLID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.BILLID.FillColor = System.Drawing.Color.Crimson;
            this.BILLID.FocusedState.BorderColor = System.Drawing.Color.White;
            this.BILLID.FocusedState.FillColor = System.Drawing.Color.Crimson;
            this.BILLID.FocusedState.ForeColor = System.Drawing.Color.White;
            this.BILLID.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BILLID.ForeColor = System.Drawing.Color.White;
            this.BILLID.HoverState.BorderColor = System.Drawing.Color.Crimson;
            this.BILLID.Location = new System.Drawing.Point(44, 94);
            this.BILLID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BILLID.Name = "BILLID";
            this.BILLID.PasswordChar = '\0';
            this.BILLID.PlaceholderForeColor = System.Drawing.Color.White;
            this.BILLID.PlaceholderText = "BILLID";
            this.BILLID.SelectedText = "";
            this.BILLID.Size = new System.Drawing.Size(297, 36);
            this.BILLID.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.BILLID.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(489, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 40);
            this.label2.TabIndex = 2;
            this.label2.Text = "SELLING";
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // SellingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1196, 761);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SellingForm";
            this.Text = "SellingForm";
            this.Load += new System.EventHandler(this.SellingForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ORDERDGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView ORDERDGV;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button button3;
        private Guna.UI2.WinForms.Guna2TextBox ProdQty;
        private Guna.UI2.WinForms.Guna2TextBox ProdPrice;
        private Guna.UI2.WinForms.Guna2TextBox Prodname;
        private Guna.UI2.WinForms.Guna2TextBox BILLID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label date1;
        private System.Windows.Forms.DataGridView DGV6;
        private System.Windows.Forms.Label Seller1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label Ghc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DGV7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn PName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalP;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}