using StackExchange.Redis;
namespace Masivian.Casino.Data.DbContext.Interfaces
{
    public interface ICasinoContext
    {
        IDatabase Redis { get; }
    }
}