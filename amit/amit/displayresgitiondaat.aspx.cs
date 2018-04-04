using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace amit
{
    public partial class displayresgitiondaat : System.Web.UI.Page
    {
        string connectionString = ConfigurationManager.ConnectionStrings["MCA"].ConnectionString;
        DataSet ds = new DataSet();
        protected List<student> objStudent = new List<student>();
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from student",conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds);
            if (ds.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    objStudent.Add(new student { 
                    Id = Convert.ToInt32(ds.Tables[0].Rows[i][0].ToString()),
                    studentId =ds.Tables[0].Rows[i][1].ToString(),
                    StudentName = ds.Tables[0].Rows[i][1].ToString(),
                    courseName = ds.Tables[0].Rows[i][1].ToString(),
                    semester = Convert.ToInt32(ds.Tables[0].Rows[i][1].ToString())
                    });
                }
            }
        }
    }
}