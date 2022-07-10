using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Day16WindowsFormsApp
{
    public partial class ExerciseForm2 : Form
    {
        private SqlConnection con = null;
        private SqlDataAdapter adapter = null;
        private DataSet ds = null;
        private SqlCommand cmd = null;

        public ExerciseForm2()
        {
            InitializeComponent();
        }

        private void ExerciseForm2_Load(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string FromDate = dateTimePicker1.Value.ToShortDateString();

            string ToDate = dateTimePicker2.Value.ToShortDateString();

            using (con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnHR"].ConnectionString))
            {
                using (cmd = new SqlCommand("usp_GetEmployeeSalByPayDate", con))
                //using (adapter = new SqlDataAdapter($"SELECT * FROM MonthlySalary WHERE dPayDate BETWEEN {FromDate} AND {ToDate} ; ", con))
                {

                    cmd.CommandType = CommandType.StoredProcedure;
                   // cmd.Parameters.AddWithValue("@FromPayDate", txtEmployeeCode.Text);
                   // cmd.Parameters.AddWithValue("@ToPayDate", txtFirstName.Text);

                    ds = new DataSet();
                    adapter.Fill(ds, "MonthlySalary");

                    DataView dv = ds.Tables["MonthlySalary"].DefaultView;

                    dataGridViewEmployeePay.DataSource = dv;
                }
            }
        }
    }
}
