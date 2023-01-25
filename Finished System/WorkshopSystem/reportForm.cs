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
using System.Collections;

namespace WorkshopSystem
{
    public partial class reportForm : Form
    {
        SqlDataAdapter daCourse, daWorkshop, daCoach, daCampus, daStudents, daSessionDetails, daSession;
        DataSet dsWorkshop = new DataSet();
        SqlCommandBuilder cmbDCourse, cmbDWorkshop, cmbDCoach, cmbDCampus, cmbDStudents, cmbDSessionDetails, cmbDSession;
        DataRow drCourse, drWorkshop, drCoach, drCampus, drStudents, drSessionDetails, drSession;
        String connStr, sqlCourse, sqlWorkshop, sqlCoach, sqlCampus, sqlStudents, sqlSessionDetails, sqlSession;

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void cmbCoach_SelectedIndexChanged(object sender, EventArgs e)
        {
            fillDgvFiltered();
        }

        private void cmbCampus_SelectedIndexChanged(object sender, EventArgs e)
        {
            fillDgvFiltered();
        }

        private void dtpFrom_ValueChanged(object sender, EventArgs e)
        {
            fillDgvFiltered();
        }

        private void dtpUntil_ValueChanged(object sender, EventArgs e)
        {
            fillDgvFiltered();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            fillDgvFiltered();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            if(dgvWorkshops.Rows.Count > 0)
            {
                frmStudents frmS = new frmStudents(dgvWorkshops.CurrentRow.Cells[0].Value.ToString());
                frmS.ShowDialog();
            }
            else
            {
                MessageBox.Show("You must choose a workshop to choose students form.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClearFilters_Click(object sender, EventArgs e)
        {
            cmbCampus.SelectedIndex = -1;
            cmbCoach.SelectedIndex = -1;
            cmbWshops.SelectedIndex = -1;
            dtpFrom.Value = findEarliest();
            dtpUntil.Value = findLatest(findEarliest());
            txtSearch.Text = "";
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if(dgvWorkshops.Rows.Count > 0)
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to export the\ninformation in the list to excel?", "Confirm", MessageBoxButtons.YesNo);
                if(dialogResult == DialogResult.Yes)
                {
                    //Export code.                     
                    Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();                   
                    Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);                 
                    Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
                    app.Visible = true;
                    worksheet = workbook.Sheets["Sheet1"];
                    worksheet = workbook.ActiveSheet;
                    worksheet.Name = "Exported from gridview";
                    for (int i = 1; i < dgvWorkshops.Columns.Count + 1; i++)
                    {
                        worksheet.Cells[1, i] = dgvWorkshops.Columns[i - 1].HeaderText;
                    }
                    // storing Each row and column value to excel sheet  
                    for (int i = 0; i < dgvWorkshops.Rows.Count; i++)
                    {
                        for (int j = 0; j < dgvWorkshops.Columns.Count; j++)
                        {
                            worksheet.Cells[i + 2, j + 1] = dgvWorkshops.Rows[i].Cells[j].Value.ToString();
                        }
                    }
                }
            }   
            else
            {
                MessageBox.Show("There are no workshops in the list to export.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbWshops_SelectedIndexChanged(object sender, EventArgs e)
        {
            fillDgvFiltered();
        }

        public reportForm()
        {
            InitializeComponent();
        }

        private void reportForm_Load(object sender, EventArgs e)
        {
            connStr = @"Data Source=DESKTOP-D93M828\SQLEXPRESS;Initial Catalog=workshop;Integrated Security=True";
            sqlCourse = @"select * from course";
            daCourse = new SqlDataAdapter(sqlCourse, connStr);
            cmbDCourse = new SqlCommandBuilder(daCourse);
            daCourse.FillSchema(dsWorkshop, SchemaType.Source, "course");
            daCourse.Fill(dsWorkshop, "course");

            sqlWorkshop = @"select * from workshops";
            daWorkshop = new SqlDataAdapter(sqlWorkshop, connStr);
            cmbDWorkshop = new SqlCommandBuilder(daWorkshop);
            daWorkshop.FillSchema(dsWorkshop, SchemaType.Source, "workshops");
            daWorkshop.Fill(dsWorkshop, "workshops");

            sqlCampus = @"select * from campus";
            daCampus = new SqlDataAdapter(sqlCampus, connStr);
            cmbDCampus = new SqlCommandBuilder(daCampus);
            daCampus.FillSchema(dsWorkshop, SchemaType.Source, "campus");
            daCampus.Fill(dsWorkshop, "campus");

            sqlCoach = @"select * from coach";
            daCoach = new SqlDataAdapter(sqlCoach, connStr);
            cmbDCoach = new SqlCommandBuilder(daCoach);
            daCoach.FillSchema(dsWorkshop, SchemaType.Source, "coach");
            daCoach.Fill(dsWorkshop, "coach");

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

            fillDgvFiltered();
            limitDates();
            fillCombo();
        }

        private void fillDgvDefault()
        {
            dgvWorkshops.Rows.Clear();
            foreach(DataRow dr in dsWorkshop.Tables["session"].Rows)
            {
                bool inDate = IsBewteenTwoDates(Convert.ToDateTime(dr["courseDate"].ToString()), dtpFrom.Value, dtpUntil.Value);
                if (inDate)
                {
                    drCourse = dsWorkshop.Tables["course"].Rows.Find(dr["courseID"]);
                    if (drCourse["courseName"].ToString().ToLower().Contains(txtSearch.Text.ToLower()))
                    {

                        String workshop = "", course = "", campus = "", coach = "", date = "", time = "", attendees = "";
                        int i = 0;
                        drCampus = dsWorkshop.Tables["campus"].Rows.Find(dr["campusID"]);
                        drCoach = dsWorkshop.Tables["coach"].Rows.Find(dr["coachID"]);
                        drCourse = dsWorkshop.Tables["course"].Rows.Find(dr["courseID"]);
                        drWorkshop = dsWorkshop.Tables["workshops"].Rows.Find(dr["workshopID"]);

                        foreach (DataRow dr2 in dsWorkshop.Tables["sessionDetails"].Rows)
                        {
                            if (dr2["sessionID"].ToString().Equals(dr["sessionID"].ToString()))
                            {
                                i++;
                            }
                        }

                        attendees = "" + i;
                        date = dr["courseDate"].ToString().Substring(0, 10);
                        time = dr["courseTime"].ToString().Substring(0, 5);
                        coach = drCoach["coachForeName"].ToString() + ", " + drCoach["coachSurName"].ToString();
                        campus = drCampus["campusName"].ToString();
                        course = drCourse["courseName"].ToString();
                        workshop = drWorkshop["workshopName"].ToString();

                        dgvWorkshops.Rows.Add(dr["sessionID"].ToString(),workshop, coach, course, attendees, date, time, campus);
                    }
                }
            }          
        }

        private void fillDgvFiltered()
        {
            bool filterCoach = false, filterWorkshop = false, filterCampus = false;
            dgvWorkshops.Rows.Clear();
            
            if(cmbCoach.SelectedIndex != -1)
            {
                //MessageBox.Show(cmbCoach.SelectedValue + "");
                filterCoach = true;
            }
            if (cmbCampus.SelectedIndex != -1)
            {
                filterCampus = true;
            }
            if (cmbWshops.SelectedIndex != -1)
            {
                filterWorkshop = true;
            }
            //Filters the dgv by campus, coach and workshop
            if (filterCampus && filterCoach && filterWorkshop)
            {
                foreach (DataRow dr in dsWorkshop.Tables["session"].Rows)
                {
                    if (dr["coachID"].ToString() == cmbCoach.SelectedValue.ToString() && dr["campusID"].ToString() == cmbCampus.SelectedValue.ToString() && dr["workshopID"].ToString() == cmbWshops.SelectedValue.ToString())
                    {
                        bool inDate = IsBewteenTwoDates(Convert.ToDateTime(dr["courseDate"].ToString()), dtpFrom.Value, dtpUntil.Value);
                        if (inDate)
                        {
                            drCourse = dsWorkshop.Tables["course"].Rows.Find(dr["courseID"]);
                            if (drCourse["courseName"].ToString().ToLower().Contains(txtSearch.Text.ToLower()))
                            {

                                String workshop = "", course = "", campus = "", coach = "", date = "", time = "", attendees = "";
                                int i = 0;
                                drCampus = dsWorkshop.Tables["campus"].Rows.Find(dr["campusID"]);
                                drCoach = dsWorkshop.Tables["coach"].Rows.Find(dr["coachID"]);
                                drCourse = dsWorkshop.Tables["course"].Rows.Find(dr["courseID"]);
                                drWorkshop = dsWorkshop.Tables["workshops"].Rows.Find(dr["workshopID"]);

                                foreach (DataRow dr2 in dsWorkshop.Tables["sessionDetails"].Rows)
                                {
                                    if (dr2["sessionID"].ToString().Equals(dr["sessionID"].ToString()))
                                    {
                                        i++;
                                    }
                                }

                                attendees = "" + i;
                                date = dr["courseDate"].ToString().Substring(0, 10);
                                time = dr["courseTime"].ToString().Substring(0, 5);
                                coach = drCoach["coachForeName"].ToString() + ", " + drCoach["coachSurName"].ToString();
                                campus = drCampus["campusName"].ToString();
                                course = drCourse["courseName"].ToString();
                                workshop = drWorkshop["workshopName"].ToString();

                                dgvWorkshops.Rows.Add(dr["sessionID"].ToString(), workshop, coach, course, attendees, date, time, campus);
                            }
                        }
                    }
                }
            }
            else if (filterCampus && filterCoach)
            {
                foreach (DataRow dr in dsWorkshop.Tables["session"].Rows)
                {
                    if (dr["coachID"].ToString() == cmbCoach.SelectedValue.ToString() && dr["campusID"].ToString() == cmbCampus.SelectedValue.ToString())
                    {
                        bool inDate = IsBewteenTwoDates(Convert.ToDateTime(dr["courseDate"].ToString()), dtpFrom.Value, dtpUntil.Value);
                        if (inDate)
                        {
                            drCourse = dsWorkshop.Tables["course"].Rows.Find(dr["courseID"]);
                            if (drCourse["courseName"].ToString().ToLower().Contains(txtSearch.Text.ToLower()))
                            {

                                String workshop = "", course = "", campus = "", coach = "", date = "", time = "", attendees = "";
                                int i = 0;
                                drCampus = dsWorkshop.Tables["campus"].Rows.Find(dr["campusID"]);
                                drCoach = dsWorkshop.Tables["coach"].Rows.Find(dr["coachID"]);
                                drCourse = dsWorkshop.Tables["course"].Rows.Find(dr["courseID"]);
                                drWorkshop = dsWorkshop.Tables["workshops"].Rows.Find(dr["workshopID"]);

                                foreach (DataRow dr2 in dsWorkshop.Tables["sessionDetails"].Rows)
                                {
                                    if (dr2["sessionID"].ToString().Equals(dr["sessionID"].ToString()))
                                    {
                                        i++;
                                    }
                                }

                                attendees = "" + i;
                                date = dr["courseDate"].ToString().Substring(0, 10);
                                time = dr["courseTime"].ToString().Substring(0, 5);
                                coach = drCoach["coachForeName"].ToString() + ", " + drCoach["coachSurName"].ToString();
                                campus = drCampus["campusName"].ToString();
                                course = drCourse["courseName"].ToString();
                                workshop = drWorkshop["workshopName"].ToString();

                                dgvWorkshops.Rows.Add(dr["sessionID"].ToString(), workshop, coach, course, attendees, date, time, campus);
                            }
                        }
                    }
                }
            }
            else if (filterCampus && filterWorkshop)
            {
                foreach (DataRow dr in dsWorkshop.Tables["session"].Rows)
                {
                    if (dr["workshopID"].ToString() == cmbWshops.SelectedValue.ToString() && dr["campusID"].ToString() == cmbCampus.SelectedValue.ToString())
                    {
                        bool inDate = IsBewteenTwoDates(Convert.ToDateTime(dr["courseDate"].ToString()), dtpFrom.Value, dtpUntil.Value);
                        if (inDate)
                        {
                            drCourse = dsWorkshop.Tables["course"].Rows.Find(dr["courseID"]);
                            if (drCourse["courseName"].ToString().ToLower().Contains(txtSearch.Text.ToLower()))
                            {

                                String workshop = "", course = "", campus = "", coach = "", date = "", time = "", attendees = "";
                                int i = 0;
                                drCampus = dsWorkshop.Tables["campus"].Rows.Find(dr["campusID"]);
                                drCoach = dsWorkshop.Tables["coach"].Rows.Find(dr["coachID"]);
                                drCourse = dsWorkshop.Tables["course"].Rows.Find(dr["courseID"]);
                                drWorkshop = dsWorkshop.Tables["workshops"].Rows.Find(dr["workshopID"]);

                                foreach (DataRow dr2 in dsWorkshop.Tables["sessionDetails"].Rows)
                                {
                                    if (dr2["sessionID"].ToString().Equals(dr["sessionID"].ToString()))
                                    {
                                        i++;
                                    }
                                }

                                attendees = "" + i;
                                date = dr["courseDate"].ToString().Substring(0, 10);
                                time = dr["courseTime"].ToString().Substring(0, 5);
                                coach = drCoach["coachForeName"].ToString() + ", " + drCoach["coachSurName"].ToString();
                                campus = drCampus["campusName"].ToString();
                                course = drCourse["courseName"].ToString();
                                workshop = drWorkshop["workshopName"].ToString();

                                dgvWorkshops.Rows.Add(dr["sessionID"].ToString(), workshop, coach, course, attendees, date, time, campus);
                            }
                        }
                    }
                }
            }
            else if (filterCoach && filterWorkshop)
            {
                foreach (DataRow dr in dsWorkshop.Tables["session"].Rows)
                {
                    if (dr["coachID"].ToString() == cmbCoach.SelectedValue.ToString() && dr["workshopID"].ToString() == cmbWshops.SelectedValue.ToString())
                    {
                        bool inDate = IsBewteenTwoDates(Convert.ToDateTime(dr["courseDate"].ToString()), dtpFrom.Value, dtpUntil.Value);
                        if (inDate)
                        {
                            drCourse = dsWorkshop.Tables["course"].Rows.Find(dr["courseID"]);
                            if (drCourse["courseName"].ToString().ToLower().Contains(txtSearch.Text.ToLower()))
                            {

                                String workshop = "", course = "", campus = "", coach = "", date = "", time = "", attendees = "";
                                int i = 0;
                                drCampus = dsWorkshop.Tables["campus"].Rows.Find(dr["campusID"]);
                                drCoach = dsWorkshop.Tables["coach"].Rows.Find(dr["coachID"]);
                                drCourse = dsWorkshop.Tables["course"].Rows.Find(dr["courseID"]);
                                drWorkshop = dsWorkshop.Tables["workshops"].Rows.Find(dr["workshopID"]);

                                foreach (DataRow dr2 in dsWorkshop.Tables["sessionDetails"].Rows)
                                {
                                    if (dr2["sessionID"].ToString().Equals(dr["sessionID"].ToString()))
                                    {
                                        i++;
                                    }
                                }

                                attendees = "" + i;
                                date = dr["courseDate"].ToString().Substring(0, 10);
                                time = dr["courseTime"].ToString().Substring(0, 5);
                                coach = drCoach["coachForeName"].ToString() + ", " + drCoach["coachSurName"].ToString();
                                campus = drCampus["campusName"].ToString();
                                course = drCourse["courseName"].ToString();
                                workshop = drWorkshop["workshopName"].ToString();

                                dgvWorkshops.Rows.Add(dr["sessionID"].ToString(), workshop, coach, course, attendees, date, time, campus);
                            }
                        }
                    }
                }
            }
            else if (filterCampus)
            {
                foreach (DataRow dr in dsWorkshop.Tables["session"].Rows)
                {
                    if (dr["campusID"].ToString() == cmbCampus.SelectedValue.ToString())
                    {
                        bool inDate = IsBewteenTwoDates(Convert.ToDateTime(dr["courseDate"].ToString()), dtpFrom.Value, dtpUntil.Value);
                        if (inDate)
                        {
                            drCourse = dsWorkshop.Tables["course"].Rows.Find(dr["courseID"]);
                            if (drCourse["courseName"].ToString().ToLower().Contains(txtSearch.Text.ToLower()))
                            {

                                String workshop = "", course = "", campus = "", coach = "", date = "", time = "", attendees = "";
                                int i = 0;
                                drCampus = dsWorkshop.Tables["campus"].Rows.Find(dr["campusID"]);
                                drCoach = dsWorkshop.Tables["coach"].Rows.Find(dr["coachID"]);
                                drCourse = dsWorkshop.Tables["course"].Rows.Find(dr["courseID"]);
                                drWorkshop = dsWorkshop.Tables["workshops"].Rows.Find(dr["workshopID"]);

                                foreach (DataRow dr2 in dsWorkshop.Tables["sessionDetails"].Rows)
                                {
                                    if (dr2["sessionID"].ToString().Equals(dr["sessionID"].ToString()))
                                    {
                                        i++;
                                    }
                                }

                                attendees = "" + i;
                                date = dr["courseDate"].ToString().Substring(0, 10);
                                time = dr["courseTime"].ToString().Substring(0, 5);
                                coach = drCoach["coachForeName"].ToString() + ", " + drCoach["coachSurName"].ToString();
                                campus = drCampus["campusName"].ToString();
                                course = drCourse["courseName"].ToString();
                                workshop = drWorkshop["workshopName"].ToString();

                                dgvWorkshops.Rows.Add(dr["sessionID"].ToString(), workshop, coach, course, attendees, date, time, campus);
                            }
                        }
                    }
                }
            }
            else if (filterCoach)
            {
                foreach (DataRow dr in dsWorkshop.Tables["session"].Rows)
                {
                    if (dr["coachID"].ToString() == cmbCoach.SelectedValue.ToString())
                    {
                        bool inDate = IsBewteenTwoDates(Convert.ToDateTime(dr["courseDate"].ToString()), dtpFrom.Value, dtpUntil.Value);
                        if (inDate)
                        {
                            drCourse = dsWorkshop.Tables["course"].Rows.Find(dr["courseID"]);
                            if (drCourse["courseName"].ToString().ToLower().Contains(txtSearch.Text.ToLower()))
                            {

                                String workshop = "", course = "", campus = "", coach = "", date = "", time = "", attendees = "";
                                int i = 0;
                                drCampus = dsWorkshop.Tables["campus"].Rows.Find(dr["campusID"]);
                                drCoach = dsWorkshop.Tables["coach"].Rows.Find(dr["coachID"]);
                                drCourse = dsWorkshop.Tables["course"].Rows.Find(dr["courseID"]);
                                drWorkshop = dsWorkshop.Tables["workshops"].Rows.Find(dr["workshopID"]);

                                foreach (DataRow dr2 in dsWorkshop.Tables["sessionDetails"].Rows)
                                {
                                    if (dr2["sessionID"].ToString().Equals(dr["sessionID"].ToString()))
                                    {
                                        i++;
                                    }
                                }

                                attendees = "" + i;
                                date = dr["courseDate"].ToString().Substring(0, 10);
                                time = dr["courseTime"].ToString().Substring(0, 5);
                                coach = drCoach["coachForeName"].ToString() + ", " + drCoach["coachSurName"].ToString();
                                campus = drCampus["campusName"].ToString();
                                course = drCourse["courseName"].ToString();
                                workshop = drWorkshop["workshopName"].ToString();

                                dgvWorkshops.Rows.Add(dr["sessionID"].ToString(), workshop, coach, course, attendees, date, time, campus);
                            }
                        }
                    }
                }
            }
            else if (filterWorkshop)
            {
                foreach (DataRow dr in dsWorkshop.Tables["session"].Rows)
                {
                    if (dr["workshopID"].ToString() == cmbWshops.SelectedValue.ToString())
                    {
                        bool inDate = IsBewteenTwoDates(Convert.ToDateTime(dr["courseDate"].ToString()), dtpFrom.Value, dtpUntil.Value);
                        if (inDate)
                        {
                            drCourse = dsWorkshop.Tables["course"].Rows.Find(dr["courseID"]);
                            if (drCourse["courseName"].ToString().ToLower().Contains(txtSearch.Text.ToLower()))
                            {
                                drCourse = dsWorkshop.Tables["course"].Rows.Find(dr["courseID"]);
                                if (drCourse["courseName"].ToString().ToLower().Contains(txtSearch.Text.ToLower()))
                                {

                                    String workshop = "", course = "", campus = "", coach = "", date = "", time = "", attendees = "";
                                    int i = 0;
                                    drCampus = dsWorkshop.Tables["campus"].Rows.Find(dr["campusID"]);
                                    drCoach = dsWorkshop.Tables["coach"].Rows.Find(dr["coachID"]);
                                    drCourse = dsWorkshop.Tables["course"].Rows.Find(dr["courseID"]);
                                    drWorkshop = dsWorkshop.Tables["workshops"].Rows.Find(dr["workshopID"]);

                                    foreach (DataRow dr2 in dsWorkshop.Tables["sessionDetails"].Rows)
                                    {
                                        if (dr2["sessionID"].ToString().Equals(dr["sessionID"].ToString()))
                                        {
                                            i++;
                                        }
                                    }

                                    attendees = "" + i;
                                    date = dr["courseDate"].ToString().Substring(0, 10);
                                    time = dr["courseTime"].ToString().Substring(0, 5);
                                    coach = drCoach["coachForeName"].ToString() + ", " + drCoach["coachSurName"].ToString();
                                    campus = drCampus["campusName"].ToString();
                                    course = drCourse["courseName"].ToString();
                                    workshop = drWorkshop["workshopName"].ToString();

                                    dgvWorkshops.Rows.Add(dr["sessionID"].ToString(), workshop, coach, course, attendees, date, time, campus);
                                }
                            }
                        }
                    }
                }
            }
            if(!filterCoach && !filterCampus && !filterWorkshop)
            {
                fillDgvDefault();
            }
        }

        private void limitDates()
        {
            dtpFrom.MinDate = findEarliest();
            dtpFrom.MaxDate = findLatest(findEarliest());
            dtpFrom.Value = dtpFrom.MinDate;

            dtpUntil.MinDate = findEarliest();
            dtpUntil.MaxDate = findLatest(findEarliest());
            dtpUntil.Value = dtpUntil.MaxDate;
        }

        private DateTime findEarliest()
        {
            DateTime first = DateTime.Now;

            if(dsWorkshop.Tables["session"].Rows.Count > 0)
            {
                foreach (DataRow dr in dsWorkshop.Tables["session"].Rows)
                {
                    String dateS = dr["courseDate"].ToString();
                    DateTime compareDate = Convert.ToDateTime(dateS);
                    if(compareDate.CompareTo(first) <0)
                    {
                        first = compareDate;
                    }
                }
            }

            return first;
        }

        private DateTime findLatest(DateTime earliest)
        {
            DateTime last = earliest;
            if (dsWorkshop.Tables["session"].Rows.Count > 0)
            {
                foreach (DataRow dr in dsWorkshop.Tables["session"].Rows)
                {
                    String dateS = dr["courseDate"].ToString();
                    DateTime compareDate = Convert.ToDateTime(dateS);
                    if (compareDate.CompareTo(last) > 0)
                    {
                        last = compareDate;
                    }
                }
            }
            return last;
        }

        private void fillCombo()
        {
            cmbWshops.DataSource = dsWorkshop.Tables["workshops"];
            cmbWshops.DisplayMember = "workshopName";
            cmbWshops.ValueMember = "workshopID";
            cmbWshops.SelectedIndex = -1;
          

            cmbCampus.DataSource = dsWorkshop.Tables["campus"];
            cmbCampus.DisplayMember = "campusName";
            cmbCampus.ValueMember = "campusID";
            cmbCampus.SelectedIndex = -1;

            
            cmbCoach.DataSource = dsWorkshop.Tables["coach"];
            cmbCoach.DisplayMember = "coachForeName";
            cmbCoach.ValueMember = "coachID";
            cmbCoach.SelectedIndex = -1;
        }

        private bool IsBewteenTwoDates(DateTime dt, DateTime start, DateTime end)
        {
            return dt >= start && dt <= end;
        }
   
    
    
    
    
    }
}
