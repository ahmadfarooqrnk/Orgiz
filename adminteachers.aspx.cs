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
    public partial class adminteachers : System.Web.UI.Page
    {
        string strcon = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        //Add Button
        protected void Button2_Click(object sender, EventArgs e)
        {
            
            if (checkIfTeacherExists())
            {
                Response.Write("<script>alert('Teacher with same ID already exists!');</script>");
            }
            else
            {
                addNewTeacher();
            }
        }

        // Update Button
        protected void Button3_Click(object sender, EventArgs e)
        {
           // Response.Write("<script>alert('Invalid Author ID');</script>");
            if (checkIfTeacherExists())
            {
                updateTeacher();

            }
            else
            {
                Response.Write("<script>alert('Teacher with input ID does not exists!');</script>");
            }
        }

        //Delete Button
        protected void Button4_Click(object sender, EventArgs e)
        {
            if (checkIfTeacherExists())
            {
                deleteTeacher();

            }
            else
            {
                Response.Write("<script>alert('Teacher with input ID does not exists!');</script>");
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

        void addNewTeacher()
        {
            try
            {
                SqlConnection con = new SqlConnection(strcon);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                SqlCommand cmd = new SqlCommand("insert_teacher", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@TeachcerID", TextBox1.Text.Trim());
                cmd.Parameters.AddWithValue("@FName", TextBox2.Text.Trim());
                cmd.Parameters.AddWithValue("@Password", TextBox3.Text.Trim());
                cmd.Parameters.AddWithValue("@Email", TextBox4.Text.Trim());

                cmd.ExecuteNonQuery();
                con.Close();
                Response.Write("<script>alert('Teacher added Successfully');</script>");
                clearForm();
                GridView1.DataBind();
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
            }
        }

        void updateTeacher()
        {
            try
            {
                SqlConnection con = new SqlConnection(strcon);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                SqlCommand cmd = new SqlCommand("UPDATE Teacher SET FName = @FName WHERE TeacherID='" + TextBox1.Text.Trim() + "'", con);

                cmd.Parameters.AddWithValue("@FName", TextBox2.Text.Trim());


                cmd.ExecuteNonQuery();

                SqlCommand cmd2 = new SqlCommand("UPDATE Teacher SET Email = @Email WHERE TeacherID='" + TextBox1.Text.Trim() + "'", con);

                cmd2.Parameters.AddWithValue("@Email", TextBox4.Text.Trim());


                cmd2.ExecuteNonQuery();

                con.Close();
                Response.Write("<script>alert('Teacher Details Updated Successfully!');</script>");
                clearForm();
                GridView1.DataBind();
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
            }
        }

        void deleteTeacher()
        {
            try
            {
                SqlConnection con = new SqlConnection(strcon);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                SqlCommand cmd = new SqlCommand("DELETE from Teacher WHERE TeacherID='" + TextBox1.Text.Trim() + "'", con);

                cmd.ExecuteNonQuery();
                con.Close();
                Response.Write("<script>alert('Teacher Deleted Successfully');</script>");
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
            TextBox3.Text = "";
            TextBox4.Text = "";
        }

      
    }
}