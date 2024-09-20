namespace App_banks_accounts.Models
{
    public class BankAccount
    {
        public int BankAccountId { get; set; }

        public string AccountNumber { get; set; }

        public string AccountType { get; set; }

        public decimal Balance { get; set; }

        public int AccountHolderId { get; set; }

        public virtual AccountHolder AccountHolder { get; set; }

    }
}
