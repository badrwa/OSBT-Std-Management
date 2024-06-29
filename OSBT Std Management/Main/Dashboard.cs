using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OSBT_Std_Management.Main
{
    public partial class Dashboard : Form
    {
        Student student = new Student();
        Course course = new Course();
        public Dashboard()
        {
            InitializeComponent();
        }

        private void label_totalStd_Click(object sender, EventArgs e)
        {

        }

        private void studentCount()
        {
            //Display the values
            label_totalStd.Text = "Total Students : " + student.totalStudent();
            label_maleStd.Text = "Male : " + student.maleStudent();
            label_femaleStd.Text = "Female : " + student.femaleStudent();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label5.Text = DateTime.Now.ToLongTimeString();
            label6.Text = DateTime.Now.ToLongDateString();
        }

        private void comboBox_course_SelectedIndexChanged(object sender, EventArgs e)
        {
            label_cmale.Text = "Male : " + student.exeCount("SELECT COUNT(*) FROM student INNER JOIN score ON score.StudentId = student.StdId WHERE score.CourseName = '" + comboBox_course.Text + "' AND student.Gender = 'Male'");
            label_cfemale.Text = "Female : " + student.exeCount("SELECT COUNT(*) FROM student INNER JOIN score ON score.StudentId = student.StdId WHERE score.CourseName = '" + comboBox_course.Text + "' AND student.Gender = 'Female'");

        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            studentCount();
            //  populate the combobox with courses name
            comboBox_course.DataSource = course.getCourse(new MySqlCommand("SELECT * FROM `course`"));
            comboBox_course.DisplayMember = "CourseName";
            comboBox_course.ValueMember = "CourseName";
            timer1.Start();
        }
    }
}
