namespace Student_manage_system
{
    partial class Search_Student
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Search_Student));
            this.radioButton_id = new System.Windows.Forms.RadioButton();
            this.radioButton_semester = new System.Windows.Forms.RadioButton();
            this.radioButton_name = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button_search = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Semester = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CGPA = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Department = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.University = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // radioButton_id
            // 
            this.radioButton_id.AutoSize = true;
            this.radioButton_id.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.radioButton_id.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_id.Location = new System.Drawing.Point(159, 116);
            this.radioButton_id.Name = "radioButton_id";
            this.radioButton_id.Size = new System.Drawing.Size(45, 21);
            this.radioButton_id.TabIndex = 0;
            this.radioButton_id.TabStop = true;
            this.radioButton_id.Text = "ID";
            this.radioButton_id.UseVisualStyleBackColor = false;
            // 
            // radioButton_semester
            // 
            this.radioButton_semester.AutoSize = true;
            this.radioButton_semester.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.radioButton_semester.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_semester.Location = new System.Drawing.Point(371, 116);
            this.radioButton_semester.Name = "radioButton_semester";
            this.radioButton_semester.Size = new System.Drawing.Size(87, 21);
            this.radioButton_semester.TabIndex = 1;
            this.radioButton_semester.TabStop = true;
            this.radioButton_semester.Text = "Semester";
            this.radioButton_semester.UseVisualStyleBackColor = false;
            // 
            // radioButton_name
            // 
            this.radioButton_name.AutoSize = true;
            this.radioButton_name.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.radioButton_name.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_name.Location = new System.Drawing.Point(265, 116);
            this.radioButton_name.Name = "radioButton_name";
            this.radioButton_name.Size = new System.Drawing.Size(64, 21);
            this.radioButton_name.TabIndex = 2;
            this.radioButton_name.TabStop = true;
            this.radioButton_name.Text = "Name";
            this.radioButton_name.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(159, 90);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(154, 20);
            this.textBox1.TabIndex = 3;
            // 
            // button_search
            // 
            this.button_search.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button_search.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_search.Location = new System.Drawing.Point(12, 158);
            this.button_search.Name = "button_search";
            this.button_search.Size = new System.Drawing.Size(119, 60);
            this.button_search.TabIndex = 4;
            this.button_search.Text = "search";
            this.button_search.UseVisualStyleBackColor = false;
            this.button_search.Click += new System.EventHandler(this.button_search_Click);
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.Name,
            this.Semester,
            this.CGPA,
            this.Department,
            this.University});
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(159, 148);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(413, 192);
            this.listView1.TabIndex = 5;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // ID
            // 
            this.ID.Text = "ID";
            this.ID.Width = 108;
            // 
            // Name
            // 
            this.Name.Text = "Name";
            // 
            // Semester
            // 
            this.Semester.Text = "Semester";
            // 
            // CGPA
            // 
            this.CGPA.Text = "CGPA";
            // 
            // Department
            // 
            this.Department.Text = "Department";
            // 
            // University
            // 
            this.University.Text = "University";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(26, 246);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 45);
            this.button1.TabIndex = 6;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(53, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(489, 50);
            this.label1.TabIndex = 7;
            this.label1.Text = "Student Profile System";
            // 
            // Search_Student
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.button_search);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.radioButton_name);
            this.Controls.Add(this.radioButton_semester);
            this.Controls.Add(this.radioButton_id);
          ///  this.Name = "Search_Student";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButton_id;
        private System.Windows.Forms.RadioButton radioButton_semester;
        private System.Windows.Forms.RadioButton radioButton_name;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button_search;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader Name;
        private System.Windows.Forms.ColumnHeader Semester;
        private System.Windows.Forms.ColumnHeader CGPA;
        private System.Windows.Forms.ColumnHeader Department;
        private System.Windows.Forms.ColumnHeader University;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
    }
}