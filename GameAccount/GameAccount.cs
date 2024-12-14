using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course_work
{
    public abstract class GameAccount
    {
        public string UserName { get; set; }
        public string UserPassword { get; set; }
        public static int Id = 0;
        public string AccountType { get; set; }

        public int CurrentRating
        {
            get => _currentRating;
            set => _currentRating = value < 0 ? 1 : value;
        }
        private int _currentRating;

        protected GameAccount(string userName, string userPassword,string accountType )
        {
            Id++;
            UserName = userName;
            UserPassword = userPassword;
            CurrentRating = 10;
            AccountType = accountType;
        } 
    }
    public class StandardAccount : GameAccount
    {
        public StandardAccount(string userName, string userPassword, string accountType) : base(userName, userPassword, accountType) { }
    }
}
