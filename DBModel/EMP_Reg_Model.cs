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
     class EMP_Reg_Model 
    {
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public String Phone { get; set; }
        public String CNICNo { get; set; }
        public float WageRate { get; set; }
        public DateTime JoiningDate { get; set; }
        public String Address { get; set; }
        public String Age { get; set; }
        public String Gender { get; set; }
        public String Email { get; set; }
        public String Barcode { get; set; }
        public float WorkingHours { get; set; }
        public int Salary { get; set; }
        public int DepartmentID { get; set; }


        public bool Insert(EMP_Reg_Model eMP_Reg)
        {
            string myConnStirng = ConfigurationManager.ConnectionStrings["connString"].ConnectionString;
            //Createing default return type and setting its value to false;
            bool isSuccess = false; 

            //Connect Database
            SqlConnection conn = new SqlConnection(myConnStirng);

            try
            {
                //string quary = "INSERT INTO Employee (FirstName, LastName, Phone, CNIC, WageRate, JoinDate, Address, Age, Gendar, Email, WorkingHours, Salary, DepId) VALUES ('FirstName', 'LastName', '03125464654', '4646565665654646', '4564.565', '02-02-2017', 'Address', '05/09/1998', 'Gendar', 'Email', '51.5156', '664646', '1')";
                string quary = "INSERT INTO Employee (FirstName, LastName, Phone, CNIC, WageRate, JoinDate, Address, Age, Gender, Email, WorkingHours, Salary, Barcode, DepId) VALUES (@FirstName, @LastName, @Phone, @CNICNo, @WageRate, @Joindate, @Address, @Age, @Gender, @Email, @WorkingHours, @Salary, @Barcode, @DepId)";

                //Create SQL Command using Quary and Conn
                SqlCommand cmd = new SqlCommand(quary, conn);
                cmd.Parameters.AddWithValue("@FirstName", eMP_Reg.FirstName);
                cmd.Parameters.AddWithValue("@LastName", eMP_Reg.LastName);
                cmd.Parameters.AddWithValue("@Phone", eMP_Reg.Phone);
                cmd.Parameters.AddWithValue("@CNICNo", eMP_Reg.CNICNo);
                cmd.Parameters.AddWithValue("@WageRate", eMP_Reg.WageRate);
                cmd.Parameters.AddWithValue("@JoinDate", eMP_Reg.JoiningDate);
                cmd.Parameters.AddWithValue("@Address", eMP_Reg.Address);
                cmd.Parameters.AddWithValue("@Age", eMP_Reg.Age);           
                cmd.Parameters.AddWithValue("@Gender", eMP_Reg.Gender);
                cmd.Parameters.AddWithValue("@Email", eMP_Reg.Email);
                cmd.Parameters.AddWithValue("@WorkingHours", eMP_Reg.WorkingHours);
                cmd.Parameters.AddWithValue("@Salary", eMP_Reg.Salary);
                cmd.Parameters.AddWithValue("@Barcode", eMP_Reg.Barcode);
                cmd.Parameters.AddWithValue("@DepId", eMP_Reg.DepartmentID);

                conn.Open();
                int row = cmd.ExecuteNonQuery();
                if (row > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
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
            return isSuccess;
        }

        

    }
}
