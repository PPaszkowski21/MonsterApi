using Kck_FirstProject.Models;
using Kck_FirstProject.ViewModels.Home.Requests;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Kck_FirstProject.ViewModels.Home.Responses
{
    public class MonsterResponse
    {
        public MonsterResponse(Monster monster)
        {
            this.Id = monster.Id;
            this.Name = monster.Name;
            this.Exp = monster.Exp;
            this.HP = monster.HP;
            this.MovementSpeed = monster.MovementSpeed;
            this.SeeingInvisible = monster.SeeingInvisible;
            this.ImageLink = monster.ImageLink;
        }

        public MonsterResponse(MonsterAddRequest monster)
        {
            this.Name = monster.Name;
            this.Exp = monster.Exp;
            this.HP = monster.HP;
            this.MovementSpeed = monster.MovementSpeed;
            this.SeeingInvisible = monster.SeeingInvisible;
            this.ImageLink = monster.ImageLink;
        }

        [Required]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public int Exp { get; set; }
        [Required]
        public int HP { get; set; }
        [Required]
        public int MovementSpeed { get; set; }
        [Required]
        public bool SeeingInvisible { get; set; }
        public string ImageLink { get; set; }
    }
}