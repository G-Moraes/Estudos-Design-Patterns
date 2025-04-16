namespace Exercises._3___Behavioral.Section_21___State
{
    /*
        A combination lock is a lock that opens after the right digits have been entered. A lock is preprogrammed with a combination (e.g., 12345) and the user is expected to enter this combination to unlock the lock.

        The lock has a Status field that indicates the state of the lock. The rules are:

            - If the lock has just been locked (or at startup), the status is LOCKED.
            - If a digit has been entered, that digit is shown on the screen. As the user enters more digits, they are added to Status.
            - If the user has entered the correct sequence of digits, the lock status changes to OPEN.
            - If the user enters an incorrect sequence of digits, the lock status changes to ERROR.

        Please implement the CombinationLock class to enable this behavior. Be sure to test both correct and incorrect inputs.
    */
    public enum StatusEnum
    {
        OPEN,
        LOCKED,
        ERROR
    }

    public class CombinationLock
    {
        private int[] Combination;
        public StatusEnum status;
        public string Status; 
        
        public CombinationLock(int[] combination)
        {
            Combination = combination;
            status      = StatusEnum.LOCKED;
            Status      = "LOCKED";
        }

        public void EnterDigit(int digit)
        {
            if (Status == "LOCKED" || Status == "ERROR")
            {
                Status = string.Empty;
            }

            Status += digit;

            OperateLock();
        }

        public void OperateLock()
        {
            if(status == StatusEnum.LOCKED)
            {
                if(Combination.Length != Status.Length)
                {
                    return;
                }

                for(int i = 0; i < Combination.Length; i++)
                {
                    int enteredDigit = Status[i] - '0';
                    if (Combination[i] != enteredDigit)
                    {
                        status = StatusEnum.ERROR;
                        Status = "ERROR";
                        return;
                    }
                }

                status = StatusEnum.OPEN;
                Status = "OPEN";
            }
        }
    }
}
