using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace WorkshopSystem
{
    public partial class frmStudents : Form
    {
        String id = "";
        SqlDataAdapter daStudents, daSessionDetails, daSession;
        DataSet dsWorkshop = new DataSet();
        SqlCommandBuilder cmbDStudents, cmbDSessionDetails, cmbDSession;
        DataRow drStudents, drSessionDetails, drSession;
        String connStr,sqlStudents, sqlSessionDetails, sqlSession;

        public frmStudents(String sessionID)
        {
            InitializeComponent();
            id = sessionID;
        }

        private void frmStudents_Load(object sender, EventArgs e)
        {
            connStr = @"Data Source=BLISSFUL-PC\MSSQLSERVER02;Initial Catalog=workshop;Integrated Security=True";
            sqlSessionDetails = @"select * from sessionDetails";
            daSessionDetails = new SqlDataAdapter(sqlSessionDetails, connStr);
            cmbDSessionDetails = new SqlCommandBuilder(daSessionDetails);
            daSessionDetails.FillSchema(dsWorkshop, SchemaType.Source, "sessionDetails");
            daSessionDetails.Fill(dsWorkshop, "sessionDetails");

            sqlStudents = @"select * from attendees";
            daStudents = new SqlDataAdapter(sqlStudents, connStr);
            cmbDStudents = new SqlCommandBuilder(daStudents);
            daStudents.FillSchema(dsWorkshop, SchemaType.Source, "attendees");
            daStudents.Fill(dsWorkshop, "attendees");


            sqlSession = @"select * from session";
            daSession = new SqlDataAdapter(sqlSession, connStr);
            cmbDSession = new SqlCommandBuilder(daSession);
            daSession.FillSchema(dsWorkshop, SchemaType.Source, "session");
            daSession.Fill(dsWorkshop, "session");


            lblID.Text = id;
            drSession = dsWorkshop.Tables["session"].Rows.Find(id);
            lblDate.Text = drSession["courseDate"].ToString();
            int i = 0;
            dgvStudents.Rows.Clear();
            foreach(DataRow dr in dsWorkshop.Tables["sessionDetails"].Rows)
            {
                if(id == dr["sessionID"].ToString())
                {
                    i++;
                    drStudents = dsWorkshop.Tables["attendees"].Rows.Find(dr["studentId"].ToString());
                    dgvStudents.Rows.Add(drStudents["name"].ToString(), drStudents["email"].ToString());
                }
            }
            lblAttendess.Text = ""+i;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
