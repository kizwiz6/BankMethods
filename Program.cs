namespace BankMethods
{
    internal class Program
    {
        // Initialise balance variable
        int balance;

        /// <summary>
        /// allows us to set the startign balance when creating a new SavingsAccount object.
        /// </summary>
        /// <param name="initialBalance">Assigns this parameter to the balance variable.</param>
        public Program(int initialBalance)
        {
            balance = initialBalance;
        }

        /// <summary>
        /// Prints "Hello!" and the value of the balance variable. Gives a way to check the balance of the savings account. The balance variable represents the current amount of money in the account.
        /// </summary>
        public void checkBalance()
        {
            Console.WriteLine("Hello!");
            Console.WriteLine("Your balance is " + balance);
        }

        /// <summary>
        /// Prints a message stating the deposited amount.
        /// </summary>
        /// <param name="amountToDeposit">Updates the balance variable by adding the deposited amount to it.</param>
        public void deposit(int amountToDeposit)
        {
            balance = amountToDeposit + balance;
            Console.WriteLine("You just deposited " + amountToDeposit);
        }

        /// <summary>
        /// Reponsible for subtracting the amountToWithdraw from the balance, pritning a withdrawal message, and returning the amountToWithdraw. Updates the balance by subtracting the amountToWithdraw and then prints a message notifying the user of the withdrawal. Return the amountToWithdraw value.
        /// </summary>
        /// <param name="amountToWithdraw"></param>
        /// <returns></returns>
        public int withdraw(int amountToWithdraw)
        {
            balance = balance - amountToWithdraw;
            Console.WriteLine("You just withdrew " + amountToWithdraw);
            return amountToWithdraw;
        }

        public string toString()
        {
            return "This is a savings account with " + balance + " saved.";
        }

        static void Main(string[] args)
        {
            Program savings = new Program(1000);

            // Check balance:
            savings.withdraw(300);

            //Withdrawing:
            savings.withdraw(300);

            //Check balance:
            savings.checkBalance();

            //Deposit:
            savings.deposit(600);

            //Check balance:
            savings.checkBalance();

            //Deposit:
            savings.deposit(600);

            //Check balance:
            savings.checkBalance();

            Console.WriteLine(savings);
        }
    }
}