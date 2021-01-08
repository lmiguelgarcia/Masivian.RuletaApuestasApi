using System;
namespace Masivian.Casino.Entity
{
    public class Bet
    {
        #region Properties
        public string User { get; }
        public DateTime Date { get; }
        public double Money { get; }
        public bool IsWinner { get; set; }
        #endregion
        #region Constructor
        public Bet(string user, DateTime date, double money)
        {
            this.User = user;
            this.Date = date;
            this.Money = money;
        }
        #endregion
    }
}