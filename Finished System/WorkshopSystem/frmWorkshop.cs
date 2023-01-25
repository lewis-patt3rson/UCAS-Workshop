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
    public partial class frmWorkshop : Form
    {
        SqlDataAdapter daCourse, daWorkshop, daCoach, daCampus, daStudents, daSessionDetails, daSession;
        DataSet dsWorkshop = new DataSet();
        SqlCommandBuilder cmbDCourse, cmbDWorkshop, cmbDCoach, cmbDCampus, cmbDStudents, cmbDSessionDetails, cmbDSession;
        DataRow drCourse, drWorkshop, drCoach, drCampus, drStudents, drSessionDetails, drSession;
        String connStr, sqlCourse, sqlWorkshop, sqlCoach, sqlCampus, sqlStudents, sqlSessionDetails, sqlSession;

        private void btnAddCourse_Click(object sender, EventArgs e)
        {
            if(txtAddCourse.Text.Length < 3 || txtAddCourseSess.Text.Length < 3)
            {
                MessageBox.Show("You must add a valid course and sess name.", "Invalid Names.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                
                String id = getCourseIDRecent();
                drCourse = dsWorkshop.Tables["course"].NewRow();
                drCourse["courseID"] = id;
                drCourse["courseName"] = txtAddCourse.Text.Trim();
                drCourse["courseSessName"] = txtAddCourseSess.Text.Trim();

                dsWorkshop.Tables["course"].Rows.Add(drCourse);
                daCourse.Update(dsWorkshop, "course");
                dgvCourses.Rows.Clear();
                txtAddCourse.Text = "";
                txtAddCourseSess.Text = "";
                fillDgvCourses();

            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(dgvCourses.SelectedRows.Count > 0)
            {
                String course = dgvCourses.CurrentRow.Cells[1].Value.ToString();
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to choose\n" + course + "?", "Confirm", MessageBoxButtons.YesNo);
                if(dialogResult==DialogResult.Yes)
                {
                    panel2.Enabled = false;
                    panel2.Visible = false;
                    panel1.Enabled = false;
                    txtCourse.Text = course;
                }
            }
            else
            {
                MessageBox.Show("You must choose a course to confirm.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if(txtSearch.Text.ToString().Length == 0)
            {
                dgvCourses.Rows.Clear();
                fillDgvCourses();
            }
            else
            {
                dgvCourses.Rows.Clear();
                foreach (DataRow dr in dsWorkshop.Tables["course"].Rows)
                {
                    //int amount = txtSearch.Text.ToString().Length;
                   // string s = dr["courseName"].ToString().Substring(0, amount).ToLower();
                    if (dr["courseName"].ToString().ToLower().Contains(txtSearch.Text.Trim().ToString()))
                    {
                        dgvCourses.Rows.Add(dr["courseName"].ToString(), dr["courseSessName"].ToString());
                    }
                }
            }
            
        }

        private void btnCourseFind_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
            panel1.Enabled = true;
            panel2.Enabled = true;
            
            txtSearch.Enabled = true;
            dgvCourses.Rows.Clear();
            fillDgvCourses();
            
        }

        SqlDataReader dr;
        ArrayList students = new ArrayList();

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to\nclear all added students?", "Confirm", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
                dgvStudents.Rows.Clear();
        }

        private void dgvStudents_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            lblTotStudents.Text = "" + (dgvStudents.Rows.Count - 1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to\ncancel this workshop?", "Confirm", MessageBoxButtons.YesNo);
            if(dialogResult == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            bool allFilled = true;
            int j = 0;
            if (dgvStudents.Rows.Count > 1)
            {
                
                foreach(DataGridViewRow dr in dgvStudents.Rows)
                {
                    if (j != dgvStudents.Rows.Count-1)
                    {
                        j++;
                        if (dr.Cells[0].Value == null || dr.Cells[1].Value == null)
                        {
                            allFilled = false;
                        }
                        else if (dr.Cells[0].Value.ToString().Length < 3 || dr.Cells[1].Value.ToString().Length < 3)
                        {
                            allFilled = false;
                        }
                    }
                }
                if(!allFilled)
                {
                    MessageBox.Show("All students must have a name\nand email adress.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    DialogResult dialogResult = MessageBox.Show("Are you sure you want to\nfinish enrolling students?", "Confirm", MessageBoxButtons.YesNo);

                    if (dialogResult == DialogResult.Yes)
                    {
                        int recentID = getStudentID();

                        int sessionID = getSessionID();

                        int courseID = getCourseID(txtCourse.Text.ToString());

                        int coachID = getCoachID();
                       

                        

                        drSession = dsWorkshop.Tables["session"].NewRow();
                        drSession["sessionID"] = sessionID;
                        drSession["coachID"] = coachID;
                        drSession["campusID"] = Convert.ToInt32(cmbCampus.SelectedValue.ToString());
                        drSession["workshopID"] = Convert.ToInt32(cmbWshops.SelectedValue.ToString());
                        drSession["courseDate"] = DateTime.Now;
                        drSession["courseTime"] = DateTime.Now.TimeOfDay;
                        drSession["courseID"] = courseID;
                        dsWorkshop.Tables["session"].Rows.Add(drSession);
                        daSession.Update(dsWorkshop, "session");


                        int i = 0;
                        foreach (DataGridViewRow r in dgvStudents.Rows)
                        {
                            if (i < dgvStudents.Rows.Count - 1)
                            {
                                i++;
                                drStudents = dsWorkshop.Tables["attendees"].NewRow();
                                drStudents["studentID"] = recentID;
                                drStudents["name"] = r.Cells[0].Value.ToString();
                                drStudents["email"] = r.Cells[1].Value.ToString();
                                dsWorkshop.Tables["attendees"].Rows.Add(drStudents);
                                daStudents.Update(dsWorkshop, "attendees");

                                drSessionDetails = dsWorkshop.Tables["sessionDetails"].NewRow();
                                drSessionDetails["sessionID"] = sessionID;
                                drSessionDetails["studentID"] = recentID;
                                dsWorkshop.Tables["sessionDetails"].Rows.Add(drSessionDetails);
                                daSessionDetails.Update(dsWorkshop, "sessionDetails");

                                recentID = recentID + 1;
                            }
                        }
                        
                        
                        this.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("You have added no students.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            cmbWshops.DataSource = dsWorkshop.Tables["workshops"];
            cmbWshops.DisplayMember = "workshopName";
            cmbWshops.ValueMember = "workshopID";
            cmbWshops.SelectedIndex = -1;
            cmbWshops.Enabled = true;

            cmbCampus.DataSource = dsWorkshop.Tables["campus"];
            cmbCampus.DisplayMember = "campusName";
            cmbCampus.ValueMember = "campusID";
            cmbCampus.SelectedIndex = -1;
            cmbCampus.Enabled = true;
            cmbCoach.Items.Clear();
            foreach(DataRow dr in dsWorkshop.Tables["coach"].Rows)
            {
                String name = "";

                name = (dr["coachForeName"].ToString() + ", " + dr["coachSurName"].ToString());
                cmbCoach.Items.Add(name);
            }

            cmbCoach.Enabled = true;
            btnStart.Enabled = false;
            btnEnrol.Enabled = true;
            btnCourseFind.Enabled = true;
        }

        private void btnEnrol_Click(object sender, EventArgs e)
        {
            bool ok = true;

            if (cmbWshops.SelectedIndex == -1 || cmbCampus.SelectedIndex == -1 || cmbCoach.SelectedIndex == -1 || txtCourse.Text.Length == 0)
            {
                ok = false;
                MessageBox.Show("You must choose a course, workshop,\nCo-ordinator and course.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (ok)
            {
                panel1.Enabled = true;
                btnEnrol.Enabled = false;
                cmbCoach.Enabled = false;
                cmbCampus.Enabled = false;
                cmbWshops.Enabled = false;
                btnStart.Enabled = false;
                btnCourseFind.Enabled = false;
            }
        }

        public frmWorkshop()
        {
            InitializeComponent();
        }

        private void frmWorkshop_Load(object sender, EventArgs e)
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
            panel2.Visible = false;



        }
        
        private void fillDgvCourses()
        {
            foreach(DataRow dr in dsWorkshop.Tables["course"].Rows)
            {
                dgvCourses.Rows.Add(dr["courseName"].ToString(), dr["courseSessName"].ToString());
            }
        }
    
        private int getStudentID()
        {
            int recentID = 0;
            if(dsWorkshop.Tables["attendees"].Rows.Count == 0)
            {
                recentID = 1000;
            }
            else
            {
                foreach (DataRow dr in dsWorkshop.Tables["attendees"].Rows)
                {
                    if (recentID < Convert.ToInt32(dr["studentID"].ToString()))
                    {
                        recentID = Convert.ToInt32(dr["studentID"].ToString());
                    }
                }
            }
            
            recentID = recentID + 1;
            return recentID;
        }
        
        private int getSessionID()
        {
            int recentID = 0;
            if (dsWorkshop.Tables["session"].Rows.Count == 0)
            {
                recentID = 1000;
            }
            else
            {
                foreach (DataRow dr in dsWorkshop.Tables["session"].Rows)
                {
                    if (recentID < Convert.ToInt32(dr["sessionID"].ToString()))
                    {
                        recentID = Convert.ToInt32(dr["sessionID"].ToString());
                    }
                }
            }

            recentID = recentID + 1;
            return recentID;
        }

        private int getCourseID(String name)
        {
            int id = 0;

            foreach(DataRow dr in dsWorkshop.Tables["course"].Rows)
            {
                if(dr["courseSessName"].ToString().Equals(name))
                {
                    id = Convert.ToInt32(dr["courseID"].ToString());
                }
            }

            return id;
        }
    
        private int getCoachID()
        {
            int id = 0;
            foreach(DataRow dr in dsWorkshop.Tables["coach"].Rows)
            {
                string name = (dr["coachForeName"].ToString() + ", " + dr["coachSurName"].ToString());
                if (name.Equals(cmbCoach.SelectedItem))
                {
                    id = Convert.ToInt32(dr["coachID"].ToString());
                }
            }
            return id;
        }

        private string getCourseIDRecent()
        {
            int id = 0;
            foreach(DataRow dr in dsWorkshop.Tables["course"].Rows)
            {
                if(Convert.ToInt32(dr["courseID"].ToString()) > id)
                {
                    id = Convert.ToInt32(dr["courseID"].ToString());
                }
            }


            String idFixed = "" + (id + 1);
            MessageBox.Show(idFixed);
            return idFixed;
        }


    }
}
