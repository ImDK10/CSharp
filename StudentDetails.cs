using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppFiles
{
    class Program
    {
        static string filepath = "E:\\QLTraining\\ConsoleAppFiles\\ConsoleAppFiles\\Myfile.txt";
        public int StudentId;
        public string StudentName;
        public double StudentScore;

        public void AcceptStudentDeatils()
        {
            Console.Write("Enter Student Id (number): ");
            StudentId = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Student Name: ");
            StudentName = Console.ReadLine();
            Console.Write("Enter Student Score: ");
            StudentScore = Convert.ToDouble(Console.ReadLine());
        }

        public void SaveToFile()
        {

            string s = $"{StudentId};{StudentName};{StudentScore}\n";
            File.AppendAllText(filepath, s);
        }
        public void Display()
        {
            Console.WriteLine("Student ID    :\t{0}", StudentId);
            Console.WriteLine("Student Name  :\t{0}", StudentName);
            Console.WriteLine("Student Score :\t{0}", StudentScore);

        }
        public static void FileWrite(string filepath, string s)
        {
            File.WriteAllText(filepath, s);
        }
        public static void FileRead(string filepath)
        {
            string s = File.ReadAllText(filepath);
            Console.WriteLine(s);
        }
        public static void SearchStudent(string SearchstudentId)
        {
            string[] studentsList = File.ReadAllLines(filepath);
            SearchstudentId += ";";
            bool searchflag = false;
            foreach (string studRow in studentsList)
            {
                if (studRow.StartsWith(SearchstudentId))
                {
                    searchflag = true;
                    string[] studCols = studRow.Split(';');
                    Console.WriteLine("Student Id: " + studCols[0]);
                    Console.WriteLine("Student Name: " + studCols[1]);
                    Console.WriteLine("Student Score: " + studCols[2]);
                    Console.WriteLine("******************************");
                }
            }
            if (searchflag == false)
            {
                Console.WriteLine($"Student with ID {SearchstudentId} does not exist");
            }

        }
        public static void ListAllStudents()
        {
            if (!File.Exists(filepath))
            {
                Console.WriteLine("Student file not found()");
                return;
            }
            string[] studentsList = File.ReadAllLines(filepath);
            if (studentsList.Length == 0)
            {
                Console.WriteLine("0 Records Found");
            }
            else
            {
                Console.WriteLine("\nStudent Id\tName\t\tScore");
                Console.WriteLine("*****************************************");
            }
            foreach (string studRow in studentsList)
            {
                string[] studCols = studRow.Split(';');
                Console.WriteLine($"{studCols[0]}\t\t{studCols[1]}\t\t{studCols[2]}");
            }
        }

        public  void DisplayStudentMenu()
        {
            Console.WriteLine("\n\n1.Student Details Entry");
            Console.WriteLine("2. Student Search by Id");
            Console.WriteLine("3. List All Students");
            Console.WriteLine("4. Exit");
            Console.WriteLine("\nEnter Choice: ");
 
        }
        static void Main(string[] args)
        {
            Program stdObj = new Program();
            stdObj.DisplayStudentMenu();
            int x;
            do
            {
                x = Convert.ToInt32(Console.ReadLine());

                switch (x)
                {
                    case 1:
                        {
                            stdObj.AcceptStudentDeatils();
                            stdObj.SaveToFile();
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("Enter Student Id to be Searched: ");
                            string studId = Console.ReadLine();
                            SearchStudent(studId);
                            break;
                        }
                    case 3:
                        {
                            ListAllStudents();
                            break;
                        }
                    case 4:
                        {

                            Console.WriteLine("Invalid option...");
                            break;
                        }

                }
            }while(x != 4);
        }
            
     
        

    }

}

