namespace Course
{
	public class Account
	{
		public int Number { get; private set; }
		public double Balance { get; private set; }
		public string Holder { get; protected set; }

		public Account()
		{

		}

		public Account(int number, string holder, double balance)
		{
			this.Number = number;
			this.Balance = balance;
			this.Holder = holder;
		}

		public void WithDraw(double amount) => this.Balance -= amount;
		public void Deposit(double amount) => this.Balance += amount;

	}

	public class BusinessAccount : Account
	{
		public double LoanLimit { get; set; }

		public BusinessAccount(){}

		public BusinessAccount(int number, string holder, double balance, double loanLimit) : base(number, holder, balance)
		{
			this.LoanLimit = loanLimit;
		}
		public void Loan(double amount)
		{
			this.Balance += amount;
		}
	}
}