using System;
namespace Exercises._3___Behavioral.Section_14___Command
{
    /*
        Implement the Account.Process() method to process different account commands. The rules are obvious:

        - Success indicates whether the operation was successful
        - You can only withdraw money if you have enough in your account

    */

    public class Command
    {
        public enum Action
        {
            Deposit,
            Withdraw
        }

        public Action TheAction;
        public int Amount;
        public bool Success;
    }

    public class Account
    {
        public int Balance { get; set; }

        public void Process(Command c)
        {
            switch (c.TheAction)
            {
                case Command.Action.Deposit:
                    
                    this.Balance    = c.Amount;
                    c.Success       = true;

                    break;

                case Command.Action.Withdraw:
                    
                    if(this.Balance < c.Amount)
                    {
                        c.Success = false;
                        break;
                    }

                    this.Balance    -= c.Amount;
                    c.Success       = true;

                    break;

                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
    }
}
