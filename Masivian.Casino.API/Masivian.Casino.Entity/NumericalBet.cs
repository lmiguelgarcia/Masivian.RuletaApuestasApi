using System;
namespace Masivian.Casino.Entity
{
    public class NumericalBet : Bet
    {
        #region Properties
        public int Number { get; }
        #endregion
        #region Constructor
        public NumericalBet(string user, DateTime date, double money, int number)
            : base(user, date, money)
        {
            this.Number = number;
        }
        #endregion
    }
}