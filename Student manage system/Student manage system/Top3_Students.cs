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
    public partial class Top3_Students : Form
    {
        public Top3_Students()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 obj = new Form1();
            obj.Show();
            Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string semester, department;
            semester = textBox_semester.Text;
            department = textBox_department.Text;
            File_Wrok obj = new File_Wrok();
            string[] data = obj.top_Student_By_CGPA(semester,department);
            ListViewItem objj;
            int k;
            k = data.Length;

            for (int i = 0; i < data.Length; i++)
            {
                objj = new ListViewItem(data[i]);
                k = 1;
                while (k != 3)
                {
                    i++;
                    objj.SubItems.Add(data[i]);
                    k++;
                }
                this.listView1.Items.Add(objj);
            }


        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
