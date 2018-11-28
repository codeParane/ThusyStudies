using System;

namespace ObjectOrientedProgramming
{
    /* Encapsulation : the Internal representation of an object is hidden from the view
    outside object’s definition. Only the required information can be accessed whereas 
    the rest of the data implementation is hidden. */
    class BankServer
    {
        private string serverIp = "192.168.1.1";
        // private int serverPort = 3030;
        private string authorizedUser = "Banker";

        //setter
        public void setServerIp(string _authorizedUser, string _serverIp)
        {
            if (authorizedUser == _authorizedUser)
            {
                serverIp = _serverIp;
            }
            else
            {
                Console.WriteLine("Cant set the variable, Youre not authorized!!!");
            }

        }
        //getter
        public string getServerIp(string _authorizedUser)
        {
            if (authorizedUser == _authorizedUser)
            {
                return serverIp;
            }
            else
            {
                return "192.168.1.0";
            }
        }
    }

    class Account
    {
        class Credentials
        {
            private int accessCode = 2304;
            public void returnBalance()
            {
                Console.WriteLine("54,000.00");
                Console.WriteLine("Access Code is : " + accessCode);
            }
        }
        public Account()
        {
            Credentials c1 = new Credentials();
            c1.returnBalance();
        }
    }
}