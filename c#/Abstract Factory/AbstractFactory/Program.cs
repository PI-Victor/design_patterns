using System;
using System.Collections.Generic;

using Interfaces;
using Providers;


namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> accntNumber = new List<string>
            {
                "CITI-456",
                "NATIONAL-987",
                "CHASE-222",
            };

            for (int i = 0; i < accntNumber.Count; i++)
            {
                ICreditUnionFactory anAbstractFactory = CreditUnionFactoryProvider.GetCreditUnionFactory(accntNumber[i]);
                if (anAbstractFactory == null )
                {
                    Console.WriteLine("This credit union with account number" + 
                        " ' {0} ' is invalid ", (accntNumber[i]));
                }
                else
                {
                    ILoanAccount loan = anAbstractFactory.CreateLoanAccount();
                    ISavingsAccount savings = anAbstractFactory.CreateSavingsAccount();
                }
            }
            Console.ReadLine();
        }
    }
}
