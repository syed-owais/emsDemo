using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EMS_Aptech.DBModel;

namespace EMS_Aptech
{
    public partial class DepartmentForm : UserControl
    {
        public DepartmentForm()
        {
            InitializeComponent();
        }

        private void panalTop_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuCustomTextbox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Department_model dp_model = new Department_model();
            if (txtName.Text == string.Empty)
            {
                //MessageBox.Show("Department Name could not be Empty. Please Fill it. Thanks!");
                ErrProAdd.SetError(txtName, "Department Name could not be Empty");
            }
            else
            {
                ErrProAdd.Clear();
                dp_model.DepartName = txtName.Text;
                bool Success = dp_model.Insert(dp_model);
                if (Success == true)
                {
                    MessageBox.Show("Deparment Enterd");
                    //load the data in data grid view
                    DataTable dt = dp_model.Select();
                    dgvDepart.DataSource = dt;
                }
            }
        }

        private void DepartmentForm_Load(object sender, EventArgs e)
        {
            Department_model dp_model = new Department_model();
            //load the data in data grid view
            DataTable dt = dp_model.Select();
            dgvDepart.DataSource = dt;
        }

        private void dgvDepart_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //Get the data to DataGridView and set it to the text boxs..
            //first identify the row on which mouse is clicked
            int rowIndex = e.RowIndex;
            lblID.Text = dgvDepart.Rows[rowIndex].Cells[0].Value.ToString();
            txtName.Text = dgvDepart.Rows[rowIndex].Cells[1].Value.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Department_model dp_model = new Department_model();
            if(txtName.Text == string.Empty)
            {
                ErrProUpdate.SetError(txtName, "Department Name could not be Empty");
            }
            else
            {
                ErrProUpdate.Clear();
                dp_model.DepartName = txtName.Text;
                dp_model.DepartID = Convert.ToInt32(lblID.Text);
                bool Success = dp_model.Update(dp_model);
                if(Success == true)
                {
                    txtName.Text = "";
                    //Refresh the data in data grid view
                    DataTable dt = dp_model.Select();
                    dgvDepart.DataSource = dt;
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Department_model dp_model = new Department_model();
            //Get the Id from lblID 
            dp_model.DepartID = Convert.ToInt32(lblID.Text);
            var confirmDB = MessageBox.Show("Are you sure you want to Delete '"+txtName.Text+"' Department","Confirmation!!",MessageBoxButtons.YesNo);
            if (confirmDB == DialogResult.Yes)
            {
                bool Success = dp_model.Delete(dp_model);
                if (Success == true)
                {
                    MessageBox.Show("Department Deleted!");
                    //Refresh the data in data grid view
                    DataTable dt = dp_model.Select();
                    dgvDepart.DataSource = dt;
                } 
            }

        }

       
       
    }
}
