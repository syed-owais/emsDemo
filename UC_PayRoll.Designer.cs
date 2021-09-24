namespace EMS_Aptech
{
    partial class UC_PayRoll
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_PayRoll));
            this.Header = new System.Windows.Forms.Panel();
            this.lblTopHeading = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblBarcde = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtBarcode = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.DP_month = new Bunifu.Framework.UI.BunifuDatepicker();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.centerPanal = new System.Windows.Forms.Panel();
            this.btnSave = new Bunifu.Framework.UI.BunifuFlatButton();
            this.comboPaymentMethod = new System.Windows.Forms.ComboBox();
            this.txtDeduction = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtComment = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtBonus = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtFineDeduction = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtPaymentAmount = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtNetSalary = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtGrossSalary = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.picEMP = new System.Windows.Forms.PictureBox();
            this.bunifuCustomLabel14 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblJobTitle = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel11 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel9 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel10 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel13 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel12 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel6 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel8 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblDepartment = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel7 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblEId = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblName = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.Header.SuspendLayout();
            this.centerPanal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picEMP)).BeginInit();
            this.SuspendLayout();
            // 
            // Header
            // 
            this.Header.Controls.Add(this.lblTopHeading);
            this.Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.Header.Location = new System.Drawing.Point(0, 0);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(948, 55);
            this.Header.TabIndex = 0;
            // 
            // lblTopHeading
            // 
            this.lblTopHeading.AutoSize = true;
            this.lblTopHeading.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTopHeading.Location = new System.Drawing.Point(393, 15);
            this.lblTopHeading.Name = "lblTopHeading";
            this.lblTopHeading.Size = new System.Drawing.Size(163, 24);
            this.lblTopHeading.TabIndex = 0;
            this.lblTopHeading.Text = "Employee Payroll";
            // 
            // lblBarcde
            // 
            this.lblBarcde.AutoSize = true;
            this.lblBarcde.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBarcde.Location = new System.Drawing.Point(31, 92);
            this.lblBarcde.Name = "lblBarcde";
            this.lblBarcde.Size = new System.Drawing.Size(129, 18);
            this.lblBarcde.TabIndex = 1;
            this.lblBarcde.Text = "Employee Barcode";
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(535, 92);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(47, 17);
            this.bunifuCustomLabel1.TabIndex = 3;
            this.bunifuCustomLabel1.Text = "Month";
            // 
            // txtBarcode
            // 
            this.txtBarcode.BorderColorFocused = System.Drawing.Color.Blue;
            this.txtBarcode.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtBarcode.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txtBarcode.BorderThickness = 3;
            this.txtBarcode.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBarcode.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtBarcode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtBarcode.isPassword = false;
            this.txtBarcode.Location = new System.Drawing.Point(164, 78);
            this.txtBarcode.Margin = new System.Windows.Forms.Padding(4);
            this.txtBarcode.Name = "txtBarcode";
            this.txtBarcode.Size = new System.Drawing.Size(359, 44);
            this.txtBarcode.TabIndex = 0;
            this.txtBarcode.Text = "Scan Employee\'s Barcode Here";
            this.txtBarcode.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtBarcode.OnValueChanged += new System.EventHandler(this.txtBarcode_OnValueChanged);
            this.txtBarcode.Enter += new System.EventHandler(this.txtBarcode_Enter);
            this.txtBarcode.Leave += new System.EventHandler(this.txtBarcode_Leave);
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(535, 92);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(49, 18);
            this.bunifuCustomLabel2.TabIndex = 3;
            this.bunifuCustomLabel2.Text = "Month";
            // 
            // DP_month
            // 
            this.DP_month.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(184)))), ((int)(((byte)(92)))));
            this.DP_month.BorderRadius = 0;
            this.DP_month.ForeColor = System.Drawing.Color.White;
            this.DP_month.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.DP_month.FormatCustom = null;
            this.DP_month.Location = new System.Drawing.Point(597, 79);
            this.DP_month.Name = "DP_month";
            this.DP_month.Size = new System.Drawing.Size(311, 44);
            this.DP_month.TabIndex = 5;
            this.DP_month.Value = new System.DateTime(2018, 6, 26, 18, 34, 0, 331);
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(36, 129);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(872, 35);
            this.bunifuSeparator1.TabIndex = 7;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // centerPanal
            // 
            this.centerPanal.BackColor = System.Drawing.Color.White;
            this.centerPanal.Controls.Add(this.btnSave);
            this.centerPanal.Controls.Add(this.comboPaymentMethod);
            this.centerPanal.Controls.Add(this.txtDeduction);
            this.centerPanal.Controls.Add(this.txtComment);
            this.centerPanal.Controls.Add(this.txtBonus);
            this.centerPanal.Controls.Add(this.txtFineDeduction);
            this.centerPanal.Controls.Add(this.txtPaymentAmount);
            this.centerPanal.Controls.Add(this.txtNetSalary);
            this.centerPanal.Controls.Add(this.txtGrossSalary);
            this.centerPanal.Controls.Add(this.picEMP);
            this.centerPanal.Controls.Add(this.bunifuCustomLabel14);
            this.centerPanal.Controls.Add(this.lblJobTitle);
            this.centerPanal.Controls.Add(this.bunifuCustomLabel11);
            this.centerPanal.Controls.Add(this.bunifuCustomLabel9);
            this.centerPanal.Controls.Add(this.bunifuCustomLabel10);
            this.centerPanal.Controls.Add(this.bunifuCustomLabel13);
            this.centerPanal.Controls.Add(this.bunifuCustomLabel12);
            this.centerPanal.Controls.Add(this.bunifuCustomLabel6);
            this.centerPanal.Controls.Add(this.bunifuCustomLabel8);
            this.centerPanal.Controls.Add(this.lblDepartment);
            this.centerPanal.Controls.Add(this.bunifuCustomLabel4);
            this.centerPanal.Controls.Add(this.bunifuCustomLabel7);
            this.centerPanal.Controls.Add(this.lblEId);
            this.centerPanal.Controls.Add(this.bunifuCustomLabel5);
            this.centerPanal.Controls.Add(this.lblName);
            this.centerPanal.Controls.Add(this.bunifuCustomLabel3);
            this.centerPanal.Location = new System.Drawing.Point(28, 164);
            this.centerPanal.Margin = new System.Windows.Forms.Padding(4);
            this.centerPanal.Name = "centerPanal";
            this.centerPanal.Size = new System.Drawing.Size(890, 391);
            this.centerPanal.TabIndex = 8;
            // 
            // btnSave
            // 
            this.btnSave.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(127)))), ((int)(((byte)(169)))));
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(141)))), ((int)(((byte)(188)))));
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSave.BorderRadius = 0;
            this.btnSave.ButtonText = " Save Salary";
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.DisabledColor = System.Drawing.Color.Gray;
            this.btnSave.Iconcolor = System.Drawing.Color.Transparent;
            this.btnSave.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnSave.Iconimage")));
            this.btnSave.Iconimage_right = null;
            this.btnSave.Iconimage_right_Selected = null;
            this.btnSave.Iconimage_Selected = null;
            this.btnSave.IconMarginLeft = 0;
            this.btnSave.IconMarginRight = 0;
            this.btnSave.IconRightVisible = true;
            this.btnSave.IconRightZoom = 0D;
            this.btnSave.IconVisible = true;
            this.btnSave.IconZoom = 50D;
            this.btnSave.IsTab = false;
            this.btnSave.Location = new System.Drawing.Point(740, 329);
            this.btnSave.Name = "btnSave";
            this.btnSave.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(141)))), ((int)(((byte)(188)))));
            this.btnSave.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(127)))), ((int)(((byte)(169)))));
            this.btnSave.OnHoverTextColor = System.Drawing.Color.White;
            this.btnSave.selected = false;
            this.btnSave.Size = new System.Drawing.Size(125, 40);
            this.btnSave.TabIndex = 14;
            this.btnSave.Text = " Save Salary";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Textcolor = System.Drawing.Color.White;
            this.btnSave.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // comboPaymentMethod
            // 
            this.comboPaymentMethod.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboPaymentMethod.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.comboPaymentMethod.FormattingEnabled = true;
            this.comboPaymentMethod.ItemHeight = 16;
            this.comboPaymentMethod.Items.AddRange(new object[] {
            "Check",
            "Cash",
            "Cradit",
            "Electronic Transfer"});
            this.comboPaymentMethod.Location = new System.Drawing.Point(500, 269);
            this.comboPaymentMethod.Name = "comboPaymentMethod";
            this.comboPaymentMethod.Size = new System.Drawing.Size(153, 24);
            this.comboPaymentMethod.TabIndex = 13;
            // 
            // txtDeduction
            // 
            this.txtDeduction.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.txtDeduction.BorderColorFocused = System.Drawing.Color.Transparent;
            this.txtDeduction.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtDeduction.BorderColorMouseHover = System.Drawing.Color.Transparent;
            this.txtDeduction.BorderThickness = 1;
            this.txtDeduction.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDeduction.Enabled = false;
            this.txtDeduction.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtDeduction.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtDeduction.isPassword = false;
            this.txtDeduction.Location = new System.Drawing.Point(500, 101);
            this.txtDeduction.Margin = new System.Windows.Forms.Padding(4);
            this.txtDeduction.Name = "txtDeduction";
            this.txtDeduction.Size = new System.Drawing.Size(153, 43);
            this.txtDeduction.TabIndex = 12;
            this.txtDeduction.Text = "00,000.00";
            this.txtDeduction.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtComment
            // 
            this.txtComment.BackColor = System.Drawing.Color.White;
            this.txtComment.BorderColorFocused = System.Drawing.Color.Transparent;
            this.txtComment.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtComment.BorderColorMouseHover = System.Drawing.Color.Transparent;
            this.txtComment.BorderThickness = 1;
            this.txtComment.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtComment.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtComment.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtComment.isPassword = false;
            this.txtComment.Location = new System.Drawing.Point(161, 319);
            this.txtComment.Margin = new System.Windows.Forms.Padding(4);
            this.txtComment.Name = "txtComment";
            this.txtComment.Size = new System.Drawing.Size(492, 43);
            this.txtComment.TabIndex = 12;
            this.txtComment.Text = "Wright your Comment here...";
            this.txtComment.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtComment.Enter += new System.EventHandler(this.txtComment_Enter);
            this.txtComment.Leave += new System.EventHandler(this.txtComment_Leave);
            // 
            // txtBonus
            // 
            this.txtBonus.BackColor = System.Drawing.Color.White;
            this.txtBonus.BorderColorFocused = System.Drawing.Color.Transparent;
            this.txtBonus.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtBonus.BorderColorMouseHover = System.Drawing.Color.Transparent;
            this.txtBonus.BorderThickness = 1;
            this.txtBonus.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBonus.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtBonus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtBonus.isPassword = false;
            this.txtBonus.Location = new System.Drawing.Point(161, 210);
            this.txtBonus.Margin = new System.Windows.Forms.Padding(4);
            this.txtBonus.Name = "txtBonus";
            this.txtBonus.Size = new System.Drawing.Size(492, 43);
            this.txtBonus.TabIndex = 12;
            this.txtBonus.Text = "00,000.00";
            this.txtBonus.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtBonus.Enter += new System.EventHandler(this.txtBonus_Enter);
            this.txtBonus.Leave += new System.EventHandler(this.txtBonus_Leave);
            // 
            // txtFineDeduction
            // 
            this.txtFineDeduction.BackColor = System.Drawing.Color.White;
            this.txtFineDeduction.BorderColorFocused = System.Drawing.Color.Transparent;
            this.txtFineDeduction.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtFineDeduction.BorderColorMouseHover = System.Drawing.Color.Transparent;
            this.txtFineDeduction.BorderThickness = 1;
            this.txtFineDeduction.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFineDeduction.Enabled = false;
            this.txtFineDeduction.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtFineDeduction.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtFineDeduction.isPassword = false;
            this.txtFineDeduction.Location = new System.Drawing.Point(500, 156);
            this.txtFineDeduction.Margin = new System.Windows.Forms.Padding(4);
            this.txtFineDeduction.Name = "txtFineDeduction";
            this.txtFineDeduction.Size = new System.Drawing.Size(153, 43);
            this.txtFineDeduction.TabIndex = 12;
            this.txtFineDeduction.Text = "00,000.00";
            this.txtFineDeduction.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtPaymentAmount
            // 
            this.txtPaymentAmount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.txtPaymentAmount.BorderColorFocused = System.Drawing.Color.Transparent;
            this.txtPaymentAmount.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPaymentAmount.BorderColorMouseHover = System.Drawing.Color.Transparent;
            this.txtPaymentAmount.BorderThickness = 1;
            this.txtPaymentAmount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPaymentAmount.Enabled = false;
            this.txtPaymentAmount.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtPaymentAmount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPaymentAmount.isPassword = false;
            this.txtPaymentAmount.Location = new System.Drawing.Point(161, 263);
            this.txtPaymentAmount.Margin = new System.Windows.Forms.Padding(4);
            this.txtPaymentAmount.Name = "txtPaymentAmount";
            this.txtPaymentAmount.Size = new System.Drawing.Size(153, 43);
            this.txtPaymentAmount.TabIndex = 12;
            this.txtPaymentAmount.Text = "00,000.00";
            this.txtPaymentAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtNetSalary
            // 
            this.txtNetSalary.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.txtNetSalary.BorderColorFocused = System.Drawing.Color.Transparent;
            this.txtNetSalary.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtNetSalary.BorderColorMouseHover = System.Drawing.Color.Transparent;
            this.txtNetSalary.BorderThickness = 1;
            this.txtNetSalary.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNetSalary.Enabled = false;
            this.txtNetSalary.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtNetSalary.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtNetSalary.isPassword = false;
            this.txtNetSalary.Location = new System.Drawing.Point(161, 156);
            this.txtNetSalary.Margin = new System.Windows.Forms.Padding(4);
            this.txtNetSalary.Name = "txtNetSalary";
            this.txtNetSalary.Size = new System.Drawing.Size(153, 43);
            this.txtNetSalary.TabIndex = 12;
            this.txtNetSalary.Text = "00,000.00";
            this.txtNetSalary.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtGrossSalary
            // 
            this.txtGrossSalary.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.txtGrossSalary.BorderColorFocused = System.Drawing.Color.Transparent;
            this.txtGrossSalary.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtGrossSalary.BorderColorMouseHover = System.Drawing.Color.Transparent;
            this.txtGrossSalary.BorderThickness = 1;
            this.txtGrossSalary.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtGrossSalary.Enabled = false;
            this.txtGrossSalary.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtGrossSalary.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtGrossSalary.isPassword = false;
            this.txtGrossSalary.Location = new System.Drawing.Point(161, 101);
            this.txtGrossSalary.Margin = new System.Windows.Forms.Padding(4);
            this.txtGrossSalary.Name = "txtGrossSalary";
            this.txtGrossSalary.Size = new System.Drawing.Size(153, 43);
            this.txtGrossSalary.TabIndex = 12;
            this.txtGrossSalary.Text = "00,000.00";
            this.txtGrossSalary.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // picEMP
            // 
            this.picEMP.Location = new System.Drawing.Point(702, 36);
            this.picEMP.Name = "picEMP";
            this.picEMP.Size = new System.Drawing.Size(163, 163);
            this.picEMP.TabIndex = 10;
            this.picEMP.TabStop = false;
            // 
            // bunifuCustomLabel14
            // 
            this.bunifuCustomLabel14.AutoSize = true;
            this.bunifuCustomLabel14.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.bunifuCustomLabel14.Location = new System.Drawing.Point(64, 329);
            this.bunifuCustomLabel14.Name = "bunifuCustomLabel14";
            this.bunifuCustomLabel14.Size = new System.Drawing.Size(76, 17);
            this.bunifuCustomLabel14.TabIndex = 5;
            this.bunifuCustomLabel14.Text = "Comment";
            this.bunifuCustomLabel14.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblJobTitle
            // 
            this.lblJobTitle.AutoSize = true;
            this.lblJobTitle.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJobTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.lblJobTitle.Location = new System.Drawing.Point(500, 71);
            this.lblJobTitle.Name = "lblJobTitle";
            this.lblJobTitle.Size = new System.Drawing.Size(58, 17);
            this.lblJobTitle.TabIndex = 3;
            this.lblJobTitle.Text = "Job Titel";
            // 
            // bunifuCustomLabel11
            // 
            this.bunifuCustomLabel11.AutoSize = true;
            this.bunifuCustomLabel11.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.bunifuCustomLabel11.Location = new System.Drawing.Point(88, 220);
            this.bunifuCustomLabel11.Name = "bunifuCustomLabel11";
            this.bunifuCustomLabel11.Size = new System.Drawing.Size(52, 17);
            this.bunifuCustomLabel11.TabIndex = 5;
            this.bunifuCustomLabel11.Text = "Bonus";
            this.bunifuCustomLabel11.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // bunifuCustomLabel9
            // 
            this.bunifuCustomLabel9.AutoSize = true;
            this.bunifuCustomLabel9.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.bunifuCustomLabel9.Location = new System.Drawing.Point(396, 71);
            this.bunifuCustomLabel9.Name = "bunifuCustomLabel9";
            this.bunifuCustomLabel9.Size = new System.Drawing.Size(66, 17);
            this.bunifuCustomLabel9.TabIndex = 3;
            this.bunifuCustomLabel9.Text = "Job Titel";
            // 
            // bunifuCustomLabel10
            // 
            this.bunifuCustomLabel10.AutoSize = true;
            this.bunifuCustomLabel10.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.bunifuCustomLabel10.Location = new System.Drawing.Point(352, 166);
            this.bunifuCustomLabel10.Name = "bunifuCustomLabel10";
            this.bunifuCustomLabel10.Size = new System.Drawing.Size(110, 17);
            this.bunifuCustomLabel10.TabIndex = 5;
            this.bunifuCustomLabel10.Text = "Fine Deduction";
            this.bunifuCustomLabel10.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // bunifuCustomLabel13
            // 
            this.bunifuCustomLabel13.AutoSize = true;
            this.bunifuCustomLabel13.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.bunifuCustomLabel13.Location = new System.Drawing.Point(336, 273);
            this.bunifuCustomLabel13.Name = "bunifuCustomLabel13";
            this.bunifuCustomLabel13.Size = new System.Drawing.Size(126, 17);
            this.bunifuCustomLabel13.TabIndex = 5;
            this.bunifuCustomLabel13.Text = "Payment Method";
            this.bunifuCustomLabel13.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // bunifuCustomLabel12
            // 
            this.bunifuCustomLabel12.AutoSize = true;
            this.bunifuCustomLabel12.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.bunifuCustomLabel12.Location = new System.Drawing.Point(11, 273);
            this.bunifuCustomLabel12.Name = "bunifuCustomLabel12";
            this.bunifuCustomLabel12.Size = new System.Drawing.Size(129, 17);
            this.bunifuCustomLabel12.TabIndex = 5;
            this.bunifuCustomLabel12.Text = "Payment Amount";
            this.bunifuCustomLabel12.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // bunifuCustomLabel6
            // 
            this.bunifuCustomLabel6.AutoSize = true;
            this.bunifuCustomLabel6.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.bunifuCustomLabel6.Location = new System.Drawing.Point(384, 111);
            this.bunifuCustomLabel6.Name = "bunifuCustomLabel6";
            this.bunifuCustomLabel6.Size = new System.Drawing.Size(78, 17);
            this.bunifuCustomLabel6.TabIndex = 5;
            this.bunifuCustomLabel6.Text = "Deduction";
            // 
            // bunifuCustomLabel8
            // 
            this.bunifuCustomLabel8.AutoSize = true;
            this.bunifuCustomLabel8.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.bunifuCustomLabel8.Location = new System.Drawing.Point(61, 166);
            this.bunifuCustomLabel8.Name = "bunifuCustomLabel8";
            this.bunifuCustomLabel8.Size = new System.Drawing.Size(79, 17);
            this.bunifuCustomLabel8.TabIndex = 5;
            this.bunifuCustomLabel8.Text = "Net Salary";
            this.bunifuCustomLabel8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblDepartment
            // 
            this.lblDepartment.AutoSize = true;
            this.lblDepartment.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepartment.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.lblDepartment.Location = new System.Drawing.Point(161, 71);
            this.lblDepartment.Name = "lblDepartment";
            this.lblDepartment.Size = new System.Drawing.Size(82, 17);
            this.lblDepartment.TabIndex = 4;
            this.lblDepartment.Text = "Department";
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(47, 111);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(93, 17);
            this.bunifuCustomLabel4.TabIndex = 5;
            this.bunifuCustomLabel4.Text = "Gross Salary";
            // 
            // bunifuCustomLabel7
            // 
            this.bunifuCustomLabel7.AutoSize = true;
            this.bunifuCustomLabel7.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.bunifuCustomLabel7.Location = new System.Drawing.Point(49, 71);
            this.bunifuCustomLabel7.Name = "bunifuCustomLabel7";
            this.bunifuCustomLabel7.Size = new System.Drawing.Size(91, 17);
            this.bunifuCustomLabel7.TabIndex = 5;
            this.bunifuCustomLabel7.Text = "Department";
            // 
            // lblEId
            // 
            this.lblEId.AutoSize = true;
            this.lblEId.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.lblEId.Location = new System.Drawing.Point(161, 36);
            this.lblEId.Name = "lblEId";
            this.lblEId.Size = new System.Drawing.Size(86, 17);
            this.lblEId.TabIndex = 6;
            this.lblEId.Text = "Employee ID";
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.AutoSize = true;
            this.bunifuCustomLabel5.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(44, 36);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(96, 17);
            this.bunifuCustomLabel5.TabIndex = 7;
            this.bunifuCustomLabel5.Text = "Employee ID";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.lblName.Location = new System.Drawing.Point(500, 36);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(107, 17);
            this.lblName.TabIndex = 8;
            this.lblName.Text = "Employee Name";
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(343, 36);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(119, 17);
            this.bunifuCustomLabel3.TabIndex = 9;
            this.bunifuCustomLabel3.Text = "Employee Name";
            // 
            // UC_PayRoll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.centerPanal);
            this.Controls.Add(this.bunifuSeparator1);
            this.Controls.Add(this.DP_month);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.txtBarcode);
            this.Controls.Add(this.lblBarcde);
            this.Controls.Add(this.Header);
            this.Name = "UC_PayRoll";
            this.Size = new System.Drawing.Size(948, 600);
            this.Load += new System.EventHandler(this.UC_PayRoll_Load);
            this.Header.ResumeLayout(false);
            this.Header.PerformLayout();
            this.centerPanal.ResumeLayout(false);
            this.centerPanal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picEMP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Header;
        private Bunifu.Framework.UI.BunifuCustomLabel lblTopHeading;
        private Bunifu.Framework.UI.BunifuCustomLabel lblBarcde;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtBarcode;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuDatepicker DP_month;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private System.Windows.Forms.Panel centerPanal;
        private System.Windows.Forms.PictureBox picEMP;
        private Bunifu.Framework.UI.BunifuCustomLabel lblJobTitle;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel9;
        private Bunifu.Framework.UI.BunifuCustomLabel lblDepartment;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel7;
        private Bunifu.Framework.UI.BunifuCustomLabel lblEId;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel5;
        private Bunifu.Framework.UI.BunifuCustomLabel lblName;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtDeduction;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtNetSalary;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtGrossSalary;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel6;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel8;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtFineDeduction;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel10;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtBonus;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel11;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtPaymentAmount;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel12;
        private System.Windows.Forms.ComboBox comboPaymentMethod;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel13;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtComment;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel14;
        private Bunifu.Framework.UI.BunifuFlatButton btnSave;
    }
}
