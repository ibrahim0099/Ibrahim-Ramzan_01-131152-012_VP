using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace student_profile
{
    class Student
    {

        
        FileStream file_Read;
        FileStream file_Write;
        public Student()
        {
            
           
        }
       
        public void New_Student(string id,string name,string semester,string cgpa,string department,string university)
        {
            file_Write = new FileStream("E:\\Student.txt", FileMode.Append, FileAccess.Write);
            byte[] newline = Encoding.ASCII.GetBytes(Environment.NewLine);
            file_Write.Write(newline, 0, newline.Length);
            newline = null;
            byte[] buffer= Encoding.ASCII.GetBytes("ID : "+id);
            file_Write.Write(buffer, 0, buffer.Length);
            newline = Encoding.ASCII.GetBytes(Environment.NewLine);
            file_Write.Write(newline, 0, newline.Length);
            buffer = null;
            newline = null;
            buffer = Encoding.ASCII.GetBytes("Name : "+name);
            file_Write.Write(buffer, 0, buffer.Length);
            newline = Encoding.ASCII.GetBytes(Environment.NewLine);
            file_Write.Write(newline, 0, newline.Length);
            buffer = null;
            newline = null;
            buffer = Encoding.ASCII.GetBytes("Semester : "+semester);
            file_Write.Write(buffer, 0, buffer.Length);
            newline = Encoding.ASCII.GetBytes(Environment.NewLine);
            file_Write.Write(newline, 0, newline.Length);
            buffer = null;
            newline = null;
            buffer = Encoding.ASCII.GetBytes("CGPA : "+cgpa);
            file_Write.Write(buffer, 0, buffer.Length);
            newline = Encoding.ASCII.GetBytes(Environment.NewLine);
            file_Write.Write(newline, 0, newline.Length);
            buffer = null;
            newline = null;
            buffer = Encoding.ASCII.GetBytes("Department : "+department);
            file_Write.Write(buffer, 0, buffer.Length);
            newline = Encoding.ASCII.GetBytes(Environment.NewLine);
            file_Write.Write(newline, 0, newline.Length);
            buffer = null;
            newline = null;
            buffer = Encoding.ASCII.GetBytes("University : "+university);
            file_Write.Write(buffer, 0, buffer.Length);
            newline = Encoding.ASCII.GetBytes(Environment.NewLine);
            file_Write.Write(newline, 0, newline.Length);
            newline = Encoding.ASCII.GetBytes("Detail End For Above Student");
            file_Write.Write(newline, 0, newline.Length);
            newline = Encoding.ASCII.GetBytes(Environment.NewLine);
            file_Write.Write(newline, 0, newline.Length);
            file_Write.Close();
        }
        public void search_By_Id(string id)
        {
            file_Read = new FileStream("E:\\Student.txt", FileMode.Open, FileAccess.Read);
            StreamReader read = new StreamReader(file_Read);
            int counter = 0;
            string line; 
            
            while ((line = read.ReadLine()) != null)
            {
                if(line=="ID : "+id)
                {
                    while((line=read.ReadLine()) != "Detail End For Above Student")
                    {
                        Console.WriteLine(line);
                    }
                    break;
                }
                counter++;
            }

            read.Close();
        }
        public void search_By_Name(string name)
        {
            file_Read = new FileStream("E:\\Student.txt", FileMode.Open, FileAccess.Read);
            StreamReader read = new StreamReader(file_Read);
            int counter = 0;
            string line;

            while ((line = read.ReadLine()) != null)
            {
                if (line == "Name : " + name)
                {
                    Console.WriteLine(line);
                    while ((line = read.ReadLine()) != "Detail End For Above Student")
                    {
                        Console.WriteLine(line);
                    }
                    
                }
                counter++;
            }

            read.Close();
        }
        public void search_By_Semester(string semester)
        {
            file_Read = new FileStream("E:\\Student.txt", FileMode.Open, FileAccess.Read);
            StreamReader read = new StreamReader(file_Read);
            int counter = 0;
            string line;
            string[] temp = new string[100];
            int i = 0;


            while ((line = read.ReadLine()) != null)
            {
                temp[i] = line;
                if (line == "Semester : " + semester)
                {
                    Console.WriteLine(temp[i-2]);
                    Console.WriteLine(temp[i - 1]);
                    Console.WriteLine(line);
                    while ((line = read.ReadLine()) != "Detail End For Above Student")
                    {
                        Console.WriteLine(line);
                    }
                    
                    Console.WriteLine("\n\n");
                }
                i++;
                counter++;
                

            }
            temp = null;
            
            read.Close();
        }

        public void delete_Student(string id)
        {
            string tempFile = Path.GetTempFileName();

            using (var read = new StreamReader("E:\\Student.txt"))
            using (var write = new StreamWriter(tempFile))
            {
                string line;

                while ((line = read.ReadLine()) != null)
                {
                    if (line == "ID : "+id)
                    {
                        while ((line = read.ReadLine()) != "Detail End For Above Student")
                        {

                        }
                    }
                    else
                    {
                        write.WriteLine(line);
                    }
                        
                }
            }

            File.Delete("E:\\Student.txt");
            File.Move(tempFile, "E:\\Student.txt");
        }
        public void top_Student_By_Semester(string semester)
        {
            file_Read = new FileStream("E:\\Student.txt", FileMode.Open, FileAccess.Read);
            StreamReader read = new StreamReader(file_Read);
            string line;
            int i = 0;
            while ((line = read.ReadLine()) != null)
            {
                if (line == "Semester : " + semester)
                {
                    line = read.ReadLine();
                    
                    i++;
                }
            }
            /*for(int j=0;j<ary.Length;j++)
            {
                Console.WriteLine(ary[j]);
            }*/
            read.Close();
        }
        public void mark_attendance(string name,string attendance,string semester)
        {
           
            FileStream file_Write;
            file_Write = new FileStream("E:\\Attendance.txt", FileMode.Append, FileAccess.Write);
            byte[] newline = Encoding.ASCII.GetBytes(Environment.NewLine);
            file_Write.Write(newline, 0, newline.Length);
            newline = null;
            byte[] buffer = Encoding.ASCII.GetBytes(semester);
            file_Write.Write(buffer, 0, buffer.Length);
            buffer = null;
            newline = Encoding.ASCII.GetBytes(Environment.NewLine);
            file_Write.Write(newline, 0, newline.Length);
            newline = null;
            buffer = Encoding.ASCII.GetBytes(name);
            file_Write.Write(buffer, 0, buffer.Length);
            buffer = null;
            newline = Encoding.ASCII.GetBytes(Environment.NewLine);
            file_Write.Write(newline, 0, newline.Length);
            newline = null;
            buffer = Encoding.ASCII.GetBytes(attendance);
            file_Write.Write(buffer, 0, buffer.Length);
            buffer = null;
            file_Write.Close();
            Console.WriteLine("Attendance updated!");
        }
        public void view_Attendance(string semester)
        {
            file_Read = new FileStream("E:\\Attendance.txt", FileMode.Open, FileAccess.Read);
            StreamReader read = new StreamReader(file_Read);
            string line;
            while ((line = read.ReadLine()) != null)
            {
                if (line == semester)
                {
                    Console.WriteLine(read.ReadLine());
                    line = read.ReadLine();
                    if (line == "yes")
                        Console.WriteLine("Present");
                    else
                        Console.WriteLine("Absent");
                }
            }
            read.Close();
        }
    }
}
