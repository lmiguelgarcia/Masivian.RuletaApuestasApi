﻿using System.Text.Json.Serialization;

namespace Masivian.Casino.Entity.DTO
{
    public class BetRequest
    {
        #region Properties
        public enum BetType
        {
            Numerical = 1,
            Color = 2
        }
        public string RouletteId { get; set; }
        public BetType Type { get; set; }
        public string Bet { get; set; }
        public double Money { get; set; }
        [JsonIgnore]
        public string User { get; set; }
        #endregion
    }
}