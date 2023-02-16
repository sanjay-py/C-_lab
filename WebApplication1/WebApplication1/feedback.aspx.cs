using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace WebApplication1
{
    public partial class feedback : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            String name = TextBox1.Text;
            String email = TextBox2.Text;
            String message = TextBox3.Text;

            SqlConnection con = new SqlConnection();
            con.ConnectionString=@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Lab2\Documents\feedback.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = string.Format("insert into fd values('{0}', '{1}', '{2}')", name, email, message);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            Label1.Text = "Saved Successfully";
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox3.Text = "";
        }
    }
}