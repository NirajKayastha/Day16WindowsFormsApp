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
    public partial class DataviewOperations : Form
    {

        private SqlConnection con = null;
        private SqlDataAdapter adapter = null;
        private DataSet ds = null;

        public DataviewOperations()
        {
            InitializeComponent();
        }

        private void DataviewOperations_Load(object sender, EventArgs e)
        {
            comboTestScore.Text = "--Select--";
            comboTestScore.Items.Add("41 to 50");
            comboTestScore.Items.Add("51 to 60");
            comboTestScore.Items.Add("61 to 70");
            comboTestScore.Items.Add("71 to 80");
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            using (con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnHR"].ConnectionString))
            {
                using (adapter = new SqlDataAdapter("Select cCandidateCode,vFirstName,cCollegecode,siTestScore from ExternalCandidate", con))
                { 
                ds =new DataSet();
                    adapter.Fill(ds, "Ext");

                    DataView dv = ds.Tables["Ext"].DefaultView;

                    if (comboTestScore.SelectedIndex == 0)
                    {
                        dv.RowFilter = "siTestScore >41 AND siTestScore <=50";

                    }
                    else if (comboTestScore.SelectedIndex == 1)
                    {
                        dv.RowFilter = "siTestScore >51 AND siTestScore <=60";

                    }
                    else if (comboTestScore.SelectedIndex == 2)
                    {
                        dv.RowFilter = "siTestScore >61 AND siTestScore <=70";

                    }
                    else 
                    {
                        dv.RowFilter = "siTestScore >71 AND siTestScore <=80";

                    }

                    dv.Sort = "siTestScore DESC";

                    dataGridCandidate.DataSource = dv;  

                }
           }
        }
    }
}
