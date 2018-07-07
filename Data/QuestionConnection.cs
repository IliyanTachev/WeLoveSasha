using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_App.Data
{
    public class QuestionConnection
    {
        public OfficePoll2Entities entities = new OfficePoll2Entities();
        public void CreateQuestion(String text, DateTime date) {
            using(entities)
            {
                entities.Questions.Add(new Questions() { text = text, date = date });
                entities.SaveChanges();

            }
        }

        public void DeleteQuestion() {

        }

        public void UpdateQuestion()
        {

        }
   
        public void SelectQuestion()
        {

        }
    }
}