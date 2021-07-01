using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using sykeplayer_1.Data;
using sykeplayer_1.Models;

namespace sykeplayer_1.Controllers
{
    [Authorize(Roles = "Admin"),System.Web.Mvc.ValidateAntiForgeryToken]
    public class AdminController : Controller
    {
        private readonly ILogger<AdminController> _logger;
        private readonly ApplicationDbContext _db;
        private readonly UserManager<ApplicationUser> _um;
        private RoleManager<IdentityRole> _rm;
        //UserManager<ApplicationUser> um, RoleManager<IdentityRole> rm
        
        public AdminController(ILogger<AdminController> logger,ApplicationDbContext db )
        {
            _logger = logger;
            _db = db;
            /*_um = um;
            _rm = rm;*/
        }
        // GET
        
        
        
        
        public IActionResult Index()
        {
            gamesViewModel gamesViewModel = new gamesViewModel();
            gamesViewModel.GameModels = _db.Games.ToList();
            return View(gamesViewModel);
        }
        
        [HttpGet]
        public IActionResult EditGame(string id, int version)
        {
            var game = _db.Games.Find(id, version);
            if (game == null)
            {
                return NotFound();
            }
            var vm = new submitModel();
            List<Questions> allQs = _db.Questions.Include(gameName => gameName.GameModel).ToList();
            List<Questions> sortedQs = allQs.Where(q => q.GameModel == game).OrderBy(questions => questions.Nr).ToList();
            vm.QuestionList = sortedQs;
            /*vm.Description = game.Description;
            vm.Name = game.Id;*/
            game.Version = GetVersionNumber(id);
            //game.Id = game.Id + "v" +game.Version;
            
            vm.GameModel = game;
            
            return View(vm);
        }
        

        private int GetVersionNumber(string id)
        {
            /*var vnumber = _db.Games.Count(g => g.Id == id);
            if (_db.Games.Find(id, vnumber) != null)
            {
                
            }*/
            var gamesOfId = _db.Games.Where(g => g.Id == id).ToList().OrderBy(g => g.Version);
            var vnumber = gamesOfId.Last().Version + 1;
            

            return vnumber;
        }
                
        [HttpPost]
        public  IActionResult EditGame(submitModel model)
        {
            GameModel newGame = model.GameModel;
            
            //getQuestionsToRemove(model.QuestionList, newGame.Id);
            foreach (var question in model.QuestionList)
            {
                question.GameModel = newGame;
                question.Id = newGame.Id + "v" + newGame.Version + question.Nr;
                /*
                 
                if (QuestionExists(question))
                {
                    _db.Questions.Update(question);
                }
                else
                {*/
                    _db.Questions.Add(question);
                    newGame.QuestionsCollection.Add(question);
                //}
            }
            newGame.LastModified = DateTime.Now;
            //newGame.Id = model.Name;
            _db.Games.Add(newGame);
            _db.SaveChanges();
            ViewBag.StartIndex = _db.Questions.Count().ToString();
            return RedirectToAction("Index");
        }

        

        private bool QuestionExists(Questions question)
        {
            return _db.Questions.Any(o => o.Nr == question.Nr);
        }

        [HttpGet]
        public IActionResult CreateGame()
        {
            var vm = new submitModel();
            ViewBag.StartIndex = (_db.Games.Count()*100).ToString();
            vm.ImageURLs = Directory.GetFiles(@"wwwroot/lib/assets/images/").ToList();
            vm.GetFileNames();
            return View(vm);
        }
        
        [HttpPost]
        public IActionResult CreateGame(submitModel model)
        {
            GameModel newGame = model.GameModel;
            newGame.Version = 1;
            foreach (var question in model.QuestionList)
            {
                question.Id = newGame.Id + "v" + newGame.Version + question.Nr;
                question.GameModel = newGame;
                _db.Questions.Add(question);
                newGame.QuestionsCollection.Add(question);
            }
            
            newGame.LastModified = DateTime.Now;
            _db.Games.Add(newGame);
            _db.SaveChanges();
            ViewBag.StartIndex = _db.Questions.Count().ToString();
            return RedirectToAction("Index");
        }
       

