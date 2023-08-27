using BankAccount;

SavingAccount sa = new SavingAccount("Jane", "Doe", 400m, 3m);

Console.WriteLine(sa);

sa.Deposit(100);

sa.Withdraw(100);
sa.Withdraw(100);
sa.Withdraw(100);
sa.Withdraw(100);
sa.Withdraw(100);

sa.Deposit(500);

Console.WriteLine(sa);

sa.ApplyInterest();