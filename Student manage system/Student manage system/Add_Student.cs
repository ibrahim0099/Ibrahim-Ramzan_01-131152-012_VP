using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_manage_system
{
    public partial class Add_Student : Form
    {
        public Add_Student()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string id,name,semester,cgpa,department,university;
            id = textBox_id.Text;
            name = textBox_name.Text;
            semester = textBox_semester.Text;
            cgpa = textBox_cgpa.Text;
            department = textBox_department.Text;
            university = textBox_university.Text;
            File_Wrok obj = new File_Wrok();
            obj.New_Student(id, name, semester, cgpa, department, university);
            MessageBox.Show("Added");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 obj = new Form1();
            obj.Show();
            Hide();
        }
    }
}
