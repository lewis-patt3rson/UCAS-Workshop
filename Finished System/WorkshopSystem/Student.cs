using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkshopSystem
{
    class Student
    {
        String name, email;

        public Student()
        {
            name = "";
            email = "";
        }

        public Student(String n, String e)
        {
            this.name = n;
            this.email = e;
        }

        public String getName()
        {
            return this.name;
        }
        public void setName(String n)
        {
            this.name = n;
        }

        public String getEmail()
        {
            return this.email;
        }
        public void setEmail(String e)
        {
            this.email = e;
        }


    }
}
