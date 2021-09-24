using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.VisualBasic;

namespace EMS_Aptech
{
    public partial class CheckIn_CheckOut_Form : Form
    {
        private static string myConnString = ConfigurationManager.ConnectionStrings["connString"].ConnectionString;
        DateTime date = DateTime.Now;
        private bool _dragging;
        private Point _startPoint = new Point(0, 0);
        public CheckIn_CheckOut_Form()
        {
            InitializeComponent();
            // barcode A4S5D8F7458S5
            //MessageBox.Show(EmployeeID("A4S5D8F7458S5").ToString());//only for testing purpose
            //isAbsent("2693455676623");//only for testing purpose
            //isPresent("2693455676623");//only for testing purpose

            //Employee Details Method is for return employee details in tuple type multiple Strings values
            //var tuple = EMPDetails("2693455676623");
            //MessageBox.Show(tuple.Item1.ToString() + " " + tuple.Item2.ToString() + " " + tuple.Item3.ToString() + " " + tuple.Item4.ToString());
           
            //string age = "1998/7/7";
            //DateTime dateob = Convert.ToDateTime(age); 
            //MessageBox.Show(CalculateAge(dateob).ToString());

            //time check method is check the time margin to avoid the suddenly checked out the Employee
            //TimeCheck("A4S5D8F7458S5");

                
        }

        //CheckEMP method check's the Employee is exist or not, if Employee is exist then this will be return True or if not then this will be return False
        private bool checkEMP(String barcode)
        {
            bool Exist = false;
            SqlConnection conn = new SqlConnection(myConnString);
            try
            {
                string query = "SELECT * FROM Employee WHERE Barcode = '"+barcode+"'";
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                if(dr.Read() == true)
                {
                    //MessageBox.Show("User Exist");
                    Exist = true;
                }
                else
                {
                    //MessageBox.Show("User Dosen't exist");
                    Exist = false;
                }
            }
            catch(Exception e)
            {
                MessageBox.Show("0----"+e.ToString());
            }
            finally
            {
                conn.Close();
            }
            return Exist;
        }

        private int Eid;//this variable is for isPresent Method to get the id from database 
        //EmployeeID is for get the employee id using barcode
        private int EmployeeID(String barcode)
        {
            SqlConnection conn = new SqlConnection(myConnString);
            
            try
            {
                string query = "SELECT ID FROM Employee WHERE Barcode = '"+barcode+"'";
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Eid = Convert.ToInt32(dr[0]);
                }
                               
            }
            catch(Exception e)
            {
                MessageBox.Show("1-----"+e.ToString());
            }
            finally
            {
                conn.Close();
            }
            return Eid;

        }

