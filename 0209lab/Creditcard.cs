using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0209lab
{
    class Creditcard
    {
        private string cardnumber;
        private string firstname;
        private string lastname;
        private DateTime expiration;
        private string CVC;
        public Creditcard(string _cardnumber, string _firstname, string _lastname,DateTime _expiration, string _CVC)
        {
            cardnumber = _cardnumber;
            firstname = _firstname;
            lastname = _lastname;
            expiration = _expiration;
            CVC = _CVC;
        }
        public void Print()
        {
            Console.WriteLine("Card number: " + cardnumber + "\nFirst name: " + firstname + "\nLast name: " + lastname + "\nExpiration date: " + expiration + "\nCVC:" + CVC);
        }
        public override string ToString()
        {
            return "Card number: " + cardnumber + "\nFirst name: " + firstname + "\nLast name: " + lastname + "\nExpiration date: " + expiration + "\nCVC:" + CVC;
        }
    }
}
