using Kck_FirstProject.Models;
using Kck_FirstProject.Services;
using Kck_FirstProject.ViewModels.Home.Requests;
using Kck_FirstProject.ViewModels.Home.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Kck_FirstProject.Controllers
{
    [RoutePrefix("home")]
    public class HomeController : BaseApiController
    {
        private readonly IMonsterService _monsterService;

        public HomeController()
        {
            _monsterService = new MonsterService();
        }
        [HttpGet]
        [Route("index")]
        public string Index()
        {
            return "Dupa";
        }

        [HttpPost]
        [Route("create")]
        public IHttpActionResult Create(MonsterAddRequest monster)
        {
            if (monster == null || !ModelState.IsValid) return ResponseMessage(CreateCustomResponseMessage(HttpStatusCode.BadRequest));
            var result = _monsterService.Add(monster);
            return ResponseMessage(CreateCustomResponseMessage(result));
        }

        [HttpPut]
        [Route("update")]
        public IHttpActionResult Update(MonsterUpdateRequest monster)
        {
            if (monster == null || !ModelState.IsValid) return ResponseMessage(CreateCustomResponseMessage(HttpStatusCode.BadRequest));
            var result = _monsterService.Update(monster);
            return ResponseMessage(CreateCustomResponseMessage(result));
        }

        [HttpGet]
        [Route("read")]
        public IHttpActionResult Read()
        {
            var result = _monsterService.Read();
            return ResponseMessage(CreateCustomResponseMessage(result));
        }

        [HttpGet]
        [Route("readbyid")]
        public IHttpActionResult ReadById(int id)
        {
            if (id <= 0) return ResponseMessage(CreateCustomResponseMessage(HttpStatusCode.BadRequest));
            var result = _monsterService.ReadById(id);
            return ResponseMessage(CreateCustomResponseMessage(result));
        }

        [HttpDelete]
        [Route("delete")]
        public IHttpActionResult Delete(int id)
        {
            if (id <= 0) return ResponseMessage(CreateCustomResponseMessage(HttpStatusCode.BadRequest));
            var result = _monsterService.Delete(id);
            return ResponseMessage(CreateCustomResponseMessage(result));
        }

        [HttpPost]
        [Route("createdb")]
        public void CreateDatabase()
        {
            using (MonstersContext db = new MonstersContext())
            {
                db.Monsters.Add(new Monster());
                db.SaveChanges();
            }
        }
    }
}
