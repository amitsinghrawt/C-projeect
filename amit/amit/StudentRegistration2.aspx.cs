using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace amit
{
    public partial class StudentRegistration2 : System.Web.UI.Page
    {
        string connectionString = ConfigurationManager.ConnectionStrings["MCA"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtId.Text);
            string studentId = txtStudentId.Text;
            string studentName = txtStudentName.Text;
            string course_Name = txtCourseName.Text;
            int semester = Convert.ToInt32(txtSemester.Text);
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand cmd = new SqlCommand("insert into student(Id,student_id,student_name,coures_name,semester) values(@Id, @student_id,@student_name,@coures_name,@semester)", conn);
            cmd.Parameters.AddWithValue("@Id", id);
            cmd.Parameters.AddWithValue("@student_id", studentId);
            cmd.Parameters.AddWithValue("@student_name", studentName);
            cmd.Parameters.AddWithValue("@coures_name", course_Name);
            cmd.Parameters.AddWithValue("@semester", semester);
            int i = cmd.ExecuteNonQuery();
            conn.Close();
            Clear();
            if (i == 1)
            {
                lblMessage.Text = "Data Inseted successfully";

            }
        }
        void Clear()
        {
            txtId.Text = string.Empty;
            txtStudentId.Text = string.Empty;
            txtStudentName.Text = string.Empty;
            txtCourseName.Text = string.Empty;
            txtSemester.Text = string.Empty;


        }
    }
}