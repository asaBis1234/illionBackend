using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Illion0.Entities
{


    [Table("CustomerAccount")]
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

    [NotMapped]
    public class Customer
    {
        public string customerId { get; set; }
        public string encryptionKey { get; set; }
    }

    [Table("CustomerAccounts")]
    public class Accounts
    {
        
        [Key]
        public string TaxPayerId { get; set; }

        public string institution { get; set; }
        public List<Account> accounts { get; set; }
        public string user_token { get; set; }
        public string referral_code { get; set; }
        public Customer customer { get; set; }
        public string dataRequestLink { get; set; }
    }

    [NotMapped]
    public class ReqAccount
    {
        public string customerId { get; set; }
        public string encryptionKey { get; set; }
    }
}
