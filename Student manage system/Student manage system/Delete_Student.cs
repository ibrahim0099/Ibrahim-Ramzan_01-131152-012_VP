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
    public partial class Delete_Student : Form
    {
        public Delete_Student()
        {
            InitializeComponent();
        }

        private void Delete_Student_Load(object sender, EventArgs e)
        {

        }

        private void Delete_Click(object sender, EventArgs e)
        {
            string id;
            id = textBox_id.Text;
            File_Wrok OBJ = new File_Wrok();
            OBJ.delete_Student(id);
            MessageBox.Show("Deleted");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 obj = new Form1();
            obj.Show();
            Hide();
        }
    }
}
