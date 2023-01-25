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
    public partial class frmCourse : Form
    {
        String sessionID = "";
        public frmCourse(String id)
        {
            sessionID = id;
            InitializeComponent();
        }

        private void frmCourse_Load(object sender, EventArgs e)
        {

        }
    }
}
