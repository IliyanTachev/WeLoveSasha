using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Globalization;
using System.Linq;
using System.Web;
using WebApplication1.Models;

namespace MVC_App.Data
{
    public class QuestionContext : DbContext
    {
    
         OfficePoll2Entities entities = new OfficePoll2Entities();
    
        public void CreateQuestion(String txt, DateTime date) {
            try
            {
                using (entities)
                {
                    entities.Questions.Add(new Questions() { text = txt, date = date });
                    entities.SaveChanges();

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
    }

        public void DeleteQuestion(int id) {
            using (entities)
            {
                var question = entities.Questions.Find(id);
                if (question != null) {
                    entities.Questions.Remove(question);
                }else
                {
                    throw new Exception();
                }
                entities.SaveChanges();

            }
        }

        public void UpdateQuestion(int id, string text, DateTime date)
        {

            var question = entities.Questions.Find(id);
            if (question != null)
            {
                question.text = text;
                question.date= date;
            }
            else
            {
                throw new Exception();
            }
            entities.SaveChanges();          
  
        }
   
        public QuestionModel SelectQuestion(int id)
        {
            QuestionModel qm = new QuestionModel();

            using (entities)
            {


                var question = entities.Questions.Find(id);
                if (question != null)
                {
                    qm.Question = question.text;
                    qm.Date = question.date.ToString();
                }
                else
                {
                    throw new Exception();
                }
            }
            return qm;
        }

       
    }
}