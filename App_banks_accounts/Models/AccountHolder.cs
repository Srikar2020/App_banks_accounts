namespace App_banks_accounts.Models
{
    public class AccountHolder
    {
        public int AccountHolderId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public string PhoneNumber { get; set; }

        public virtual List<BankAccount> BankAccounts { get; set; }

    }
}
