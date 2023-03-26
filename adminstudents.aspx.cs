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
    public partial class adminstudents : System.Web.UI.Page
    {
        string strcon = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        // Add Button
        protected void Button2_Click(object sender, EventArgs e)
        {
            if (checkIfStudentExists())
            {
                Response.Write("<script>alert('Student with same ID already exists!');</script>");
            }
            else
            {

                SqlConnection con = new SqlConnection(strcon);

                SqlCommand cmd = new SqlCommand("insert_student", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@FName", TextBox2.Text.Trim());
                cmd.Parameters.AddWithValue("@StudentID", TextBox1.Text.Trim());
                cmd.Parameters.AddWithValue("@Password", TextBox3.Text.Trim());
                cmd.Parameters.AddWithValue("@Phoneno", TextBox4.Text.Trim());
                cmd.Parameters.AddWithValue("@Email", TextBox5.Text.Trim());
                cmd.Parameters.AddWithValue("@Address", TextBox6.Text);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                Response.Write("<script>alert('Student added Successfully');</script>");
                clearForm();
                GridView1.DataBind();

            }
        }

        // Update Button
        protected void Button3_Click(object sender, EventArgs e)
        {
            if (checkIfStudentExists())
            {

                SqlConnection con = new SqlConnection(strcon);

                SqlCommand cmd = new SqlCommand("update_student", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@FName", TextBox2.Text.Trim());
                cmd.Parameters.AddWithValue("@StudentID", TextBox1.Text.Trim());
                cmd.Parameters.AddWithValue("@Password", TextBox3.Text.Trim());
                cmd.Parameters.AddWithValue("@Phoneno", TextBox4.Text.Trim());
                cmd.Parameters.AddWithValue("@Email", TextBox5.Text.Trim());
                cmd.Parameters.AddWithValue("@Address", TextBox6.Text);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                Response.Write("<script>alert('Student Data Updated Successfully');</script>");
                clearForm();
                GridView1.DataBind();
                
            }
            else
            {

                Response.Write("<script>alert('Student with given ID does not exists!');</script>");
            }
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            if (checkIfStudentExists())
            {

                SqlConnection con = new SqlConnection(strcon);

                SqlCommand cmd = new SqlCommand("delete_student", con);

                cmd.CommandType = System.Data.CommandType.StoredProcedure;
               
                cmd.Parameters.AddWithValue("@StudentID", TextBox1.Text.Trim());
               
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                Response.Write("<script>alert('Student Data Deleted Successfully');</script>");
                clearForm();
                GridView1.DataBind();

            }
            else
            {

                Response.Write("<script>alert('Student with given ID does not exists!');</script>");
            }
        }

        // Go Button
        protected void Button1_Click(object sender, EventArgs e)
        {
            getStudent();
        }

        //void addNewStudent()
        //{
        //    try
        //    {
        //        SqlConnection con = new SqlConnection(strcon);
               

        //        SqlCommand cmd = new SqlCommand("insert_student", con);
        //        cmd.CommandType = System.Data.CommandType.StoredProcedure;
        //        cmd.Parameters.AddWithValue("@FName", TextBox2.Text.Trim());
        //        cmd.Parameters.AddWithValue("@StudentID", TextBox1.Text.Trim());
        //        cmd.Parameters.AddWithValue("@Password", TextBox3.Text.Trim());
        //        cmd.Parameters.AddWithValue("@Phoneno", TextBox4.Text.Trim());
        //        cmd.Parameters.AddWithValue("@Email", TextBox5.Text.Trim());
        //        cmd.Parameters.AddWithValue("@Address", TextBox6.Text);

        //        con.Open();
        //        cmd.ExecuteNonQuery();
        //        con.Close();
        //        Response.Write("<script>alert('Student added Successfully');</script>");
        //        clearForm();
        //        GridView1.DataBind();
        //    }
        //    catch (Exception ex)
        //    {
        //        Response.Write("<script>alert('" + ex.Message + "');</script>");
        //    }
        //}

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
                        TextBox2.Text = dt.Rows[0][0].ToString();
                        TextBox3.Text = dt.Rows[0][2].ToString();
                        TextBox4.Text = dt.Rows[0][3].ToString();
                        TextBox5.Text = dt.Rows[0][4].ToString();
                        TextBox6.Text = dt.Rows[0][5].ToString();
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

        void clearForm()
        {
            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox3.Text = "";
            TextBox4.Text = "";
            TextBox5.Text = "";
            TextBox6.Text = "";
        }

       
    }
}