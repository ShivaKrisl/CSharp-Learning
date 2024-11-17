using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryForMethods
{
    public class StaticMethodsClassLib
    {
        private string StudentName;

        private static string CollegeName;

        private double TotalMarks;

        public StaticMethodsClassLib(string collegeName)
        {
            CollegeName = collegeName;
        }

        public void SetStudentName(string StudentName)
        {
            this.StudentName = StudentName;
        }

        public string GetStudentName()
        {
            return this.StudentName ?? null;
        }

        public static void SetCollegeName(string collegeName)
        {
            CollegeName = collegeName;
        }

        public string GetCollegeName()
        {
            return CollegeName;
        }


        public void SetTotalMarks(double marks)
        {
            this.TotalMarks = marks;
        }

        public double GetTotalMarks()
        {
            return this.TotalMarks;
        }

        /// <summary>
        /// Passing object reference as parameters
        /// </summary>
        /// <param name="ob1"></param>
        /// <param name="ob2"></param>
        /// <returns></returns>
        public static double GetFinalMarksOfAll(StaticMethodsClassLib ob1, StaticMethodsClassLib ob2)
        {
            double marks = 0;
            marks =  ob1.GetTotalMarks()+ob2.GetTotalMarks();
            return marks;
        }

        public double GetTotalCutOffMarks(double cutOffPercentage = 10)
        {
            double cutOffMarks = 0;

            cutOffMarks = (this.GetTotalMarks() * (cutOffPercentage / 100.0));

            return cutOffMarks;
        }

        public static void NamedArgsExample(int integerValue, string stringValue, bool booleanValue, DateTime dateTimeValue)
        {
            Console.WriteLine(integerValue);
            Console.WriteLine(stringValue);
            Console.WriteLine(booleanValue);
            Console.WriteLine(dateTimeValue);
        }
    }
}
