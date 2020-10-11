using System;
using System.Collections.Generic;
using System.Text;

namespace Practic
{
    class User
    {
        public string Name;
        public string SurName;
        public double Money;

        public User(string name,string surname,int money)
        {
            Name = name;
            SurName = surname;
            Money = money;
        }
        public void ReduceBalance(double price)
        {
            Money -= price;
        }
    }
}
