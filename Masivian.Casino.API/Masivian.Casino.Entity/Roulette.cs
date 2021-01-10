using System;
using System.Collections.Generic;
namespace Masivian.Casino.Entity
{
    public class Roulette
    {
        #region Properties
        public enum StatusRoulette
        {
            Created,
            Opened,
            Closed
        };
        public string Id { get; }
        public StatusRoulette Status { get; set; }
        public DateTime OpeningDate { get; set; }
        public DateTime ClosingDate { get; set; }
        public List<Bet> Bets { get; set; }
        public int WinnerNumber { get; set; }
        #endregion
        #region Constructor
        public Roulette(string id)
        {
            this.Id = id;
        }
        #endregion
    }
}