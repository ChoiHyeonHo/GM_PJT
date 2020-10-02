using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class StudentInfo
    {
        string name;
        string grade;

        public string Name { get; set; }
        public string Grade { get; set; }

        public StudentInfo(string name, string grade)
        {
            this.name = name;
            this.grade = grade;
        }
    }
}
