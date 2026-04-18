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

        

        private void submitbtn_Click(object sender, EventArgs e)
        {

            StudentInfo std = new StudentInfo(
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
                listBox1.Items.Add(std.StudentID);
                listBox2.Items.Add(std.FirstName);
                listBox3.Items.Add(std.LastName);
            }

        }
    }
}
