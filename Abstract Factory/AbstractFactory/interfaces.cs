namespace Interfaces
{
    public abstract class ICreditUnionFactory 
    {
        public abstract ISavingsAccount CreateSavingsAccount();
        public abstract ILoanAccount CreateLoanAccount();
    }

    public interface ISavingsAccount { }
    public interface ILoanAccount { }
}