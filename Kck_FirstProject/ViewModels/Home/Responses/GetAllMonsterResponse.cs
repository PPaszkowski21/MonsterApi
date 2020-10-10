using Kck_FirstProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Kck_FirstProject.ViewModels.Home.Responses
{
    public class GetAllMonsterResponse
    {
        public List<MonsterResponse> Monsters { get; set; }
    }
}