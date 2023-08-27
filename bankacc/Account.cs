namespace BankAccount
{
    class Account
    {
        public string FirstName { get; }
        public string LastName { get; }
        public decimal Balance {get; set;}

        public Account(string firstname, string lastname, decimal balance) {
            FirstName = firstname;
            LastName = lastname;
            Balance = balance;
        }

        public override string ToString()
        {
            return $"name: {FirstName} {LastName}, balance: {Balance:C2}";
        }

        public virtual void Deposit(decimal deposit) {
            Balance += deposit;
            Console.WriteLine($"deposit {deposit:C2}, balance: {Balance:C2}");
        }

        public virtual void Withdraw(decimal withdraw) {
            Balance -= withdraw;
            Console.WriteLine($"withdraw {withdraw:C2}, balance: {Balance:C2}");
        }
    }
}