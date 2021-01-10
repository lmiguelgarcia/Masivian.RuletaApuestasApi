using Masivian.Casino.Entity.DTO;
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
        #region Methods
        public override void CheckWinner(int randomWinnerNumber)
        {
            bool isEvenNumber = randomWinnerNumber % 2 == 0;
            bool isEvenColor = Color.Equals("ROJO");
            this.IsWinner = (isEvenNumber && isEvenColor) || (!isEvenNumber && !isEvenColor);
        }
        public override BetResult GetResult()
        {
            double moneyFactor = 1.8;

            return new BetResult()
            {
                BetType = "ColorBet",
                Bet = this.Color,
                MoneyBet = this.Money,
                MoneyWon = this.Money * moneyFactor,
                User = this.User
            };
        }
        #endregion
    }
}