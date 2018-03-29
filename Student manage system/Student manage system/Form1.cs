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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Add_Student obj = new Add_Student();
           Hide();
            obj.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Delete_Student obj = new Delete_Student();
            obj.Show();
            Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Search_Student obj = new Search_Student();
            obj.Show();
            Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Top3_Students obj = new Top3_Students();
            obj.Show();
            Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Attendence_Sheet obj = new Attendence_Sheet();
            obj.Show();
            Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            view_Attendence obj = new view_Attendence();
            obj.Show();
            Hide();
        }
    }
}
