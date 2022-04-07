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
    public partial class studentfee : System.Web.UI.Page
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
            cmd.CommandText = @"SELECT student_name AS ""Student Name"" , student_id AS ""Student ID"", amount AS ""Fee Amount"",
                                year_semester AS ""Yeat/Semester"", due_date AS ""Due Date"", payment_date AS ""Payment Date"", remarks AS ""Remarks"" FROM student inner join fee on student_id=student";
            cmd.CommandType = CommandType.Text;

            DataTable dt = new DataTable("sf");

            using (OracleDataReader sdr = cmd.ExecuteReader())
            {
                dt.Load(sdr);
            }

            con.Close();


            gvSF.DataSource = dt;
            gvSF.DataBind();

        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {

            string studentID = ddlStudent.SelectedValue.ToString();

            string constr = System.Configuration.ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            OracleCommand cmd = new OracleCommand();
            OracleConnection con = new OracleConnection(constr);
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = @"SELECT student_name AS ""Student Name"" , student_id AS ""Student ID"", amount AS ""Fee Amount"",
                                year_semester AS ""Year/Semester"", due_date AS ""Due Date"", payment_date AS ""Payment Date"", remarks AS ""Remarks"" FROM student inner join fee on student_id=student WHERE student_id=" + studentID + "";
            cmd.CommandType = CommandType.Text;

            DataTable dt = new DataTable("sf");

            using (OracleDataReader sdr = cmd.ExecuteReader())
            {
                dt.Load(sdr);
            }

            con.Close();


            gvSF.DataSource = dt;
            gvSF.DataBind();


        }
    }

}