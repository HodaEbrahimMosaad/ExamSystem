using ExamSystem.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSystem.Models
{
    class QuestionsAnswersMapping
    {
        public int QuestionId { get; set; }
        public string Body { get; set; }
        public int ModelAnswer { get; set; }
        public int Grade { get; set; }
        public int Type { get; set; }
        public int? CourseId { get; set; }
        public virtual List <ChoiceSelectResult> Choice { get; set; }
    }
}


