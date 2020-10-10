using Kck_FirstProject.Models;
using Kck_FirstProject.ViewModels.Home.Requests;
using Kck_FirstProject.ViewModels.Home.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;

namespace Kck_FirstProject.Services
{
    public class MonsterService : IMonsterService
    {
        public MonsterService()
        {

        }

        public ServiceResponse Add(MonsterAddRequest monster)
        {
            using (MonstersContext db = new MonstersContext())
            {
                db.Monsters.Add(new Monster(monster));
                db.SaveChanges();
                return new ServiceResponse(HttpStatusCode.Created, "Monster added succesfully!");
            }
        }

        public ServiceResponse<IEnumerable<MonsterResponse>> Read()
        {
            var monsters = new List<Monster>();
            var monsters2 = new List<MonsterResponse>();
            using (MonstersContext db = new MonstersContext())
            {
                monsters = db.Monsters.ToList();
            }
            foreach (var item in monsters)
            {
                monsters2.Add(new MonsterResponse(item));
            }
            return new ServiceResponse<IEnumerable<MonsterResponse>>(monsters2, HttpStatusCode.OK, "Table downloaded!");
        }

        public ServiceResponse<MonsterResponse> ReadById(int id)
        {
            Monster monster;
            MonsterResponse monster2;
            using (MonstersContext db = new MonstersContext())
            {
                if (!db.Monsters.Any(x => x.Id == id))
                {
                    return new ServiceResponse<MonsterResponse>(null, HttpStatusCode.NotFound, "There is not existing monster with given id!");
                }
                monster = db.Monsters.FirstOrDefault(x => x.Id == id);
                monster2 = new MonsterResponse(monster);
            }
            return new ServiceResponse<MonsterResponse>(monster2,HttpStatusCode.OK, "Monster downloaded!");
        }

        public ServiceResponse Update(MonsterUpdateRequest monster)
        {
            using (MonstersContext db = new MonstersContext())
            {
                
                var monsterToUpdate = db.Monsters.FirstOrDefault(x => x.Id == monster.Id);
                if (monster.HP.HasValue)
                {
                    monsterToUpdate.HP = monster.HP.Value;
                }
                if (monster.Exp.HasValue)
                {
                    monsterToUpdate.Exp = monster.Exp.Value;
                }
                if (!string.IsNullOrEmpty(monster.Name))
                {
                    monsterToUpdate.Name = monster.Name;
                }
                if (monster.MovementSpeed.HasValue)
                {
                    monsterToUpdate.MovementSpeed = monster.MovementSpeed.Value;
                }
                if (monster.SeeingInvisible != null)
                {
                    monsterToUpdate.SeeingInvisible = monster.SeeingInvisible.Value;
                }
                db.SaveChanges(); 
            }
                return new ServiceResponse(HttpStatusCode.Created, "Monster updated succesfully!");
        }
        public ServiceResponse Delete(int id)
        {
            using (MonstersContext db = new MonstersContext())
            {
                if (!db.Monsters.Any(x=>x.Id == id))
                {
                    return new ServiceResponse(HttpStatusCode.NotFound, "There is not existing monster with given id!");
                }
                db.Monsters.Remove(db.Monsters.FirstOrDefault(x => x.Id == id));
                db.SaveChanges();
            }
            return new ServiceResponse(HttpStatusCode.OK, "Monster deleted!");
        }
    }
}