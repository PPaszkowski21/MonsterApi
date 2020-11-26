using Kck_FirstProject.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Kck_FirstProject.ViewModels.Home.Requests
{
    public class MonsterAddRequest
    {
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