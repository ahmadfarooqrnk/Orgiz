using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Orgiz
{
    public partial class teacherlogin : System.Web.UI.Page
    {
        string strcon = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(strcon);
                if (con.State == System.Data.ConnectionState.Closed)
                {
                    con.Open();
                }

                SqlCommand cmd = new SqlCommand("select * from Teacher where TeacherID = '" + TextBox1.Text.Trim() + "' AND [Password] = '" + TextBox2.Text.Trim() + "'", con);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        Response.Write("<script>alert('Successful login');</script>");
                        Session["Teacher Name"] = dr.GetValue(0).ToString();
                        Session["Teacher ID"] = dr.GetValue(1).ToString();
                        
                    }
                    Session["teacher"] = TextBox1.Text;
                    SqlCommand cmd2 = new SqlCommand("teacher_session", con);
                    cmd2.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@TeacherID", TextBox1.Text.Trim());
                    Response.Redirect("teacherprofile.aspx");
                }
                else
                {
                    Response.Write("<script>alert('Invalid credentials');</script>");
                }
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
            }
        }
    }
}