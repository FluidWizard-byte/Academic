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
    public partial class studentassignment : System.Web.UI.Page
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
            cmd.CommandText = @"SELECT student_name AS ""Student Name"" , student_id AS ""Student ID"", module_name AS ""Module Name"",
                               assignment_type AS ""Assignment Type"", grade_obtained AS ""Grade Obtained"", status AS ""Status"" 
                               FROM student JOIN assignment ON student.student_id=assignment.student
                               JOIN module ON module.module_id=assignment.module AND assignment.student=student.student_id";
            cmd.CommandType = CommandType.Text;

            DataTable dt = new DataTable("sf");

            using (OracleDataReader sdr = cmd.ExecuteReader())
            {
                dt.Load(sdr);
            }

            con.Close();


            gvSA.DataSource = dt;
            gvSA.DataBind();

        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {

            string studentID = ddlStudent.SelectedValue.ToString();

            string constr = System.Configuration.ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            OracleCommand cmd = new OracleCommand();
            OracleConnection con = new OracleConnection(constr);
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = @"SELECT student_name AS ""Student Name"" , student_id AS ""Student ID"", module_name AS ""Module Name"",
                               assignment_type AS ""Assignment Type"", grade_obtained AS ""Grade Obtained"", status AS ""Status"" 
                               FROM student JOIN assignment ON student.student_id=assignment.student
                               JOIN module ON module.module_id=assignment.module AND assignment.student=student.student_id WHERE student_id=" + studentID + "";
            cmd.CommandType = CommandType.Text;

            DataTable dt = new DataTable("sf");

            using (OracleDataReader sdr = cmd.ExecuteReader())
            {
                dt.Load(sdr);
            }

            con.Close();


            gvSA.DataSource = dt;
            gvSA.DataBind();


        }
    }

}