using System;
using ExamSystem.Entities;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ExamSystem
{
    public partial class Login : Form
    {
        StudentHome frmStudentHome;
        frmInstructorHome frmInstructorHome;
        public Login()
        {
            InitializeComponent();
            this.FormClosed += (sender, e) => db.Dispose();
        }
        Examv2Context db = new Examv2Context();
        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            var user = db.Users.SingleOrDefault(u => u.Username == txtUserName.Text && u.Password == txtPassword.Text);
           
            if (user?.Type== "Instructor")
            {
                var loginUser = db.Instructor.FirstOrDefault(u => u.UserId == user.UserId);
                //check if student or instractor  here
                //go to student form
                this.Hide();
                frmInstructorHome = new frmInstructorHome(loginUser);
                frmInstructorHome.Show();
            } 
            else if (user?.Type=="student")
            {
                Student loginUser = db.Student.FirstOrDefault(u => u.UserId == user.UserId);
               
                this.Hide();
                frmStudentHome = new StudentHome(loginUser);
                frmStudentHome.Show();
            }
            else
            {
                MessageBox.Show(" wrong  user name or password... please try again");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void label5_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
