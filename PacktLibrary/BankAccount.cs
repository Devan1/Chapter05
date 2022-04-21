using System;
using System.Collections.Generic;
using System.Text;

namespace Packt.Shared
{
    public class BankAccount
    {
        //each instance of BankAccount wll have its own AccountName and Balance values
        //but all instances will share a single InterestRate value

        public string AccountName;//istance member
        public decimal Balance; // instance member
        public static decimal InterestRate;//shared member
    }
}
