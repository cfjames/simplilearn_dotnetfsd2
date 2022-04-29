using System;

namespace Phase1Section6._6
{
    interface IBank
    {
        decimal Balance { get;}
        string Deposit(decimal amount);
        string Withdraw(decimal amount);
        
    }

    //In a real world scenario this would be a privately accessible via an API on the Bank Servers
    class Bank : IBank
    {
        public decimal Balance { get; private set; }
        public string Deposit(decimal amount)
        {
            Balance += amount;
            return "Current Balance = " + Balance.ToString("C");
        }
        public string Withdraw(decimal amount) 
        {
            if ((Balance - amount) >= 0)
            {
                Balance -= amount;
                return "Current Balance = " + Balance.ToString("C");
            }
            else
                return "Insufficent Funds";
        }

        //Various Methods to validate Customer and Account go here
        
    }

    class ATM : IBank
    {
        //In a real world scenario this would make a remote connection to Bank Servers
        private Bank _bank = new Bank();
        private bool _cardValidated = false;

        public decimal Balance
        {
            get
            {
                if (_cardValidated)
                    return _bank.Balance;
                else
                    throw new Exception("Please insert your Card and enter your Pin");          
            }
        }

        public string Deposit(decimal amount)
        {
            if (_cardValidated)
                return _bank.Deposit(amount);
            else
                throw new Exception("Please insert your Card and enter your Pin");

        }
        public string Withdraw(decimal amount)
        {
            if (_cardValidated)
                return _bank.Withdraw(amount);
            else
                throw new Exception("Please insert your Card and enter your Pin");
        }

        public string ValidateBankCard(int pin)
        {
            //Simulates card detected or not
            Random rand = new Random();

            if (rand.Next(0, 2) == 0)
                return "Please Insert Valid Card";
            else
            {
                //Simulates pin validation
                if (pin != 123)
                    return "Invalid Card / Pin combination";
                else
                {
                    _cardValidated = true;
                    return "Validated Card and Pin.  Please choose a transaction";
                }
                   

            }
        }
    }

}
