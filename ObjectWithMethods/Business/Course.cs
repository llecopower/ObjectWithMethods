using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace ObjectWithMethods.Business
{
    public class Course
    {

        //custom Methods
        private int studentId;

        public void SetStudentId(int sId)
        {
            studentId = sId;
        }

        public int GetStudentId()
        {
            return studentId;
        }

        private string firstName;
        public void SetFirstName(string fname)
        {
                firstName = fname;
        }

        public string GetFirstName()
        {         
        return firstName;
        }


        private string lastName;
        public void SetLastName(string lname)
        {
            lastName = lname;
        }

        public string GetLastName()
        {
            return lastName;
        }

        private float midtermGrade;

        public void SetMidtermGrade(float mTermGrade)
        { 
        
            midtermGrade = mTermGrade;
        
        }

        public float GetMidtermGrade()
            {
            return midtermGrade;
        
            }

        private float finaltermGrade;

        public void SetFinalGrade(float fGrade)
        {

            finaltermGrade = fGrade;

        }

        public float GetFinalGrade()
        {
            return finaltermGrade;

        }

        public string GetGradeInfo(Course oGradeRecord)
        {
            string infoGrade = oGradeRecord.GetStudentId().ToString() + "\n" +
                               oGradeRecord.GetFirstName() + "\n" +
                               oGradeRecord.GetLastName() + "\n" +
                               oGradeRecord.GetMidtermGrade() + "\n" +
                               oGradeRecord.GetFinalGrade() + "\n" +
                               oGradeRecord.GetFinalResult(oGradeRecord);
            return infoGrade;
        }

        private int GetFinalResult(Course oGradeRecord)
        {
            const float midterm = 0.4f;
            const float finalexam = 0.6f;
            int finalResult = 0;

            finalResult = Convert.ToInt32((oGradeRecord.GetMidtermGrade() * midterm) +
                                         (oGradeRecord.GetFinalGrade() * finalexam));

            return finalResult;            
        
        }















    }
}
