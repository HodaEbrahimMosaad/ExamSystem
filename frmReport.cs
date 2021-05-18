using ExamSystem.Entities;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamSystem
{
    public partial class frmReport : Form
    {
        Examv2Context db;
        Examv2ContextProcedures procs;
        public frmReport()
        {
            InitializeComponent();
            db = new Examv2Context();
            procs = new Examv2ContextProcedures(db);
            FormClosing += (sender, e) => db.Dispose();
        }
        ReportViewer report;
        int reportIndex = -1;
        int firstParameter = -1;

        public void SetReportParameters(int _reportIndex, int _firstParameter)
        {
            reportIndex = _reportIndex;
            firstParameter = _firstParameter;
        }
        private async void frmReport_Load(object sender, EventArgs e)
        {
            ReportDataSource src = new ReportDataSource();
            report = new ReportViewer();
            switch (reportIndex)
            {
                case 0:
                    report.LocalReport.ReportPath = "rptStudentInfo.rdlc";
                    var data = await procs.reportStudentInfoAsync(firstParameter);
                    src = new ReportDataSource("stdInfo", data.ToList());
                    var deptName = db.Department.SingleOrDefault(d=>d.DeptId==firstParameter).Name;
                    report.LocalReport.SetParameters(new ReportParameter("deptName", deptName));
                    break;
                case 1:
                    report.LocalReport.ReportPath = "rptStudentGrade.rdlc";
                    var data1 = await procs.reportStudentGradesAsync(firstParameter);
                    src = new ReportDataSource("stdGrades", data1.ToList());
                    var stdName = db.Student.SingleOrDefault(i => i.StudentId == firstParameter).Name;
                    report.LocalReport.SetParameters(new ReportParameter("stdName", stdName));
                    break;
                case 2:
                    report.LocalReport.ReportPath = "rptInstructorCourses.rdlc";
                    var data2 = await procs.reportInsCoursesAsync(firstParameter);
                    src = new ReportDataSource("insCourses", data2.ToList());
                    var insName = db.Instructor.SingleOrDefault(i => i.InsId == firstParameter).Name;
                    report.LocalReport.SetParameters(new ReportParameter("insName", insName));
                    break;
                case 3:
                    report.LocalReport.ReportPath = "rptCourseTopics.rdlc";
                    var data3 = await procs.reportCourseTopicsAsync(firstParameter);
                    src = new ReportDataSource("courseTopics", data3.ToList());
                    var courseName = db.Course.SingleOrDefault(i => i.CourseId == firstParameter).Name;
                    report.LocalReport.SetParameters(new ReportParameter("courseName", courseName));

                    break;
                case 4:
                    report.LocalReport.ReportPath = "rptExamQuestions.rdlc";
                    var data4 = await procs.reportExamQuestionsAsync(firstParameter);
                    src = new ReportDataSource("examQ", data4.ToList());
                    var stdName2 = db.Student.SingleOrDefault(s => s.StudentId == db.StudentAnswers.First(t => t.ExamId == firstParameter).StudentId).Name;
                    report.LocalReport.SetParameters(new[] { new ReportParameter("examID", firstParameter.ToString()), new ReportParameter("stdName", stdName2) });
                    break;
                case 5:
                    report.LocalReport.ReportPath = "rptExamAnswers.rdlc";
                    var data5 = await procs.reportExamStudentAsync(firstParameter);
                    src = new ReportDataSource("stdAnswers", data5.ToList());
                    var stdName3 = db.Student.SingleOrDefault(s => s.StudentId == db.StudentAnswers.First(t => t.ExamId == firstParameter).StudentId).Name;
                    report.LocalReport.SetParameters(new[] { new ReportParameter("examID", firstParameter.ToString()), new ReportParameter("stdName", stdName3) });
                    break;
                default:
                    break;
            }

            
            report.Dock = DockStyle.Fill;
            report.LocalReport.DataSources.Clear();
            report.LocalReport.DataSources.Add(src);

            this.Controls.Add(report);
            report.RefreshReport();
        }
    }
}
