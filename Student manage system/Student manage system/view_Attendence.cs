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
    public partial class view_Attendence : Form
    {
        public view_Attendence()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string semester, department;
            semester = textBox_semester.Text;
            department = textBox_department.Text;
            File_Wrok obj = new File_Wrok();
            string[] data= obj.view_Attendence(semester,department);
            ListViewItem objj;
            int k = 1;
            for (int i = 0; i < data.Length; i++)
            {
                objj = new ListViewItem(data[i]);

                objj.SubItems.Add(data[k]);
                i++;
                k = k + 2;

                
                this.listView1.Items.Add(objj);
            }
        }

        private void view_Attendence_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 obj = new Form1();
            obj.Show();
            Hide();
        }
    }
}
