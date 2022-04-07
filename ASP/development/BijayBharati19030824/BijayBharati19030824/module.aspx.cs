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
    public partial class module : System.Web.UI.Page
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
            cmd.CommandText = @"SELECT module_id , course AS ""Course ID"", module_code AS ""Module Code"", module_name AS ""Module Name"", credit_hours AS ""Credit Hours"" FROM module";
            cmd.CommandType = CommandType.Text;

            DataTable dt = new DataTable("module");

            using (OracleDataReader sdr = cmd.ExecuteReader())
            {
                dt.Load(sdr);
            }

            con.Close();


            gvModule.DataSource = dt;
            gvModule.DataBind();

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {

            // insert code
            string name = txtmodulename.Text.ToString();
            string code = txtmodulecode.Text.ToString();
            
            int courseid = Convert.ToInt32(ddlCourse.SelectedValue.ToString());
            int chrs = Convert.ToInt32(txthrs.Text.ToString());
            string constr = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            OracleConnection con = new OracleConnection(constr);

            if (btnSubmit.Text == "Submit")
            {

                OracleCommand cmd = new OracleCommand("INSERT INTO module(course, module_code,module_name,credit_hours)VALUES('" + courseid + "','" + code + "','" + name + "','" + chrs + "')");
                cmd.Connection = con;
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

            }

            else if (btnSubmit.Text == "Update")
            {
                //get ID for the Update
                string ID = txtID.Text.ToString();
                OracleCommand cmd = new OracleCommand("UPDATE module SET course = '" + courseid + "',module_code = '" + code + "',module_name = '" + name + "',credit_hours = '" + chrs + "' WHERE student_id = " + ID);
                cmd.Connection = con;
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                btnSubmit.Text = "Submit";
                gvModule.EditIndex = -1;

            }

            this.BindGrid();
        }


        protected void OnRowCancelingEdit(object sender, EventArgs e)
        {

            this.BindGrid();
            gvModule.EditIndex = -1;
        }
        protected void OnRowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int ID = Convert.ToInt32(gvModule.DataKeys[e.RowIndex].Values[0]);
            string constr = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            using (OracleConnection con = new OracleConnection(constr))
            {
                using (OracleCommand cmd = new OracleCommand("DELETE FROM module WHERE module_id =" + ID))
                {

                    cmd.Connection = con;
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
            }

            this.BindGrid();
            gvModule.EditIndex = -1;

        }
        protected void OnRowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow && e.Row.RowIndex != gvModule.EditIndex)
            {
                (e.Row.Cells[0].Controls[2] as LinkButton).Attributes["onclick"] = "return confirm('Do you want to delete this row?');";


            }
            //this.BindGrid();
            gvModule.EditIndex = -1;

        }
        protected void OnRowEditing(object sender, GridViewEditEventArgs e)
        {

            // get id for data update
            txtID.Text = this.gvModule.Rows[e.NewEditIndex].Cells[1].Text;
            txtmodulecode.Text = this.gvModule.Rows[e.NewEditIndex].Cells[3].Text;
            txtmodulename.Text = this.gvModule.Rows[e.NewEditIndex].Cells[4].Text;
            txthrs.Text= this.gvModule.Rows[e.NewEditIndex].Cells[5].Text;
            btnSubmit.Text = "Update";

        }


    }

}