        //
        public bool isPresent(String barcode)
        {
            bool Present = false;
            SqlConnection conn = new SqlConnection(myConnString);
            int EMPid = EmployeeID(barcode);
            try
            {
                string query = "SELECT EmployeeID FROM AttCheckIn WHERE Date='" + date + "' and EmployeeID=" + EMPid + "";
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                if(dr.Read() == true)
                {
                    Present = true;
                    //MessageBox.Show(dr+"________"+Present);//only for testing purpose
                }
                else
                {
                    Present = false;
                    
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show("2----"+ex.ToString());
            }
            finally
            {
                conn.Close();
            }
            return Present; 
        }

        public bool isAbsent(String barcode)
        {
            bool Absent = false;
            SqlConnection conn = new SqlConnection(myConnString);
            int EMPid = EmployeeID(barcode);
            try
            {
                string query = "SELECT EmployeeID FROM AttCheckOut WHERE Date='" + date + "' and EmployeeID=" + EMPid + "";
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read() == true)
                {
                    Absent = true;
                    //MessageBox.Show(dr + "________" + Absent);//only for testing purpose
                }
                else
                {
                    Absent = false;
                    //MessageBox.Show(dr + "________" + Absent);//only for testing purpose
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("3----" + ex.ToString());
            }
            finally
            {
                conn.Close();
            }
            return Absent;
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

        //Caluculate Age Method is for calculate age for given dateOfBirth
        private int CalculateAge(DateTime dob)
        {
            int age = 0;
            age = DateTime.Now.Year - dob.Year;
            if (DateTime.Now.DayOfYear < dob.DayOfYear)
                age = age - 1;

            return age;
        }  

        //Employee Details Method is for return employee details in multiple Strings values using tuple type
        private Tuple<string, string, string, string> EMPDetails(String barcode)
        {
            
            string eFName = null, eLName = null, eId = null, eDepartment = null, eAge = null, eFullName = null, Cal_eAge = null;
            SqlConnection conn = new SqlConnection(myConnString);
            int DepartmentId,EMP_age;
            DateTime dtAge;
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
                    eAge = dr[6].ToString();

                    //Convert Department Id to Department Name
                    DepartmentId = Convert.ToInt32(dr[11].ToString());
                    eDepartment = DepartmaneName(DepartmentId);

                    //Convert First & Last Name to Full Name
                    eFullName = eFName +" "+ eLName;

                    //Calculate Age
                    dtAge = Convert.ToDateTime(eAge);
                    EMP_age = CalculateAge(dtAge);
                    Cal_eAge = Convert.ToString(EMP_age);
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
            return new Tuple<string,string,string,string>(eId,eFullName,Cal_eAge,eDepartment);
        }

        private Tuple<bool, int> TimeCheck(String barcode)
        {
            bool TimeOver = false;
            DateTime ThisDate = DateTime.Now;
            SqlConnection conn = new SqlConnection(myConnString);
            int Min_Unit = 0, E_Id = EmployeeID(barcode);
            bool is_Present = isPresent(barcode);
            DateTime time, TimeOfDay = ThisDate;
            string inTime;
            double Cal_Time;
            try
            {
                if (is_Present == true)
                {
                    string query = "SELECT TimeIn FROM AttCheckIn where EmployeeID = " + E_Id + " and Date = '" + ThisDate + "'";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    conn.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.Read() == true)
                    {
                        inTime = dr[0].ToString();
                        time = Convert.ToDateTime(inTime);
                        Cal_Time = (TimeOfDay - time).TotalMinutes;
                        Min_Unit = Convert.ToInt32(Cal_Time);
                        if (Min_Unit >= 10)
                        { 
                            TimeOver = true;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("6----" + ex.ToString());
            }
            finally
            {
                conn.Close();
            }
            return new Tuple<bool, int>(TimeOver, Min_Unit);
        }

        private bool CHK_TodayLeaves(String barcode)
        {
            bool TodayLeaves = false;
            SqlConnection conn = new SqlConnection(myConnString);
            int EMPid = EmployeeID(barcode);
            try
            {
                string query = "SELECT EmployeeID FROM EmployeeLeaves WHERE Date='" + date + "' and EmployeeID=" + EMPid + "";
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read() == true)
                {
                    TodayLeaves = true;
                    //MessageBox.Show(dr + "________" + TodayLeaves);//only for testing purpose
                }
                else
                {
                    TodayLeaves = false;
                    //MessageBox.Show(dr + "________" + TodayLeaves);//only for testing purpose
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("7----" + ex.ToString());
            }
            finally
            {
                conn.Close();
            }
            return TodayLeaves;
        }

        private void txtBarcode_TextChanged(object sender, EventArgs e)
        {
           if(txtBarcode.Text != "" &&  txtBarcode.TextLength == 13)
           {
                bool UserExist = checkEMP(txtBarcode.Text);
                SqlConnection conn = new SqlConnection(myConnString);
                bool is_Present = isPresent(txtBarcode.Text);
                bool is_Absent = isAbsent(txtBarcode.Text);
                bool EMP_Exist = checkEMP(txtBarcode.Text);
                var tuple_TimeCheck = TimeCheck(txtBarcode.Text);
                bool TimeOver = tuple_TimeCheck.Item1;
                int E_ID = EmployeeID(txtBarcode.Text);
                var tuple = EMPDetails(txtBarcode.Text);
                int TotalMins = tuple_TimeCheck.Item2;
                int TotalHours = TotalMins / 60;
                bool EMP_TodayLeavs_CHK = CHK_TodayLeaves(txtBarcode.Text);
                try
                {
                    if (is_Present == true)
                    {
                       if(EMP_Exist == true)
                       {
                            if(is_Absent == false)
                            {
                                if (TimeOver == true)
                                {
                                    if (TotalHours < 4)
                                    {
                                        if (EMP_TodayLeavs_CHK == true)
                                        {
                                            MessageBox.Show("You are alrady on Short Leave Today.");
                                        }
                                        else
                                        {
                                            string remarks = Interaction.InputBox("Why are you need half day Leave for today?", "Remarks", "Enter your remarks here....");                                           
                                            string query = "INSERT INTO EmployeeLeaves (EmployeeID,Date,Type,TimeLeave,Remarks) VALUES (" + E_ID + ",'" + date + "','Short Leave','" + date + "','"  + remarks + "')";
                                            SqlCommand cmd = new SqlCommand(query, conn);
                                            conn.Open();
                                            int row = cmd.ExecuteNonQuery();
                                            if (row > 0)
                                            {
                                                MessageBox.Show("Leave Submit...!");
                                            }
                                        }
                                    }
                                    else if (TotalHours >= 4 && TotalHours < 8)
                                    {
                                        if (EMP_TodayLeavs_CHK == true)
                                        {
                                            MessageBox.Show("You are alrady on Half Leave Today.");
                                        }
                                        else
                                        {
                                            string remarks = Interaction.InputBox("Why are you need half day Leave for today?", "Remarks", "Enter your remarks here....");
                                            string query = "INSERT INTO EmployeeLeaves (EmployeeID,Date,Type,TimeLeave,Remarks) VALUES (" + E_ID + ",'" + date + "','Halfday Leave','" + date + "','" + remarks + "')";
                                            SqlCommand cmd = new SqlCommand(query, conn);
                                            conn.Open();
                                            int row = cmd.ExecuteNonQuery();
                                            if (row > 0)
                                            {
                                                MessageBox.Show("Half Leave Submit...!");
                                            }
                                        }
                                    }
                                    else
                                    {
                                        string query = "INSERT INTO AttCheckOut (EmployeeId,Date,TimeOut,Remarks) VALUES (" + E_ID + ",'" + date + "','" + date + "','Remarks')";
                                        SqlCommand cmd = new SqlCommand(query, conn);
                                        conn.Open();
                                        int row = cmd.ExecuteNonQuery();
                                        if (row > 0)
                                        {
                                            MessageBox.Show("Out");
                                        }
                                    }
                                }
                                else
                                {
                                    var tuple_TimeCheck_ref = TimeCheck(txtBarcode.Text);
                                    int TimeDuration = tuple_TimeCheck_ref.Item2;
                                    TimeDuration = 10 - TimeDuration;
                                    MessageBox.Show("You are already Checked In. If you want to Check Out then Please wait at least " + TimeDuration + " Minutes.");
                                }
                            }
                            else
                            {
                                MessageBox.Show("You are already Out!");
                            }
                       }
                       else
                       {
                           MessageBox.Show("Employee Didn't Exist!");
                       }
                    }
                    else
                    {
                        if(EMP_Exist == true)
                        {
                            string query = "INSERT INTO AttCheckIn (EmployeeID, Date, TimeIn, Remarks) VALUES ("+E_ID+",'"+date+"','"+date+"','Remarks')";
                            SqlCommand cmd = new SqlCommand(query, conn);
                            conn.Open();
                            int row = cmd.ExecuteNonQuery();
                            if (row > 0)
                            {
                                lblID.Text = tuple.Item1.ToString();
                                lblName.Text = tuple.Item2.ToString();
                                lblAge.Text = tuple.Item3.ToString();
                                lblDepartment.Text = tuple.Item4.ToString();
                                lblstatus.Text = "Checked In";
                                panalProfile.Visible = true;
                            }
                        }
                        else
                        {
                            MessageBox.Show("Employee Didn't Exist!");
                        }
                    }
                }
                catch(Exception ex)
                {
                     MessageBox.Show("8-----"+ex.ToString());
                }
                finally
                {
                    conn.Close();
                }
           }
        }

        

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblhead_Click(object sender, EventArgs e)
        {

        }

        private void CIn_COut_MouseDown(object sender, MouseEventArgs e)
        {
            _dragging = true;
            _startPoint = new Point(e.X, e.Y);

        }

        private void CIn_COut_MouseMove(object sender, MouseEventArgs e)
        {
            if (!_dragging) return;
            var p = PointToScreen(e.Location);
            Location = new Point(p.X - this._startPoint.X, p.Y - this._startPoint.Y);
        }

        private void CIn_COut_MouseUp(object sender, MouseEventArgs e)
        {
            _dragging = false;
        }
        
        private void btnExit_Click(object sender, EventArgs e)
        {
             //this will Close the intier application
             Environment.Exit(0);
        }

        private void lblLogin_Click(object sender, EventArgs e)
        {
            MainWindow mainWindow = new MainWindow(); // this is only for testing purpose
            mainWindow.Show();

            //Login_Form lf = new Login_Form(); // Main purpose is this
            //lf.Show();
        }
        
    }
}
