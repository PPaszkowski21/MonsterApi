using Kck_FirstProject.ViewModels.Home.Requests;
using Kck_FirstProject.ViewModels.Home.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Kck_FirstProject.Models
{
    public class Monster
    {
        public Monster(string name, int exp, int hp, int ms, bool inv, string il)
        {
            this.Name = name;
            this.Exp = exp;
            this.HP = hp;
            this.MovementSpeed = ms;
            this.SeeingInvisible = inv;
            this.ImageLink = il;
        }
        public Monster(string name, int exp, int hp, int ms, bool inv)
        {
            this.Name = name;
            this.Exp = exp;
            this.HP = hp;
            this.MovementSpeed = ms;
            this.SeeingInvisible = inv;
        }
        public Monster()
        {

        }

        public Monster(MonsterAddRequest monster)
        {
            this.Name = monster.Name;
            this.Exp = monster.Exp;
            this.HP = monster.HP;
            this.MovementSpeed = monster.MovementSpeed;
            this.SeeingInvisible = monster.SeeingInvisible;
            this.ImageLink = monster.ImageLink;

        }

        public Monster(MonsterResponse monster)
        {
            this.Name = monster.Name;
            this.Exp = monster.Exp;
            this.HP = monster.HP;
            this.MovementSpeed = monster.MovementSpeed;
            this.SeeingInvisible = monster.SeeingInvisible;
            this.ImageLink = monster.ImageLink;

        }
        public int Id { get; set; }
        public string Name { get; set; }
        public int Exp { get; set; }
        public int HP { get; set; }
        public int MovementSpeed { get; set; }
        public bool SeeingInvisible { get; set; }
        public string ImageLink { get; set; }
    }
}