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
    public partial class Search_Student : Form
    {
        public Search_Student()
        {
            InitializeComponent();
        }

        private void button_search_Click(object sender, EventArgs e)
        {
            File_Wrok obj = new File_Wrok();
            
            if (radioButton_id.Checked==true)
            {
                string id;
                
                id = textBox1.Text;
                //obj.search_By_Id(id);
                
                string[] data=obj.search_By_Id(id);
                ListViewItem objj = new ListViewItem(data[0]);
                for(int i=1;i<6;i++)
                {
                    objj.SubItems.Add(data[i]);
                }
                
                this.listView1.Items.Add(objj);
            }
            else if (radioButton_name.Checked==true)
            {
                
                string name;

                name = textBox1.Text;
                //obj.search_By_Id(id);

                string[] data = obj.search_By_Name(name);
                ListViewItem objj;
                int k;
                k = data.Length;
                
                for(int i=0;i<data.Length;i++)
                {
                    objj = new ListViewItem(data[i]);
                    k = 1;
                    while(k!=6)
                    {
                        i++;
                        objj.SubItems.Add(data[i]);
                        
                        k++;
                    }
                    this.listView1.Items.Add(objj);
                }

                
                radioButton_name.Focus();
            }
            else if (radioButton_semester.Checked == true)
            {

                string semester;

                semester = textBox1.Text;
                

                string[] data = obj.search_By_Semester(semester);
                
                ListViewItem objj;
                int k;
                k = data.Length;

                for (int i = 0; i < data.Length; i++)
                {
                    objj = new ListViewItem(data[i]);
                    k = 1;
                    while (k != 6)
                    {
                        i++;
                        objj.SubItems.Add(data[i]);

                        k++;
                    }
                    this.listView1.Items.Add(objj);
                }
                radioButton_name.Focus();
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 obj = new Form1();
            obj.Show();
            Hide();
        }
    }
}
