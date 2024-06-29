using MySql.Data.MySqlClient;
using OSBT_Std_Management.Main;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OSBT_Std_Management
{
    public partial class MainForm : Form
    {
        Student student = new Student();
        Course course = new Course();
        public MainForm()
        {
            InitializeComponent();
            customizeDesign();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            studentCount();
          //  populate the combobox with courses name
            comboBox_course.DataSource = course.getCourse(new MySqlCommand("SELECT * FROM `course`"));
            comboBox_course.DisplayMember = "CourseName";
            comboBox_course.ValueMember = "CourseName";
            timer1.Start();
        }


        private void studentCount()
        {
            //Display the values
            label_totalStd.Text = "Total Students : " + student.totalStudent();
            label_maleStd.Text = "Male : " + student.maleStudent();
            label_femaleStd.Text = "Female : " + student.femaleStudent();

        }
      

        private void customizeDesign()
        {
            panel_stdsubmenu.Visible = false;
            panel_courseSubmenu.Visible = false;
            panel_scoreSubmenu.Visible = false;

        }

        private void hideSubmenu()
        {
            if (panel_stdsubmenu.Visible == true)
                panel_stdsubmenu.Visible = false;
            if (panel_courseSubmenu.Visible == true)
                panel_courseSubmenu.Visible = false;
            if (panel_scoreSubmenu.Visible == true)
                panel_scoreSubmenu.Visible = false;
        }

        private void showSubmenu(Panel submenu)
        {
            if (submenu.Visible == false)
            {
                hideSubmenu();
                submenu.Visible = true;
            }
            else
                submenu.Visible = false;
        }

        private void button_std_Click(object sender, EventArgs e)
        {
            showSubmenu(panel_stdsubmenu);
        }

        #region StdSubmenu
        private void button_registration_Click(object sender, EventArgs e)
        {
            openChildForm(new RegisterForm());
            //...
            //..Your code
            //...
            hideSubmenu();
        }

        private void button_managestd_Click(object sender, EventArgs e)
        {
            openChildForm(new ManageStudentForm());
            //...
            //..Your code
            //...
            hideSubmenu();
        }



        private void button_stdPrint_Click(object sender, EventArgs e)
        {
            openChildForm(new PrintStudent());
            //...
            //..Your code
            //...
            hideSubmenu();
        }

        #endregion StdSubmenu

        private void button_course_Click(object sender, EventArgs e)
        {
            showSubmenu(panel_courseSubmenu);
        }

        #region CourseSubmenu
        private void button_newCourse_Click(object sender, EventArgs e)
        {
            openChildForm(new CourseForm());
            //...
            //..Your code
            //...
            hideSubmenu();
        }

        private void button_manageCourse_Click(object sender, EventArgs e)
        {
            openChildForm(new ManageCourseForm());
            //...
            //..Your code
            //...
            hideSubmenu();
        }

        private void button_coursePrint_Click(object sender, EventArgs e)
        {
            openChildForm(new PrintCourseForm());
            //...
            //..Your code
            //...
            hideSubmenu();
        }

        #endregion CourseSubmenu

        private void button_score_Click(object sender, EventArgs e)
        {
            showSubmenu(panel_scoreSubmenu);
        }

        #region ScoreSubmenu
        private void button_newScore_Click(object sender, EventArgs e)
        {
            openChildForm(new ScoreForm());
            //...
            //..Your code
            //...
            hideSubmenu();
        }

        private void button_manageScore_Click(object sender, EventArgs e)
        {
            openChildForm(new ManageScoreForm());

            hideSubmenu();
        }

        private void button_scorePrint_Click(object sender, EventArgs e)
        {
            openChildForm(new PrintScoreForm());
            hideSubmenu();
        }

        #endregion ScoreSubmenu


        //to show register form in mainform
        private Form activeForm = null;

        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel_main.Controls.Add(childForm);
            panel_main.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }

       private void button_Exit_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            this.Hide();
            login.Show();
        }

        private void comboBox_course_SelectedIndexChanged(object sender, EventArgs e)
        {
            label_cmale.Text = "Male : " + student.exeCount("SELECT COUNT(*) FROM student INNER JOIN score ON score.StudentId = student.StdId WHERE score.CourseName = '" + comboBox_course.Text + "' AND student.Gender = 'Male'");
            label_cfemale.Text = "Female : " + student.exeCount("SELECT COUNT(*) FROM student INNER JOIN score ON score.StudentId = student.StdId WHERE score.CourseName = '" + comboBox_course.Text + "' AND student.Gender = 'Female'");

        }

        private void button11_Click(object sender, EventArgs e)
        {
            openChildForm(new Dashboard());
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label5.Text = DateTime.Now.ToLongTimeString();
            label6.Text = DateTime.Now.ToLongDateString();

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
