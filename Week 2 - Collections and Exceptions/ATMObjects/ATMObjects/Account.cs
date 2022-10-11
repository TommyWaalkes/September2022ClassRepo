using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMObjects
{
    public class Account
    {
        public string Name { get; set; }
        public string Password { get; set; }
        public int Balance { get; set; }

        public Account(string Name, string Password, int Balance)
        {
            this.Name = Name;
            this.Password = Password;
            this.Balance = Balance;
        }
    }
}
