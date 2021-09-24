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
using System.Data.SqlClient;
using System.Configuration;
using System.Text.RegularExpressions;

namespace EMS_Aptech
{
   
    public partial class EMP_Reg : UserControl
    {
        EMP_Reg_Model erm = new EMP_Reg_Model();
        public EMP_Reg()
        {
            InitializeComponent();
            
            //load the Department Name in combobox  
            getDepartment();
        }

        private void btn_add_emp_Click(object sender, EventArgs e)
        {
            ComboboxItem item = new ComboboxItem();
            if (txtFirstName.Text == "" || txtLastName.Text == "" || txtPhone.Text == "" || txtCnic.Text == "" || txtDOB.Text == "" || txtEmail.Text == "" || combo_gender.Text == "Select Gender" || comboDept.Text == "Select Department" || txtJoiningDate.Text == "" || txtSalary.Text == "" || txtWorkingHours.Text == "" || txtWageRate.Text == "" || txtAddress.Text == "")
            {
                MessageBox.Show("Form is not fill properly.", "Submission Faild");
            }
            else
            {
                erm.FirstName = txtFirstName.Text.ToString();
                erm.LastName = txtLastName.Text.ToString();
                erm.Phone = txtPhone.Text.ToString();
                erm.CNICNo = txtCnic.Text.ToString();
                erm.Age = txtDOB.Text.ToString();
                erm.Email = txtEmail.Text.ToString();
                erm.Gender = combo_gender.Text.ToString();
                erm.Address = txtAddress.Text.ToString();
                erm.Barcode = txtBarcode.Text.ToString();
                erm.JoiningDate = DateTime.Parse(txtJoiningDate.Text.ToString());
                erm.WageRate = float.Parse(txtWageRate.Text.ToString());
                erm.WorkingHours = float.Parse(txtWorkingHours.Text.ToString());
                erm.Salary = int.Parse(txtSalary.Text.ToString());
                string cmbvalue = (comboDept.SelectedItem as ComboboxItem).Value.ToString();
                erm.DepartmentID = Convert.ToInt32(cmbvalue);

                bool Success = erm.Insert(erm);
                if (Success == true)
                {
                    MessageBox.Show("Employee Registerd Succssfull!");
                }
                else
                {
                    MessageBox.Show("Employee Registerd Faild!");
                }
            }

        }

        private void getDepartment()
        {
            string myConn = ConfigurationManager.ConnectionStrings["connString"].ConnectionString;

            SqlConnection sql = new SqlConnection(myConn);
            try
            {
                string query = "SELECT * FROM Department";
                sql.Open();
                SqlCommand cmd = new SqlCommand(query,sql);
                SqlDataReader dr = cmd.ExecuteReader();
                
                
                while (dr.Read())
                {
                    ComboboxItem item = new ComboboxItem();
                    item.Text = dr[1].ToString();
                    item.Value = dr[0];
                    comboDept.Items.Add(item);
                }

            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
            finally
            {
                sql.Close();
            }
        }

        private void EMP_Reg_Load(object sender, EventArgs e)
        {

        }

        private void salary_Tab(object sender, EventArgs e)
        {
            float hours, result;
            int salary;
            hours = float.Parse(txtWorkingHours.Text.ToString()); //get working hours in hours float variable 
            salary = Convert.ToInt32(txtSalary.Text.ToString()); //get salary in salary integer variable 

            result = salary / 30 / hours; // calculate wage rate
            txtWageRate.Text = result.ToString();
        }

        //public void RegExp(string rgex, TextBox textBox)
        //{
        //    Regex regex = new Regex(rgex);
        //    if (regex.IsMatch(textBox.Text))
        //    {
                    
        //    }
        //}
    }
    public class ComboboxItem
    {
        public string Text { get; set; }
        public object Value { get; set; }

        public override string ToString()
        {
            return Text;
        }
    }
}