        public IActionResult HideGame(string id, int version)
        {
            var gameToHide = _db.Games.Find(id, version);
            gameToHide.Visible = false;
            _db.Games.Update(gameToHide);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult ShowGame(string id, int version)
        {
            var gameToHide = _db.Games.Find(id, version);
            gameToHide.Visible = true;
            _db.Games.Update(gameToHide);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult GetDeleteGame(string id, int version)
        {
            var gm = _db.Games.Find( id, version);

            return PartialView("_DeletePartial", gm);
        }

        public IActionResult PostDeleteGame(string id, int version)
        {
            var gameToRemove =_db.Games.Find(id, version);
            _db.Games.Remove(gameToRemove);
            
            var qs = _db.Questions.Include(q => q.GameModel);
            var qsToDelete = qs.Where(q => q.GameModel == gameToRemove);
            foreach (var q in qsToDelete)
            {
                _db.Remove(q);
            }
           
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult CancelDelete()
        {
            return RedirectToAction("Index");
        }
        
        public IActionResult NewIndex()
        {
            if (_db.IndexInfo.Find("Index") != null)
            {
                ViewBag.Html = _db.IndexInfo.Find( "Index").Html;
            }

            var model = new editIndexModel();
            model.IndexInfo = _db.IndexInfo.Find("Index");
            model.Images =  Directory.GetFiles(@"wwwroot/lib/assets/images/").ToList();
            model.CorrectPaths();
            
            return View(model);
        }
        
        public IActionResult UpdateIndex(editIndexModel model)
        {
            var info = model.IndexInfo;
            _db.IndexInfo.Update(info);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult UploadImage()
        {
            var fm = new FileModel();
            fm.FilePaths = Directory.GetFiles(@"wwwroot/lib/assets/images").ToList();
            fm.CorrectPaths();
            return View(fm);
        }

        [HttpPost]
        public async Task<IActionResult> UploadImage(IFormFile file, string choice)
        {
            if (file != null && file.Length > 0)
            {
                var fileName = Path.GetFileName(file.FileName);
                using(var stream = System.IO.File.Create(Path.Combine("wwwroot/lib/assets/images", fileName)))
                    {
                        await file.CopyToAsync(stream);
                    }
            }

            return RedirectToAction("UploadImage");
        }

        [HttpGet]
        public IActionResult UploadAudio(string id)
        {
            
            var q = _db.Questions
                .Include(questions =>questions.GameModel)
                .FirstOrDefault(q => q.Id == id);
            
            if (q != null)
            {
                
                ViewBag.qText = q.Question;
                ViewBag.Id = q.Id;
                ViewBag.GameName = q.GameModel.Id;
                
            }
            else
            {
                ViewBag.ErrorMessage = "Du har gått gjennom hele lista med spørsmål";
            }

            return View();
        }
        [HttpPost]
        public async Task<IActionResult> UploadAudio(IFormFile file, string id, string gameName)
        {
            
            if (file != null && file.Length > 0)
            {
                var extension = Path.GetExtension(file.FileName);
                var qToUpdate = await _db.Questions.FindAsync(id);
                if (extension != ".mp3" && extension != ".m4a")
                {
                    ViewBag.ErrorMessage = "Last opp riktig filtype. Tillatte filtyper er mp3 og m4a";
                    ViewBag.qText = qToUpdate.Question;
                    
                    ViewBag.Nr = qToUpdate.Nr;
                    ViewBag.GameName = qToUpdate.GameModel.Id;
                    return View();
                }

                //var fileName = Path.GetFileName(file.FileName);
                var fileName = id + extension;
                var path = Path.Combine(@"wwwroot/lib/assets/Audio", fileName);
                await using (var stream = System.IO.File.Create(path))
                {
                    await file.CopyToAsync(stream);
                }

                
                qToUpdate.AudioURL = fileName;
                _db.Questions.Update(qToUpdate);
                await _db.SaveChangesAsync();
            }
            
            return RedirectToAction("AudioList", new {id = gameName});
        }

        public IActionResult AudioList(string id, int version)
        {
            var game = _db.Games.Find(id, version);
            if (game != null)
            {
                game.QuestionsCollection = _db.Questions
                    .Include(q => q.GameModel)
                    .Where(q => q.GameModel.Id ==  id).ToList();
                return View(game);
            }

            return RedirectToAction("Index");
        }
        public IActionResult Question()
        {
            viewModel vm = new viewModel();
            vm.QuestionList = _db.Questions.Include(question => question.GameModel).ToList();
            return View(vm);
        }

      

        public IActionResult Preview(string id, int version)
        {
            var game = _db.Games.Find(id, version);
            if (game == null)
            {
                return NotFound();
            }

            var vm = new viewModel();
            List<Questions> allQs = _db.Questions.Include(gameName => gameName.GameModel).ToList();
            List<Questions> sortedQs = allQs.Where(q => q.GameModel == game).ToList();
            vm.QuestionList = sortedQs;
            vm.Characters = _db.Characters.ToList();
            vm.Version = version;
            vm.Id = id;
            vm.Description = game.Description;
            //vm.Characters = _db.Characters.Where(c => game.Characters.Contains(c.Id)).ToList();
            return View(vm);
        }
        [HttpPost]
        public string GetEndCard(int points, string id, int version)
        {
            string endCard;
            if (points > 30)
            {
                endCard = _db.Games.Find(id, version).GoodEnd;
            }else if (points < 30 && points > 8)
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