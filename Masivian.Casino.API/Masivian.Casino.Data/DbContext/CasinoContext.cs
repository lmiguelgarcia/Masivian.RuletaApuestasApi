using Masivian.Casino.Data.DbContext.Interfaces;
using StackExchange.Redis;
namespace Masivian.Casino.Data.DbContext
{
    public class CasinoContext : ICasinoContext
    {
        private readonly ConnectionMultiplexer _redisConnection;
        public CasinoContext(ConnectionMultiplexer redisConnection)
        {
            _redisConnection = redisConnection;
            Redis = redisConnection.GetDatabase();
        }
        public IDatabase Redis { get; }
    }
}