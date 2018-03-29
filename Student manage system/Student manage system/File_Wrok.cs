using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Linq;

namespace Student_manage_system
{
    class File_Wrok
    {

        FileStream file_Read;
        FileStream file_Write;

        public void New_Student(string id, string name, string semester, string cgpa, string department, string university)
        {
            file_Write = new FileStream("E:\\Student.txt", FileMode.Append, FileAccess.Write);
            //byte[] newline = Encoding.ASCII.GetBytes(Environment.NewLine);
            //file_Write.Write(newline, 0, newline.Length);
            //newline = null;
            byte[] newline;
            byte[] buffer = Encoding.ASCII.GetBytes("ID :"+id);
            file_Write.Write(buffer, 0, buffer.Length);
            newline = Encoding.ASCII.GetBytes(Environment.NewLine);
            file_Write.Write(newline, 0, newline.Length);
            buffer = null;
            newline = null;
            buffer = Encoding.ASCII.GetBytes("Name :" + name);
            file_Write.Write(buffer, 0, buffer.Length);
            newline = Encoding.ASCII.GetBytes(Environment.NewLine);
            file_Write.Write(newline, 0, newline.Length);
            buffer = null;
            newline = null;
            buffer = Encoding.ASCII.GetBytes("Semester :" + semester);
            file_Write.Write(buffer, 0, buffer.Length);
            newline = Encoding.ASCII.GetBytes(Environment.NewLine);
            file_Write.Write(newline, 0, newline.Length);
            buffer = null;
            newline = null;
            buffer = Encoding.ASCII.GetBytes("CGPA :" + cgpa);
            file_Write.Write(buffer, 0, buffer.Length);
            newline = Encoding.ASCII.GetBytes(Environment.NewLine);
            file_Write.Write(newline, 0, newline.Length);
            buffer = null;
            newline = null;
            buffer = Encoding.ASCII.GetBytes("Department :" + department);
            file_Write.Write(buffer, 0, buffer.Length);
            newline = Encoding.ASCII.GetBytes(Environment.NewLine);
            file_Write.Write(newline, 0, newline.Length);
            buffer = null;
            newline = null;
            buffer = Encoding.ASCII.GetBytes("University :" + university);
            file_Write.Write(buffer, 0, buffer.Length);
            newline = Encoding.ASCII.GetBytes(Environment.NewLine);
            file_Write.Write(newline, 0, newline.Length);
            newline = Encoding.ASCII.GetBytes("Detail End For Above Student");
            file_Write.Write(newline, 0, newline.Length);
            newline = Encoding.ASCII.GetBytes(Environment.NewLine);
            file_Write.Write(newline, 0, newline.Length);
            buffer = Encoding.ASCII.GetBytes("Status : NO");
            file_Write.Write(buffer, 0, buffer.Length);
            newline = Encoding.ASCII.GetBytes(Environment.NewLine);
            file_Write.Write(newline, 0, newline.Length);
            file_Write.Close();
        }
        public string[] search_By_Id(string id)
        {
            file_Read = new FileStream("E:\\Student.txt", FileMode.Open, FileAccess.Read);
            StreamReader read = new StreamReader(file_Read);
            int counter = 0;
            string line;
            string temp=null;
            string[] data = new string[6];
            int j = 0;
            while ((line = read.ReadLine()) != null)
            {
                if (line =="ID :"+ id)
                {

                    data[j] = data_formate(line);
                    j++;
                    while ((line = read.ReadLine()) != "Detail End For Above Student")
                    {
                        data[j] = data_formate(line);
                        j++;
                    }
                    break;
                }
                counter++;
            }
            
            read.Close();
            return data;
        }

