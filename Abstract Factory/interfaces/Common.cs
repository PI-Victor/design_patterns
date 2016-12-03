namespace Interfaces
{
    // Abstract Factory
    public abstract class ICreditUnionFactory
    {
        public abstract ISavingsAccount CreateSavingsAccount();
        public abstract ILoanAccount CreateLoanAccount();
    }

    public interface ILoanAccount { }
    public interface ISavingsAccount { }
}