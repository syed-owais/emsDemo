namespace EMS_Aptech
{
    partial class UC_Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Dashboard));
            this.panaltop = new System.Windows.Forms.Panel();
            this.btnLoadChart = new Bunifu.Framework.UI.BunifuThinButton2();
            this.panalSeablue = new System.Windows.Forms.Panel();
            this.panelDarkgray = new System.Windows.Forms.Panel();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.panalOrange = new System.Windows.Forms.Panel();
            this.lblpres = new System.Windows.Forms.Label();
            this.lblAbs = new System.Windows.Forms.Label();
            this.lblu = new System.Windows.Forms.Label();
            this.lblPresent = new System.Windows.Forms.Label();
            this.lblAbsent = new System.Windows.Forms.Label();
            this.lblUsers = new System.Windows.Forms.Label();
            this.Chart = new Bunifu.DataViz.BunifuDataViz();
            this.panaltop.SuspendLayout();
            this.SuspendLayout();
            // 
            // panaltop
            // 
            this.panaltop.Controls.Add(this.Chart);
            this.panaltop.Controls.Add(this.btnLoadChart);
            this.panaltop.Controls.Add(this.panalSeablue);
            this.panaltop.Controls.Add(this.panelDarkgray);
            this.panaltop.Controls.Add(this.bunifuSeparator1);
            this.panaltop.Controls.Add(this.panalOrange);
            this.panaltop.Controls.Add(this.lblpres);
            this.panaltop.Controls.Add(this.lblAbs);
            this.panaltop.Controls.Add(this.lblu);
            this.panaltop.Controls.Add(this.lblPresent);
            this.panaltop.Controls.Add(this.lblAbsent);
            this.panaltop.Controls.Add(this.lblUsers);
            this.panaltop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panaltop.Location = new System.Drawing.Point(0, 0);
            this.panaltop.Name = "panaltop";
            this.panaltop.Size = new System.Drawing.Size(948, 600);
            this.panaltop.TabIndex = 1;
            // 
            // btnLoadChart
            // 
            this.btnLoadChart.ActiveBorderThickness = 1;
            this.btnLoadChart.ActiveCornerRadius = 30;
            this.btnLoadChart.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnLoadChart.ActiveForecolor = System.Drawing.Color.White;
            this.btnLoadChart.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnLoadChart.BackColor = System.Drawing.SystemColors.Control;
            this.btnLoadChart.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLoadChart.BackgroundImage")));
            this.btnLoadChart.ButtonText = "Load Chart";
            this.btnLoadChart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLoadChart.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadChart.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnLoadChart.IdleBorderThickness = 1;
            this.btnLoadChart.IdleCornerRadius = 30;
            this.btnLoadChart.IdleFillColor = System.Drawing.Color.WhiteSmoke;
            this.btnLoadChart.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnLoadChart.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnLoadChart.Location = new System.Drawing.Point(380, 213);
            this.btnLoadChart.Margin = new System.Windows.Forms.Padding(5);
            this.btnLoadChart.Name = "btnLoadChart";
            this.btnLoadChart.Size = new System.Drawing.Size(181, 41);
            this.btnLoadChart.TabIndex = 2;
            this.btnLoadChart.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnLoadChart.Click += new System.EventHandler(this.btnLoadChart_Click);
            // 
            // panalSeablue
            // 
            this.panalSeablue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(154)))), ((int)(((byte)(150)))));
            this.panalSeablue.Location = new System.Drawing.Point(662, 173);
            this.panalSeablue.Name = "panalSeablue";
            this.panalSeablue.Size = new System.Drawing.Size(87, 10);
            this.panalSeablue.TabIndex = 10;
            // 
            // panelDarkgray
            // 
            this.panelDarkgray.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(46)))));
            this.panelDarkgray.Location = new System.Drawing.Point(423, 173);
            this.panelDarkgray.Name = "panelDarkgray";
            this.panelDarkgray.Size = new System.Drawing.Size(87, 10);
            this.panelDarkgray.TabIndex = 11;
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(78, 189);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(788, 35);
            this.bunifuSeparator1.TabIndex = 1;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // panalOrange
            // 
            this.panalOrange.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(174)))), ((int)(((byte)(57)))));
            this.panalOrange.Location = new System.Drawing.Point(191, 173);
            this.panalOrange.Name = "panalOrange";
            this.panalOrange.Size = new System.Drawing.Size(87, 10);
            this.panalOrange.TabIndex = 9;
            // 
            // lblpres
            // 
            this.lblpres.AutoSize = true;
            this.lblpres.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpres.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblpres.Location = new System.Drawing.Point(639, 33);
            this.lblpres.Name = "lblpres";
            this.lblpres.Size = new System.Drawing.Size(113, 15);
            this.lblpres.TabIndex = 8;
            this.lblpres.Text = "Present Employees";
            // 
            // lblAbs
            // 
            this.lblAbs.AutoSize = true;
            this.lblAbs.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAbs.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblAbs.Location = new System.Drawing.Point(415, 33);
            this.lblAbs.Name = "lblAbs";
            this.lblAbs.Size = new System.Drawing.Size(108, 15);
            this.lblAbs.TabIndex = 7;
            this.lblAbs.Text = "Absent Employees";
            // 
            // lblu
            // 
            this.lblu.AutoSize = true;
            this.lblu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblu.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblu.Location = new System.Drawing.Point(200, 33);
            this.lblu.Name = "lblu";
            this.lblu.Size = new System.Drawing.Size(63, 15);
            this.lblu.TabIndex = 6;
            this.lblu.Text = "Total User";
            // 
            // lblPresent
            // 
            this.lblPresent.AutoSize = true;
            this.lblPresent.Font = new System.Drawing.Font("Segoe UI Light", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPresent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(78)))), ((int)(((byte)(78)))));
            this.lblPresent.Location = new System.Drawing.Point(608, 39);
            this.lblPresent.Name = "lblPresent";
            this.lblPresent.Size = new System.Drawing.Size(189, 128);
            this.lblPresent.TabIndex = 5;
            this.lblPresent.Text = "451";
            // 
            // lblAbsent
            // 
            this.lblAbsent.AutoSize = true;
            this.lblAbsent.Font = new System.Drawing.Font("Segoe UI Light", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAbsent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(78)))), ((int)(((byte)(78)))));
            this.lblAbsent.Location = new System.Drawing.Point(395, 39);
            this.lblAbsent.Name = "lblAbsent";
            this.lblAbsent.Size = new System.Drawing.Size(153, 128);
            this.lblAbsent.TabIndex = 4;
            this.lblAbsent.Text = "09";
            // 
            // lblUsers
            // 
            this.lblUsers.AutoSize = true;
            this.lblUsers.Font = new System.Drawing.Font("Segoe UI Light", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(78)))), ((int)(((byte)(78)))));
            this.lblUsers.Location = new System.Drawing.Point(144, 39);
            this.lblUsers.Name = "lblUsers";
            this.lblUsers.Size = new System.Drawing.Size(204, 128);
            this.lblUsers.TabIndex = 3;
            this.lblUsers.Text = "450";
            // 
            // Chart
            // 
            this.Chart.animationEnabled = true;
            this.Chart.AxisLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(78)))), ((int)(((byte)(78)))));
            this.Chart.AxisXFontColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(78)))), ((int)(((byte)(78)))));
            this.Chart.AxisXGridColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(78)))), ((int)(((byte)(78)))));
            this.Chart.AxisXGridThickness = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.Chart.AxisYFontColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(78)))), ((int)(((byte)(78)))));
            this.Chart.AxisYGridColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(78)))), ((int)(((byte)(78)))));
            this.Chart.AxisYGridThickness = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.Chart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Chart.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Chart.Location = new System.Drawing.Point(45, 266);
            this.Chart.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.Chart.Name = "Chart";
            this.Chart.Size = new System.Drawing.Size(870, 250);
            this.Chart.TabIndex = 12;
            this.Chart.Theme = Bunifu.DataViz.BunifuDataViz._theme.theme1;
            this.Chart.Title = "";
            // 
            // UC_Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panaltop);
            this.Name = "UC_Dashboard";
            this.Size = new System.Drawing.Size(948, 600);
            this.panaltop.ResumeLayout(false);
            this.panaltop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panaltop;
        private Bunifu.Framework.UI.BunifuThinButton2 btnLoadChart;
        private System.Windows.Forms.Panel panalSeablue;
        private System.Windows.Forms.Panel panelDarkgray;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private System.Windows.Forms.Panel panalOrange;
        private System.Windows.Forms.Label lblpres;
        private System.Windows.Forms.Label lblAbs;
        private System.Windows.Forms.Label lblu;
        private System.Windows.Forms.Label lblPresent;
        private System.Windows.Forms.Label lblAbsent;
        private System.Windows.Forms.Label lblUsers;
        private Bunifu.DataViz.BunifuDataViz Chart;
    }
}
