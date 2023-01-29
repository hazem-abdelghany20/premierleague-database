using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ms3
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void log_in(object sender, EventArgs e)
        {
            string connStr = WebConfigurationManager.ConnectionStrings["premierleague"].ToString();
            SqlConnection conn = new SqlConnection(connStr);

            int id = Int16.Parse(username.Text);
            String pass = password.Text;

            SqlCommand loginproc = new SqlCommand("userlogiin",conn);
            loginproc.CommandType = CommandType.StoredProcedure;
            loginproc.Parameters.Add(new SqlParameter("@id", id));
            loginproc.Parameters.Add(new SqlParameter("@password", pass));

            SqlParameter success = loginproc.Parameters.Add("@success", System.Data.SqlDbType.Int);
            SqlParameter type = loginproc.Parameters.Add("@type", System.Data.SqlDbType.Int);

            success.Direction = ParameterDirection.Output;
            type.Direction = ParameterDirection.Output;

            conn.Open();
            loginproc.ExecuteNonQuery();
            conn.Close();
            
            if(success.Value.ToString()=="1")
            {
                Response.Write("hello");
            }
            if (success.Value.ToString() == "0")
            {
                Response.Write("hello3");
                Response.Redirect("home.aspx");
            }
        }

    }
}