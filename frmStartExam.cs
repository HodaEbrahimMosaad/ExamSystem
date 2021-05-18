using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using ExamSystem.Entities;
using System.Windows.Forms;
using System.Linq;
using ExamSystem.Models;

namespace ExamSystem
{
    public partial class frmStartExam : Form
    {
        public  Student student { set; get; }
        public  int CourseID;
        public frmStartExam(int _courseID,Student _student)
        {
            InitializeComponent();
            student = _student;
            CourseID = _courseID;
            timer1.Start();
        }
        int _ticks=0;
        Examv2Context db = new Examv2Context();
       
        private void label1_Click(object sender, EventArgs e)
        {

        }
        BindingSource ExamQuestion;
        int cout = 0;
        BindingSource ExamQuestionAnswers;
        BindingNavigator Navigator = new BindingNavigator();
        List<QuestionsAnswersMapping> questionsList;
        string userAnswers = "";
        string qsId = "";
        int ExamIdP;
        private async void frmStartExam_Load(object sender, EventArgs e)
        {

             var procs = new Examv2ContextProcedures(db);



            var flag = new OutputParameter<bool?>();
            var ExamId = new OutputParameter<int?>();


            var result = await procs.GenerateExamAsync(CourseID, student.StudentId, flag, ExamId);
            ExamIdP =(int) ExamId.Value;

            var QuestionsInExam = db.StudentAnswers.Where(e => e.ExamId == ExamId.Value).ToList();
            var Questions = db.Question.ToList();


            var QNames = Questions.Join(QuestionsInExam,
              q => q.QuestionId,
              qn => qn.QuestionId,
              (q, qn) => new { qn.QuestionId, q.Body, q.Type }
            ).ToList();
            questionsList = new List<QuestionsAnswersMapping>();
            for (int i = 0; i < QuestionsInExam?.Count(); i++)
            {
                var QuestionAnswers = await procs.ChoiceSelectAsync(QuestionsInExam[i].QuestionId, flag);
                var c = QuestionAnswers.ToList();
                QuestionsAnswersMapping qq = new QuestionsAnswersMapping()
                {
                    Body = QNames[i].Body,
                    Choice = c,
                    Type = QNames[i].Type,
                    QuestionId = QNames[i].QuestionId,
                    CourseId = CourseID

                };
                questionsList.Add(qq);
            }
            ExamQuestion = new BindingSource(questionsList, "");
           // ExamQuestionAnswers = new BindingSource(questionsList[0].Choice.ToList(),"");
            lblQuestionBody.DataBindings.Add("Text", ExamQuestion, "Body");
           // for(int x = 0; x < questionsList?.Count; x++) {
                if (questionsList[ExamQuestion.Position].Type == 1)
                {
                rdioanswer1.Text = questionsList[ExamQuestion.Position].Choice[0].choiceBody;
                rdioanswer1.Checked = true;
                rdioanswer2.Text = questionsList[ExamQuestion.Position].Choice[1].choiceBody;
                rdioanswer3.Show();
                rdioanswer4.Show();
                rdioanswer3.Text = questionsList[ExamQuestion.Position].Choice[2].choiceBody;
                rdioanswer4.Text = questionsList[ExamQuestion.Position].Choice[3].choiceBody;
                //rdioanswer1.DataBindings.Add("Text", questionsList[ExamQuestion.Position].Choice[0], "choiceBody");
                //rdioanswer2.DataBindings.Add("Text", questionsList[ExamQuestion.Position].Choice[1], "choiceBody");
                //rdioanswer3.DataBindings.Add("Text", questionsList[ExamQuestion.Position].Choice[2], "choiceBody");
                //rdioanswer4.DataBindings.Add("Text", questionsList[ExamQuestion.Position].Choice[3], "choiceBody");
                this.Controls.Add(Navigator);
                
                }
            else if (questionsList[ExamQuestion.Position].Type == 0)
            {
                rdioanswer1.Text = "True";
                rdioanswer2.Text = "False";
                rdioanswer3.Hide();
                rdioanswer4.Hide();
                this.Controls.Add(Navigator);
            }

        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            ExamQuestion.MovePrevious();
            if (questionsList[ExamQuestion.Position].Type == 1)
            {
                rdioanswer1.Text = questionsList[ExamQuestion.Position].Choice[0].choiceBody;
                rdioanswer1.Checked = true;
                rdioanswer2.Text = questionsList[ExamQuestion.Position].Choice[1].choiceBody;
                rdioanswer3.Text = questionsList[ExamQuestion.Position].Choice[2].choiceBody;
                rdioanswer4.Text = questionsList[ExamQuestion.Position].Choice[3].choiceBody;
            }
            else if (questionsList[ExamQuestion.Position].Type == 0)
            {
                rdioanswer1.Text = "True";
                rdioanswer1.Checked = true;
                rdioanswer2.Text = "False";

                this.Controls.Add(Navigator);
            }


        }

