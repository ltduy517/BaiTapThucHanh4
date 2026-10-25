using System;
using System.Text;
namespace buoc5
{
    public class BankAccount
    {
        private string accountNumber;
        private double balance;
        public string AccountNumber
        {
            get { return accountNumber; }
        }
        public double Balance
        {
            get { return balance; }
            set
            {
                if (value < 50000)
                {
                    Console.WriteLine("So du khong duoc nho hon 50,000!");
                }
                else
                {
                    balance = value;
                }
            }
        }
        public BankAccount(string accountNumber, double initialBalance)
        {
            this.accountNumber = accountNumber;
            this.Balance = initialBalance;
        }
        public void Deposit(double amount)
        {
            if (amount > 0)
            {
                balance += amount;
                Console.WriteLine($"Da nap: {amount}. So du hien tai: {balance}");
            }
            else
            {
                Console.WriteLine("So tien nap khong hop le!");
            }
        }
        public void Withdraw(double amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("So tien rut khong hop le!");
            }
            else if (amount > balance)
            {
                Console.WriteLine("SO du khong du de thuc hien giao dich!");
            }
            else if (balance - amount < 50000)
            {
                Console.WriteLine("Khong the rut!So du toi thieu de duy tri tai khoang phai tu 50,000.");
            }
            else
            {
                balance -= amount;
                Console.WriteLine($"Da rut: {amount}. So du hien taii: {balance}");
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            BankAccount acc = new BankAccount("123456", 100000);
            Console.WriteLine("SO du: " + acc.Balance);
            acc.Deposit(50000);
            acc.Withdraw(20000);
            acc.Withdraw(200000);

            Console.ReadLine();
        }
    }
}