using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0209lab
{
    class Creditcard
    {
        private double money;
        private string cardnumber;
        private string firstname;
        private string lastname;
        private DateTime expiration;
        private string CVC;
        public Creditcard(string _cardnumber, string _firstname, string _lastname,DateTime _expiration, string _CVC, double _money)
        {
            cardnumber = _cardnumber;
            firstname = _firstname;
            lastname = _lastname;
            expiration = _expiration;
            CVC = _CVC;
            money = _money;
        }
        public double Money { get => money;}
        public string CardNumber { get => cardnumber; }
        public string FirstName { get => firstname; }
        public string LastName { get => lastname; }
        public DateTime Expiration { get => expiration; }
        public string _CVC { get => CVC; }

        public static Creditcard operator +(Creditcard opl, int op2)
        {
            Creditcard result = opl;
            result.money = opl.money + op2;
            return result;
        }
        public static Creditcard operator -(Creditcard opl, int op2)
        {
            Creditcard result = opl;
            result.money = opl.money - op2;
            return result;
        }
        public static bool operator <(Creditcard op1, Creditcard op2)
        {
            if (op1.money < op2.money)
                return true;
            else
                return false;
        }
        public static bool operator >(Creditcard op1, Creditcard op2)
        {
            if (op1.money > op2.money)
                return true;
            else
                return false;
        }

        public static bool operator ==(Creditcard op1, Creditcard op2)
        {
            if (op1.CVC == op2.CVC)
                return true;
            else
                return false;
        }

        public static bool operator !=(Creditcard op1, Creditcard op2)
        {
            if (op1.CVC != op2.CVC)
                return true;
            else
                return false;
        }

        public void Print()
        {
            Console.WriteLine("Card number: " + cardnumber + "\nFirst name: " + firstname + "\nLast name: " + lastname + "\nExpiration date: " + expiration + "\nCVC:" + CVC + "\n Current balance: " + money);
        }
        public override string ToString()
        {
            return "Card number: " + cardnumber + "\nFirst name: " + firstname + "\nLast name: " + lastname + "\nExpiration date: " + expiration + "\nCVC:" + CVC+"\n Current balance: "+money;
        }
    }
}
