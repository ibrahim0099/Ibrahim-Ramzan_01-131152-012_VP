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
    
    public partial class Attendence_Sheet : Form
    {

        string[] data = null;
        string[] present = new string[65];
        int j = 0, i = 2;
        public Attendence_Sheet()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string temp = null;
            File_Wrok obj = new File_Wrok();
            
            if (radioButton_present.Checked==true)
            {
                present[j++] = label_id.Text;
                temp = label_id.Text;
                label_id.Text = data[i++];
                label_name.Text = data[i++];
            }
            else
            {
                if(i<=data.Length)
                {
                    //  MessageBox.Show("HEy");
                    label_id.Text = data[i++];
                    label_name.Text = data[i++];
                }
             
            }
            obj.Mark_Attendence(present);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 obj = new Form1();
            obj.Show();
            Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string semester, department;
            semester = textBox_semester.Text;
            department = textBox_department.Text;
            File_Wrok obj = new File_Wrok();
            data = obj.Attendence_data_toMark(semester, department);
            label_id.Text = data[0];
            label_name.Text = data[1];

        }
    }
}
