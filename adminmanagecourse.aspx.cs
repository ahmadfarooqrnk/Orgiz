using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Orgiz
{
    public partial class adminmanagecourse : System.Web.UI.Page
    {
        string strcon = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        // Add button
        protected void Button2_Click(object sender, EventArgs e)
        {
            if (checkIfStudentExists() && checkIfCourseExists())
            {
                SqlConnection con = new SqlConnection(strcon);

                SqlCommand cmd = new SqlCommand("student_allotcourse", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@StudentID", TextBox1.Text.Trim());
                cmd.Parameters.AddWithValue("@CourseID", TextBox3.Text.Trim());

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                Response.Write("<script>alert('Course allotted to Student Successfully');</script>");
                clearForm();
                GridView1.DataBind();

            }
            else
            {
                Response.Write("<script>alert('Student with given ID or Course with given ID does not exists!');</script>");
            }
        }

        // Delete Button
        protected void Button4_Click(object sender, EventArgs e)
        {
            if (checkIfStudentExists() && checkIfCourseExists())
            {
                SqlConnection con = new SqlConnection(strcon);

                SqlCommand cmd = new SqlCommand("delete_studentcourse", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@StudentID", TextBox1.Text.Trim());
                cmd.Parameters.AddWithValue("@CourseID", TextBox3.Text.Trim());

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                Response.Write("<script>alert('Course taken from Student Successfully');</script>");
                clearForm();
                GridView1.DataBind();

            }
            else
            {
                Response.Write("<script>alert('Student with given ID or Course with given ID does not exists!');</script>");
            }
        }

        // Student Go Button
        protected void Button3_Click(object sender, EventArgs e)
        {
            getStudent();
        }

        bool checkIfStudentExists()
        {
            try
            {
                SqlConnection con = new SqlConnection(strcon);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                SqlCommand cmd = new SqlCommand("SELECT * from Student where StudentID ='" + TextBox1.Text.Trim() + "';", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows.Count >= 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }


            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
                return false;
            }
        }

        // Course Go Button
        protected void Button1_Click(object sender, EventArgs e)
        {
            getCourse();
        }

        bool checkIfCourseExists()
        {
            try
            {
                SqlConnection con = new SqlConnection(strcon);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                SqlCommand cmd = new SqlCommand("SELECT * from Courses where CourseID='" + TextBox3.Text.Trim() + "';", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows.Count >= 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }


            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
                return false;
            }
        }

        void getStudent()
        {
            try
            {
                SqlConnection con = new SqlConnection(strcon);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                SqlCommand cmd = new SqlCommand("SELECT * from Student where StudentID ='" + TextBox1.Text.Trim() + "';", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows.Count >= 1)
                {

                    TextBox4.Text = dt.Rows[0][0].ToString();

                }
                else
                {
                    Response.Write("<script>alert('Invalid Student ID');</script>");
                }


            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");

            }
        }

        void getCourse()
        {
            try
            {
                SqlConnection con = new SqlConnection(strcon);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                SqlCommand cmd = new SqlCommand("SELECT * from Courses where CourseID ='" + TextBox3.Text.Trim() + "';", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows.Count >= 1)
                {

                    TextBox2.Text = dt.Rows[0][1].ToString();

                }
                else
                {
                    Response.Write("<script>alert('Invalid Course ID');</script>");
                }


            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");

            }
        }

        void clearForm()
            {
            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox3.Text = "";
            }

       
    }
}