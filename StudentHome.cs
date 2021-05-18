using System;
using ExamSystem.Entities;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Collections;
using System.Linq;
using System.Windows.Forms;
using System.Diagnostics;

namespace ExamSystem
{
    public partial class StudentHome : Form
    {
        public Student LoginStudent=new Student();
        public StudentHome(Student user)
        {
            LoginStudent = user;
            
            InitializeComponent();
        }

        private void btnStartExam_Click(object sender, EventArgs e)
        {
          int courseID =(int) comboxCourses.SelectedValue;
           var studentcourse = db.StudentCourse.FirstOrDefault(c => c.CourseId == courseID && c.StudentId == LoginStudent.StudentId);
            int coursegrade = (int)db.Course.FirstOrDefault(c => c.CourseId == courseID).CourseGrade;

            if (studentcourse.Status < 2 && studentcourse.Grade<.5*coursegrade)
            {
                frmStartExam frmStartExam = new frmStartExam(courseID, LoginStudent);
                frmStartExam.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("you not allowed to take exam");
            }
           
        }
        Examv2Context db = new Examv2Context();
        private async void StudentHome_Load(object sender, EventArgs e)
        {
            var procs = new Examv2ContextProcedures(db);

            BindingSource CourseBS = new BindingSource();

            var flag = new OutputParameter<bool?>();
            var result= await procs.selectStudentCourseAsync(LoginStudent.StudentId, flag);
            
            CourseBS.DataSource = result.ToList();
            foreach (var item in result)
            {
                Trace.WriteLine(item.name);
            }
           
            comboxCourses.DataSource = CourseBS;
            comboxCourses.DisplayMember = "name";
            comboxCourses.ValueMember = "courseID";
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnGenerateReport_Click(object sender, EventArgs e)
        {

            var Exam = db.Exam.ToList();
            var StudentAnswers = db.StudentAnswers.ToList();
            var Course = db.Course.ToList();
            var q = (from ex in Exam
                     join sa in StudentAnswers
                     on ex.ExamId equals sa.ExamId
                     where ex.CourseId == (int)comboxCourses.SelectedValue
                     where sa.StudentId == LoginStudent.StudentId


                     orderby sa.ExamId descending
                     select new
                     {
                        sa

                     }).ToList();
            var param = q[0].sa.ExamId;
            frmReport fr = new frmReport();
            fr.SetReportParameters(5, param);
            fr.ShowDialog();
        }
    }
}
