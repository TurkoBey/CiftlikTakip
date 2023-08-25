using CiftlikTakip.Model.Entities;
using Infrastructure.DataAccess.Interfaces;

namespace CiftlikTakip.DataAccess.Interfaces
{
    public interface IFTeamRepository : IBaseRepository<FTeam>
    {
        Task<FTeam> GetByIdAsync(Guid Id, params string[] includeList);
    }
}
