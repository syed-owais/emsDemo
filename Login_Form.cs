using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EMS_Aptech
{
    public partial class Login_Form : Form
    {
        //SqlConnection conn = new SqlConnection(); //Connection Class
        MainWindow mainWindow = new MainWindow(); //Dashboard Class

        private static string sqlconn = ConfigurationManager.ConnectionStrings["connString"].ConnectionString;
        public Login_Form()
        {
            InitializeComponent();
        }

        private void Login_Form_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            String userName, Password;
            userName = txtUserName.Text;
            Password = txtPassword.Text;
            SqlConnection conn = new SqlConnection(sqlconn); //Connection Class
            try
            {

                //Data Source=.;Initial Catalog=sms_2;Integrated Security=True
                //conn.ConnectionString = @"Data Source=DESKTOP-8ADRJ8G\MSSQLSERVER2017;Initial Catalog=EMP_Management;Persist Security Info=True;User ID=sa;Password=owais"; //Old Connection String
                //conn.ConnectionString = @"Data Source=DESKTOP-8ADRJ8G\MSSQLSERVER2017;Initial Catalog=EMP_Management;Integrated Security=True "; //New Connection String
               
                conn.Open();
                //SQL command quary;
                string quary = "SELECT Name,Password FROM Users WHERE Name = '" + userName + "' AND Password = '" + Password + "'";
                SqlCommand cmd = new SqlCommand(quary, conn);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    this.Hide();
                    mainWindow.Show();
                }
                else
                    MessageBox.Show("Faild");
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                conn.Close();
            }

;        }
    }
}
