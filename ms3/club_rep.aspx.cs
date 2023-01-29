using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ms3
{
    public partial class club_rep1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
         protected void register(object sender, EventArgs e)
        {

                string connStr = WebConfigurationManager.ConnectionStrings["premierleague"].ToString();
                SqlConnection conn = new SqlConnection(connStr);

                String name = repname.Text;
                String club = DropDownList1.Text;
                String user = username.Text;
                String pass = password.Text;

                SqlCommand loginproc = new SqlCommand("addRepresentative", conn);
                loginproc.CommandType = CommandType.StoredProcedure;
                loginproc.Parameters.Add(new SqlParameter("@name", name));
                loginproc.Parameters.Add(new SqlParameter("@club_name", club));
                loginproc.Parameters.Add(new SqlParameter("@username", user));
                loginproc.Parameters.Add(new SqlParameter("@password", pass));


                conn.Open();
                loginproc.ExecuteNonQuery();
                conn.Close();

            }

        protected void viewclub(object sender, EventArgs e)
        {

            string connStr = WebConfigurationManager.ConnectionStrings["premierleague"].ToString();
            SqlConnection conn = new SqlConnection(connStr);

            String name = repname.Text;

            SqlCommand viewclub = new SqlCommand("clubbyrepresentative", conn);
            viewclub.CommandType = CommandType.StoredProcedure;
            viewclub.Parameters.Add(new SqlParameter("@repname", name));


            conn.Open();
            SqlDataReader rdr = viewclub.ExecuteReader(CommandBehavior.CloseConnection);
            Table table= new Table();

            GridView1.DataSource = rdr;
            GridView1.DataBind();
            conn.Close();

        }

        protected void upcomingmatches(object sender, EventArgs e)
        {

            string connStr = WebConfigurationManager.ConnectionStrings["premierleague"].ToString();
            SqlConnection conn = new SqlConnection(connStr);

            String name = DropDownList1.Text;

            SqlCommand upcoming = new SqlCommand("upcomingmatchesproc", conn);
            upcoming.CommandType = CommandType.StoredProcedure;
            upcoming.Parameters.Add(new SqlParameter("@name", name));


            conn.Open();
            SqlDataReader rdr = upcoming.ExecuteReader(CommandBehavior.CloseConnection);
            Table table = new Table();

            GridView2.DataSource = rdr;
            GridView2.DataBind();
            conn.Close();

        }

        protected void availablestadiums(object sender, EventArgs e)
        {

            string connStr = WebConfigurationManager.ConnectionStrings["premierleague"].ToString();
            SqlConnection conn = new SqlConnection(connStr);

            String date = stadium.Text;

            SqlCommand available = new SqlCommand("AvailableStadiums", conn);
            available.CommandType = CommandType.StoredProcedure;
            available.Parameters.Add(new SqlParameter("@date", date));


            conn.Open();
            SqlDataReader rdr = available.ExecuteReader(CommandBehavior.CloseConnection);
            Table table = new Table();

            GridView3.DataSource = rdr;
            GridView3.DataBind();
            conn.Close();

        }

        protected void addhostrequest(object sender, EventArgs e)
        {

            string connStr = WebConfigurationManager.ConnectionStrings["premierleague"].ToString();
            SqlConnection conn = new SqlConnection(connStr);

            String date= matchdate.Text;
            String club = DropDownList1.Text;
            String stad= DropDownList2.Text;

            SqlCommand addreq = new SqlCommand("addHostRequest", conn);
            addreq.CommandType = CommandType.StoredProcedure;
            addreq.Parameters.Add(new SqlParameter("@date", date));
            addreq.Parameters.Add(new SqlParameter("@club_name", club));
            addreq.Parameters.Add(new SqlParameter("@stadium_name", stad));


            conn.Open();
            addreq.ExecuteNonQuery();
            conn.Close();

        }

    }
}