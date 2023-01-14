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
    public partial class student : System.Web.UI.Page
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
            cmd.CommandText = @"SELECT student_id , student_name AS ""Student Name"", student_DOB AS ""DOB"", student_address AS ""Address ID"", enrolled_course AS ""Course"", student_email AS ""Email"", student_phone AS ""Phone"", attendance AS ""Total Attendance"" FROM student";
            cmd.CommandType = CommandType.Text;

            DataTable dt = new DataTable("student");

            using (OracleDataReader sdr = cmd.ExecuteReader())
            {
                dt.Load(sdr);
            }

            con.Close();


            gvStudent.DataSource = dt;
            gvStudent.DataBind();

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {

            // insert code
            string name = txtstudentname.Text.ToString();
            string dob = TextBox1.Text.ToString();
            int addressid = Convert.ToInt32(ddlAddress.SelectedValue.ToString());
            int courseid = Convert.ToInt32(ddlCourse.SelectedValue.ToString());
            string semail = txtemail.Text.ToString();
            string sphone = txtphone.Text.ToString();
            string attendance = txtattendance.Text.ToString();
            string constr = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            OracleConnection con = new OracleConnection(constr);

            if (btnSubmit.Text == "Submit")
            {
                
                OracleCommand cmd = new OracleCommand("INSERT INTO student(student_name, student_dob,student_address,enrolled_course,student_email,student_phone,attendance)Values('" + name + "','" + dob + "','" + addressid + "','" + courseid + "','" + semail + "','" + sphone + "','" + attendance + "')");
                cmd.Connection = con;
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

            }

            else if (btnSubmit.Text == "Update")
            {
                //get ID for the Update
                string ID = txtID.Text.ToString();
                OracleCommand cmd = new OracleCommand("UPDATE student SET student_name = '" + name + "',student_dob = '" + dob + "',student_address = '" + addressid + "',enrolled_course = '" + courseid + "',student_email = '" + semail + "',student_phone = '" + sphone + "',attendance = '" + attendance + "' WHERE student_id = " + ID);
                cmd.Connection = con;
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                btnSubmit.Text = "Submit";
                gvStudent.EditIndex = -1;

            }

            this.BindGrid();
        }


        protected void OnRowCancelingEdit(object sender, EventArgs e)
        {

            this.BindGrid();
            gvStudent.EditIndex = -1;
        }
        protected void OnRowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int ID = Convert.ToInt32(gvStudent.DataKeys[e.RowIndex].Values[0]);
            string constr = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            using (OracleConnection con = new OracleConnection(constr))
            {
                using (OracleCommand cmd = new OracleCommand("DELETE FROM student WHERE student_id =" + ID))
                {

                    cmd.Connection = con;
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
            }

            this.BindGrid();
            gvStudent.EditIndex = -1;

        }
        protected void OnRowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow && e.Row.RowIndex != gvStudent.EditIndex)
            {
                (e.Row.Cells[0].Controls[2] as LinkButton).Attributes["onclick"] = "return confirm('Do you want to delete this row?');";


            }
            //this.BindGrid();
            gvStudent.EditIndex = -1;

        }
        protected void OnRowEditing(object sender, GridViewEditEventArgs e)
        {

            // get id for data update
            txtID.Text = this.gvStudent.Rows[e.NewEditIndex].Cells[1].Text;
            txtstudentname.Text = this.gvStudent.Rows[e.NewEditIndex].Cells[2].Text.ToString().TrimStart().TrimEnd(); // (row.Cells[2].Controls[0] as TextBox).Text;
            txtemail.Text = this.gvStudent.Rows[e.NewEditIndex].Cells[6].Text;
            txtphone.Text = this.gvStudent.Rows[e.NewEditIndex].Cells[7].Text;
            txtattendance.Text=this.gvStudent.Rows[e.NewEditIndex].Cells[8].Text;
            btnSubmit.Text = "Update";

        }


    }

}