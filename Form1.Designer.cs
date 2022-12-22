namespace FinalExcercise03
{
    partial class Form1
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
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.dtpProductOutOfDate = new DevExpress.XtraEditors.DateTimeOffsetEdit();
            this.txtProductOrigin = new System.Windows.Forms.TextBox();
            this.txtProductCost = new System.Windows.Forms.TextBox();
            this.txtProductAmount = new System.Windows.Forms.TextBox();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.txtProductCode = new System.Windows.Forms.TextBox();
            this.sbtnRemoveProduct = new DevExpress.XtraEditors.SimpleButton();
            this.sbtnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.lsvTask = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtCostTo = new DevExpress.XtraEditors.TextEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.txtCostFrom = new DevExpress.XtraEditors.TextEdit();
            this.sbtnCostFromTo = new DevExpress.XtraEditors.SimpleButton();
            this.sbtnOutOfDate = new DevExpress.XtraEditors.SimpleButton();
            this.sbtnProductJapanese = new DevExpress.XtraEditors.SimpleButton();
            this.sbtnMaxScost = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.lsvProduct = new System.Windows.Forms.ListView();
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupControl4 = new DevExpress.XtraEditors.GroupControl();
            this.sbtnRemoveOutOfDate = new DevExpress.XtraEditors.SimpleButton();
            this.sbtnRemoveAll = new DevExpress.XtraEditors.SimpleButton();
            this.sbtnProductOutOfDate = new DevExpress.XtraEditors.SimpleButton();
            this.sbtnRemove = new DevExpress.XtraEditors.SimpleButton();
            this.txtFindOrigin = new DevExpress.XtraEditors.TextEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtpProductOutOfDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCostTo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCostFrom.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).BeginInit();
            this.groupControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtFindOrigin.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.dtpProductOutOfDate);
            this.groupControl1.Controls.Add(this.txtProductOrigin);
            this.groupControl1.Controls.Add(this.txtProductCost);
            this.groupControl1.Controls.Add(this.txtProductAmount);
            this.groupControl1.Controls.Add(this.txtProductName);
            this.groupControl1.Controls.Add(this.txtProductCode);
            this.groupControl1.Controls.Add(this.sbtnRemoveProduct);
            this.groupControl1.Controls.Add(this.sbtnAdd);
            this.groupControl1.Controls.Add(this.labelControl6);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Location = new System.Drawing.Point(12, 12);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(344, 326);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Nhập thông tin sản phẩm";
            // 
            // dtpProductOutOfDate
            // 
            this.dtpProductOutOfDate.EditValue = null;
            this.dtpProductOutOfDate.Location = new System.Drawing.Point(106, 242);
            this.dtpProductOutOfDate.Name = "dtpProductOutOfDate";
            this.dtpProductOutOfDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpProductOutOfDate.Size = new System.Drawing.Size(221, 20);
            this.dtpProductOutOfDate.TabIndex = 8;
            // 
            // txtProductOrigin
            // 
            this.txtProductOrigin.Location = new System.Drawing.Point(106, 198);
            this.txtProductOrigin.Name = "txtProductOrigin";
            this.txtProductOrigin.Size = new System.Drawing.Size(221, 21);
            this.txtProductOrigin.TabIndex = 15;
            // 
            // txtProductCost
            // 
            this.txtProductCost.Location = new System.Drawing.Point(106, 155);
            this.txtProductCost.Name = "txtProductCost";
            this.txtProductCost.Size = new System.Drawing.Size(221, 21);
            this.txtProductCost.TabIndex = 14;
            // 
            // txtProductAmount
            // 
            this.txtProductAmount.Location = new System.Drawing.Point(106, 114);
            this.txtProductAmount.Name = "txtProductAmount";
            this.txtProductAmount.Size = new System.Drawing.Size(221, 21);
            this.txtProductAmount.TabIndex = 13;
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(106, 72);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(221, 21);
            this.txtProductName.TabIndex = 12;
            // 
            // txtProductCode
            // 
            this.txtProductCode.Location = new System.Drawing.Point(106, 34);
            this.txtProductCode.Name = "txtProductCode";
            this.txtProductCode.Size = new System.Drawing.Size(221, 21);
            this.txtProductCode.TabIndex = 3;
            // 
            // sbtnRemoveProduct
            // 
            this.sbtnRemoveProduct.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sbtnRemoveProduct.Appearance.Options.UseFont = true;
            this.sbtnRemoveProduct.Location = new System.Drawing.Point(223, 279);
            this.sbtnRemoveProduct.Name = "sbtnRemoveProduct";
            this.sbtnRemoveProduct.Size = new System.Drawing.Size(104, 35);
            this.sbtnRemoveProduct.TabIndex = 1;
            this.sbtnRemoveProduct.Text = "Xoá sản phẩm";
            this.sbtnRemoveProduct.Click += new System.EventHandler(this.sbtnRemoveProduct_Click);
            // 
            // sbtnAdd
            // 
            this.sbtnAdd.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sbtnAdd.Appearance.Options.UseFont = true;
            this.sbtnAdd.Location = new System.Drawing.Point(106, 279);
            this.sbtnAdd.Name = "sbtnAdd";
            this.sbtnAdd.Size = new System.Drawing.Size(104, 35);
            this.sbtnAdd.TabIndex = 1;
            this.sbtnAdd.Text = "Thêm sản phẩm";
            this.sbtnAdd.Click += new System.EventHandler(this.sbtnAdd_Click);
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(14, 246);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(75, 16);
            this.labelControl6.TabIndex = 11;
            this.labelControl6.Text = "Ngày hết hạn";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(14, 199);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(44, 16);
            this.labelControl5.TabIndex = 8;
            this.labelControl5.Text = "Xuất xứ";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(14, 156);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(44, 16);
            this.labelControl4.TabIndex = 6;
            this.labelControl4.Text = "Đơn giá";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(14, 115);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(51, 16);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "Số lượng";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(14, 77);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(82, 16);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Tên sản phẩm";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(14, 36);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(77, 16);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Mã sản phẩm";
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.lsvTask);
            this.groupControl2.Controls.Add(this.txtCostTo);
            this.groupControl2.Controls.Add(this.labelControl7);
            this.groupControl2.Controls.Add(this.txtCostFrom);
            this.groupControl2.Controls.Add(this.sbtnCostFromTo);
            this.groupControl2.Controls.Add(this.sbtnOutOfDate);
            this.groupControl2.Controls.Add(this.sbtnProductJapanese);
            this.groupControl2.Controls.Add(this.sbtnMaxScost);
            this.groupControl2.Location = new System.Drawing.Point(362, 12);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(873, 326);
            this.groupControl2.TabIndex = 0;
            this.groupControl2.Text = "Chọn chức  năng tìm kiếm";
            // 
            // lsvTask
            // 
            this.lsvTask.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.lsvTask.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsvTask.FullRowSelect = true;
            this.lsvTask.GridLines = true;
            this.lsvTask.HideSelection = false;
            this.lsvTask.Location = new System.Drawing.Point(14, 67);
            this.lsvTask.Name = "lsvTask";
            this.lsvTask.Size = new System.Drawing.Size(847, 254);
            this.lsvTask.TabIndex = 7;
            this.lsvTask.UseCompatibleStateImageBehavior = false;
            this.lsvTask.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Mã sản phẩm";
            this.columnHeader1.Width = 123;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tên sản phẩm";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 174;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Số lượng";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 118;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Đơn giá";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 120;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Xuất xứ";
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader5.Width = 147;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Ngày hết hạn";
            this.columnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader6.Width = 151;
            // 
            // txtCostTo
            // 
            this.txtCostTo.Location = new System.Drawing.Point(730, 36);
            this.txtCostTo.Name = "txtCostTo";
            this.txtCostTo.Size = new System.Drawing.Size(131, 20);
            this.txtCostTo.TabIndex = 6;
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(703, 37);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(23, 16);
            this.labelControl7.TabIndex = 5;
            this.labelControl7.Text = "Đến";
            // 
            // txtCostFrom
            // 
            this.txtCostFrom.Location = new System.Drawing.Point(566, 35);
            this.txtCostFrom.Name = "txtCostFrom";
            this.txtCostFrom.Size = new System.Drawing.Size(132, 20);
            this.txtCostFrom.TabIndex = 4;
            // 
            // sbtnCostFromTo
            // 
            this.sbtnCostFromTo.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sbtnCostFromTo.Appearance.Options.UseFont = true;
            this.sbtnCostFromTo.Location = new System.Drawing.Point(428, 28);
            this.sbtnCostFromTo.Name = "sbtnCostFromTo";
            this.sbtnCostFromTo.Size = new System.Drawing.Size(132, 33);
            this.sbtnCostFromTo.TabIndex = 3;
            this.sbtnCostFromTo.Text = "Sản phẩm có giá từ";
            this.sbtnCostFromTo.Click += new System.EventHandler(this.sbtnCostFromTo_Click);
            // 
            // sbtnOutOfDate
            // 
            this.sbtnOutOfDate.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sbtnOutOfDate.Appearance.Options.UseFont = true;
            this.sbtnOutOfDate.Location = new System.Drawing.Point(290, 28);
            this.sbtnOutOfDate.Name = "sbtnOutOfDate";
            this.sbtnOutOfDate.Size = new System.Drawing.Size(132, 33);
            this.sbtnOutOfDate.TabIndex = 2;
            this.sbtnOutOfDate.Text = "Sản phẩm quá hạn";
            this.sbtnOutOfDate.Click += new System.EventHandler(this.sbtnOutOfDate_Click);
            // 
            // sbtnProductJapanese
            // 
            this.sbtnProductJapanese.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sbtnProductJapanese.Appearance.Options.UseFont = true;
            this.sbtnProductJapanese.Location = new System.Drawing.Point(152, 28);
            this.sbtnProductJapanese.Name = "sbtnProductJapanese";
            this.sbtnProductJapanese.Size = new System.Drawing.Size(132, 33);
            this.sbtnProductJapanese.TabIndex = 1;
            this.sbtnProductJapanese.Text = "Sản phẩm nhật bản";
            this.sbtnProductJapanese.Click += new System.EventHandler(this.sbtnProductJapanese_Click);
            // 
            // sbtnMaxScost
            // 
            this.sbtnMaxScost.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sbtnMaxScost.Appearance.Options.UseFont = true;
            this.sbtnMaxScost.Location = new System.Drawing.Point(14, 28);
            this.sbtnMaxScost.Name = "sbtnMaxScost";
            this.sbtnMaxScost.Size = new System.Drawing.Size(132, 33);
            this.sbtnMaxScost.TabIndex = 0;
            this.sbtnMaxScost.Text = "Đơn giá cao nhất";
            this.sbtnMaxScost.Click += new System.EventHandler(this.sbtnMaxScost_Click);
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.lsvProduct);
            this.groupControl3.Location = new System.Drawing.Point(12, 344);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(863, 387);
            this.groupControl3.TabIndex = 1;
            this.groupControl3.Text = "Danh sách sản phẩm sau khi nhập";
            // 
            // lsvProduct
            // 
            this.lsvProduct.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader11,
            this.columnHeader12});
            this.lsvProduct.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsvProduct.FullRowSelect = true;
            this.lsvProduct.GridLines = true;
            this.lsvProduct.HideSelection = false;
            this.lsvProduct.Location = new System.Drawing.Point(5, 26);
            this.lsvProduct.Name = "lsvProduct";
            this.lsvProduct.Size = new System.Drawing.Size(853, 356);
            this.lsvProduct.TabIndex = 0;
            this.lsvProduct.UseCompatibleStateImageBehavior = false;
            this.lsvProduct.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Mã sản phẩm";
            this.columnHeader7.Width = 116;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Tên sản phẩm";
            this.columnHeader8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader8.Width = 144;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Số lượng";
            this.columnHeader9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader9.Width = 114;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Đơn giá";
            this.columnHeader10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader10.Width = 144;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Xuất xứ";
            this.columnHeader11.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader11.Width = 133;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "Ngày hết hạn";
            this.columnHeader12.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader12.Width = 171;
            // 
            // groupControl4
            // 
            this.groupControl4.Controls.Add(this.sbtnRemoveOutOfDate);
            this.groupControl4.Controls.Add(this.sbtnRemoveAll);
            this.groupControl4.Controls.Add(this.sbtnProductOutOfDate);
            this.groupControl4.Controls.Add(this.sbtnRemove);
            this.groupControl4.Controls.Add(this.txtFindOrigin);
            this.groupControl4.Controls.Add(this.labelControl8);
            this.groupControl4.Location = new System.Drawing.Point(881, 344);
            this.groupControl4.Name = "groupControl4";
            this.groupControl4.Size = new System.Drawing.Size(354, 387);
            this.groupControl4.TabIndex = 2;
            this.groupControl4.Text = "Chọn thao tác";
            // 
            // sbtnRemoveOutOfDate
            // 
            this.sbtnRemoveOutOfDate.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sbtnRemoveOutOfDate.Appearance.Options.UseFont = true;
            this.sbtnRemoveOutOfDate.Location = new System.Drawing.Point(15, 171);
            this.sbtnRemoveOutOfDate.Name = "sbtnRemoveOutOfDate";
            this.sbtnRemoveOutOfDate.Size = new System.Drawing.Size(322, 40);
            this.sbtnRemoveOutOfDate.TabIndex = 5;
            this.sbtnRemoveOutOfDate.Text = "Xoá sản phẩm quá hạn";
            this.sbtnRemoveOutOfDate.Click += new System.EventHandler(this.sbtnRemoveOutOfDate_Click);
            // 
            // sbtnRemoveAll
            // 
            this.sbtnRemoveAll.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sbtnRemoveAll.Appearance.Options.UseFont = true;
            this.sbtnRemoveAll.Location = new System.Drawing.Point(16, 127);
            this.sbtnRemoveAll.Name = "sbtnRemoveAll";
            this.sbtnRemoveAll.Size = new System.Drawing.Size(321, 38);
            this.sbtnRemoveAll.TabIndex = 4;
            this.sbtnRemoveAll.Text = "Xoá sản phẩm trong kho";
            this.sbtnRemoveAll.Click += new System.EventHandler(this.sbtnRemoveAll_Click);
            // 
            // sbtnProductOutOfDate
            // 
            this.sbtnProductOutOfDate.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sbtnProductOutOfDate.Appearance.Options.UseFont = true;
            this.sbtnProductOutOfDate.Location = new System.Drawing.Point(15, 85);
            this.sbtnProductOutOfDate.Name = "sbtnProductOutOfDate";
            this.sbtnProductOutOfDate.Size = new System.Drawing.Size(322, 36);
            this.sbtnProductOutOfDate.TabIndex = 3;
            this.sbtnProductOutOfDate.Text = "Kiểm tra sản phẩm quá hạn";
            this.sbtnProductOutOfDate.Click += new System.EventHandler(this.sbtnProductOutOfDate_Click);
            // 
            // sbtnRemove
            // 
            this.sbtnRemove.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sbtnRemove.Appearance.Options.UseFont = true;
            this.sbtnRemove.Location = new System.Drawing.Point(215, 49);
            this.sbtnRemove.Name = "sbtnRemove";
            this.sbtnRemove.Size = new System.Drawing.Size(122, 30);
            this.sbtnRemove.TabIndex = 2;
            this.sbtnRemove.Text = "Xoá";
            this.sbtnRemove.Click += new System.EventHandler(this.sbtnRemove_Click);
            // 
            // txtFindOrigin
            // 
            this.txtFindOrigin.Location = new System.Drawing.Point(15, 55);
            this.txtFindOrigin.Name = "txtFindOrigin";
            this.txtFindOrigin.Size = new System.Drawing.Size(185, 20);
            this.txtFindOrigin.TabIndex = 1;
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Location = new System.Drawing.Point(16, 33);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(183, 16);
            this.labelControl8.TabIndex = 0;
            this.labelControl8.Text = "Nhập xuất xứ sản phẩm cần xoá";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1247, 740);
            this.Controls.Add(this.groupControl4);
            this.Controls.Add(this.groupControl3);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Name = "Form1";
            this.Text = "Quản lý thông tin sản phẩm";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtpProductOutOfDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCostTo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCostFrom.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).EndInit();
            this.groupControl4.ResumeLayout(false);
            this.groupControl4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtFindOrigin.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.TextEdit txtCostTo;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.TextEdit txtCostFrom;
        private DevExpress.XtraEditors.SimpleButton sbtnCostFromTo;
        private DevExpress.XtraEditors.SimpleButton sbtnOutOfDate;
        private DevExpress.XtraEditors.SimpleButton sbtnProductJapanese;
        private DevExpress.XtraEditors.SimpleButton sbtnMaxScost;
        private DevExpress.XtraEditors.SimpleButton sbtnRemoveProduct;
        private DevExpress.XtraEditors.SimpleButton sbtnAdd;
        private System.Windows.Forms.ListView lsvTask;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private System.Windows.Forms.ListView lsvProduct;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private DevExpress.XtraEditors.GroupControl groupControl4;
        private DevExpress.XtraEditors.TextEdit txtFindOrigin;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.SimpleButton sbtnRemoveOutOfDate;
        private DevExpress.XtraEditors.SimpleButton sbtnRemoveAll;
        private DevExpress.XtraEditors.SimpleButton sbtnProductOutOfDate;
        private DevExpress.XtraEditors.SimpleButton sbtnRemove;
        private System.Windows.Forms.TextBox txtProductOrigin;
        private System.Windows.Forms.TextBox txtProductCost;
        private System.Windows.Forms.TextBox txtProductAmount;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.TextBox txtProductCode;
        private DevExpress.XtraEditors.DateTimeOffsetEdit dtpProductOutOfDate;
    }
}

