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
    public partial class adminteachercourse : System.Web.UI.Page
    {
        string strcon = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        // Add Button
        protected void Button2_Click(object sender, EventArgs e)
        {
            if (checkIfTeacherExists() && checkIfCourseExists())
            { 
                    allotCourse();
            }
            else
            {
                Response.Write("<script>alert('Teacher with given ID or Course with given ID does not exists!');</script>");
            }
        }

        // Delete Button
        protected void Button4_Click(object sender, EventArgs e)
        {
            if (checkIfTeacherExists() && checkIfCourseExists())
            {
                deleteCourse();
            }
            else
            {
                Response.Write("<script>alert('Teacher with given ID or Course with given ID does not exists!');</script>");
            }
        }

        bool checkIfTeacherExists()
        {
            try
            {
                SqlConnection con = new SqlConnection(strcon);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                SqlCommand cmd = new SqlCommand("SELECT * from Teacher where TeacherID='" + TextBox1.Text.Trim() + "';", con);
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

        void allotCourse()
        {
            try
            {
                SqlConnection con = new SqlConnection(strcon);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                SqlCommand cmd = new SqlCommand("INSERT INTO TeacherCourse(TeacherID,CourseID) VALUES (@TeacherID,@CourseID)", con);

                cmd.Parameters.AddWithValue("@TeacherID", TextBox1.Text.Trim());
                cmd.Parameters.AddWithValue("@CourseID", TextBox3.Text.Trim());

                cmd.ExecuteNonQuery();
                con.Close();
                Response.Write("<script>alert('Course alloted to Teacher Successfully');</script>");
                clearForm();
                GridView1.DataBind();
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
            }
        }

        void deleteCourse()
        {
            try
            {
                SqlConnection con = new SqlConnection(strcon);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                SqlCommand cmd = new SqlCommand("DELETE FROM TeacherCourse WHERE TeacherID ='" + TextBox1.Text.Trim() + "' AND CourseID ='" + TextBox3.Text.Trim() + "'", con);

                cmd.ExecuteNonQuery();
                con.Close();
                Response.Write("<script>alert('Course taken from Teacher Successfully');</script>");
                clearForm();
                GridView1.DataBind();
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
            }
        }

        void clearForm()
        {
            TextBox1.Text = "";
            TextBox3.Text = "";
        }

       
    }
}