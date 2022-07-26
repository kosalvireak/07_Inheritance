using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson07InheritanceExample
{
    class School //base class
    {
        public string strSchoolName;
        private string strAddress;
        public string Address
        {
            get { return strAddress; }
            set { strAddress = value; }
        }
        public School(string strSchoolName, string strAddress)
        {
            this.strSchoolName = strSchoolName;
            this.strAddress = strAddress;
        }
    }
    class Student : School   // Student is derive class
    {
        public string strStudentName;
        private float fltSchoolFees;
        public float SchoolFees
        {
            get { return fltSchoolFees; }
            set { fltSchoolFees = value; }
        }
        public Student(string strStudentName,
                       float fltSchoolFees,
                        string strSchoolName,
                        string strAddress) :base (strSchoolName, strAddress)
        {
            this.strStudentName = strStudentName;
            this.fltSchoolFees = fltSchoolFees;
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Student objS1;
            Console.WriteLine("Enter School Name: ");
            string school = Console.ReadLine();
            Console.WriteLine("Enter the Address: ");
            string address = Console.ReadLine();
            Console.WriteLine("Enter the Student Name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter the School Fees: ");
            float fee = float.Parse(Console.ReadLine());
            objS1 = new Student(name, fee, school, address);
            Console.WriteLine("School name: {0} ",objS1.strSchoolName);
            Console.WriteLine("Student address: {0} ", objS1.Address);
            Console.WriteLine("School name: {0} ", objS1.strStudentName);
            Console.WriteLine("Student fee: {0} ", objS1.SchoolFees);
            Console.ReadKey();

        }
    }
}
