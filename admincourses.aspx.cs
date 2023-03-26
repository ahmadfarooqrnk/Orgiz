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
    public partial class admincourses : System.Web.UI.Page
    {
        string strcon = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        // Add Button
        protected void Button2_Click(object sender, EventArgs e)
        {
           // Response.Write("<script>alert('Invalid Author ID');</script>");
           if (checkIfCourseExists())
            {
                Response.Write("<script>alert('Course with same ID already exists!');</script>");
            }
            else
            {
                addNewCourse();
            }
        }

        // Update Button
        protected void Button3_Click(object sender, EventArgs e)
        {
            if (checkIfCourseExists())
            {
                updateCourse();
                
            }
            else
            {
                Response.Write("<script>alert('Course with input ID does not exists!');</script>");
            }
        }

        // Delete Button
        protected void Button4_Click(object sender, EventArgs e)
        {
            if (checkIfCourseExists())
            {
                deleteCourse();

            }
            else
            {
                Response.Write("<script>alert('Course with input ID does not exists!');</script>");
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

                SqlCommand cmd = new SqlCommand("SELECT * from Courses where CourseID='" + TextBox1.Text.Trim() + "';", con);
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

        void addNewCourse()
        {
            try
            {
                SqlConnection con = new SqlConnection(strcon);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                SqlCommand cmd = new SqlCommand("insert_Course", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@CourseID", TextBox1.Text.Trim());
                cmd.Parameters.AddWithValue("@CourseName", TextBox2.Text.Trim());
                

                cmd.ExecuteNonQuery();
                con.Close();
                Response.Write("<script>alert('Course added Successfully');</script>");
                clearForm();
                GridView1.DataBind();
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
            }
        }

        void updateCourse()
        {
            try
            {
                SqlConnection con = new SqlConnection(strcon);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                SqlCommand cmd = new SqlCommand("update_course", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@CourseName", TextBox2.Text.Trim());
                cmd.Parameters.AddWithValue("@CourseID", TextBox1.Text.Trim());
                
                

                cmd.ExecuteNonQuery();



                con.Close();
                Response.Write("<script>alert('Course Details Updated Successfully!');</script>");
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

                SqlCommand cmd = new SqlCommand("DELETE from Courses WHERE CourseID='" + TextBox1.Text.Trim() + "'", con);

                cmd.ExecuteNonQuery();
                con.Close();
                Response.Write("<script>alert('Course Deleted Successfully');</script>");
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
            TextBox2.Text = "";
          
        }

       
    }
}

