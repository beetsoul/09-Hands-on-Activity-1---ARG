using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace StudentInfoApplication
{
    public partial class frmStudentInfo : Form
    {
        private String studentId;
        private String lastname;
        private String firstname;

        public frmStudentInfo()
        {
            InitializeComponent();
        }

        public frmStudentInfo(string studentId, string lastname, string firstname)
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

        private void submitbtn_Click(object sender, EventArgs e)
        {

            frmStudentInfo std = new frmStudentInfo(
                textboxstdID.Text, textboxLN.Text, textboxFN.Text
                );

            if (string.IsNullOrWhiteSpace(textboxstdID.Text) 
                || string.IsNullOrWhiteSpace(textboxFN.Text) 
                || string.IsNullOrWhiteSpace(textboxLN.Text))
            {
                MessageBox.Show("Please enter all student information.",
                    "Missing Input",
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Warning);
                return;
            } else
            {
                listBox1.Items.Add(std.studentId);
                listBox2.Items.Add(std.firstname);
                listBox3.Items.Add(std.lastname);
            }

        }
    }
}
