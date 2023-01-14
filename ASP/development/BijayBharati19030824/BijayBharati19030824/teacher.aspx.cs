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
    public partial class teacher : System.Web.UI.Page
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
            cmd.CommandText = @"SELECT teacher_id , teacher_name AS ""Teacher Name"", module_taught AS ""Module ID"", department AS ""Department ID"", teacher_address AS ""Address ID"", teacher_email AS ""Email"", teacher_phone AS ""Phone"" FROM teacher";
            cmd.CommandType = CommandType.Text;

            DataTable dt = new DataTable("teacher");

            using (OracleDataReader sdr = cmd.ExecuteReader())
            {
                dt.Load(sdr);
            }

            con.Close();


            gvTeacher.DataSource = dt;
            gvTeacher.DataBind();

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {

            // insert code
            string name = txtteachername.Text.ToString();
            int moduleid = Convert.ToInt32(ddlModule.SelectedValue.ToString());
            int departmentid = Convert.ToInt32(ddlDepartment.SelectedValue.ToString());
            int addressid = Convert.ToInt32(ddlAddress.SelectedValue.ToString());
            string temail = txtemail.Text.ToString();
            string tphone = txtphone.Text.ToString();
            string constr = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            OracleConnection con = new OracleConnection(constr);

            if (btnSubmit.Text == "Submit")
            {

                OracleCommand cmd = new OracleCommand("INSERT INTO teacher(teacher_name, module_taught,department,teacher_address,teacher_email,teacher_phone)Values('" + name + "','" + moduleid + "','" + departmentid + "','" + addressid + "','" + temail + "','" + tphone + "')");
                cmd.Connection = con;
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

            }

            else if (btnSubmit.Text == "Update")
            {
                //get ID for the Update
                string ID = txtID.Text.ToString();
                OracleCommand cmd = new OracleCommand("UPDATE teacher SET teacher_name = '" + name + "',module_taught = '" + moduleid + "',department = '" + departmentid + "',teacher_address = '" + addressid + "',teacher_email = '" + temail + "',teacher_phone = '" + tphone + "' WHERE teacher_id = " + ID);
                cmd.Connection = con;
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                btnSubmit.Text = "Submit";
                gvTeacher.EditIndex = -1;

            }

            this.BindGrid();
        }


        protected void OnRowCancelingEdit(object sender, EventArgs e)
        {

            this.BindGrid();
            gvTeacher.EditIndex = -1;
        }
        protected void OnRowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int ID = Convert.ToInt32(gvTeacher.DataKeys[e.RowIndex].Values[0]);
            string constr = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            using (OracleConnection con = new OracleConnection(constr))
            {
                using (OracleCommand cmd = new OracleCommand("DELETE FROM teacher WHERE teacher_id =" + ID))
                {

                    cmd.Connection = con;
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
            }

            this.BindGrid();
            gvTeacher.EditIndex = -1;

        }
        protected void OnRowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow && e.Row.RowIndex != gvTeacher.EditIndex)
            {
                (e.Row.Cells[0].Controls[2] as LinkButton).Attributes["onclick"] = "return confirm('Do you want to delete this row?');";


            }
            //this.BindGrid();
            gvTeacher.EditIndex = -1;

        }
        protected void OnRowEditing(object sender, GridViewEditEventArgs e)
        {

            // get id for data update
            txtID.Text = this.gvTeacher.Rows[e.NewEditIndex].Cells[1].Text;
            txtteachername.Text = this.gvTeacher.Rows[e.NewEditIndex].Cells[2].Text.ToString().TrimStart().TrimEnd(); // (row.Cells[2].Controls[0] as TextBox).Text;
            txtemail.Text = this.gvTeacher.Rows[e.NewEditIndex].Cells[6].Text;
            txtphone.Text = this.gvTeacher.Rows[e.NewEditIndex].Cells[7].Text;
            btnSubmit.Text = "Update";

        }


    }

}