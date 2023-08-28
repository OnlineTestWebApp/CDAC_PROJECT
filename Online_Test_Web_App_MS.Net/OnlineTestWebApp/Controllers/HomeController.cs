
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Business_Logic_Layer;
using Data_Access_Layer;
using Business_Object_Layer;

namespace OnlineTestWebApp.Controllers
{
    public class HomeController : Controller
    {
        String Name;
        Login login = new Login();
        SqlUserDatabase _db = new SqlUserDatabase();
        SqlExamDatabase _exam = new SqlExamDatabase();
        // GET: index
        public ActionResult Index()
        { 
          return View();   
        }
        //Get:redirect
        public ActionResult redirect(String username, String password)
        {
            String privilege;
            
          privilege = _db.login(username, password);


            if (privilege.Equals("true")) return View("leaderboard");

            if (privilege.Equals("false")) return View("instructions");

            else return View("Index");
            
        }
        //Get:register
        public ActionResult register(String firstname, String lastname,String username, String password,String privilege)
        {

            _db.regestration(firstname, lastname, username, password, privilege);

            return View();
        }
        //Get:instructions
        public ActionResult instructions()
        {
            return View();
        }
        
        //Get:test
        public ActionResult test()
        {
            List<Questions> questions = QuestionBank.GetQuestions();
            ViewData["LIST"]=questions;
            return View();
        }
        //Get:submit
        public ActionResult submit()
        {
            return View();
        }

        //Get:leaderboard
        public ActionResult leaderboard()
        {
          SortedDictionary<double,Exam> list= _exam.displayLeaderboard();

            ViewData["LIST"]=list;
            return View();
        }

        //Get:about
        public ActionResult about()
        {
            return View();
        }
    }
}