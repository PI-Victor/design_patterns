namespace Singleton
{
    public class Policy
    {
        // private static readonly object _lock = new object();

        private static readonly Policy _instance = new Policy();
        public static Policy Instance
        {
            get {
                return _instance;
            }
        }
        public Policy() {}

        private int Id { get; set; } = 123;
        private string Insured { get; set; } = "John Roy";

        public string GetInsuredName() => Insured;
    }
}