        private void btnNext_Click(object sender, EventArgs e)
        {

            if (rdioanswer1.Checked == true)
            {
                if (questionsList[ExamQuestion.Position].Type == 0)
                {
                    userAnswers += 1+",";//true
                }
                else
                {
                    userAnswers += questionsList[ExamQuestion.Position].Choice.FirstOrDefault(c => c.choiceBody == rdioanswer1.Text).choiceID + ",";
                }
            }
            else if (rdioanswer2.Checked == true)
            {
                if (questionsList[ExamQuestion.Position].Type == 0)
                {
                    userAnswers += 0+",";//false
                }
                else
                    userAnswers += questionsList[ExamQuestion.Position].Choice.FirstOrDefault(c => c.choiceBody == rdioanswer2.Text).choiceID + ",";
            }
            else if (rdioanswer3.Checked == true)
            {

                userAnswers += questionsList[ExamQuestion.Position].Choice.FirstOrDefault(c => c.choiceBody == rdioanswer3.Text) .choiceID+ ",";
            }
            else if (rdioanswer4.Checked == true)
            {

                userAnswers += questionsList[ExamQuestion.Position].Choice.FirstOrDefault(c => c.choiceBody == rdioanswer4.Text).choiceID + ",";
            }
            qsId += questionsList[ExamQuestion.Position].QuestionId+",";
            ExamQuestion.MoveNext();
            cout++;
            if (cout < questionsList.Count)
            {
                if (questionsList[ExamQuestion.Position].Type == 1)
                {
                    rdioanswer1.Text = questionsList[ExamQuestion.Position].Choice[0].choiceBody;
                    rdioanswer1.Checked = true;
                    rdioanswer2.Text = questionsList[ExamQuestion.Position].Choice[1].choiceBody;
                    rdioanswer3.Show();
                    rdioanswer4.Show();
                    rdioanswer3.Text = questionsList[ExamQuestion.Position].Choice[2].choiceBody;
                    rdioanswer4.Text = questionsList[ExamQuestion.Position].Choice[3].choiceBody;
                }
                else if (questionsList[ExamQuestion.Position].Type == 0)
                {
                    rdioanswer3.Hide();
                    rdioanswer4.Hide();
                    rdioanswer1.Text = "True";
                    rdioanswer2.Text = "False";

                    this.Controls.Add(Navigator);
                }
            }
            else
            {
                // btnSubmit
                // 
                btnNext.Hide();
                this.btnSubmit.Name = "btnSubmit";
                //this.btnSubmit.Size = new System.Drawing.Size(75, 23);
                //this.btnSubmit.TabIndex = 2;
                this.btnSubmit.Text = "Submit";
                this.btnSubmit.UseVisualStyleBackColor = true;
                this.btnSubmit.BackColor = Color.CadetBlue;
                this.btnSubmit.ForeColor = Color.White;
                this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
                // 
            }
        }
        StudentHome studentHome;
        private async void timer1_Tick(object sender, EventArgs e)

        {
            this.Text ="your timer "+ _ticks.ToString();
            if (_ticks <1000)
            {
                _ticks++;
            }
            else
            {
                timer1.Stop();
                var procs = new Examv2ContextProcedures(db);
                var ExamAnswers = await procs.ExamAnswersAsync(userAnswers, ExamIdP, student.StudentId, qsId);
                var ExamCorrection = await procs.ExamCorrectionAsync(ExamIdP);
                studentHome =new StudentHome(student);
                studentHome.Show();
                this.Hide();
                    }

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            _ticks = 1000;
        }
        private void label1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void label2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void btnSubmit_Click_1(object sender, EventArgs e)
        {

        }
    }
}