        public string data_formate(string line)
        {
            string temp=null;
            for (int i = 0; i < line.Length; i++)
            {

                if (line[i] == ':')
                {


                    for (int k = i + 1; k < line.Length; k++)
                    {
                        temp = temp + line[k];
                    }
                }
            }
            return temp;
        }
        public string[] search_By_Name(string name)
        {
            file_Read = new FileStream("E:\\Student.txt", FileMode.Open, FileAccess.Read);
            StreamReader read = new StreamReader(file_Read);
            string[] allData = File.ReadAllLines("E:\\Student.txt");
            int size = allData.Length;
            int counter = 0;
            int index = 0;
            int j = 0;
            string line;
            string tempp= null;
            string[] data = new string[size];
            string[] temp = new string[size];
            while ((line = read.ReadLine()) != null)
            {
                temp[j]= line;
                if (line =="Name :"+ name)
                {
                   
                    data[index++] = data_formate(temp[j - 1]);
                    data[index++] = data_formate(line);
                    while ((line = read.ReadLine()) != "Detail End For Above Student")
                    {
                        
                        data[index++]= data_formate(line);
                    }

                }
                j++;
                counter++;
            }
            
            read.Close();
            string[] dataValue=data.Where(x => !string.IsNullOrEmpty(x)).ToArray();
            return dataValue;
        }
        public string[] search_By_Semester(string semester)
        {


            file_Read = new FileStream("E:\\Student.txt", FileMode.Open, FileAccess.Read);
            string[] allData = File.ReadAllLines("E:\\Student.txt");
            int size = allData.Length;
            string[] data = new string[size];
            StreamReader read = new StreamReader(file_Read);
            int counter = 0;
            string line;
            string[] temp = new string[size];
            int i = 0;
            int j = 0;
            while ((line = read.ReadLine()) != null)
            {
                temp[i] = line;
                if (line == "Semester :" + semester)
                {
                    
                    data[j++] = data_formate(temp[i - 2]); 
                    data[j++] = data_formate(temp[i - 1]);
                    data[j++] = data_formate(line);
                    while ((line = read.ReadLine()) != "Detail End For Above Student")
                    {
                        data[j++] = data_formate(line);
                    }
                    
                }
                i++;
                counter++;
            }
            temp = null;
            
            read.Close();
            string[] dataValue = data.Where(x => !string.IsNullOrEmpty(x)).ToArray();
           
            return dataValue;
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
                    if (line == "ID :"+id)
                    {
                        while ((line = read.ReadLine()) != "Detail End For Above Student")
                        {

                        }
                        line = read.ReadLine();
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
        public string[] top_Student_By_CGPA(string semester,string department)
        {
            
            file_Read = new FileStream("E:\\Student.txt", FileMode.Open, FileAccess.Read);
            StreamReader read = new StreamReader(file_Read);
            string line;
            string[] allData = File.ReadAllLines("E:\\Student.txt");
            int size = allData.Length;
            
            string[] gpa = new string[size];
            string[] top_three = new string[3];
            int i = 0;
            while ((line = read.ReadLine()) != null)
            {
                if (line.Contains("CGPA :")==true)
                {
                    gpa[i++] = data_formate(line);
                }
            }
            read.Close();

            string[] dataValue = gpa.Where(x => !string.IsNullOrEmpty(x)).ToArray();
           
            dataValue = dataValue.OrderByDescending(d => d).ToArray();
            for (int j=0;j<3;j++)
            {
                top_three[j] = dataValue[j];
            }
           
            string temp=null;
            string[] top_student = new string[size];
            string[] get_Data = new string[size];
            int h = 0, c = 0;
          
            file_Read = new FileStream("E:\\Student.txt", FileMode.Open, FileAccess.Read);
            StreamReader readd = new StreamReader(file_Read);
          
            while ((line = readd.ReadLine()) != null)
            {
                get_Data[c] = line;
                
                if (line== "Department :"+department)
                {
                    if("Semester :"+semester ==get_Data[c-2])
                    {
                        
                        temp = data_formate(get_Data[c - 1]);
                        for (int k = 0; k < 3; k++)
                        {
                            
                            if (top_three[k] == temp)
                            {
                                top_student[h++] = data_formate(get_Data[c - 4]);
                                top_student[h++] = data_formate(get_Data[c - 3]);
                                top_student[h++] = temp;
                                break;
                            }
                        }
                    }
                    
                }
                c++;
            }
            string[] top_students = top_student.Where(x => !string.IsNullOrEmpty(x)).ToArray();
            readd.Close();
            return top_students;



        
            read.Close();
        }


        public string[] Attendence_data_toMark(string semester,string department)
        {
            string line = null;
            string temp = null;
            string[] allData = File.ReadAllLines("E:\\Student.txt");
            int size = allData.Length;
            string[] student = new string[size];
            string[] get_Data = new string[size];
            int h = 0, c = 0;

            file_Read = new FileStream("E:\\Student.txt", FileMode.Open, FileAccess.Read);
            StreamReader readd = new StreamReader(file_Read);

            while ((line = readd.ReadLine()) != null)
            {
                get_Data[c] = line;

                if (line == "Department :" + department)
                {
                    //MessageBox.Show("if d");
                    if ("Semester :" + semester == get_Data[c - 2])
                    {
                        //MessageBox.Show("if s");
                        student[h++] = data_formate(get_Data[c - 4]);
                        student[h++] = data_formate(get_Data[c - 3]);
                    }

                }
                c++;
            }
            string[] data = student.Where(x => !string.IsNullOrEmpty(x)).ToArray();
            readd.Close();
            return data;

        }


        public void Mark_Attendence(string[] data)
        {

            string tempFile = Path.GetTempFileName();
            byte[] newline;
            byte[] buffer;
            //file_Write = new FileStream("E:\\Student.txt", FileMode.Append, FileAccess.Write);
            using (var read = new StreamReader("E:\\Student.txt"))
            using (var write = new StreamWriter(tempFile))
            {
                string line=null;

                while ((line = read.ReadLine()) != null)
                {
                    for(int i=0;i<data.Length;i++)
                    {
                        if (line == "ID :" +data[i])
                        {
                            write.WriteLine(line);
                            while ((line = read.ReadLine()) != "Detail End For Above Student")
                            {
                                write.WriteLine(line);

                            }
                            write.WriteLine(line);
                         
                            line = read.ReadLine();
                            write.WriteLine("status :YES");
                            break;

                        }
                        else
                        {
                            write.WriteLine(line);
                            break;
                        }
                    }
                    

                }
            }

            File.Delete("E:\\Student.txt");
            File.Move(tempFile, "E:\\Student.txt");
        }
         
        public string[] view_Attendence(string semester, string department)
        {
            string line = null;
            string temp = null;
            string[] allData = File.ReadAllLines("E:\\Student.txt");
            int size = allData.Length;
            string[] student = new string[size];
            string[] get_Data = new string[size];
            int h = 0, c = 0;

            file_Read = new FileStream("E:\\Student.txt", FileMode.Open, FileAccess.Read);
            StreamReader readd = new StreamReader(file_Read);

            while ((line = readd.ReadLine()) != null)
            {
                get_Data[c] = line;
                if(line== "status :YES")
                {
                    if (get_Data[c-3] == "Department :" + department)
                    {

                        if ("Semester :" + semester == get_Data[c - 5])
                        {

                            student[h++] = data_formate(get_Data[c - 7]);
                            student[h++] = data_formate(get_Data[c - 6]);
                        }

                    }


                }

               
                c++;
            }
            string[] data = student.Where(x => !string.IsNullOrEmpty(x)).ToArray();
            readd.Close();
           // MessageBox.Show(data[0]);
            return data;

        }




    }
}
