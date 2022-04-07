using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace BijayBharati19030824
{
    public partial class teachermodule : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // default load data
            if (!this.IsPostBack)
            {
                this.BindGrid();
            }
        }
        private void BindGrid()
        {
            string constr = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            OracleCommand cmd = new OracleCommand();
            OracleConnection con = new OracleConnection(constr);
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = @"SELECT teacher_name AS ""Teacher Name"" , module_name AS ""Module Taught"", module_code AS ""Module Code"",
                                course AS ""Course ID"", credit_hours AS ""Module Credit Hours"" FROM module inner join teacher on module_id = module_taught";
            cmd.CommandType = CommandType.Text;

            DataTable dt = new DataTable("am");

            using (OracleDataReader sdr = cmd.ExecuteReader())
            {
                dt.Load(sdr);
            }

            con.Close();


            gvAM.DataSource = dt;
            gvAM.DataBind();

        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {

            string teacherid = ddlTeacher.SelectedValue.ToString();

            string constr = System.Configuration.ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            OracleCommand cmd = new OracleCommand();
            OracleConnection con = new OracleConnection(constr);
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = @"SELECT teacher_name AS ""Teacher Name"" , module_name AS ""Module Taught"", module_code AS ""Module Code"",
                                course AS ""Course ID"", credit_hours AS ""Module Credit Hours"" FROM module inner join teacher on module_id = module_taught WHERE teacher_id="+teacherid+"";
            cmd.CommandType = CommandType.Text;

            DataTable dt = new DataTable("am");

            using (OracleDataReader sdr = cmd.ExecuteReader())
            {
                dt.Load(sdr);
            }

            con.Close();


            gvAM.DataSource = dt;
            gvAM.DataBind();


        }
    }

}