using Masivian.Casino.Data.DbContext.Interfaces;
using Masivian.Casino.Data.Repositories.Interfaces;
using Masivian.Casino.Entity;
using Newtonsoft.Json;
using System;
using System.Threading.Tasks;
namespace Masivian.Casino.Data.Repositories
{
    public class CasinoRepository : ICasinoRepository
    {
        private readonly ICasinoContext _context;

        public CasinoRepository(ICasinoContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public async Task<Roulette> GetRoulette(string id)
        {
            var roulette = await _context
                                .Redis
                                .StringGetAsync(id);
            if (roulette.IsNullOrEmpty)
            {
                return null;
            }
            return JsonConvert.DeserializeObject<Roulette>(roulette);
        }
        public async Task<Roulette> UpdateRoulette(Roulette roulette)
        {
            var updated = await _context
                              .Redis
                              .StringSetAsync(roulette.Id, JsonConvert.SerializeObject(roulette));
            if (!updated)
            {
                return null;
            }
            return await GetRoulette(roulette.Id);
        }
    }
}