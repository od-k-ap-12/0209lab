using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0209lab
{
    class Program
    {
        static bool CreateCreditCard()
        {

            try
            {
                Console.WriteLine("Enter card number: ");
                string cardnumber = Console.ReadLine();
                if (cardnumber.All(char.IsDigit) == false)
                {
                    throw new Exception("Card number doesn't allow anything except numbers");
                }
                if (cardnumber.Length !=16)
                {
                    throw new Exception("Invalid card number length");
                }

                Console.WriteLine("Enter first name: ");
                string firstname = Console.ReadLine();

                if (firstname.All(char.IsDigit) == true)
                {
                    throw new Exception("First name doesn't allow numbers");
                }
                if (!Char.IsUpper(firstname[0]))
                {
                    throw new Exception("First letter should be uppercase");
                }
                for(int i = 1; i < firstname.Length; i++)
                {
                    if (Char.IsUpper(firstname[i]))
                    {
                        throw new Exception("All letters except for the first one should be lowercase");
                    }
                }


                Console.WriteLine("Enter last name: ");
                string lastname = Console.ReadLine();

                if (firstname.All(char.IsDigit) == true)
                {
                    throw new Exception("First name doesn't allow numbers");
                }
                if (!Char.IsUpper(firstname[0]))
                {
                    throw new Exception("First letter should be uppercase");
                }
                for (int i = 1; i < firstname.Length; i++)
                {
                    if (Char.IsUpper(firstname[i]))
                    {
                        throw new Exception("All letters except for the first one should be lowercase");
                    }
                }

                Console.WriteLine("Enter CVC: ");
                string CVC = Console.ReadLine();
                if (CVC.All(char.IsDigit) == false)
                {
                    throw new Exception("CVC doesn't allow anything except numbers");
                }
                if (CVC.Length > 3 || CVC.Length <= 0)
                {
                    throw new Exception("Invalid CVC length");
                }

                Console.WriteLine("Enter the expiration date(month): ");
                string expirationmonth = Console.ReadLine();
                if (expirationmonth.All(char.IsDigit) == false)
                {
                    throw new Exception("Date doesn't allow anything except numbers");
                }
                if (expirationmonth.Length > 2 || expirationmonth.Length <= 0)
                {
                    throw new Exception("Invalid date length");
                }

                Console.WriteLine("Enter the expiration date(year): ");
                string expirationyear = Console.ReadLine();
                if (expirationyear.All(char.IsDigit) == false)
                {
                    throw new Exception("Date doesn't allow anything except numbers");
                }
                if (expirationyear.Length > 4 || expirationyear.Length <= 0)
                {
                    throw new Exception("Invalid date length");
                }
                var dateNow = DateTime.Now;
                var dateResult = new DateTime(Convert.ToInt32(expirationyear), Convert.ToInt32(expirationmonth), 1,0,0,0);
                if(DateTime.Compare(dateResult, dateNow)>0)
                {
                    throw new Exception("This credit card is expired");
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
            Console.WriteLine("Credit card was successfully created.");
            return true;
        }

        static void Main(string[] args)
        {
            do
            {
                CreateCreditCard();
            }
            while (CreateCreditCard() == false);
        }
    }
}

