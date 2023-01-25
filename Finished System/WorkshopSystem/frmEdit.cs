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
    public partial class frmEdit : Form
    {
        SqlDataAdapter daCourse, daWorkshop, daCoach, daCampus, daStudents, daSessionDetails, daSession;
        DataSet dsWorkshop = new DataSet();
        SqlCommandBuilder cmbDCourse, cmbDWorkshop, cmbDCoach, cmbDCampus, cmbDStudents, cmbDSessionDetails, cmbDSession;

        private void btnCoach_Click(object sender, EventArgs e)
        {
            txtNewWorkshop.Text = "";
            loadWorkshops();
            panelWorkshops.Visible = true;
            panelCoor.Visible = true;           
            panelCampus.Visible = false;
            panelSession.Visible = false;
            loadCoor();
        }

        private void btnNewCoor_Click(object sender, EventArgs e)
        {
            if(txtNewCoorFor.Text.Trim().Length > 2 && txtNewCoorSur.Text.Trim().Length > 2)
            {
                drCoach = dsWorkshop.Tables["coach"].NewRow();
                drCoach["coachID"] = getCoorID();
                drCoach["coachForeName"] = txtNewCoorFor.Text.Trim().ToString();
                drCoach["coachSurname"] = txtNewCoorSur.Text.Trim().ToString();
                dsWorkshop.Tables["coach"].Rows.Add(drCoach);
                daCoach.Update(dsWorkshop, "coach");
                loadCoor();
                txtNewCoorFor.Text = "";
                txtNewCoorSur.Text = "";
                MessageBox.Show("Co-ordinator added.");
            }
            else
            {
                MessageBox.Show("Valid Forname and Surname must be entered\nto add a new co-ordinator","Invalid Name.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtNewCoorFor_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSaveWorkshopEdits_Click(object sender, EventArgs e)
        {
            bool ok = true;
            foreach(DataGridViewRow dr in dgvWorkshop.Rows)
            {
                if (dr.Cells[1].Value == null)
                {
                    ok = false;
                }
            }
            if(!ok)
            {
                MessageBox.Show("Edits can not be saved as not all fields have\nvalid names entered.", "Error, Invalid Names.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to confirm\nthe edited cells?","Confirm edit.", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    foreach (DataGridViewRow dr in dgvWorkshop.Rows)
                    {
                        drWorkshop = dsWorkshop.Tables["workshops"].Rows.Find(dr.Cells[0].Value.ToString());
                        drWorkshop.BeginEdit();
                        drWorkshop["workshopID"] = dr.Cells[0].Value.ToString();
                        drWorkshop["workshopName"] = dr.Cells[1].Value.ToString();
                        drWorkshop.EndEdit();
                        daWorkshop.Update(dsWorkshop, "workshops");
                    }
                    loadWorkshops();
                    MessageBox.Show("Edits saved.");                   
                }
            }
        }

        private void btnDeleteCoor_Click(object sender, EventArgs e)
        {
            if (dgvCoor.Rows.Count > 0)
            {
                if (Convert.ToInt32(dgvCoor.CurrentRow.Cells[3].Value.ToString()) != 0)
                {
                    MessageBox.Show("This co-ordinator can not be delted as\nthey have completed sessions.", "Error, Sessions recorded.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this\nCo-ordinator called: " + (dgvCoor.CurrentRow.Cells[1].Value.ToString() + ", " + dgvCoor.CurrentRow.Cells[2].Value.ToString()) + "?", "Confirm delete.", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        drCoach = dsWorkshop.Tables["coach"].Rows.Find(dgvCoor.CurrentRow.Cells[0].Value.ToString());
                        drCoach.Delete();
                        daCoach.Update(dsWorkshop, "coach");
                        loadCoor();
                    }
                }
            }
            else
            {
                MessageBox.Show("There is no co-ordinator seleceted.", "Error, No Co-ordinator.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSaveCoor_Click(object sender, EventArgs e)
        {
            bool ok = true;
            foreach (DataGridViewRow dr in dgvCoor.Rows)
            {
                if (dr.Cells[1].Value == null || dr.Cells[2].Value == null)
                {
                    ok = false;
                }
            }
            if (!ok)
            {
                MessageBox.Show("Edits can not be saved as not all fields have\nvalid names entered.", "Error, Invalid Names.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to confirm\nthe edited cells?", "Confirm edit.", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    foreach (DataGridViewRow dr in dgvCoor.Rows)
                    {
                        drCoach = dsWorkshop.Tables["coach"].Rows.Find(dr.Cells[0].Value.ToString());
                        drCoach.BeginEdit();
                        drCoach["coachID"] = dr.Cells[0].Value.ToString();
                        drCoach["coachForeName"] = dr.Cells[1].Value.ToString();
                        drCoach["coachSurName"] = dr.Cells[2].Value.ToString();
                        drCoach.EndEdit();
                        daCoach.Update(dsWorkshop, "coach");
                    }
                    loadCoor();
                    MessageBox.Show("Edits saved.");
                }
            }
        }

        private void btnCampus_Click(object sender, EventArgs e)
        {
            panelCampus.Visible = true;
            panelCoor.Visible = true;
            panelWorkshops.Visible = true;
            panelSession.Visible = false;
            loadCampus();
            txtNewCampus.Text = "";
        }

        private void btnDeleteWorkshop_Click(object sender, EventArgs e)
        {
            if(dgvWorkshop.Rows.Count > 0)
            {
                if(Convert.ToInt32(dgvWorkshop.CurrentRow.Cells[2].Value.ToString()) != 0)
                {
                    MessageBox.Show("This workshop can not be delted as\nthere are sessions recorded with it.", "Error, Sessions recorded.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this\nworkshop called: " + dgvWorkshop.CurrentRow.Cells[1].Value.ToString() + "?", "Confirm delete.", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        drWorkshop = dsWorkshop.Tables["workshops"].Rows.Find(dgvWorkshop.CurrentRow.Cells[0].Value.ToString());
                        drWorkshop.Delete();
                        daWorkshop.Update(dsWorkshop,"workshops");
                        loadWorkshops();
                    }
                }
            }
            else
            {
                MessageBox.Show("There is no workshop seleceted.", "Error, No workshop.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAddCampus_Click(object sender, EventArgs e)
        {
            if(txtNewCampus.Text.Trim().Length > 2)
            {
                drCampus = dsWorkshop.Tables["campus"].NewRow();
                drCampus["campusID"] = getCampusID();
                drCampus["campusName"] = txtNewCampus.Text.Trim().ToString();               
                dsWorkshop.Tables["campus"].Rows.Add(drCampus);
                daCampus.Update(dsWorkshop, "campus");
                loadCampus();
                txtNewCampus.Text = "";
                MessageBox.Show("Campus added.");
            }
            else
            {
                MessageBox.Show("Valid campus name must be entered\nto add a new campus.", "Invalid Name.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClearFilters_Click(object sender, EventArgs e)
        {

        }

        private void btnDeleteCampus_Click(object sender, EventArgs e)
        {
            if (dgvCampus.Rows.Count > 0)
            {
                if (Convert.ToInt32(dgvCampus.CurrentRow.Cells[2].Value.ToString()) != 0)
                {
                    MessageBox.Show("This campus can not be delted as\nthere are sessions that have been held in it.", "Error, Sessions recorded.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this\ncampus called: " + dgvCampus.CurrentRow.Cells[1].Value.ToString() + "?", "Confirm delete.", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        drCampus = dsWorkshop.Tables["campus"].Rows.Find(dgvCampus.CurrentRow.Cells[0].Value.ToString());
                        drCampus.Delete();
                        daCampus.Update(dsWorkshop, "campus");
                        loadCampus();
                    }
                }
            }
            else
            {
                MessageBox.Show("There is no campus seleceted.", "Error, No campus.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEditCampus_Click(object sender, EventArgs e)
        {
            bool ok = true;
            foreach (DataGridViewRow dr in dgvCampus.Rows)
            {
                if (dr.Cells[1].Value == null)
                {
                    ok = false;
                }
            }
            if (!ok)
            {
                MessageBox.Show("Edits can not be saved as not all fields have\nvalid names entered.", "Error, Invalid Names.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to confirm\nthe edited cells?", "Confirm edit.", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    foreach (DataGridViewRow dr in dgvCampus.Rows)
                    {
                        drCampus = dsWorkshop.Tables["campus"].Rows.Find(dr.Cells[0].Value.ToString());
                        drCampus.BeginEdit();
                        drCampus["campusID"] = dr.Cells[0].Value.ToString();
                        drCampus["campusName"] = dr.Cells[1].Value.ToString();
                        drCampus.EndEdit();
                        daCampus.Update(dsWorkshop, "campus");
                    }
                    loadCampus();
                    MessageBox.Show("Edits saved.");
                }
            }
        }

        private void btnSession_Click(object sender, EventArgs e)
        {
            panelCampus.Visible = true;
            panelCoor.Visible = true;
            panelWorkshops.Visible = true;
            panelSession.Visible = true;
            panelDisplay.Enabled = false;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if(txtNewWorkshop.Text.Trim().Length > 0)
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to create a new\nworkshop called: " + txtNewWorkshop.Text.Trim().ToString() + "?", "Confirm addition.", MessageBoxButtons.YesNo);
                if(dialogResult == DialogResult.Yes)
                {                    
                    drWorkshop = dsWorkshop.Tables["workshops"].NewRow();
                    drWorkshop["workshopID"] = getWorkshopID();
                    drWorkshop["workshopName"] = txtNewWorkshop.Text.Trim().ToString();                   
                    dsWorkshop.Tables["workshops"].Rows.Add(drWorkshop);
                    daWorkshop.Update(dsWorkshop, "workshops");
                    loadWorkshops();
                    txtNewWorkshop.Text = "";
                    MessageBox.Show("Workshop Added.");
                }
            }
            else
            {
                MessageBox.Show("You must type a name for the workshop\nin the textbox above to be able to add it.", "Error, No Name", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            bool ok = true;
            try
            {
                drSession = dsWorkshop.Tables["session"].Rows.Find(txtSearch.Text.Trim().ToString());
            }
            catch(System.FormatException)
            {
                MessageBox.Show("You must enter a value into the textbox to search.", "Invalid ID.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ok = false;
            }
            if (ok)
            {
                if (drSession == null)
                {
                    MessageBox.Show("Session not found.", "Invalid ID.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    panelDisplay.Enabled = true;

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
                    foreach (DataRow dr in dsWorkshop.Tables["coach"].Rows)
                    {
                        String name = "";

                        name = (dr["coachForeName"].ToString() + ", " + dr["coachSurName"].ToString());
                        cmbCoach.Items.Add(name);
                    }
                    cmbCoach.Enabled = true;

                    lblID.Text = drSession["sessionID"].ToString();
                    dtpSessionDate.Value = Convert.ToDateTime(drSession["courseDate"].ToString());
                    

                    int i1 = cmbMins.FindString(drSession["courseTime"].ToString().Substring(3, 2));
                    cmbMins.SelectedIndex = i1;
                    int i2 = cmbHours.FindString(drSession["courseTime"].ToString().Substring(0, 2));
                    cmbHours.SelectedIndex = i2;


                    cmbWshops.SelectedValue = drSession["workshopID"].ToString();
                    cmbCampus.SelectedValue = drSession["campusID"].ToString();

                    drCoach = dsWorkshop.Tables["coach"].Rows.Find(drSession["coachID"].ToString());
                    int index = cmbCoach.FindString(drCoach["coachForeName"].ToString() + ", " + drCoach["coachSurName"].ToString());
                    cmbCoach.SelectedIndex = index;
                    cmbHours.Enabled = true;
                    cmbMins.Enabled = true;
                }
            }
        }

        private void panelDisplay_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnEditStudents_Click(object sender, EventArgs e)
        {
            frmStudents frmS = new frmStudents(lblID.Text);
            frmS.ShowDialog();
        }

        private void btnDeleteSession_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete\nthis session?", "Confirm delete.", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                ArrayList ids = new ArrayList();
                foreach(DataRow dr in dsWorkshop.Tables["sessionDetails"].Rows)
                {
                    if(dr["sessionID"].ToString() == lblID.Text)
                    {                        
                        sessionDetails sD = new sessionDetails(dr["sessionID"].ToString(), dr["studentID"].ToString());
                        ids.Add(sD);
                    }
                }

                for(int i = 0; i < ids.Count;i++)
                {

                    object[] keys = new object[2];
                    keys[0] = ((sessionDetails)ids[i]).getSessionID();
                    keys[1] = ((sessionDetails)ids[i]).getStudentID();

                    drSessionDetails = dsWorkshop.Tables["sessionDetails"].Rows.Find(keys);
                    drSessionDetails.Delete();
                    daSessionDetails.Update(dsWorkshop, "sessionDetails");
                }

                drSession = dsWorkshop.Tables["session"].Rows.Find(lblID.Text);
                drSession.Delete();
                daSession.Update(dsWorkshop, "session");

                MessageBox.Show("Session Deleted.");
                clearSession();
            }
        }

        DataRow drCourse, drWorkshop, drCoach, drCampus, drStudents, drSessionDetails, drSession;

        private void button1_Click(object sender, EventArgs e)
        {
            frmCourse frmC = new frmCourse(lblID.Text);
            frmC.ShowDialog();
        }

        private void btnSaveSession_Click(object sender, EventArgs e)
        {
            bool ok = true;

            if(cmbHours.SelectedIndex == -1)
            {
                ok = false;
                errP.SetError(cmbMins,"You must choose an hour from the drop down box.");
            }

            if (cmbMins.SelectedIndex == -1)
            {
                ok = false;
                errP.SetError(cmbMins, "You must choose a minute from the drop down box.");
            }

            if (cmbWshops.SelectedIndex == -1)
            {
                ok = false;
                errP.SetError(cmbWshops, "You must choose a workshop from the drop down box.");
            }

            if (cmbCoach.SelectedIndex == -1)
            {
                ok = false;
                errP.SetError(cmbCoach, "You must choose a co-ordinator from the drop down box.");
            }

            if (cmbCampus.SelectedIndex == -1)
            {
                ok = false;
                errP.SetError(cmbCampus, "You must choose a campus from the drop down box.");
            }

            if(ok)
            {
                drSession = dsWorkshop.Tables["session"].Rows.Find(lblID.Text);
                drSession.BeginEdit();
                drSession["workshopID"] = cmbWshops.SelectedValue.ToString();
                drSession["campusID"] = cmbCampus.SelectedValue.ToString();
                drSession["coachID"] = findCoachID();
                drSession["courseDate"] = dtpSessionDate.Value;
                string timeFromCmb = (cmbHours.SelectedItem.ToString() + ":" + cmbMins.SelectedItem.ToString());
                TimeSpan time = TimeSpan.Parse(timeFromCmb);
                drSession["courseTime"] = time;
                drSession.EndEdit();
                daSession.Update(dsWorkshop, "session");
                String id = lblID.Text;
                clearSession();
                MessageBox.Show("Session: " + id + ", updated successfully.");
            }





        }

        String connStr, sqlCourse, sqlWorkshop, sqlCoach, sqlCampus, sqlStudents, sqlSessionDetails, sqlSession;

        public frmEdit()
        {
            InitializeComponent();
        }

        public frmEdit(String id)
        {
            InitializeComponent();
        }

        private void frmEdit_Load(object sender, EventArgs e)
        {
            connStr = @"Data Source=DESKTOP-D93M828\SQLEXPRESS;Initial Catalog=workshopIntegrated Security=True";
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

            panelWorkshops.Visible = false;
        }

        private void btnWorkshops_Click(object sender, EventArgs e)
        {            
            panelWorkshops.Visible = true;
            panelCoor.Visible = false;
            panelCampus.Visible = false;
            panelSession.Visible = false;
            loadWorkshops();
        }

        private void loadWorkshops()
        {
            int i = 0;
            dgvWorkshop.Rows.Clear();
            foreach(DataRow dr in dsWorkshop.Tables["workshops"].Rows)
            {
                foreach(DataRow dr2 in dsWorkshop.Tables["session"].Rows)
                {
                    if(dr2["workshopID"].ToString() == dr["workshopID"].ToString())
                    {
                        i++;
                    }
                }
                dgvWorkshop.Rows.Add(dr["workshopID"].ToString(), dr["workshopName"].ToString(), i);
                i = 0;
            }
            dgvWorkshop.Columns[0].ReadOnly = true;
            dgvWorkshop.Columns[2].ReadOnly = true;

        }

        private string getWorkshopID()
        {
            int id = 1000;

            if(dsWorkshop.Tables["workshops"].Rows.Count > 0)
            {
                foreach(DataRow dr in dsWorkshop.Tables["workshops"].Rows)
                {
                    if(Convert.ToInt32(dr["workshopID"].ToString()) > id)
                    {
                        id = Convert.ToInt32(dr["workshopID"].ToString());
                    }
                }
            }

            String returnID = "" + (id+1);

            return returnID;
        }
    
        private void loadCoor()
        {
            dgvCoor.Columns[0].ReadOnly = true;
            dgvCoor.Columns[3].ReadOnly = true;
            dgvCoor.Rows.Clear();
            foreach(DataRow dr in dsWorkshop.Tables["coach"].Rows)
            {
                int i = 0;
                foreach(DataRow dr2 in dsWorkshop.Tables["session"].Rows)
                {
                    if(dr2["coachID"].ToString() == dr["coachID"].ToString())
                    {
                        i++;
                    }
                }
                dgvCoor.Rows.Add(dr["coachID"].ToString(), dr["coachForeName"].ToString(), dr["coachSurName"].ToString(), i);
            }
        }

        private string getCoorID()
        {
            int id = 1000;

            if (dsWorkshop.Tables["coach"].Rows.Count > 0)
            {
                foreach (DataRow dr in dsWorkshop.Tables["coach"].Rows)
                {
                    if (Convert.ToInt32(dr["coachID"].ToString()) > id)
                    {
                        id = Convert.ToInt32(dr["coachID"].ToString());
                    }
                }
            }

            String returnID = "" + (id + 1);

            return returnID;
        }
    
        private void loadCampus()
        {
            dgvCampus.Columns[0].ReadOnly = true;
            dgvCampus.Columns[2].ReadOnly = true;
            dgvCampus.Rows.Clear();
            foreach(DataRow dr in dsWorkshop.Tables["campus"].Rows)
            {
                int i = 0;
                foreach(DataRow dr2 in dsWorkshop.Tables["session"].Rows)
                {
                    if(dr2["campusID"].ToString() == dr["campusID"].ToString())
                    {
                        i++;
                    }
                }

                dgvCampus.Rows.Add(dr["campusID"].ToString(), dr["campusName"].ToString(), i);
            }
        }
    
        private string getCampusID()
        {
            int id = 1000;

            if (dsWorkshop.Tables["campus"].Rows.Count > 0)
            {
                foreach (DataRow dr in dsWorkshop.Tables["campus"].Rows)
                {
                    if (Convert.ToInt32(dr["campusID"].ToString()) > id)
                    {
                        id = Convert.ToInt32(dr["campusID"].ToString());
                    }
                }
            }

            String returnID = "" + (id + 1);

            return returnID;
        }
    
        private void clearSession()
        {
            lblID.Text = "";
            cmbCampus.SelectedIndex = -1;
            cmbCoach.SelectedIndex = -1;
            cmbWshops.SelectedIndex = -1;
           
            dtpSessionDate.Value = DateTime.Now;
            cmbMins.SelectedIndex = -1;
            cmbHours.SelectedIndex = -1;
            panelDisplay.Enabled = false;
            txtSearch.Text = "";
        }

        private String findCoachID()
        {
            String s = cmbCoach.SelectedItem.ToString();
            String forN = "", surN = "";

            int split = s.IndexOf(",");
            int remaining = (s.Length - split);
            forN = s.Substring(0, split);
            surN = s.Substring(split+2, remaining-2);
            
            foreach(DataRow dr in dsWorkshop.Tables["coach"].Rows)
            {
                if(dr["coachForeName"].ToString() == forN && dr["coachSurName"].ToString() == surN)
                {
                    s = dr["coachID"].ToString();
                }
            }

            return s;
        }
    }
}
