using System;
using System.Collections.Generic;
namespace Masivian.Casino.Entity
{
    public class Roulette
    {
        #region Properties
        public string Id { get; }
        public string State { get; set; }
        public DateTime OpeningDate { get; }
        public DateTime ClosingDate { get; set; }
        public List<Bet> Bets { get; set; }
        public int WinnersNumber { get; set; }
        #endregion
        #region Constructor
        public Roulette(string id, string state, DateTime openingDate)
        {
            this.Id = id;
            this.State = state;
            this.OpeningDate = openingDate;
            this.Bets = new List<Bet>();
        }
        #endregion
    }
}