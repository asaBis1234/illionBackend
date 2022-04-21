namespace Illion0.Entities
{
   

    public class Account
    {
        public string accountHolder { get; set; }
        public string name { get; set; }
        public string accountNumber { get; set; }
        public int id { get; set; }
        public string bsb { get; set; }
        public string balance { get; set; }
        public string available { get; set; }
        public string accountHolderType { get; set; }
        public string accountType { get; set; }
        public string interestRate { get; set; }
    }

    public class Customer
    {
        public string customerId { get; set; }
        public string encryptionKey { get; set; }
    }

    public class Accounts
    {
        public List<Account> accounts { get; set; }
        public string user_token { get; set; }
        public string referral_code { get; set; }
        public Customer customer { get; set; }
        public string dataRequestLink { get; set; }
    }


    public class ReqAccount
    {
        public string customerId { get; set; }
        public string encryptionKey { get; set; }
    }
}
