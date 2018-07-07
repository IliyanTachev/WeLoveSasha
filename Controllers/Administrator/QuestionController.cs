using MVC_App.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers.Administrator
{
    public class QuestionController : Controller
    {
        // GET: Question
        public ActionResult Index()
        {

            List<QuestionModel> questions = new List<QuestionModel>();

            questions.Add(new QuestionModel { Question = "What is your best coffee in the company?", Date = "Jul 05/07/2018" });
            questions.Add(new QuestionModel { Question = "What is your best coffee in the company?", Date = "Jul 06/07/2018" });
            questions.Add(new QuestionModel { Question = "What is your best coffee in the company?", Date = "Jul 07/07/2018" });

            return View(questions);
        }

        // GET: Question/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Question/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Question/Create
        [HttpPost]
        public ActionResult Create(QuestionModel  cl)
        {

            try
            {
                // TODO: Add insert logic here
                QuestionContext qt = new QuestionContext();
                DateTime date =  DateTime.ParseExact(cl.Date, "yyyy-MM-dd",System.Globalization.CultureInfo.InvariantCulture);
                qt.CreateQuestion(cl.Question, date);
                
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Question/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Question/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Question/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Question/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
