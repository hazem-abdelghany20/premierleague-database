using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ms3
{
    public partial class manager : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void register(object sender, EventArgs e)
        {


                string connStr = WebConfigurationManager.ConnectionStrings["premierleague"].ToString();
                SqlConnection conn = new SqlConnection(connStr);

                String name = managername.Text;
                String stadium = DropDownList1.Text;
                String user = username.Text;
                String pass = password.Text;

                SqlCommand addman = new SqlCommand("addstadiummanager", conn);
                addman.CommandType = CommandType.StoredProcedure;
                addman.Parameters.Add(new SqlParameter("@name", name));
                addman.Parameters.Add(new SqlParameter("@stadium_name", stadium ));
                addman.Parameters.Add(new SqlParameter("@username", user));
                addman.Parameters.Add(new SqlParameter("@password", pass));


                conn.Open();
                addman.ExecuteNonQuery();
                conn.Close();

          
        }

        protected void viewstadium(object sender, EventArgs e)
        {

            string connStr = WebConfigurationManager.ConnectionStrings["premierleague"].ToString();
            SqlConnection conn = new SqlConnection(connStr);

            String stadium = DropDownList1.Text;

            SqlCommand viewstad = new SqlCommand("viewStadiumofManager", conn);
            viewstad.CommandType = CommandType.StoredProcedure;
            viewstad.Parameters.Add(new SqlParameter("@stadium_name", stadium));


            conn.Open();
            SqlDataReader rdr = viewstad.ExecuteReader(CommandBehavior.CloseConnection);
            Table table = new Table();

            GridView1.DataSource = rdr;
            GridView1.DataBind();
            conn.Close();

        }
        protected void requestsbymanager(object sender, EventArgs e)
        {

            string connStr = WebConfigurationManager.ConnectionStrings["premierleague"].ToString();
            SqlConnection conn = new SqlConnection(connStr);

            String stadium = DropDownList1.Text;

            SqlCommand viewreq = new SqlCommand("viewStadiumofManager", conn);
            viewreq.CommandType = CommandType.StoredProcedure;
            viewreq.Parameters.Add(new SqlParameter("@stadium_name", stadium));


            conn.Open();
            SqlDataReader rdr = viewreq.ExecuteReader(CommandBehavior.CloseConnection);

            GridView2.DataSource = rdr;
            GridView2.DataBind();
            conn.Close();

        }

        protected void acceptreq(object sender, EventArgs e)
        {


            string connStr = WebConfigurationManager.ConnectionStrings["premierleague"].ToString();
            SqlConnection conn = new SqlConnection(connStr);

            String name = username.Text;
            String req_id = unhandledreqs.Text;
           

            SqlCommand addman = new SqlCommand("acceptrequestinitial", conn);
            addman.CommandType = CommandType.StoredProcedure;
            addman.Parameters.Add(new SqlParameter("@manager_username", name));
            addman.Parameters.Add(new SqlParameter("@req_id", req_id));
          
            conn.Open();
            addman.ExecuteNonQuery();
            conn.Close();


        }

        protected void rejectreq(object sender, EventArgs e)
        {


            string connStr = WebConfigurationManager.ConnectionStrings["premierleague"].ToString();
            SqlConnection conn = new SqlConnection(connStr);

            String name = username.Text;
            String req_id = unhandledreqs.Text;


            SqlCommand addman = new SqlCommand("rejectrequestinitial", conn);
            addman.CommandType = CommandType.StoredProcedure;
            addman.Parameters.Add(new SqlParameter("@manager_username", name));
            addman.Parameters.Add(new SqlParameter("@req_id", req_id));

            conn.Open();
            addman.ExecuteNonQuery();
            conn.Close();


        }

    }
}