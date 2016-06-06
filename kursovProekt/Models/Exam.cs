using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace kursovProekt.Models
{
    public class Exam
    {
        public int ID { get; set; }
        private IList<Question> _question = new List<Question>();
        public string Name { get; set; }

        public IList<Question> Questions
        {
            get { return _question; }
            set { _question = value; }
        }

        public void AddQuestion(IList<Question> questions)
        {
            foreach (var question in questions)
            {
                AddQuestion(question);
            }
        }
        public void AddQuestion(Question question)
        {
            _question.Add(question);
        }
        public double TotalPoints
        {
            get
            {
                return (from q in _question select q.Point).Sum();
            }
        }

    }
}