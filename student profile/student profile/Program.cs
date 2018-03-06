using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace student_profile
{
    class Program
    {
        static void Main(string[] args)
        {
            int user_option;
            string line = null;
            Student student_Object = new Student();
            while (true)
            {

                Console.WriteLine("1: Create Student profile\n2: Search Student\n3: Delete Student Record\n4: List top 03 of class\n5: Mark student attendance\n6: View attendance");
                user_option = Convert.ToInt16(Console.ReadLine());
                switch (user_option)
                {
                    case 1:
                        string student_ID, student_Name, student_Semester, student_CGPA, student_Department, student_University;
                        Console.WriteLine("Enter Student ID : ");
                        student_ID = Console.ReadLine();
                        FileStream file_Read;
                        string linee;
                        int check = 0;
                        file_Read = new FileStream("E:\\Student.txt", FileMode.Open, FileAccess.Read);
                        StreamReader read = new StreamReader(file_Read);
                        while ((line = read.ReadLine()) != null)
                        {
                            if (line == "ID : "+student_ID)
                            {
                                check++;
                                break;
                            }
                        }
                        file_Read.Close();
                        if (check > 0)
                        {
                            Console.WriteLine("This ID Already In Use");
                        }
                        else
                        {
                            Console.WriteLine("Enter Student Name : ");
                            student_Name = Console.ReadLine();
                            Console.WriteLine("Enter Student Semester : ");
                            student_Semester = Console.ReadLine();
                            Console.WriteLine("Enter Student CGPA : ");
                            student_CGPA = Console.ReadLine();
                            Console.WriteLine("Enter Student Department : ");
                            student_Department = Console.ReadLine();
                            Console.WriteLine("Enter Student University : ");
                            student_University = Console.ReadLine();
                            student_Object.New_Student(student_ID, student_Name, student_Semester, student_CGPA, student_Department, student_University);
                            Console.WriteLine("Srudent Added");
                        }
                        break;

                    case 2:
                        int option;
                        Console.WriteLine("1: Search by ID\n2: Search by Name\n3: Search by Semester");
                        option = Convert.ToInt16(Console.ReadLine());
                        if (option == 1)
                        {
                            Console.WriteLine("Enter Student ID : ");
                            student_ID = Console.ReadLine();
                            student_Object.search_By_Id(student_ID);
                        }
                        else if (option == 2)
                        {
                            Console.WriteLine("Enter Student Name : ");
                            student_Name = Console.ReadLine();
                            student_Object.search_By_Name(student_Name);
                        }
                        else if (option == 3)
                        {
                            Console.WriteLine("Enter Student Semester : ");
                            student_Semester = Console.ReadLine();
                            student_Object.search_By_Semester(student_Semester);
                        }

                        break;

                    case 3:
                        string id;
                        Console.WriteLine("Enter Student ID ");
                        id=Console.ReadLine();
                        student_Object.delete_Student(id);
                        break;

                    case 4:
                        string semester;
                        Console.WriteLine("Enter Semester ");
                        semester = Console.ReadLine();
                        student_Object.top_Student_By_Semester(semester);
                        break;

                    case 5:
                        string name,attendance,semesterr;
                        Console.WriteLine("Enter Semester");
                        semesterr = Console.ReadLine();
                        Console.WriteLine("Enter Student Name ");
                        name = Console.ReadLine();
                        Console.WriteLine("presence? (yes or no)");
                        attendance = Console.ReadLine();
                        student_Object.mark_attendance(name,attendance,semesterr);
                        break;
                    case 6:
                        string semster;
                        Console.WriteLine("Enter semester");
                        semster = Console.ReadLine();
                        student_Object.view_Attendance(semster);
                        break;
                }
            }

            
            Console.ReadKey();


        }
    }
}
