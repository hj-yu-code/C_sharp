using System;

namespace Bank
{
    class BankAccount
    {
        private decimal balance;
        private string name;

        public BankAccount()
        {
            name = "noName";
            balance = 0;
        }
        public void setName(string _name)
        {
            name = _name;
        }
        public string getName()
        {
            return name;
        }
        public decimal getBalance()
        {
            return balance;
        }
        public void Deposit(int _n)
        {
            balance += _n;
        }
        public void Withdraw(int _n)
        {
            if(balance < _n)
            {
                Console.WriteLine("잔고부족, 현재잔고 : {0}", balance);
                return;
            }
            balance -= _n;
        }


    }
}
