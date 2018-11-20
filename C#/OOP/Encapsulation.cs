using System;

namespace OOP
{
    //private Access Modifier
    class atmAccount
    {
        private int atmPin = 2304;

        public bool getPin(int _atmPin)
        {
            if (atmPin == _atmPin)
                return true;
            else
                return false;

        }
    }
    
    //nested Class
    class BankSync
    {
        public bool isServerConnect;
        class SyncToServer
        {
            private int bankAccessCode = 1105;
            private bool connectToServer(int _bankAccessCode)
            {
                if (bankAccessCode == _bankAccessCode)
                    return true;
                else
                    return false;
            }
            SyncToServer()
            {
                BankSync b1 = new BankSync();
                b1.isServerConnect = connectToServer(11);
            }
        }
    }


}
