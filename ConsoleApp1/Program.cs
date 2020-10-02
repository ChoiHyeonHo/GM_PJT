using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {

        static void Main(string[] args)
        {
            ShowMenu();

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    break;
                case 2:
                    break;
                case 3:
                    break;
                case 4:
                    break;
                case 5:
                    return;
            }

        }

        private static void ShowMenu()
        {
            Console.WriteLine("===================성적 관리 프로그램==================");
            Console.WriteLine("==========\t 1. 학생 정보 입력 \t ==============");
            Console.WriteLine("==========\t 2. 학생 성적 입력 \t ==============");
            Console.WriteLine("==========\t 3. 학생 성적 계산 \t ==============");
            Console.WriteLine("==========\t 4. 학생 성적 출력 \t ==============");
            Console.WriteLine("==========\t 5. 종료 \t\t ==============");
            Console.WriteLine("======================================================");
        }
        public void InputStudentData()
        {
            const int Max_Cnt = 100;
            string[] StuDataArr = new string[Max_Cnt];
            Console.WriteLine("1. 1학년\t 2. 2학년\t 3. 3학년\t 4. 4학년\t 5. 기타");
            int year = int.Parse(Console.ReadLine());

            switch (year)
            {
                case 1:
                    Console.WriteLine();
                default:
                    break;
            }

        }
        public void InputGradeData()
        {

        }
        public void GradeCalc()
        {

        }
        public void PrintGrade()
        {

        }
    }
}
