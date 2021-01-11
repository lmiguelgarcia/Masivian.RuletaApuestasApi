using Masivian.Casino.Entity.DTO;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Masivian.Casino.Business.Interfaces
{
    public interface ICasinoBusiness
    {
        Task<string> CreateRouletteAsync();
        Task<string> OpenRouletteByIdAsync(string id);
        Task<string> CreateBet(BetRequest betRequest);
        Task<RouletteResult> ClosedRouletteById(string id);
        Task<List<RouletteDetail>> GetRoulettes();
    }
}