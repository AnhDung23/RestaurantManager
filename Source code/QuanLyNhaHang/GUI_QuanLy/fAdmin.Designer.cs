namespace GUI_QuanLy
{
    partial class fAdmin
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
            this.tcAdmin = new System.Windows.Forms.TabControl();
            this.tpBill = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnViewBill = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpkToDate = new System.Windows.Forms.DateTimePicker();
            this.dtpkFromDate = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtgvBill = new System.Windows.Forms.DataGridView();
            this.tpFood = new System.Windows.Forms.TabPage();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.cbxFoodCategory = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel10 = new System.Windows.Forms.Panel();
            this.txtFoodPrice = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.txtFoodName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txtSearchFood = new System.Windows.Forms.TextBox();
            this.btnSearchFood = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnViewFood = new System.Windows.Forms.Button();
            this.btnUpdateFood = new System.Windows.Forms.Button();
            this.btnDeleteFood = new System.Windows.Forms.Button();
            this.btnAddFood = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dtgvFood = new System.Windows.Forms.DataGridView();
            this.tpFoodCategory = new System.Windows.Forms.TabPage();
            this.panel11 = new System.Windows.Forms.Panel();
            this.btnViewCategory = new System.Windows.Forms.Button();
            this.btnUpdateCategory = new System.Windows.Forms.Button();
            this.btnDeleteCategory = new System.Windows.Forms.Button();
            this.btnAddCategory = new System.Windows.Forms.Button();
            this.dtgvCategory = new System.Windows.Forms.DataGridView();
            this.panel12 = new System.Windows.Forms.Panel();
            this.panel14 = new System.Windows.Forms.Panel();
            this.txtCategoryName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel15 = new System.Windows.Forms.Panel();
            this.txtCategoryID = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tpTable = new System.Windows.Forms.TabPage();
            this.panel13 = new System.Windows.Forms.Panel();
            this.btnSearchTable = new System.Windows.Forms.Button();
            this.txtSearchTable = new System.Windows.Forms.TextBox();
            this.btnViewTable = new System.Windows.Forms.Button();
            this.dtgvTable = new System.Windows.Forms.DataGridView();
            this.panel16 = new System.Windows.Forms.Panel();
            this.panel17 = new System.Windows.Forms.Panel();
            this.txtTableName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnDeleteTable = new System.Windows.Forms.Button();
            this.btnAddTable = new System.Windows.Forms.Button();
            this.tpAccount = new System.Windows.Forms.TabPage();
            this.panel20 = new System.Windows.Forms.Panel();
            this.panel22 = new System.Windows.Forms.Panel();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.btnDeleteAccount = new System.Windows.Forms.Button();
            this.panel23 = new System.Windows.Forms.Panel();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.panel24 = new System.Windows.Forms.Panel();
            this.btnViewUser = new System.Windows.Forms.Button();
            this.txtSearchUser = new System.Windows.Forms.TextBox();
            this.btnSearchUser = new System.Windows.Forms.Button();
            this.panel26 = new System.Windows.Forms.Panel();
            this.dtgvUser = new System.Windows.Forms.DataGridView();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.tcAdmin.SuspendLayout();
            this.tpBill.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvBill)).BeginInit();
            this.tpFood.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvFood)).BeginInit();
            this.tpFoodCategory.SuspendLayout();
            this.panel11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCategory)).BeginInit();
            this.panel12.SuspendLayout();
            this.panel14.SuspendLayout();
            this.panel15.SuspendLayout();
            this.tpTable.SuspendLayout();
            this.panel13.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTable)).BeginInit();
            this.panel16.SuspendLayout();
            this.panel17.SuspendLayout();
            this.tpAccount.SuspendLayout();
            this.panel20.SuspendLayout();
            this.panel22.SuspendLayout();
            this.panel23.SuspendLayout();
            this.panel24.SuspendLayout();
            this.panel26.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvUser)).BeginInit();
            this.SuspendLayout();
            // 
            // tcAdmin
            // 
            this.tcAdmin.Controls.Add(this.tpBill);
            this.tcAdmin.Controls.Add(this.tpFood);
            this.tcAdmin.Controls.Add(this.tpFoodCategory);
            this.tcAdmin.Controls.Add(this.tpTable);
            this.tcAdmin.Controls.Add(this.tpAccount);
            this.tcAdmin.Location = new System.Drawing.Point(12, 12);
            this.tcAdmin.Name = "tcAdmin";
            this.tcAdmin.SelectedIndex = 0;
            this.tcAdmin.Size = new System.Drawing.Size(958, 520);
            this.tcAdmin.TabIndex = 0;
            // 
            // tpBill
            // 
            this.tpBill.Controls.Add(this.panel2);
            this.tpBill.Controls.Add(this.panel1);
            this.tpBill.Location = new System.Drawing.Point(4, 25);
            this.tpBill.Name = "tpBill";
            this.tpBill.Padding = new System.Windows.Forms.Padding(3);
            this.tpBill.Size = new System.Drawing.Size(950, 491);
            this.tpBill.TabIndex = 0;
            this.tpBill.Text = "Doanh thu";
            this.tpBill.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnViewBill);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.dtpkToDate);
            this.panel2.Controls.Add(this.dtpkFromDate);
            this.panel2.Location = new System.Drawing.Point(6, 6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(938, 32);
            this.panel2.TabIndex = 1;
            // 
            // btnViewBill
            // 
            this.btnViewBill.Location = new System.Drawing.Point(826, 4);
            this.btnViewBill.Name = "btnViewBill";
            this.btnViewBill.Size = new System.Drawing.Size(84, 23);
            this.btnViewBill.TabIndex = 4;
            this.btnViewBill.Text = "Thống kê";
            this.btnViewBill.UseVisualStyleBackColor = true;
            this.btnViewBill.Click += new System.EventHandler(this.btnViewBill_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(416, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "đến ngày";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Từ ngày ";
            // 
            // dtpkToDate
            // 
            this.dtpkToDate.Location = new System.Drawing.Point(528, 5);
            this.dtpkToDate.Name = "dtpkToDate";
            this.dtpkToDate.Size = new System.Drawing.Size(261, 22);
            this.dtpkToDate.TabIndex = 1;
            // 
            // dtpkFromDate
            // 
            this.dtpkFromDate.Location = new System.Drawing.Point(119, 5);
            this.dtpkFromDate.Name = "dtpkFromDate";
            this.dtpkFromDate.Size = new System.Drawing.Size(262, 22);
            this.dtpkFromDate.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dtgvBill);
            this.panel1.Location = new System.Drawing.Point(6, 44);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(941, 441);
            this.panel1.TabIndex = 0;
            // 
            // dtgvBill
            // 
            this.dtgvBill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvBill.Location = new System.Drawing.Point(0, 9);
            this.dtgvBill.Name = "dtgvBill";
            this.dtgvBill.RowHeadersWidth = 51;
            this.dtgvBill.RowTemplate.Height = 24;
            this.dtgvBill.Size = new System.Drawing.Size(934, 435);
            this.dtgvBill.TabIndex = 0;
            // 
            // tpFood
            // 
            this.tpFood.Controls.Add(this.panel6);
            this.tpFood.Controls.Add(this.panel5);
            this.tpFood.Controls.Add(this.panel4);
            this.tpFood.Controls.Add(this.panel3);
            this.tpFood.Location = new System.Drawing.Point(4, 25);
            this.tpFood.Name = "tpFood";
            this.tpFood.Padding = new System.Windows.Forms.Padding(3);
            this.tpFood.Size = new System.Drawing.Size(950, 491);
            this.tpFood.TabIndex = 1;
            this.tpFood.Text = "Thức ăn";
            this.tpFood.UseVisualStyleBackColor = true;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.panel9);
            this.panel6.Controls.Add(this.panel10);
            this.panel6.Controls.Add(this.panel8);
            this.panel6.Location = new System.Drawing.Point(504, 71);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(369, 417);
            this.panel6.TabIndex = 3;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.cbxFoodCategory);
            this.panel9.Controls.Add(this.label5);
            this.panel9.Location = new System.Drawing.Point(0, 122);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(366, 63);
            this.panel9.TabIndex = 4;
            // 
            // cbxFoodCategory
            // 
            this.cbxFoodCategory.FormattingEnabled = true;
            this.cbxFoodCategory.Location = new System.Drawing.Point(124, 20);
            this.cbxFoodCategory.Name = "cbxFoodCategory";
            this.cbxFoodCategory.Size = new System.Drawing.Size(239, 24);
            this.cbxFoodCategory.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 24);
            this.label5.TabIndex = 0;
            this.label5.Text = "Danh mục: ";
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.txtFoodPrice);
            this.panel10.Controls.Add(this.label6);
            this.panel10.Location = new System.Drawing.Point(0, 210);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(366, 63);
            this.panel10.TabIndex = 5;
            // 
            // txtFoodPrice
            // 
            this.txtFoodPrice.Location = new System.Drawing.Point(124, 20);
            this.txtFoodPrice.Name = "txtFoodPrice";
            this.txtFoodPrice.Size = new System.Drawing.Size(239, 22);
            this.txtFoodPrice.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 24);
            this.label6.TabIndex = 0;
            this.label6.Text = "Giá: ";
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.txtFoodName);
            this.panel8.Controls.Add(this.label4);
            this.panel8.Location = new System.Drawing.Point(0, 29);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(366, 63);
            this.panel8.TabIndex = 3;
            // 
            // txtFoodName
            // 
            this.txtFoodName.Location = new System.Drawing.Point(124, 23);
            this.txtFoodName.Name = "txtFoodName";
            this.txtFoodName.Size = new System.Drawing.Size(239, 22);
            this.txtFoodName.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 24);
            this.label4.TabIndex = 0;
            this.label4.Text = "Tên món: ";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.txtSearchFood);
            this.panel5.Controls.Add(this.btnSearchFood);
            this.panel5.Location = new System.Drawing.Point(504, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(369, 56);
            this.panel5.TabIndex = 3;
            // 
            // txtSearchFood
            // 
            this.txtSearchFood.Location = new System.Drawing.Point(13, 17);
            this.txtSearchFood.Name = "txtSearchFood";
            this.txtSearchFood.Size = new System.Drawing.Size(262, 22);
            this.txtSearchFood.TabIndex = 5;
            // 
            // btnSearchFood
            // 
            this.btnSearchFood.Location = new System.Drawing.Point(281, 4);
            this.btnSearchFood.Name = "btnSearchFood";
            this.btnSearchFood.Size = new System.Drawing.Size(85, 49);
            this.btnSearchFood.TabIndex = 4;
            this.btnSearchFood.Text = "Tìm kiếm";
            this.btnSearchFood.UseVisualStyleBackColor = true;
            this.btnSearchFood.Click += new System.EventHandler(this.btnSearchFood_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnViewFood);
            this.panel4.Controls.Add(this.btnUpdateFood);
            this.panel4.Controls.Add(this.btnDeleteFood);
            this.panel4.Controls.Add(this.btnAddFood);
            this.panel4.Location = new System.Drawing.Point(6, 6);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(462, 56);
            this.panel4.TabIndex = 3;
            // 
            // btnViewFood
            // 
            this.btnViewFood.Location = new System.Drawing.Point(359, 4);
            this.btnViewFood.Name = "btnViewFood";
            this.btnViewFood.Size = new System.Drawing.Size(85, 49);
            this.btnViewFood.TabIndex = 3;
            this.btnViewFood.Text = "Xem";
            this.btnViewFood.UseVisualStyleBackColor = true;
            this.btnViewFood.Click += new System.EventHandler(this.btnViewFood_Click);
            // 
            // btnUpdateFood
            // 
            this.btnUpdateFood.Location = new System.Drawing.Point(248, 4);
            this.btnUpdateFood.Name = "btnUpdateFood";
            this.btnUpdateFood.Size = new System.Drawing.Size(85, 49);
            this.btnUpdateFood.TabIndex = 2;
            this.btnUpdateFood.Text = "Sửa";
            this.btnUpdateFood.UseVisualStyleBackColor = true;
            this.btnUpdateFood.Click += new System.EventHandler(this.btnUpdateFood_Click);
            // 
            // btnDeleteFood
            // 
            this.btnDeleteFood.Location = new System.Drawing.Point(133, 4);
            this.btnDeleteFood.Name = "btnDeleteFood";
            this.btnDeleteFood.Size = new System.Drawing.Size(85, 49);
            this.btnDeleteFood.TabIndex = 1;
            this.btnDeleteFood.Text = "Xóa";
            this.btnDeleteFood.UseVisualStyleBackColor = true;
            this.btnDeleteFood.Click += new System.EventHandler(this.btnDeleteFood_Click);
            // 
            // btnAddFood
            // 
            this.btnAddFood.Location = new System.Drawing.Point(22, 4);
            this.btnAddFood.Name = "btnAddFood";
            this.btnAddFood.Size = new System.Drawing.Size(85, 49);
            this.btnAddFood.TabIndex = 0;
            this.btnAddFood.Text = "Thêm";
            this.btnAddFood.UseVisualStyleBackColor = true;
            this.btnAddFood.Click += new System.EventHandler(this.btnAddFood_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dtgvFood);
            this.panel3.Location = new System.Drawing.Point(6, 68);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(462, 417);
            this.panel3.TabIndex = 2;
            // 
            // dtgvFood
            // 
            this.dtgvFood.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvFood.Location = new System.Drawing.Point(4, 3);
            this.dtgvFood.Name = "dtgvFood";
            this.dtgvFood.RowHeadersWidth = 51;
            this.dtgvFood.RowTemplate.Height = 24;
            this.dtgvFood.Size = new System.Drawing.Size(455, 411);
            this.dtgvFood.TabIndex = 0;
            // 
            // tpFoodCategory
            // 
            this.tpFoodCategory.Controls.Add(this.panel11);
            this.tpFoodCategory.Controls.Add(this.dtgvCategory);
            this.tpFoodCategory.Controls.Add(this.panel12);
            this.tpFoodCategory.Location = new System.Drawing.Point(4, 25);
            this.tpFoodCategory.Name = "tpFoodCategory";
            this.tpFoodCategory.Padding = new System.Windows.Forms.Padding(3);
            this.tpFoodCategory.Size = new System.Drawing.Size(950, 491);
            this.tpFoodCategory.TabIndex = 2;
            this.tpFoodCategory.Text = "Danh mục";
            this.tpFoodCategory.UseVisualStyleBackColor = true;
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.btnViewCategory);
            this.panel11.Controls.Add(this.btnUpdateCategory);
            this.panel11.Controls.Add(this.btnDeleteCategory);
            this.panel11.Controls.Add(this.btnAddCategory);
            this.panel11.Location = new System.Drawing.Point(7, 7);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(452, 56);
            this.panel11.TabIndex = 5;
            // 
            // btnViewCategory
            // 
            this.btnViewCategory.Location = new System.Drawing.Point(345, 4);
            this.btnViewCategory.Name = "btnViewCategory";
            this.btnViewCategory.Size = new System.Drawing.Size(85, 49);
            this.btnViewCategory.TabIndex = 3;
            this.btnViewCategory.Text = "Xem";
            this.btnViewCategory.UseVisualStyleBackColor = true;
            this.btnViewCategory.Click += new System.EventHandler(this.btnViewCategory_Click);
            // 
            // btnUpdateCategory
            // 
            this.btnUpdateCategory.Location = new System.Drawing.Point(238, 4);
            this.btnUpdateCategory.Name = "btnUpdateCategory";
            this.btnUpdateCategory.Size = new System.Drawing.Size(85, 49);
            this.btnUpdateCategory.TabIndex = 2;
            this.btnUpdateCategory.Text = "Sửa";
            this.btnUpdateCategory.UseVisualStyleBackColor = true;
            this.btnUpdateCategory.Click += new System.EventHandler(this.btnUpdateCategory_Click);
            // 
            // btnDeleteCategory
            // 
            this.btnDeleteCategory.Location = new System.Drawing.Point(131, 4);
            this.btnDeleteCategory.Name = "btnDeleteCategory";
            this.btnDeleteCategory.Size = new System.Drawing.Size(85, 49);
            this.btnDeleteCategory.TabIndex = 1;
            this.btnDeleteCategory.Text = "Xóa";
            this.btnDeleteCategory.UseVisualStyleBackColor = true;
            this.btnDeleteCategory.Click += new System.EventHandler(this.btnDeleteCategory_Click);
            // 
            // btnAddCategory
            // 
            this.btnAddCategory.Location = new System.Drawing.Point(22, 4);
            this.btnAddCategory.Name = "btnAddCategory";
            this.btnAddCategory.Size = new System.Drawing.Size(85, 49);
            this.btnAddCategory.TabIndex = 0;
            this.btnAddCategory.Text = "Thêm";
            this.btnAddCategory.UseVisualStyleBackColor = true;
            this.btnAddCategory.Click += new System.EventHandler(this.btnAddCategory_Click);
            // 
            // dtgvCategory
            // 
            this.dtgvCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvCategory.Location = new System.Drawing.Point(7, 72);
            this.dtgvCategory.Name = "dtgvCategory";
            this.dtgvCategory.RowHeadersWidth = 51;
            this.dtgvCategory.RowTemplate.Height = 24;
            this.dtgvCategory.Size = new System.Drawing.Size(452, 413);
            this.dtgvCategory.TabIndex = 4;
            // 
            // panel12
            // 
            this.panel12.Controls.Add(this.panel14);
            this.panel12.Controls.Add(this.panel15);
            this.panel12.Location = new System.Drawing.Point(519, 56);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(369, 417);
            this.panel12.TabIndex = 6;
            // 
            // panel14
            // 
            this.panel14.Controls.Add(this.txtCategoryName);
            this.panel14.Controls.Add(this.label8);
            this.panel14.Location = new System.Drawing.Point(0, 72);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(366, 63);
            this.panel14.TabIndex = 3;
            // 
            // txtCategoryName
            // 
            this.txtCategoryName.Location = new System.Drawing.Point(158, 23);
            this.txtCategoryName.Name = "txtCategoryName";
            this.txtCategoryName.Size = new System.Drawing.Size(205, 22);
            this.txtCategoryName.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(6, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(158, 24);
            this.label8.TabIndex = 0;
            this.label8.Text = "Tên danh mục: ";
            // 
            // panel15
            // 
            this.panel15.Controls.Add(this.txtCategoryID);
            this.panel15.Controls.Add(this.label9);
            this.panel15.Location = new System.Drawing.Point(0, 3);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(366, 63);
            this.panel15.TabIndex = 2;
            // 
            // txtCategoryID
            // 
            this.txtCategoryID.Location = new System.Drawing.Point(158, 23);
            this.txtCategoryID.Name = "txtCategoryID";
            this.txtCategoryID.Size = new System.Drawing.Size(205, 22);
            this.txtCategoryID.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(6, 20);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 24);
            this.label9.TabIndex = 0;
            this.label9.Text = "ID: ";
            // 
            // tpTable
            // 
            this.tpTable.Controls.Add(this.panel13);
            this.tpTable.Controls.Add(this.dtgvTable);
            this.tpTable.Controls.Add(this.panel16);
            this.tpTable.Location = new System.Drawing.Point(4, 25);
            this.tpTable.Name = "tpTable";
            this.tpTable.Padding = new System.Windows.Forms.Padding(3);
            this.tpTable.Size = new System.Drawing.Size(950, 491);
            this.tpTable.TabIndex = 3;
            this.tpTable.Text = "Bàn ăn";
            this.tpTable.UseVisualStyleBackColor = true;
            // 
            // panel13
            // 
            this.panel13.Controls.Add(this.btnSearchTable);
            this.panel13.Controls.Add(this.txtSearchTable);
            this.panel13.Controls.Add(this.btnViewTable);
            this.panel13.Location = new System.Drawing.Point(6, 6);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(452, 56);
            this.panel13.TabIndex = 8;
            // 
            // btnSearchTable
            // 
            this.btnSearchTable.Location = new System.Drawing.Point(263, 4);
            this.btnSearchTable.Name = "btnSearchTable";
            this.btnSearchTable.Size = new System.Drawing.Size(85, 49);
            this.btnSearchTable.TabIndex = 7;
            this.btnSearchTable.Text = "Tìm kiếm";
            this.btnSearchTable.UseVisualStyleBackColor = true;
            this.btnSearchTable.Click += new System.EventHandler(this.btnSearchTable_Click);
            // 
            // txtSearchTable
            // 
            this.txtSearchTable.Location = new System.Drawing.Point(3, 17);
            this.txtSearchTable.Name = "txtSearchTable";
            this.txtSearchTable.Size = new System.Drawing.Size(243, 22);
            this.txtSearchTable.TabIndex = 6;
            // 
            // btnViewTable
            // 
            this.btnViewTable.Location = new System.Drawing.Point(364, 4);
            this.btnViewTable.Name = "btnViewTable";
            this.btnViewTable.Size = new System.Drawing.Size(85, 49);
            this.btnViewTable.TabIndex = 3;
            this.btnViewTable.Text = "Xem";
            this.btnViewTable.UseVisualStyleBackColor = true;
            this.btnViewTable.Click += new System.EventHandler(this.btnViewTable_Click);
            // 
            // dtgvTable
            // 
            this.dtgvTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvTable.Location = new System.Drawing.Point(6, 71);
            this.dtgvTable.Name = "dtgvTable";
            this.dtgvTable.RowHeadersWidth = 51;
            this.dtgvTable.RowTemplate.Height = 24;
            this.dtgvTable.Size = new System.Drawing.Size(452, 413);
            this.dtgvTable.TabIndex = 7;
            // 
            // panel16
            // 
            this.panel16.Controls.Add(this.panel17);
            this.panel16.Controls.Add(this.btnDeleteTable);
            this.panel16.Controls.Add(this.btnAddTable);
            this.panel16.Location = new System.Drawing.Point(523, 67);
            this.panel16.Name = "panel16";
            this.panel16.Size = new System.Drawing.Size(369, 417);
            this.panel16.TabIndex = 9;
            // 
            // panel17
            // 
            this.panel17.Controls.Add(this.txtTableName);
            this.panel17.Controls.Add(this.label7);
            this.panel17.Location = new System.Drawing.Point(0, 17);
            this.panel17.Name = "panel17";
            this.panel17.Size = new System.Drawing.Size(366, 63);
            this.panel17.TabIndex = 3;
            // 
            // txtTableName
            // 
            this.txtTableName.Location = new System.Drawing.Point(158, 23);
            this.txtTableName.Name = "txtTableName";
            this.txtTableName.Size = new System.Drawing.Size(205, 22);
            this.txtTableName.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 24);
            this.label7.TabIndex = 0;
            this.label7.Text = "Tên bàn: ";
            // 
            // btnDeleteTable
            // 
            this.btnDeleteTable.Location = new System.Drawing.Point(278, 108);
            this.btnDeleteTable.Name = "btnDeleteTable";
            this.btnDeleteTable.Size = new System.Drawing.Size(85, 49);
            this.btnDeleteTable.TabIndex = 1;
            this.btnDeleteTable.Text = "Xóa";
            this.btnDeleteTable.UseVisualStyleBackColor = true;
            this.btnDeleteTable.Click += new System.EventHandler(this.btnDeleteTable_Click);
            // 
            // btnAddTable
            // 
            this.btnAddTable.Location = new System.Drawing.Point(158, 108);
            this.btnAddTable.Name = "btnAddTable";
            this.btnAddTable.Size = new System.Drawing.Size(85, 49);
            this.btnAddTable.TabIndex = 0;
            this.btnAddTable.Text = "Thêm";
            this.btnAddTable.UseVisualStyleBackColor = true;
            this.btnAddTable.Click += new System.EventHandler(this.btnAddTable_Click);
            // 
            // tpAccount
            // 
            this.tpAccount.Controls.Add(this.panel20);
            this.tpAccount.Controls.Add(this.panel24);
            this.tpAccount.Controls.Add(this.panel26);
            this.tpAccount.Location = new System.Drawing.Point(4, 25);
            this.tpAccount.Name = "tpAccount";
            this.tpAccount.Padding = new System.Windows.Forms.Padding(3);
            this.tpAccount.Size = new System.Drawing.Size(950, 491);
            this.tpAccount.TabIndex = 4;
            this.tpAccount.Text = "Tài khoản";
            this.tpAccount.UseVisualStyleBackColor = true;
            // 
            // panel20
            // 
            this.panel20.Controls.Add(this.panel22);
            this.panel20.Controls.Add(this.btnDeleteAccount);
            this.panel20.Controls.Add(this.panel23);
            this.panel20.Location = new System.Drawing.Point(529, 71);
            this.panel20.Name = "panel20";
            this.panel20.Size = new System.Drawing.Size(369, 417);
            this.panel20.TabIndex = 5;
            // 
            // panel22
            // 
            this.panel22.Controls.Add(this.txtName);
            this.panel22.Controls.Add(this.label13);
            this.panel22.Location = new System.Drawing.Point(0, 72);
            this.panel22.Name = "panel22";
            this.panel22.Size = new System.Drawing.Size(366, 63);
            this.panel22.TabIndex = 3;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(124, 23);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(239, 22);
            this.txtName.TabIndex = 1;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(6, 20);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(59, 24);
            this.label13.TabIndex = 0;
            this.label13.Text = "Tên: ";
            // 
            // btnDeleteAccount
            // 
            this.btnDeleteAccount.Location = new System.Drawing.Point(239, 153);
            this.btnDeleteAccount.Name = "btnDeleteAccount";
            this.btnDeleteAccount.Size = new System.Drawing.Size(113, 49);
            this.btnDeleteAccount.TabIndex = 1;
            this.btnDeleteAccount.Text = "Xóa tài khoản";
            this.btnDeleteAccount.UseVisualStyleBackColor = true;
            this.btnDeleteAccount.Click += new System.EventHandler(this.btnDeleteAccount_Click);
            // 
            // panel23
            // 
            this.panel23.Controls.Add(this.txtUser);
            this.panel23.Controls.Add(this.label14);
            this.panel23.Location = new System.Drawing.Point(0, 3);
            this.panel23.Name = "panel23";
            this.panel23.Size = new System.Drawing.Size(366, 63);
            this.panel23.TabIndex = 2;
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(124, 23);
            this.txtUser.Name = "txtUser";
            this.txtUser.ReadOnly = true;
            this.txtUser.Size = new System.Drawing.Size(239, 22);
            this.txtUser.TabIndex = 1;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(6, 20);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(116, 24);
            this.label14.TabIndex = 0;
            this.label14.Text = "Tài khoản: ";
            // 
            // panel24
            // 
            this.panel24.Controls.Add(this.btnViewUser);
            this.panel24.Controls.Add(this.txtSearchUser);
            this.panel24.Controls.Add(this.btnSearchUser);
            this.panel24.Location = new System.Drawing.Point(6, 6);
            this.panel24.Name = "panel24";
            this.panel24.Size = new System.Drawing.Size(452, 56);
            this.panel24.TabIndex = 6;
            // 
            // btnViewUser
            // 
            this.btnViewUser.Location = new System.Drawing.Point(364, 3);
            this.btnViewUser.Name = "btnViewUser";
            this.btnViewUser.Size = new System.Drawing.Size(85, 49);
            this.btnViewUser.TabIndex = 6;
            this.btnViewUser.Text = "Xem";
            this.btnViewUser.UseVisualStyleBackColor = true;
            this.btnViewUser.Click += new System.EventHandler(this.btnViewUser_Click);
            // 
            // txtSearchUser
            // 
            this.txtSearchUser.Location = new System.Drawing.Point(13, 17);
            this.txtSearchUser.Name = "txtSearchUser";
            this.txtSearchUser.Size = new System.Drawing.Size(231, 22);
            this.txtSearchUser.TabIndex = 5;
            // 
            // btnSearchUser
            // 
            this.btnSearchUser.Location = new System.Drawing.Point(262, 3);
            this.btnSearchUser.Name = "btnSearchUser";
            this.btnSearchUser.Size = new System.Drawing.Size(85, 49);
            this.btnSearchUser.TabIndex = 4;
            this.btnSearchUser.Text = "Tìm kiếm";
            this.btnSearchUser.UseVisualStyleBackColor = true;
            this.btnSearchUser.Click += new System.EventHandler(this.btnSearchUser_Click);
            // 
            // panel26
            // 
            this.panel26.Controls.Add(this.dtgvUser);
            this.panel26.Location = new System.Drawing.Point(6, 68);
            this.panel26.Name = "panel26";
            this.panel26.Size = new System.Drawing.Size(452, 417);
            this.panel26.TabIndex = 4;
            // 
            // dtgvUser
            // 
            this.dtgvUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvUser.Location = new System.Drawing.Point(4, 3);
            this.dtgvUser.Name = "dtgvUser";
            this.dtgvUser.RowHeadersWidth = 51;
            this.dtgvUser.RowTemplate.Height = 24;
            this.dtgvUser.Size = new System.Drawing.Size(445, 411);
            this.dtgvUser.TabIndex = 0;
            // 
            // fAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(972, 540);
            this.Controls.Add(this.tcAdmin);
            this.Name = "fAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Admin";
            this.tcAdmin.ResumeLayout(false);
            this.tpBill.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvBill)).EndInit();
            this.tpFood.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvFood)).EndInit();
            this.tpFoodCategory.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCategory)).EndInit();
            this.panel12.ResumeLayout(false);
            this.panel14.ResumeLayout(false);
            this.panel14.PerformLayout();
            this.panel15.ResumeLayout(false);
            this.panel15.PerformLayout();
            this.tpTable.ResumeLayout(false);
            this.panel13.ResumeLayout(false);
            this.panel13.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTable)).EndInit();
            this.panel16.ResumeLayout(false);
            this.panel17.ResumeLayout(false);
            this.panel17.PerformLayout();
            this.tpAccount.ResumeLayout(false);
            this.panel20.ResumeLayout(false);
            this.panel22.ResumeLayout(false);
            this.panel22.PerformLayout();
            this.panel23.ResumeLayout(false);
            this.panel23.PerformLayout();
            this.panel24.ResumeLayout(false);
            this.panel24.PerformLayout();
            this.panel26.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvUser)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcAdmin;
        private System.Windows.Forms.TabPage tpBill;
        private System.Windows.Forms.TabPage tpFood;
        private System.Windows.Forms.TabPage tpFoodCategory;
        private System.Windows.Forms.TabPage tpTable;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnViewBill;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpkToDate;
        private System.Windows.Forms.DateTimePicker dtpkFromDate;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dtgvBill;
        private System.Windows.Forms.TabPage tpAccount;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox txtSearchFood;
        private System.Windows.Forms.Button btnSearchFood;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnViewFood;
        private System.Windows.Forms.Button btnUpdateFood;
        private System.Windows.Forms.Button btnDeleteFood;
        private System.Windows.Forms.Button btnAddFood;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dtgvFood;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.ComboBox cbxFoodCategory;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.TextBox txtFoodPrice;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.TextBox txtFoodName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Button btnViewCategory;
        private System.Windows.Forms.Button btnUpdateCategory;
        private System.Windows.Forms.Button btnDeleteCategory;
        private System.Windows.Forms.Button btnAddCategory;
        private System.Windows.Forms.DataGridView dtgvCategory;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.TextBox txtCategoryName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.TextBox txtCategoryID;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Button btnViewTable;
        private System.Windows.Forms.Button btnDeleteTable;
        private System.Windows.Forms.Button btnAddTable;
        private System.Windows.Forms.DataGridView dtgvTable;
        private System.Windows.Forms.Panel panel16;
        private System.Windows.Forms.Panel panel17;
        private System.Windows.Forms.TextBox txtTableName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel20;
        private System.Windows.Forms.Panel panel22;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnDeleteAccount;
        private System.Windows.Forms.Panel panel23;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Panel panel24;
        private System.Windows.Forms.TextBox txtSearchUser;
        private System.Windows.Forms.Button btnSearchUser;
        private System.Windows.Forms.Panel panel26;
        private System.Windows.Forms.DataGridView dtgvUser;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnViewUser;
        private System.Windows.Forms.Button btnSearchTable;
        private System.Windows.Forms.TextBox txtSearchTable;
    }
}