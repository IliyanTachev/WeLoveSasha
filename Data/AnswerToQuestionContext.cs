using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVC_App.Data
{
    public class AnswerToQuestionContext
    {
        public void CreateAnswerToTheQuestions(String txt, int question_id) {
            using(OfficePoll2Entities entities = new OfficePoll2Entities())
            {
                entities.Answers_to_the_Questions.Add(new Answers_to_the_Questions() { text = txt, question_id = question_id });
                entities.SaveChanges();

            }
        }

        public void UpdateAnswerToTheQuestions(String text, int id, int question_id)
        {
            using (OfficePoll2Entities entities = new OfficePoll2Entities())
            {
                var answerToUpdate = entities.Answers_to_the_Questions.Find(id);
                answerToUpdate.text = text;
                answerToUpdate.question_id = question_id;
                entities.SaveChanges();
                
            }
        }

        public void DeleteAnswerToTheQuestions(int id)
        {
            using (OfficePoll2Entities entities = new OfficePoll2Entities())
            {

                var answerToDelete = entities.Answers_to_the_Questions.Find(id);
                entities.Answers_to_the_Questions.Remove(answerToDelete);
                entities.SaveChanges();

            }
        }

        public void SelectAnswerToTheQuestions(int id)
        {
            using (OfficePoll2Entities entities = new OfficePoll2Entities())
            {
                var answerToSelect = entities.Answers_to_the_Questions.Find(id);

            }
        }
    }
}