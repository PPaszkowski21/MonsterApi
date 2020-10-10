using Kck_FirstProject.Models;
using Kck_FirstProject.ViewModels.Home.Requests;
using Kck_FirstProject.ViewModels.Home.Responses;
using System.Collections.Generic;

namespace Kck_FirstProject.Services
{
    public interface IMonsterService
    {
        ServiceResponse Add(MonsterAddRequest Monster);
        ServiceResponse<IEnumerable<MonsterResponse>> Read();
        ServiceResponse<MonsterResponse> ReadById(int id);
        ServiceResponse Update(MonsterUpdateRequest monster);
        ServiceResponse Delete(int id);
    }
}
