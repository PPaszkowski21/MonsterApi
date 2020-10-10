using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Kck_FirstProject.ViewModels.Home.Requests
{
    public class MonsterUpdateRequest
    {
        [Required]
        public int Id { get; set; }
        public string Name { get; set; }
        public int? Exp { get; set; }
        public int? HP { get; set; }
        public int? MovementSpeed { get; set; }
        public bool? SeeingInvisible { get; set; }
    }
}