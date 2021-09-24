using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EMS_Aptech
{
    public partial class MainWindow : Form
    {
        private bool _dragging;
        private Point _startPoint = new Point(0, 0);
        public MainWindow()
        {
            InitializeComponent();
        }

        private void dashboard_MouseDown(object sender, MouseEventArgs e)
        {
            _dragging = true;
            _startPoint = new Point(e.X, e.Y);

        }

        private void dashboard_MouseMove(object sender, MouseEventArgs e)
        {
            if (!_dragging) return;
            var p = PointToScreen(e.Location);
            Location = new Point(p.X - this._startPoint.X, p.Y - this._startPoint.Y);
        }

        private void dashboard_MouseUp(object sender, MouseEventArgs e)
        {
            _dragging = false;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //this will Close the intier application
            Environment.Exit(0);
        }

        private void btnHide_Click(object sender, EventArgs e)
        {
            //this will allow to minimize the window
            WindowState = FormWindowState.Minimized;
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            uC_Dashboard1.BringToFront();
        }

        private void btnEmployeeReg_Click(object sender, EventArgs e)
        {
            //emp_Reg.BringToFront();
        }

        private void btnReports_Click(object sender, EventArgs e)
        {

        }

        private void btnDepart_Click(object sender, EventArgs e)
        {
            departmentForm.BringToFront();
        }

        private void btnPayroll_Click(object sender, EventArgs e)
        {
            uC_PayRoll1.BringToFront();
        }
    }
}
