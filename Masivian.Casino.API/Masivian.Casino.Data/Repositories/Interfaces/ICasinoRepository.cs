using Masivian.Casino.Entity;
using System.Threading.Tasks;
namespace Masivian.Casino.Data.Repositories.Interfaces
{
    public interface ICasinoRepository
    {
        Task<Roulette> GetRoulette(string id);
        Task<Roulette> UpdateRoulette(Roulette roulette);
    }
}