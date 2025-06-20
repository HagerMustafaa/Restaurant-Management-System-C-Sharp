namespace Restaurant_Management_System
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            btnCalculate = new Button();
            btnSave = new Button();
            btnOpen = new Button();
            btncancel = new Button();
            btnUpdate = new Button();
            btnAdd2 = new Button();
            btnEdit2 = new Button();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            menu = new ListView();
            item_category = new ColumnHeader();
            item_name = new ColumnHeader();
            item_price = new ColumnHeader();
            item_options = new ColumnHeader();
            radbtnSmall = new RadioButton();
            radbtnMedium = new RadioButton();
            radbtnLarge = new RadioButton();
            groupbxDrinksize = new GroupBox();
            groupbxFlavors = new GroupBox();
            radbtnMild = new RadioButton();
            radbtnSpicy = new RadioButton();
            Quantity = new DataGridViewTextBoxColumn();
            Price = new DataGridViewTextBoxColumn();
            Item = new DataGridViewTextBoxColumn();
            Option = new DataGridViewTextBoxColumn();
            Category = new DataGridViewTextBoxColumn();
            dataGridView1 = new DataGridView();
            radbtnVanilla = new RadioButton();
            radbtnChocolate = new RadioButton();
            radbtnStrawberry = new RadioButton();
            radbtnBlueberry = new RadioButton();
            groupbxSauce = new GroupBox();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            label2 = new Label();
            lblWarning = new Label();
            txtQuantity = new TextBox();
            txtPrice = new TextBox();
            txtItem = new TextBox();
            btnAdd = new Button();
            btnUpdate1 = new Button();
            btnRemove = new Button();
            groupbxBill = new GroupBox();
            lblPrice = new Label();
            lblOption = new Label();
            lblItem = new Label();
            lblCategory = new Label();
            optionstxt = new TextBox();
            pricetxt = new TextBox();
            groupbxMenu = new GroupBox();
            lblWarning2 = new Label();
            itemtxt = new TextBox();
            categorytxt = new TextBox();
            panel2 = new Panel();
            pictureBox2 = new PictureBox();
            cmbCategory = new ComboBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupbxDrinksize.SuspendLayout();
            groupbxFlavors.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupbxSauce.SuspendLayout();
            groupbxBill.SuspendLayout();
            groupbxMenu.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // btnCalculate
            // 
            btnCalculate.BackColor = Color.FromArgb(89, 74, 71);
            btnCalculate.Font = new Font("Segoe Script", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCalculate.ForeColor = SystemColors.ButtonHighlight;
            btnCalculate.Location = new Point(420, 513);
            btnCalculate.Margin = new Padding(3, 2, 3, 2);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(108, 56);
            btnCalculate.TabIndex = 5;
            btnCalculate.Text = "Calculate";
            btnCalculate.UseVisualStyleBackColor = false;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(237, 240, 209);
            btnSave.Font = new Font("Arial", 9F, FontStyle.Bold);
            btnSave.Location = new Point(267, 519);
            btnSave.Margin = new Padding(3, 2, 3, 2);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 50);
            btnSave.TabIndex = 17;
            btnSave.Text = "Save ";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnOpen
            // 
            btnOpen.BackColor = Color.FromArgb(237, 240, 209);
            btnOpen.Font = new Font("Arial", 9F, FontStyle.Bold);
            btnOpen.Location = new Point(159, 518);
            btnOpen.Margin = new Padding(3, 2, 3, 2);
            btnOpen.Name = "btnOpen";
            btnOpen.Size = new Size(74, 51);
            btnOpen.TabIndex = 18;
            btnOpen.Text = "Open";
            btnOpen.UseVisualStyleBackColor = false;
            btnOpen.Click += btnOpen_Click;
            // 
            // btncancel
            // 
            btncancel.BackColor = Color.FromArgb(198, 40, 40);
            btncancel.Font = new Font("Segoe Script", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btncancel.ForeColor = Color.White;
            btncancel.Location = new Point(354, 185);
            btncancel.Name = "btncancel";
            btncancel.Size = new Size(73, 32);
            btncancel.TabIndex = 31;
            btncancel.Text = "Cancel";
            btncancel.UseVisualStyleBackColor = false;
            btncancel.Click += btncancel_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.FromArgb(149, 152, 64);
            btnUpdate.Font = new Font("Segoe Script", 10.2F, FontStyle.Bold);
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(268, 185);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(81, 32);
            btnUpdate.TabIndex = 32;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click_1;
            // 
            // btnAdd2
            // 
            btnAdd2.BackColor = Color.FromArgb(149, 152, 64);
            btnAdd2.Font = new Font("Segoe Script", 10.2F, FontStyle.Bold);
            btnAdd2.ForeColor = Color.White;
            btnAdd2.Location = new Point(94, 185);
            btnAdd2.Name = "btnAdd2";
            btnAdd2.Size = new Size(81, 32);
            btnAdd2.TabIndex = 33;
            btnAdd2.Text = "Add";
            btnAdd2.UseVisualStyleBackColor = false;
            btnAdd2.Click += btnAdd2_Click;
            // 
            // btnEdit2
            // 
            btnEdit2.BackColor = Color.FromArgb(149, 152, 64);
            btnEdit2.Font = new Font("Segoe Script", 10.2F, FontStyle.Bold);
            btnEdit2.ForeColor = Color.White;
            btnEdit2.Location = new Point(181, 185);
            btnEdit2.Name = "btnEdit2";
            btnEdit2.Size = new Size(81, 32);
            btnEdit2.TabIndex = 34;
            btnEdit2.Text = "Edit";
            btnEdit2.UseVisualStyleBackColor = false;
            btnEdit2.Click += btnEdit2_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(570, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(597, 90);
            panel1.TabIndex = 15;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.coverr;
            pictureBox1.Location = new Point(-714, -22);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(2069, 203);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // menu
            // 
            menu.BackColor = Color.FromArgb(215, 213, 178);
            menu.Columns.AddRange(new ColumnHeader[] { item_category, item_name, item_price, item_options });
            menu.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            menu.Location = new Point(65, 241);
            menu.Name = "menu";
            menu.Size = new Size(399, 258);
            menu.TabIndex = 20;
            menu.UseCompatibleStateImageBehavior = false;
            menu.View = View.Details;
            menu.SelectedIndexChanged += menu_SelectedIndexChanged;
            // 
            // item_category
            // 
            item_category.Text = "Category";
            item_category.Width = 100;
            // 
            // item_name
            // 
            item_name.Text = "Item";
            item_name.Width = 100;
            // 
            // item_price
            // 
            item_price.Text = "Price";
            item_price.Width = 50;
            // 
            // item_options
            // 
            item_options.Text = "Options";
            item_options.Width = 110;
            // 
            // radbtnSmall
            // 
            radbtnSmall.AutoSize = true;
            radbtnSmall.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            radbtnSmall.Location = new Point(11, 19);
            radbtnSmall.Margin = new Padding(3, 2, 3, 2);
            radbtnSmall.Name = "radbtnSmall";
            radbtnSmall.Size = new Size(55, 19);
            radbtnSmall.TabIndex = 0;
            radbtnSmall.TabStop = true;
            radbtnSmall.Text = "Small";
            radbtnSmall.UseVisualStyleBackColor = true;
            // 
            // radbtnMedium
            // 
            radbtnMedium.AutoSize = true;
            radbtnMedium.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            radbtnMedium.Location = new Point(11, 41);
            radbtnMedium.Margin = new Padding(3, 2, 3, 2);
            radbtnMedium.Name = "radbtnMedium";
            radbtnMedium.Size = new Size(70, 19);
            radbtnMedium.TabIndex = 1;
            radbtnMedium.TabStop = true;
            radbtnMedium.Text = "Medium";
            radbtnMedium.UseVisualStyleBackColor = true;
            // 
            // radbtnLarge
            // 
            radbtnLarge.AutoSize = true;
            radbtnLarge.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            radbtnLarge.Location = new Point(11, 62);
            radbtnLarge.Margin = new Padding(3, 2, 3, 2);
            radbtnLarge.Name = "radbtnLarge";
            radbtnLarge.Size = new Size(54, 19);
            radbtnLarge.TabIndex = 2;
            radbtnLarge.TabStop = true;
            radbtnLarge.Text = "Large";
            radbtnLarge.UseVisualStyleBackColor = true;
            // 
            // groupbxDrinksize
            // 
            groupbxDrinksize.BackColor = Color.FromArgb(250, 251, 242);
            groupbxDrinksize.Controls.Add(radbtnLarge);
            groupbxDrinksize.Controls.Add(radbtnMedium);
            groupbxDrinksize.Controls.Add(radbtnSmall);
            groupbxDrinksize.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            groupbxDrinksize.Location = new Point(278, 75);
            groupbxDrinksize.Margin = new Padding(3, 2, 3, 2);
            groupbxDrinksize.Name = "groupbxDrinksize";
            groupbxDrinksize.Padding = new Padding(3, 2, 3, 2);
            groupbxDrinksize.Size = new Size(109, 82);
            groupbxDrinksize.TabIndex = 15;
            groupbxDrinksize.TabStop = false;
            groupbxDrinksize.Text = "Size";
            groupbxDrinksize.Visible = false;
            // 
            // groupbxFlavors
            // 
            groupbxFlavors.BackColor = Color.FromArgb(250, 251, 242);
            groupbxFlavors.Controls.Add(radbtnMild);
            groupbxFlavors.Controls.Add(radbtnSpicy);
            groupbxFlavors.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            groupbxFlavors.Location = new Point(256, 72);
            groupbxFlavors.Margin = new Padding(3, 2, 3, 2);
            groupbxFlavors.Name = "groupbxFlavors";
            groupbxFlavors.Padding = new Padding(3, 2, 3, 2);
            groupbxFlavors.Size = new Size(109, 82);
            groupbxFlavors.TabIndex = 16;
            groupbxFlavors.TabStop = false;
            groupbxFlavors.Text = "Flavors";
            groupbxFlavors.Visible = false;
            // 
            // radbtnMild
            // 
            radbtnMild.AutoSize = true;
            radbtnMild.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            radbtnMild.Location = new Point(11, 41);
            radbtnMild.Margin = new Padding(3, 2, 3, 2);
            radbtnMild.Name = "radbtnMild";
            radbtnMild.Size = new Size(49, 19);
            radbtnMild.TabIndex = 1;
            radbtnMild.TabStop = true;
            radbtnMild.Text = "Mild";
            radbtnMild.UseVisualStyleBackColor = true;
            // 
            // radbtnSpicy
            // 
            radbtnSpicy.AutoSize = true;
            radbtnSpicy.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            radbtnSpicy.Location = new Point(11, 19);
            radbtnSpicy.Margin = new Padding(3, 2, 3, 2);
            radbtnSpicy.Name = "radbtnSpicy";
            radbtnSpicy.Size = new Size(54, 19);
            radbtnSpicy.TabIndex = 0;
            radbtnSpicy.TabStop = true;
            radbtnSpicy.Text = "Spicy";
            radbtnSpicy.UseVisualStyleBackColor = true;
            // 
            // Quantity
            // 
            dataGridViewCellStyle1.BackColor = Color.FromArgb(224, 224, 224);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            Quantity.DefaultCellStyle = dataGridViewCellStyle1;
            Quantity.HeaderText = "Quantity";
            Quantity.MinimumWidth = 6;
            Quantity.Name = "Quantity";
            Quantity.Width = 125;
            // 
            // Price
            // 
            dataGridViewCellStyle2.BackColor = Color.FromArgb(224, 224, 224);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            Price.DefaultCellStyle = dataGridViewCellStyle2;
            Price.HeaderText = "Price";
            Price.MinimumWidth = 6;
            Price.Name = "Price";
            Price.Width = 125;
            // 
            // Item
            // 
            dataGridViewCellStyle3.BackColor = Color.FromArgb(224, 224, 224);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            Item.DefaultCellStyle = dataGridViewCellStyle3;
            Item.HeaderText = "Item";
            Item.MinimumWidth = 6;
            Item.Name = "Item";
            Item.Width = 125;
            // 
            // Option
            // 
            dataGridViewCellStyle4.BackColor = Color.FromArgb(224, 224, 224);
            dataGridViewCellStyle4.ForeColor = Color.Black;
            Option.DefaultCellStyle = dataGridViewCellStyle4;
            Option.HeaderText = "Option";
            Option.MinimumWidth = 6;
            Option.Name = "Option";
            Option.Width = 125;
            // 
            // Category
            // 
            dataGridViewCellStyle5.BackColor = Color.FromArgb(224, 224, 224);
            dataGridViewCellStyle5.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle5.ForeColor = Color.Black;
            Category.DefaultCellStyle = dataGridViewCellStyle5;
            Category.HeaderText = "Category";
            Category.MinimumWidth = 6;
            Category.Name = "Category";
            Category.Width = 125;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            dataGridView1.BackgroundColor = Color.FromArgb(235, 228, 215);
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = SystemColors.Control;
            dataGridViewCellStyle7.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            dataGridViewCellStyle7.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Category, Option, Item, Price, Quantity });
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = SystemColors.Window;
            dataGridViewCellStyle8.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle8.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle8;
            dataGridView1.Location = new Point(4, 241);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(582, 210);
            dataGridView1.TabIndex = 19;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // radbtnVanilla
            // 
            radbtnVanilla.AutoSize = true;
            radbtnVanilla.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            radbtnVanilla.Location = new Point(11, 19);
            radbtnVanilla.Margin = new Padding(3, 2, 3, 2);
            radbtnVanilla.Name = "radbtnVanilla";
            radbtnVanilla.Size = new Size(60, 19);
            radbtnVanilla.TabIndex = 0;
            radbtnVanilla.TabStop = true;
            radbtnVanilla.Text = "Vanilla";
            radbtnVanilla.UseVisualStyleBackColor = true;
            // 
            // radbtnChocolate
            // 
            radbtnChocolate.AutoSize = true;
            radbtnChocolate.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            radbtnChocolate.Location = new Point(11, 40);
            radbtnChocolate.Margin = new Padding(3, 2, 3, 2);
            radbtnChocolate.Name = "radbtnChocolate";
            radbtnChocolate.Size = new Size(78, 19);
            radbtnChocolate.TabIndex = 1;
            radbtnChocolate.TabStop = true;
            radbtnChocolate.Text = "Chocolate";
            radbtnChocolate.UseVisualStyleBackColor = true;
            // 
            // radbtnStrawberry
            // 
            radbtnStrawberry.AutoSize = true;
            radbtnStrawberry.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            radbtnStrawberry.Location = new Point(11, 63);
            radbtnStrawberry.Margin = new Padding(3, 2, 3, 2);
            radbtnStrawberry.Name = "radbtnStrawberry";
            radbtnStrawberry.Size = new Size(82, 19);
            radbtnStrawberry.TabIndex = 2;
            radbtnStrawberry.TabStop = true;
            radbtnStrawberry.Text = "Strawberry";
            radbtnStrawberry.UseVisualStyleBackColor = true;
            // 
            // radbtnBlueberry
            // 
            radbtnBlueberry.AutoSize = true;
            radbtnBlueberry.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            radbtnBlueberry.Location = new Point(11, 86);
            radbtnBlueberry.Margin = new Padding(3, 2, 3, 2);
            radbtnBlueberry.Name = "radbtnBlueberry";
            radbtnBlueberry.Size = new Size(75, 19);
            radbtnBlueberry.TabIndex = 3;
            radbtnBlueberry.TabStop = true;
            radbtnBlueberry.Text = "Blueberry";
            radbtnBlueberry.UseVisualStyleBackColor = true;
            // 
            // groupbxSauce
            // 
            groupbxSauce.BackColor = Color.FromArgb(250, 251, 242);
            groupbxSauce.Controls.Add(radbtnBlueberry);
            groupbxSauce.Controls.Add(radbtnStrawberry);
            groupbxSauce.Controls.Add(radbtnChocolate);
            groupbxSauce.Controls.Add(radbtnVanilla);
            groupbxSauce.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            groupbxSauce.Location = new Point(284, 77);
            groupbxSauce.Margin = new Padding(3, 2, 3, 2);
            groupbxSauce.Name = "groupbxSauce";
            groupbxSauce.Padding = new Padding(3, 2, 3, 2);
            groupbxSauce.Size = new Size(114, 111);
            groupbxSauce.TabIndex = 15;
            groupbxSauce.TabStop = false;
            groupbxSauce.Text = "Sauce";
            groupbxSauce.Visible = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(8, 76);
            label1.Name = "label1";
            label1.Size = new Size(68, 19);
            label1.TabIndex = 10;
            label1.Text = "Category";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(24, 101);
            label3.Name = "label3";
            label3.Size = new Size(38, 19);
            label3.TabIndex = 11;
            label3.Text = "Item";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.White;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.Location = new Point(20, 124);
            label4.Name = "label4";
            label4.Size = new Size(41, 19);
            label4.TabIndex = 12;
            label4.Text = "Price";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(8, 151);
            label2.Name = "label2";
            label2.Size = new Size(66, 19);
            label2.TabIndex = 13;
            label2.Text = "Quantity";
            // 
            // lblWarning
            // 
            lblWarning.AutoSize = true;
            lblWarning.BackColor = Color.Transparent;
            lblWarning.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 0);
            lblWarning.ForeColor = Color.Red;
            lblWarning.Location = new Point(66, 185);
            lblWarning.Name = "lblWarning";
            lblWarning.Size = new Size(20, 15);
            lblWarning.TabIndex = 16;
            lblWarning.Text = "\" \"";
            lblWarning.Visible = false;
            lblWarning.Click += lblWarning_Click;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(653, 245);
            txtQuantity.Margin = new Padding(3, 2, 3, 2);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(110, 23);
            txtQuantity.TabIndex = 3;
            txtQuantity.KeyPress += txtQuantity_KeyPress;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(653, 220);
            txtPrice.Margin = new Padding(3, 2, 3, 2);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(110, 23);
            txtPrice.TabIndex = 2;
            txtPrice.KeyPress += txtPrice_KeyPress;
            // 
            // txtItem
            // 
            txtItem.Location = new Point(653, 196);
            txtItem.Margin = new Padding(3, 2, 3, 2);
            txtItem.Name = "txtItem";
            txtItem.Size = new Size(110, 23);
            txtItem.TabIndex = 1;
            txtItem.TextChanged += txtItem_TextChanged;
            txtItem.KeyPress += txtItem_KeyPress;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(149, 152, 64);
            btnAdd.Font = new Font("Segoe Script", 10.2F, FontStyle.Bold);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(97, 525);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(81, 32);
            btnAdd.TabIndex = 39;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate1
            // 
            btnUpdate1.BackColor = Color.FromArgb(149, 152, 64);
            btnUpdate1.Font = new Font("Segoe Script", 10.2F, FontStyle.Bold);
            btnUpdate1.ForeColor = Color.White;
            btnUpdate1.Location = new Point(200, 525);
            btnUpdate1.Name = "btnUpdate1";
            btnUpdate1.Size = new Size(81, 32);
            btnUpdate1.TabIndex = 40;
            btnUpdate1.Text = "Update";
            btnUpdate1.UseVisualStyleBackColor = false;
            btnUpdate1.Click += btnUpdate1_Click_1;
            // 
            // btnRemove
            // 
            btnRemove.BackColor = Color.FromArgb(198, 40, 40);
            btnRemove.Font = new Font("Segoe Script", 10.2F, FontStyle.Bold);
            btnRemove.ForeColor = Color.White;
            btnRemove.Location = new Point(306, 525);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(81, 32);
            btnRemove.TabIndex = 41;
            btnRemove.Text = "Remove";
            btnRemove.UseVisualStyleBackColor = false;
            btnRemove.Click += btnRemove_Click;
            btnRemove.MouseEnter += btnRemove_MouseEnter_1;
            btnRemove.MouseLeave += btnRemove_MouseLeave_1;
            btnRemove.MouseHover += btnRemove_MouseHover;
            // 
            // groupbxBill
            // 
            groupbxBill.BackColor = Color.FromArgb(250, 251, 242);
            groupbxBill.Controls.Add(btnUpdate1);
            groupbxBill.Controls.Add(groupbxFlavors);
            groupbxBill.Controls.Add(label4);
            groupbxBill.Controls.Add(groupbxDrinksize);
            groupbxBill.Controls.Add(groupbxSauce);
            groupbxBill.Controls.Add(btnRemove);
            groupbxBill.Controls.Add(label3);
            groupbxBill.Controls.Add(btnAdd);
            groupbxBill.Controls.Add(label2);
            groupbxBill.Controls.Add(lblWarning);
            groupbxBill.Controls.Add(label1);
            groupbxBill.Controls.Add(dataGridView1);
            groupbxBill.Controls.Add(btnCalculate);
            groupbxBill.Font = new Font("Brush Script MT", 19.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            groupbxBill.Location = new Point(570, 94);
            groupbxBill.Margin = new Padding(3, 2, 3, 2);
            groupbxBill.Name = "groupbxBill";
            groupbxBill.Padding = new Padding(3, 2, 3, 2);
            groupbxBill.Size = new Size(585, 589);
            groupbxBill.TabIndex = 43;
            groupbxBill.TabStop = false;
            groupbxBill.Text = "Bill";
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.BackColor = Color.White;
            lblPrice.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblPrice.Location = new Point(58, 117);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(41, 19);
            lblPrice.TabIndex = 37;
            lblPrice.Text = "Price";
            // 
            // lblOption
            // 
            lblOption.AutoSize = true;
            lblOption.BackColor = Color.White;
            lblOption.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblOption.Location = new Point(255, 118);
            lblOption.Name = "lblOption";
            lblOption.Size = new Size(53, 19);
            lblOption.TabIndex = 38;
            lblOption.Text = "Option";
            // 
            // lblItem
            // 
            lblItem.AutoSize = true;
            lblItem.BackColor = Color.White;
            lblItem.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblItem.Location = new Point(267, 86);
            lblItem.Name = "lblItem";
            lblItem.Size = new Size(38, 19);
            lblItem.TabIndex = 36;
            lblItem.Text = "Item";
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.BackColor = Color.White;
            lblCategory.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblCategory.Location = new Point(42, 83);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(68, 19);
            lblCategory.TabIndex = 35;
            lblCategory.Text = "Category";
            // 
            // optionstxt
            // 
            optionstxt.Font = new Font("Segoe UI", 9F);
            optionstxt.Location = new Point(316, 117);
            optionstxt.Multiline = true;
            optionstxt.Name = "optionstxt";
            optionstxt.Size = new Size(112, 21);
            optionstxt.TabIndex = 24;
            optionstxt.TextChanged += optionstxt_TextChanged;
            optionstxt.KeyPress += optionstxt_KeyPress;
            // 
            // pricetxt
            // 
            pricetxt.Font = new Font("Segoe UI", 9F);
            pricetxt.Location = new Point(130, 116);
            pricetxt.Multiline = true;
            pricetxt.Name = "pricetxt";
            pricetxt.Size = new Size(112, 21);
            pricetxt.TabIndex = 21;
            pricetxt.TextChanged += pricetxt_TextChanged;
            pricetxt.KeyPress += pricetxt_KeyPress;
            // 
            // groupbxMenu
            // 
            groupbxMenu.BackColor = Color.FromArgb(255, 251, 247);
            groupbxMenu.Controls.Add(lblWarning2);
            groupbxMenu.Controls.Add(itemtxt);
            groupbxMenu.Controls.Add(lblOption);
            groupbxMenu.Controls.Add(btnUpdate);
            groupbxMenu.Controls.Add(lblPrice);
            groupbxMenu.Controls.Add(btncancel);
            groupbxMenu.Controls.Add(lblItem);
            groupbxMenu.Controls.Add(btnAdd2);
            groupbxMenu.Controls.Add(lblCategory);
            groupbxMenu.Controls.Add(btnEdit2);
            groupbxMenu.Controls.Add(categorytxt);
            groupbxMenu.Controls.Add(btnOpen);
            groupbxMenu.Controls.Add(optionstxt);
            groupbxMenu.Controls.Add(pricetxt);
            groupbxMenu.Controls.Add(btnSave);
            groupbxMenu.Controls.Add(menu);
            groupbxMenu.Font = new Font("Brush Script MT", 19.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            groupbxMenu.Location = new Point(10, 94);
            groupbxMenu.Margin = new Padding(3, 2, 3, 2);
            groupbxMenu.Name = "groupbxMenu";
            groupbxMenu.Padding = new Padding(3, 2, 3, 2);
            groupbxMenu.Size = new Size(530, 589);
            groupbxMenu.TabIndex = 44;
            groupbxMenu.TabStop = false;
            groupbxMenu.Text = "Menu";
            // 
            // lblWarning2
            // 
            lblWarning2.AutoSize = true;
            lblWarning2.BackColor = Color.Transparent;
            lblWarning2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 0);
            lblWarning2.ForeColor = Color.Red;
            lblWarning2.Location = new Point(107, 152);
            lblWarning2.Name = "lblWarning2";
            lblWarning2.Size = new Size(20, 15);
            lblWarning2.TabIndex = 46;
            lblWarning2.Text = "\" \"";
            lblWarning2.Visible = false;
            // 
            // itemtxt
            // 
            itemtxt.Font = new Font("Segoe UI", 9F);
            itemtxt.Location = new Point(316, 83);
            itemtxt.Multiline = true;
            itemtxt.Name = "itemtxt";
            itemtxt.Size = new Size(112, 21);
            itemtxt.TabIndex = 45;
            itemtxt.TextChanged += itemtxt_TextChanged_1;
            itemtxt.KeyPress += itemtxt_KeyPress;
            // 
            // categorytxt
            // 
            categorytxt.Font = new Font("Segoe UI", 9F);
            categorytxt.Location = new Point(130, 83);
            categorytxt.Multiline = true;
            categorytxt.Name = "categorytxt";
            categorytxt.Size = new Size(112, 21);
            categorytxt.TabIndex = 22;
            categorytxt.TextChanged += categorytxt_TextChanged;
            categorytxt.KeyPress += categorytxt_KeyPress;
            // 
            // panel2
            // 
            panel2.Controls.Add(pictureBox2);
            panel2.Location = new Point(-3, 0);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(543, 90);
            panel2.TabIndex = 45;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.coverr;
            pictureBox2.Location = new Point(-24, -22);
            pictureBox2.Margin = new Padding(3, 2, 3, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(637, 203);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // cmbCategory
            // 
            cmbCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Location = new Point(653, 166);
            cmbCategory.Margin = new Padding(3, 2, 3, 2);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(110, 23);
            cmbCategory.TabIndex = 0;
            cmbCategory.SelectedIndexChanged += cmbCategory_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 251, 247);
            ClientSize = new Size(1188, 681);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(txtItem);
            Controls.Add(txtPrice);
            Controls.Add(txtQuantity);
            Controls.Add(cmbCategory);
            Controls.Add(groupbxBill);
            Controls.Add(groupbxMenu);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Main Form";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupbxDrinksize.ResumeLayout(false);
            groupbxDrinksize.PerformLayout();
            groupbxFlavors.ResumeLayout(false);
            groupbxFlavors.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupbxSauce.ResumeLayout(false);
            groupbxSauce.PerformLayout();
            groupbxBill.ResumeLayout(false);
            groupbxBill.PerformLayout();
            groupbxMenu.ResumeLayout(false);
            groupbxMenu.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnCalculate;
        private Button btnSave;
        private Button btnOpen;
        private Button btncancel;
        private Button btnUpdate;
        private Button btnAdd2;
        private Button btnEdit2;
        private Panel panel1;
        private ListView menu;
        private ColumnHeader item_category;
        private ColumnHeader item_name;
        private ColumnHeader item_price;
        private ColumnHeader item_options;
        private RadioButton radbtnSmall;
        private RadioButton radbtnMedium;
        private RadioButton radbtnLarge;
        private GroupBox groupbxDrinksize;
        private DataGridViewTextBoxColumn Quantity;
        private DataGridViewTextBoxColumn Price;
        private DataGridViewTextBoxColumn Item;
        private DataGridViewTextBoxColumn Option;
        private DataGridViewTextBoxColumn Category;
        private DataGridView dataGridView1;
        private RadioButton radbtnVanilla;
        private RadioButton radbtnChocolate;
        private RadioButton radbtnStrawberry;
        private RadioButton radbtnBlueberry;
        private GroupBox groupbxSauce;
        private Label label1;
        private Label label3;
        private Label label4;
        private Label label2;
        private Label lblWarning;
        private TextBox txtQuantity;
        private TextBox txtPrice;
        private TextBox txtItem;
        private Button btnAdd;
        private Button btnUpdate1;
        private Button btnRemove;
        private GroupBox groupbxFlavors;
        private RadioButton radbtnMild;
        private RadioButton radbtnSpicy;
        private GroupBox groupbxBill;
        private Label lblPrice;
        private Label lblOption;
        private Label lblItem;
        private Label lblCategory;
        private TextBox optionstxt;
        private TextBox pricetxt;
        private GroupBox groupbxMenu;
        private TextBox categorytxt;
        private TextBox itemtxt;
        private Label lblWarning2;
        private PictureBox pictureBox1;
        private Panel panel2;
        private PictureBox pictureBox2;
        private ComboBox cmbCategory;
    }
}
