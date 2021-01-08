using System;
namespace Masivian.Casino.Entity
{
    public class ColorBet : Bet
    {
        #region Properties
        public string Color { get; }
        #endregion
        #region Constructor
        public ColorBet(string user, DateTime date, double money, string color)
            : base(user, date, money)
        {
            this.Color = color;
        }
        #endregion
    }
}