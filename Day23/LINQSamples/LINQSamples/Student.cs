using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQSamples
{
    public class Student
    {
        private int _studentID;
        public int StudentID { get { return _studentID; } set {  _studentID = value; } }

        private string _studentName;
        public string StudentName { get { return _studentName; } set { _studentName = value; } }

        private int _age;
        public int Age { get { return _age; } set { _age = value; } }
        private int _standardID;
        public int StandardID { get { return _standardID; } set { _standardID = value; } }

        public Student(int studentID, string studentName, int age, int standardID)
        {
            StudentID = studentID;          
            StudentName = studentName;            
            Age = age;
            StandardID = standardID;
        }

        public Student()
        {

        }
    }
}
