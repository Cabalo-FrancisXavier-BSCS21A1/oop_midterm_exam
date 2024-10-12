namespace ConsoleApp1.Exam
{
    // Encapsulation Example
    public class BankAccount
    {
        public decimal Balance { get; private set; }

        public void Deposit(decimal amount)
        {
            Balance += amount;
        }

        public string Withdraw(decimal amount)
        {
            if (Balance >= amount)
            {
                Balance -= amount;
                return "Success"; // You can keep this message or modify it if needed
            }
            return "Insufficient funds."; // Added a period here
        }

        public void Transfer(BankAccount target, decimal amount)
        {
            if (this.Balance >= amount)
            {
                Withdraw(amount);
                target.Deposit(amount);
            }
        }
    }
}