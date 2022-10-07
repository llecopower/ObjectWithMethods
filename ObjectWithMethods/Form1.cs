using ObjectWithMethods.Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ObjectWithMethods
{
    public partial class Form1 : Form
    {
        Course oCourse = new Course();

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonSet_Click(object sender, EventArgs e)
        {

            oCourse.SetStudentId(123456);
            oCourse.SetFirstName("Kavya");
            oCourse.SetLastName("Benitez");
            oCourse.SetMidtermGrade(100.0f);
            oCourse.SetFinalGrade(20.0f);           
        }
           

        private void buttonGet_Click(object sender, EventArgs e)
        {
            string display = oCourse.GetGradeInfo(oCourse);

            MessageBox.Show(display, "Student record");

            labelInfo.Text = oCourse.GetGradeInfo(oCourse);
            
        }
    }
}
