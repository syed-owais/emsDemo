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


namespace EMS_Aptech
{
    public partial class UC_PayRoll : UserControl
    {
        private static string myConnString = ConfigurationManager.ConnectionStrings["connString"].ConnectionString;
        PayrollManagement_Model pm_model = new PayrollManagement_Model();
        
        public UC_PayRoll()
        {
            InitializeComponent();
            comboPaymentMethod.Text = "Select Payment Method";

            //CheckInTime("A4S5D8F7458S5");
            
        }
        
        private void UC_PayRoll_Load(object sender, EventArgs e)
        {

        }

        //This DepartmentName method takes Department Id and return Its name....
        private string DepartmaneName(int Id)
        {
            string dName = null;
            SqlConnection conn = new SqlConnection(myConnString);
            try
            {
                string query = "SELECT * FROM Department WHERE ID = " + Id + "";
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read() == true)
                {
                    dName = dr[1].ToString();
                }
                else
                {
                    MessageBox.Show("Department Id is didn't match!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("4----" + ex.ToString());
            }
            finally
            {
                conn.Close();
            }
            return dName;
        }
        //Employee Details Method is for return employee details in multiple Strings values using tuple type
        private Tuple<string, string, string, string, string> EMPDetails(String barcode)
        {

            string eFName = null, eLName = null, eId = null, eDepartment = null, eSalary = null, eFullName = null, eJobTitle = null;
            SqlConnection conn = new SqlConnection(myConnString);
            int DepartmentId;
            try
            {
                string query = "SELECT * FROM Employee WHERE Barcode = '" + barcode + "'";
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read() == true)
                {
                    eId = dr[0].ToString();
                    eFName = dr[1].ToString();
                    eLName = dr[2].ToString();
                    eSalary = dr[10].ToString();
                    eJobTitle = dr[12].ToString();

                    //Convert Department Id to Department Name
                    DepartmentId = Convert.ToInt32(dr[11].ToString());
                    eDepartment = DepartmaneName(DepartmentId);

                    //Convert First & Last Name to Full Name
                    eFullName = eFName + " " + eLName;

                    
                }
                else
                {
                    MessageBox.Show("Employee Dosen't exist");
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("5----" + e.ToString());
            }
            finally
            {
                conn.Close();
            }
            return new Tuple<string, string, string, string, string>(eId, eFullName, eJobTitle, eDepartment, eSalary);
        }

        //private int Eid;//this variable is for SalaryDeduction Method to get the id from database 
        //EmployeeID is for get the employee id using barcode
        private int EmployeeID(String barcode)
        {
            SqlConnection conn = new SqlConnection(myConnString);
            int Eid = 0;
            try
            {
                string query = "SELECT ID FROM Employee WHERE Barcode = '" + barcode + "'";
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Eid = Convert.ToInt32(dr[0]);
                }

            }
            catch (Exception e)
            {
                MessageBox.Show("1-----" + e.ToString());
            }
            finally
            {
                conn.Close();
            }
            return Eid;

        }

        private Tuple<int, int> CheckInTime(string barcode)
        {
            SqlConnection conn = new SqlConnection(myConnString);
            int E_ID = EmployeeID(barcode);
            int E_InTime = 0, Idate = DateTime.Now.Month;
            DateTime inTime, date = DateTime.Now;
            try
            {
                //string query = "SELECT TimeIn,Date FROM AttCheckIn WHERE EmployeeID = " + E_ID + " and Date = '" + Idate + "'";
                string query = "SELECT TimeIn,Date FROM AttCheckIn WHERE EmployeeID = " + E_ID + "";
                SqlCommand cmd = new SqlCommand(query,conn);
                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    inTime = Convert.ToDateTime(dr[3]);
                    date = Convert.ToDateTime(dr[2]);

                    MessageBox.Show(inTime.ToString() + " " + date.ToString());
                }
               
            }
            catch (Exception ex)
            {
                MessageBox.Show("CheckInTime..."+ex.ToString());
            }
            finally
            {
                conn.Close();
            }
            return new Tuple<int, int>(E_InTime,Idate);
        }

        //private int FineDeduction(string barcode)
        //{

        //    return;
        //}

        //This DepartmentName method takes Department Id and return Its name....
        private int SalaryDuduction(string barcode)
        {
            int DeductionAmount = 0;
            SqlConnection conn = new SqlConnection(myConnString);
            int E_ID = EmployeeID(barcode);
            try
            {
                string query = "SELECT DeductionAmount FROM SalaryDeductions WHERE EmployeeID = " + E_ID + "";
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read() == true)
                {
                    DeductionAmount = Convert.ToInt32(dr[0]);
                }
               
            }
            catch (Exception ex)
            {
                MessageBox.Show("4----" + ex.ToString());
            }
            finally
            {
                conn.Close();
            }
            return DeductionAmount;
        }
        private void txtBarcode_OnValueChanged(object sender, EventArgs e)
        {
            string barcode = txtBarcode.Text;
            if (txtBarcode.Text != "" && barcode.Length == 13)
            {
                //get salary 
                int DeductSalary = SalaryDuduction(barcode);
                var eDetails = EMPDetails(txtBarcode.Text);
                //Set value in form
                lblEId.Text = eDetails.Item1;
                lblName.Text = eDetails.Item2;
                lblJobTitle.Text = eDetails.Item3;
                lblDepartment.Text = eDetails.Item4;
                txtGrossSalary.Text = eDetails.Item5;
                txtDeduction.Text = DeductSalary.ToString();
                txtNetSalary.Text = (Convert.ToInt32(eDetails.Item5) - DeductSalary).ToString();

                
            }
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtBarcode.Text == "" || DP_month.Value == null || lblName.Text == "Employee Name" || lblDepartment.Text == "Department" || lblJobTitle.Text == "Job Title" || lblEId.Text == "" || txtGrossSalary.Text == "00,000.00" || txtDeduction.Text == "00,000.00" || txtNetSalary.Text == "00,000.00" || txtFineDeduction.Text == "00,000.00" || txtBonus.Text == "00,000.00" || txtPaymentAmount.Text == "00,000.00" || comboPaymentMethod.Text == "Select Payment Method" || txtComment.Text == "Wight your comment here...")
            {
                MessageBox.Show("Please Fill the form corretly");
            }
            else
            {
                MessageBox.Show("form corret");
            }
        }

        private void txtBarcode_Enter(object sender, EventArgs e)
        {
            txtBarcode.Text = "";
        }

        private void txtBarcode_Leave(object sender, EventArgs e)
        {
            txtBarcode.Text = "Scan Employee's Barcode Here";
        }

        private void txtBonus_Enter(object sender, EventArgs e)
        {
            txtBonus.Text = "";
        }

        private void txtBonus_Leave(object sender, EventArgs e)
        {
            txtBonus.Text = "00,000.00";
        }

        private void txtComment_Enter(object sender, EventArgs e)
        {
            txtComment.Text = "";
        }

        private void txtComment_Leave(object sender, EventArgs e)
        {
            txtComment.Text = "Wright your Comment here...";
        }


    }
}
