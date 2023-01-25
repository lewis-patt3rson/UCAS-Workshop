using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WorkshopSystem
{
    public partial class HomeForm : Form
    {
        public HomeForm()
        {
            InitializeComponent();
        }

        private void HomeForm_Load(object sender, EventArgs e)
        {
            lblDate.Text = (DateTime.Now.Day + " / " + DateTime.Now.Month + " / " + DateTime.Now.Year);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            foreach (Form form in panel1.Controls.OfType<Form>())
                form.Close();

            frmWorkshop frmW = new frmWorkshop();
            frmW.TopLevel = false;
            //frmW.BorderStyle = FormBorderStyle.SizableToolWindow;
            frmW.ControlBox = false;
            frmW.Text = String.Empty;
            panel1.Controls.Add(frmW);
            frmW.Show();
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            foreach (Form form in panel1.Controls.OfType<Form>())
                form.Close();

            reportForm frmR = new reportForm();
            frmR.TopLevel = false;
            //frmW.BorderStyle = FormBorderStyle.SizableToolWindow;
            frmR.ControlBox = false;
            frmR.Text = String.Empty;
            panel1.Controls.Add(frmR);
            frmR.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            foreach (Form form in panel1.Controls.OfType<Form>())
                form.Close();

            frmEdit frmE = new frmEdit();
            frmE.TopLevel = false;
            //frmW.BorderStyle = FormBorderStyle.SizableToolWindow;
            frmE.ControlBox = false;
            frmE.Text = String.Empty;
            panel1.Controls.Add(frmE);
            frmE.Show();
        }
    }
}
