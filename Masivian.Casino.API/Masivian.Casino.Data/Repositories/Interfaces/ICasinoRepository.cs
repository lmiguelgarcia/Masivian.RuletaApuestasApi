using Masivian.Casino.Entity;
using System.Collections.Generic;
using System.Threading.Tasks;
namespace Masivian.Casino.Data.Repositories.Interfaces
{
    public interface ICasinoRepository
    {
        Task<Roulette> GetRouletteById(string id);
        Task<Roulette> UpdateRoulette(Roulette roulette);
        Task<List<Roulette>> GetRoulettes();
    }
}