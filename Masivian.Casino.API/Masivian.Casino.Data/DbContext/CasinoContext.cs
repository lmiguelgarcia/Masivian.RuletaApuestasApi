using Masivian.Casino.Data.DbContext.Interfaces;
using StackExchange.Redis;
namespace Masivian.Casino.Data.DbContext
{
    public class CasinoContext : ICasinoContext
    {
        #region Properties
        private readonly ConnectionMultiplexer _redisConnection;
        #endregion

        #region Constructor
        public CasinoContext(ConnectionMultiplexer redisConnection)
        {
            _redisConnection = redisConnection;
            RedisDatabase = redisConnection.GetDatabase();
            RedisServer = redisConnection.GetServer(redisConnection.Configuration);
        }
        #endregion

        #region Methods
        public IDatabase RedisDatabase { get; }
        public IServer RedisServer { get; }
        #endregion
    }
}