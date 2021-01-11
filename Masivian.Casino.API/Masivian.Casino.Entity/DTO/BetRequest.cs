using Masivian.Casino.Entity.ENUM;
using System.Text.Json.Serialization;

namespace Masivian.Casino.Entity.DTO
{
    public class BetRequest
    {
        #region Properties        
        public string RouletteId { get; set; }
        public BetType Type { get; set; }
        public string Bet { get; set; }
        public double Money { get; set; }
        [JsonIgnore]
        public string User { get; set; }
        #endregion
    }
}