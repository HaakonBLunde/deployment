using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using sykeplayer_1.Data;
using sykeplayer_1.Models;
using ActionResult = Microsoft.AspNetCore.Mvc.ActionResult;
using Controller = Microsoft.AspNetCore.Mvc.Controller;

namespace sykeplayer_1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _db;
        private readonly UserManager<ApplicationUser> _um;
        private RoleManager<IdentityRole> _rm;

        public HomeController(ILogger<HomeController> logger, ApplicationDbContext db)
        {
            _logger = logger;
            _db = db;
            //_um = um;
            //_rm = rm;
        }

        public IActionResult Index()
        {
            if (_db.IndexInfo.FirstOrDefault(i => i.Id == "Index") != null)
            {
                ViewBag.Html = _db.IndexInfo.FirstOrDefault(i => i.Id == "Index").Html;
            }
            else
            {
                ViewBag.Html = "<h1>Dette er en tittel</h1>" +
                               "<h3>Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.</h3>";

            }
            /*
            Character character1 = _db.Characters.Find("Karstein");
            var character2 = _db.Characters.Find("Merethe");
            
            game.Characters.Add(character1);
            game.Characters.Add(character2);
            */
            
            //game.Characters.Add(character1);
            return View();
        }



        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel {RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier});
        }


        public IActionResult GameList()
        {
            gamesViewModel gamesViewModel = new gamesViewModel();
            gamesViewModel.GameModels = _db.Games.Where(g => g.Visible == true).ToList();
            return View(gamesViewModel);
        }

        public IActionResult Game(string id, int version)
        {
            var game = _db.Games.Find(id, version);
            if (game == null)
            {
                return NotFound();
            }

            if (game.Visible == false)
            {
                ViewBag.HiddenString = "Denne modulen har blitt gjemt eller slettet. Velg en annen modul fra lista.";
                return RedirectToAction("GameList", ViewBag);
            }

            var vm = new viewModel();
            List<Questions> allQs = _db.Questions.Include(gameName => gameName.GameModel).ToList();
            List<Questions> sortedQs = allQs.Where(q => q.GameModel == game).OrderBy(questions => questions.Nr).ToList();
            vm.QuestionList = sortedQs;
            vm.Characters = _db.Characters.ToList();
            vm.Version = version;
            vm.Id = id;
            vm.Description = game.Description;
            //vm.Characters = _db.Characters.Where(c => game.Characters.Contains(c.Id)).ToList();
            return View(vm);
        }

       

        [System.Web.Mvc.HttpPost]
        public ActionResult GetQuestion(string id)
        {

            var question = _db.Questions.FirstOrDefault(q => q.Nr == int.Parse(id));
            //if (question != null)
            {
                /*
                                if (question.Answer1 != null && question.Next1 != null && question.Points1 != null)
                                {
                                    question.Answers.Add(new Answer(question.Answer1, question.Next1, question.Points1));
                                }
                                if (question.Answer2 != null && question.Next2 != null && question.Points2 != null)
                                {
                                    question.Answers.Add(new Answer(question.Answer2, question.Next2, question.Points2));
                                }
                                if (question.Answer3 != null && question.Next3 != null && question.Points3 != null)
                                {
                                    question.Answers.Add(new Answer(question.Answer3, question.Next3, question.Points3));
                                }
                                if (question.Answer4 != null && question.Next4 != null && question.Points4 != null)
                                {
                                    question.Answers.Add(new Answer(question.Answer4, question.Next4, question.Points4));
                                }
                            }*/
                return PartialView("_Game", question);
            }
            
        }
        [HttpPost]
        public string GetEndCard(int points, string id, int version)
        {
            string endCard;
            if (points >= 30)
            {
                endCard = _db.Games.Find(id, version).GoodEnd;
            }else if (points > 8)
            {
                endCard = _db.Games.Find(id, version).MediumEnd;
            }
            else
            {
                endCard = _db.Games.Find(id, version).BadEnd;
            }

            return endCard;
        }
        
    }
}
