namespace EMS_Aptech
{
    partial class DepartmentForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DepartmentForm));
            this.mainPanal = new System.Windows.Forms.Panel();
            this.panelbottom = new System.Windows.Forms.Panel();
            this.dgvDepart = new System.Windows.Forms.DataGridView();
            this.panalTop = new System.Windows.Forms.Panel();
            this.btnDelete = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnUpdate = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnAdd = new Bunifu.Framework.UI.BunifuFlatButton();
            this.lblDep = new System.Windows.Forms.Label();
            this.txtName = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.lblHead = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.ErrProAdd = new System.Windows.Forms.ErrorProvider(this.components);
            this.ErrProUpdate = new System.Windows.Forms.ErrorProvider(this.components);
            this.ErrProDelete = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblID = new System.Windows.Forms.Label();
            this.mainPanal.SuspendLayout();
            this.panelbottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepart)).BeginInit();
            this.panalTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrProAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrProUpdate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrProDelete)).BeginInit();
            this.SuspendLayout();
            // 
            // mainPanal
            // 
            this.mainPanal.Controls.Add(this.panelbottom);
            this.mainPanal.Controls.Add(this.panalTop);
            this.mainPanal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanal.Location = new System.Drawing.Point(0, 0);
            this.mainPanal.Name = "mainPanal";
            this.mainPanal.Size = new System.Drawing.Size(948, 600);
            this.mainPanal.TabIndex = 0;
            // 
            // panelbottom
            // 
            this.panelbottom.Controls.Add(this.dgvDepart);
            this.panelbottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelbottom.Location = new System.Drawing.Point(0, 243);
            this.panelbottom.Name = "panelbottom";
            this.panelbottom.Size = new System.Drawing.Size(948, 357);
            this.panelbottom.TabIndex = 1;
            // 
            // dgvDepart
            // 
            this.dgvDepart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDepart.Location = new System.Drawing.Point(40, 18);
            this.dgvDepart.Name = "dgvDepart";
            this.dgvDepart.Size = new System.Drawing.Size(871, 251);
            this.dgvDepart.TabIndex = 0;
            this.dgvDepart.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvDepart_RowHeaderMouseClick);
            // 
            // panalTop
            // 
            this.panalTop.Controls.Add(this.lblID);
            this.panalTop.Controls.Add(this.btnDelete);
            this.panalTop.Controls.Add(this.btnUpdate);
            this.panalTop.Controls.Add(this.btnAdd);
            this.panalTop.Controls.Add(this.lblDep);
            this.panalTop.Controls.Add(this.txtName);
            this.panalTop.Controls.Add(this.lblHead);
            this.panalTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panalTop.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.panalTop.Location = new System.Drawing.Point(0, 0);
            this.panalTop.Name = "panalTop";
            this.panalTop.Size = new System.Drawing.Size(948, 245);
            this.panalTop.TabIndex = 0;
            this.panalTop.Paint += new System.Windows.Forms.PaintEventHandler(this.panalTop_Paint);
            // 
            // btnDelete
            // 
            this.btnDelete.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDelete.BorderRadius = 0;
            this.btnDelete.ButtonText = "Delete Department";
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.DisabledColor = System.Drawing.Color.Gray;
            this.btnDelete.Iconcolor = System.Drawing.Color.Transparent;
            this.btnDelete.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnDelete.Iconimage")));
            this.btnDelete.Iconimage_right = null;
            this.btnDelete.Iconimage_right_Selected = null;
            this.btnDelete.Iconimage_Selected = null;
            this.btnDelete.IconMarginLeft = 0;
            this.btnDelete.IconMarginRight = 0;
            this.btnDelete.IconRightVisible = true;
            this.btnDelete.IconRightZoom = 0D;
            this.btnDelete.IconVisible = true;
            this.btnDelete.IconZoom = 90D;
            this.btnDelete.IsTab = false;
            this.btnDelete.Location = new System.Drawing.Point(575, 190);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnDelete.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnDelete.OnHoverTextColor = System.Drawing.Color.White;
            this.btnDelete.selected = false;
            this.btnDelete.Size = new System.Drawing.Size(176, 47);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Tag = "1";
            this.btnDelete.Text = "Delete Department";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.Textcolor = System.Drawing.Color.White;
            this.btnDelete.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUpdate.BorderRadius = 0;
            this.btnUpdate.ButtonText = "Update Department";
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.DisabledColor = System.Drawing.Color.Gray;
            this.btnUpdate.Iconcolor = System.Drawing.Color.Transparent;
            this.btnUpdate.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnUpdate.Iconimage")));
            this.btnUpdate.Iconimage_right = null;
            this.btnUpdate.Iconimage_right_Selected = null;
            this.btnUpdate.Iconimage_Selected = null;
            this.btnUpdate.IconMarginLeft = 0;
            this.btnUpdate.IconMarginRight = 0;
            this.btnUpdate.IconRightVisible = true;
            this.btnUpdate.IconRightZoom = 0D;
            this.btnUpdate.IconVisible = true;
            this.btnUpdate.IconZoom = 90D;
            this.btnUpdate.IsTab = false;
            this.btnUpdate.Location = new System.Drawing.Point(380, 190);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnUpdate.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnUpdate.OnHoverTextColor = System.Drawing.Color.White;
            this.btnUpdate.selected = false;
            this.btnUpdate.Size = new System.Drawing.Size(189, 47);
            this.btnUpdate.TabIndex = 4;
            this.btnUpdate.Tag = "1";
            this.btnUpdate.Text = "Update Department";
            this.btnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdate.Textcolor = System.Drawing.Color.White;
            this.btnUpdate.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAdd.BorderRadius = 0;
            this.btnAdd.ButtonText = "Add Department";
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.DisabledColor = System.Drawing.Color.Gray;
            this.btnAdd.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAdd.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnAdd.Iconimage")));
            this.btnAdd.Iconimage_right = null;
            this.btnAdd.Iconimage_right_Selected = null;
            this.btnAdd.Iconimage_Selected = null;
            this.btnAdd.IconMarginLeft = 0;
            this.btnAdd.IconMarginRight = 0;
            this.btnAdd.IconRightVisible = true;
            this.btnAdd.IconRightZoom = 0D;
            this.btnAdd.IconVisible = true;
            this.btnAdd.IconZoom = 90D;
            this.btnAdd.IsTab = false;
            this.btnAdd.Location = new System.Drawing.Point(214, 190);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnAdd.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnAdd.OnHoverTextColor = System.Drawing.Color.White;
            this.btnAdd.selected = false;
            this.btnAdd.Size = new System.Drawing.Size(160, 47);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Tag = "1";
            this.btnAdd.Text = "Add Department";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.Textcolor = System.Drawing.Color.White;
            this.btnAdd.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblDep
            // 
            this.lblDep.AutoSize = true;
            this.lblDep.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblDep.Location = new System.Drawing.Point(257, 113);
            this.lblDep.Name = "lblDep";
            this.lblDep.Size = new System.Drawing.Size(140, 20);
            this.lblDep.TabIndex = 2;
            this.lblDep.Text = "Department Name";
            // 
            // txtName
            // 
            this.txtName.BorderColor = System.Drawing.Color.SeaGreen;
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtName.Location = new System.Drawing.Point(404, 109);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(293, 26);
            this.txtName.TabIndex = 1;
            this.txtName.Tag = "0";
            this.txtName.TextChanged += new System.EventHandler(this.bunifuCustomTextbox1_TextChanged);
            // 
            // lblHead
            // 
            this.lblHead.AutoSize = true;
            this.lblHead.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.lblHead.Location = new System.Drawing.Point(399, 11);
            this.lblHead.Name = "lblHead";
            this.lblHead.Size = new System.Drawing.Size(187, 29);
            this.lblHead.TabIndex = 0;
            this.lblHead.Text = "Add Department";
            // 
            // ErrProAdd
            // 
            this.ErrProAdd.ContainerControl = this;
            // 
            // ErrProUpdate
            // 
            this.ErrProUpdate.ContainerControl = this;
            // 
            // ErrProDelete
            // 
            this.ErrProDelete.ContainerControl = this;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblID.Location = new System.Drawing.Point(407, 138);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(0, 20);
            this.lblID.TabIndex = 6;
            this.lblID.Visible = false;
            // 
            // DepartmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mainPanal);
            this.Name = "DepartmentForm";
            this.Size = new System.Drawing.Size(948, 600);
            this.Load += new System.EventHandler(this.DepartmentForm_Load);
            this.mainPanal.ResumeLayout(false);
            this.panelbottom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepart)).EndInit();
            this.panalTop.ResumeLayout(false);
            this.panalTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrProAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrProUpdate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrProDelete)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mainPanal;
        private System.Windows.Forms.Panel panelbottom;
        private System.Windows.Forms.Panel panalTop;
        private Bunifu.Framework.UI.BunifuCustomLabel lblHead;
        private System.Windows.Forms.Label lblDep;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txtName;
        private Bunifu.Framework.UI.BunifuFlatButton btnDelete;
        private Bunifu.Framework.UI.BunifuFlatButton btnUpdate;
        private Bunifu.Framework.UI.BunifuFlatButton btnAdd;
        private System.Windows.Forms.DataGridView dgvDepart;
        private System.Windows.Forms.ErrorProvider ErrProAdd;
        private System.Windows.Forms.ErrorProvider ErrProUpdate;
        private System.Windows.Forms.ErrorProvider ErrProDelete;
        private System.Windows.Forms.Label lblID;
    }
}
