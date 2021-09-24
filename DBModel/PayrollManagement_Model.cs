using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EMS_Aptech.DBModel
{
    class PayrollManagement_Model
    {
        public string EName { get; set; }
        public int DepartmentID { get; set; }
        public string JobTitle { get; set; }
        public double GrossSalary { get; set; }
        public double DeductionAmount { get; set; }
        public double NetSalary { get; set; }
        public double FineDeduction { get; set; }
        public double Bonus { get; set; }
        public double PaymentAmount { get; set; }
        public string PaymentMethod { get; set; }
        public string Comment { get; set; }
        public int EmployeeID { get; set; }

        public bool Insert(PayrollManagement_Model PM_Model)
        {
            string myConnString = ConfigurationManager.ConnectionStrings["connString"].ConnectionString;
            //Createing default return type and setting its value to false;
            bool IsSuccess = false;
            
            //Connection to database
            SqlConnection conn = new SqlConnection(myConnString);

            try
            {
                string query = "INSERT INTO PayrollDetails (EmployeeName,DepartmentID,JobTitle,GrossSalary,DeductionAmount,NetSalary,FineDeduction,Bonus,PaymentAmount,PaymentMethod,Comment,EmployeeID) VALUES (@EmployeeName, @DepartmentID, @JobTitle, @GrossSalary, @DeductionAmount, @NetSalary, @FineDeduction, @Bonus, @PaymentAmount, @PaymentMethod, @Comment, @EmployeeID)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@EmployeeName", PM_Model.EName);
                cmd.Parameters.AddWithValue("@DepartmentID", PM_Model.DepartmentID);
                cmd.Parameters.AddWithValue("@JobTitle", PM_Model.JobTitle);
                cmd.Parameters.AddWithValue("@GrossSalary", PM_Model.GrossSalary);
                cmd.Parameters.AddWithValue("@DeductionAomunt", PM_Model.DeductionAmount);
                cmd.Parameters.AddWithValue("@NetSalary", PM_Model.NetSalary);
                cmd.Parameters.AddWithValue("@FineDeduction", PM_Model.FineDeduction);
                cmd.Parameters.AddWithValue("@Bonus", PM_Model.Bonus);
                cmd.Parameters.AddWithValue("@PaymentAmount", PM_Model.PaymentAmount);
                cmd.Parameters.AddWithValue("@PaymentMethod", PM_Model.PaymentMethod);
                cmd.Parameters.AddWithValue("@EmployeeID", PM_Model.EmployeeID);

                conn.Open();
                int row = cmd.ExecuteNonQuery();
                if (row > 0)
                {
                    IsSuccess = true;
                }
                else
                {
                    IsSuccess = false; 
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                conn.Close();
            }

            return IsSuccess;
        }

        
    }
}
