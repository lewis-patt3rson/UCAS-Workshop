using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkshopSystem
{
    class sessionDetails
    {
        string sessID, stuID;

        public sessionDetails()
        {
            sessID = "";
            stuID = "";
        }

        public sessionDetails(String se, String st)
        {
            this.sessID = se;
            this.stuID = st;
        }

        public void setSessionID(String s)
        {
            this.sessID = s;
        }
        public String getSessionID()
        {
            return this.sessID;
        }

        public void setStudentID(String s)
        {
            this.stuID = s;
        }
        public String getStudentID()
        {
            return this.stuID;
        }

    }
}
