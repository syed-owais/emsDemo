using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EMS_Aptech.DBModel
{
    class Department_model
    {
        public int DepartID { get; set; }
        public string DepartName { get; set; }


        public DataTable Select() 
        {
            string myConnStirng = ConfigurationManager.ConnectionStrings["connString"].ConnectionString;
            SqlConnection sqlConn = new SqlConnection(myConnStirng);
            DataTable datatable = new DataTable();
            try 
            {
                string query = "SELECT * FROM Department";
                SqlCommand cmd = new SqlCommand(query,sqlConn);
                SqlDataAdapter sqlAdapter = new SqlDataAdapter(cmd);
                sqlConn.Open();
                sqlAdapter.Fill(datatable);
            }
            catch(Exception e)
            {
                MessageBox.Show(e.ToString());
            }
            finally
            {
                sqlConn.Close();
            }

            return datatable;
        }

        public bool Insert(Department_model departModel)
        {
            string myConnStirng = ConfigurationManager.ConnectionStrings["connString"].ConnectionString;
            //creating a defult return type and set its value to false
            bool isSuccess = false;
            
            SqlConnection conn = new SqlConnection(myConnStirng);//SQLConnecion conn is for connect to connection String

            try
            {
                
                string query = "INSERT INTO Department (Name) values (@DepartName)";//Query is for SQL database
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@DepartName", departModel.DepartName);
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
            catch (Exception e) 
            {
                MessageBox.Show(e.ToString());
            }
            finally
            {
                conn.Close();
            }

            return isSuccess;
        }

        public bool Update(Department_model Dp_model)
        {
            string myConnStirng = ConfigurationManager.ConnectionStrings["connString"].ConnectionString;
            //creating a defult return type and set its value to false
            bool isSuccess = false;
            //create sql connection 
            SqlConnection conn = new SqlConnection(myConnStirng);
            try
            {
                string query = "UPDATE Department SET Name=@DepartName WHERE ID=@DepartID";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@DepartName", Dp_model.DepartName);
                cmd.Parameters.AddWithValue("@DepartID", Dp_model.DepartID);
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
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
            finally
            {
                conn.Close();
            }
            return isSuccess;
        }

        public bool Delete(Department_model dp_Model)
        {
            string myConnStirng = ConfigurationManager.ConnectionStrings["connString"].ConnectionString;
            bool isSuccss = false;
            SqlConnection conn = new SqlConnection(myConnStirng);
            try
            {
                string query = "DELETE FROM Department WHERE ID=@DepartID";
                SqlCommand cmd = new SqlCommand(query,conn);
                cmd.Parameters.AddWithValue("@DepartID",dp_Model.DepartID);
                conn.Open();
                int row = cmd.ExecuteNonQuery();
                if (row > 0)
                {
                    isSuccss = true;
                }
                else
                {
                    isSuccss = false;
                }
            }
            catch(Exception e)
            {
                MessageBox.Show(e.ToString());
            }
            finally
            {
                conn.Close();
            }

            return isSuccss;
        }
    }
}
