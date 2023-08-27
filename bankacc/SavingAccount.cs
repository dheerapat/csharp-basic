namespace BankAccount
{
    class SavingAccount : Account
    {
        private decimal _interest;
        private int _withdrawcount = 0;
        private const decimal FEE = 2.0m;
        public SavingAccount(string firstname, string lastname, decimal balance, decimal interest): base(firstname, lastname, balance) {
            _interest = interest;
        }

        public override void Withdraw(decimal withdraw)
        {
            if (_withdrawcount >= 3) {
                withdraw += FEE;
                Console.WriteLine($"withdraw more than 3 time, {FEE:C2} fee applied");
            }
            if (withdraw > Balance) {
                Console.WriteLine($"your balance is insufficient");
                return;
            }
            base.Withdraw(withdraw);
            _withdrawcount++;
        }

        public void ApplyInterest() {
            Balance += Balance * _interest/100;
            Console.WriteLine($"name: {FirstName} {LastName}, balance: {Balance:C2}");
        }
    }
}