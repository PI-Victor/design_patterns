using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// Example for the factory method pattern.
// Define an interface for creating an object, but let subclasses decide
// which class to instantiate. Factory Method lets a class defer 
// instantiation to subclasses.
namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            var factory = new SavingsAcctFactory() as ICreditUnionFactory;
            var citiAcct = factory.GetSavingsAccount("CITI-321");
            var nationalAcct = factory.GetSavingsAccount("NATIONAL-987");
            Console.WriteLine($"My citi balance is ${citiAcct.Balance}" + 
                $" and national balace is ${nationalAcct.Balance}");

        }
    }

    // Product - defines the interface of objects the factory method 
    // creates.
    public abstract class ISavingsAccount
    {
        public decimal Balance { get; set; }

    }

    // Concrete product - implements the Product interface, or in this
    // inherits from the Product.
    public class CitiSavingsAcct : ISavingsAccount
    {
        public CitiSavingsAcct()
        {
            Balance = 5000;
        }
    }

    // Concrete Product 2
    public class NationalSavingsAcct : ISavingsAccount
    {
        public NationalSavingsAcct()
        {
            Balance = 2000;
        }
    }

    // Creator - declares the factory method, which returns an object of type Product.
    // in this case, ISavingsAccount.
    interface ICreditUnionFactory
    {
        ISavingsAccount GetSavingsAccount(string acctNo);
    }

    // Concrete Creator - overrides the factory method to return an instance of a 
    // concrete product.
    public class SavingsAcctFactory : ICreditUnionFactory
    {
        public ISavingsAccount GetSavingsAccount(string acctNo)
        {
            // The essence of the factory method. This contains the logic that 
            // determines which type is going to be returned.
            if (acctNo.Contains("CITI")) { return new CitiSavingsAcct(); }
            else
            if (acctNo.Contains("NATIONAL")) { return new NationalSavingsAcct(); }
            else
                throw new ArgumentException("Invalid Account Number");
        }
    }
}
