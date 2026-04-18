using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentInfoApplication
{
    internal class StudentInfo
    {

        private String studentId;
        private String lastname;
        private String firstname;

        public StudentInfo(string studentId, string lastname, string firstname)
        {
            this.studentId = studentId;
            this.lastname = lastname;
            this.firstname = firstname;
        }

        public String StudentID
        {
            get { return this.studentId; }
            set { this.studentId = value; }
        }

        public String LastName
        {
            get { return this.lastname; }
            set { this.lastname = value; }
        }

        public String FirstName
        {
            get { return this.firstname; }
            set { this.firstname = value; }
        }
    }
}
