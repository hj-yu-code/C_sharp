using System;
using Bank;

namespace ch07
{
    class BankMain
    {
        static void Main(string[] args)
        {
            BankAccount a1 = new BankAccount();
            a1.setName("kim");
            Console.WriteLine("{0}, {1} ", a1.getName(), a1.getBalance());

            a1.Deposit(10000);
            Console.WriteLine("{0}, {1} ", a1.getName(), a1.getBalance());

            a1.Withdraw(4000);
            Console.WriteLine("{0}, {1} ", a1.getName(), a1.getBalance());

            a1.Withdraw(40000);
            Console.WriteLine("{0}, {1} ", a1.getName(), a1.getBalance());
        }
    }
}
