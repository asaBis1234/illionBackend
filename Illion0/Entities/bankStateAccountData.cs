using Newtonsoft.Json;
using System.ComponentModel;

namespace Illion0.Entities
{
   

    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    public class DateObj
    {
        public string date { get; set; }
        public int timezone_type { get; set; }
        public string timezone { get; set; }
    }

    public class Detail
    {
        public DateObj dateObj { get; set; }
        public string date { get; set; }
        public string text { get; set; }
        public object notes { get; set; }
        public object transactionHash { get; set; }
        public string hashText { get; set; }
        public double amount { get; set; }
        public string isPending { get; set; }
        public string type { get; set; }
        public string balance { get; set; }
        public List<string> tags { get; set; }
    }

    public class DayEndBalance
    {
        public string date { get; set; }
        public string balance { get; set; }
    }

    public class Total
    {
        public int transactionCount { get; set; }
        public double totalValue { get; set; }
        public double monthAvg { get; set; }
    }

    public class Transaction
    {
        public DateObj dateObj { get; set; }
        public string date { get; set; }
        public string text { get; set; }
        public object notes { get; set; }
        public object transactionHash { get; set; }
        public string hashText { get; set; }
        public double amount { get; set; }
        public string isPending { get; set; }
        public string type { get; set; }
        public string balance { get; set; }
        public List<string> tags { get; set; }
    }

    public class Wages
    {
        public int transactionCount { get; set; }
        public double totalValue { get; set; }
        public double monthAvg { get; set; }
        public string minValue { get; set; }
        public string maxValue { get; set; }
        public string firstTransaction { get; set; }
        public string lastTransaction { get; set; }
        public double period { get; set; }
        public bool periodIsRegular { get; set; }
        public List<Transaction> transactions { get; set; }
    }

    public class Rent
    {
        public int transactionCount { get; set; }
        public int totalValue { get; set; }
        public int monthAvg { get; set; }
        public int minValue { get; set; }
        public int maxValue { get; set; }
        public object firstTransaction { get; set; }
        public object lastTransaction { get; set; }
        public int period { get; set; }
        public bool periodIsRegular { get; set; }
        public List<object> transactions { get; set; }
        public Total total { get; set; }
        //public Rent Rent { get; set; }
    }

    public class Interest
    {
        public int transactionCount { get; set; }
        public int totalValue { get; set; }
        public int monthAvg { get; set; }
        public string minValue { get; set; }
        public string maxValue { get; set; }
        public string firstTransaction { get; set; }
        public string lastTransaction { get; set; }
        public int period { get; set; }
        public bool periodIsRegular { get; set; }
        public List<Transaction> transactions { get; set; }
    }

    public class Income
    {
        public Total total { get; set; }
        public Wages Wages { get; set; }
        public Rent Rent { get; set; }
        public Interest Interest { get; set; }
    }

    public class MaternityPayment
    {
        public int transactionCount { get; set; }
        public int totalValue { get; set; }
        public int monthAvg { get; set; }
        public int minValue { get; set; }
        public int maxValue { get; set; }
        public object firstTransaction { get; set; }
        public object lastTransaction { get; set; }
        public int period { get; set; }
        public bool periodIsRegular { get; set; }
        public List<object> transactions { get; set; }
    }

    public class FamilyBenefits
    {
        public int transactionCount { get; set; }
        public int totalValue { get; set; }
        public int monthAvg { get; set; }
        public int minValue { get; set; }
        public int maxValue { get; set; }
        public object firstTransaction { get; set; }
        public object lastTransaction { get; set; }
        public int period { get; set; }
        public bool periodIsRegular { get; set; }
        public List<object> transactions { get; set; }
    }

    public class SchoolkidsBonus
    {
        public int transactionCount { get; set; }
        public int totalValue { get; set; }
        public int monthAvg { get; set; }
        public int minValue { get; set; }
        public int maxValue { get; set; }
        public object firstTransaction { get; set; }
        public object lastTransaction { get; set; }
        public int period { get; set; }
        public bool periodIsRegular { get; set; }
        public List<object> transactions { get; set; }
    }

    public class ParentingPayment
    {
        public int transactionCount { get; set; }
        public int totalValue { get; set; }
        public int monthAvg { get; set; }
        public int minValue { get; set; }
        public int maxValue { get; set; }
        public object firstTransaction { get; set; }
        public object lastTransaction { get; set; }
        public int period { get; set; }
        public bool periodIsRegular { get; set; }
        public List<object> transactions { get; set; }
    }

    public class CarersBenefits
    {
        public int transactionCount { get; set; }
        public int totalValue { get; set; }
        public int monthAvg { get; set; }
        public int minValue { get; set; }
        public int maxValue { get; set; }
        public object firstTransaction { get; set; }
        public object lastTransaction { get; set; }
        public int period { get; set; }
        public bool periodIsRegular { get; set; }
        public List<object> transactions { get; set; }
    }

    public class YouthAllowance
    {
        public int transactionCount { get; set; }
        public int totalValue { get; set; }
        public int monthAvg { get; set; }
        public int minValue { get; set; }
        public int maxValue { get; set; }
        public object firstTransaction { get; set; }
        public object lastTransaction { get; set; }
        public int period { get; set; }
        public bool periodIsRegular { get; set; }
        public List<object> transactions { get; set; }
    }

    public class Newstart
    {
        public int transactionCount { get; set; }
        public double totalValue { get; set; }
        public double monthAvg { get; set; }
        public string minValue { get; set; }
        public string maxValue { get; set; }
        public string firstTransaction { get; set; }
        public string lastTransaction { get; set; }
        public double period { get; set; }
        public bool periodIsRegular { get; set; }
        public List<Transaction> transactions { get; set; }
    }

    public class Pension
    {
        public int transactionCount { get; set; }
        public int totalValue { get; set; }
        public int monthAvg { get; set; }
        public int minValue { get; set; }
        public int maxValue { get; set; }
        public object firstTransaction { get; set; }
        public object lastTransaction { get; set; }
        public int period { get; set; }
        public bool periodIsRegular { get; set; }
        public List<object> transactions { get; set; }
    }

    public class AusStudy
    {
        public int transactionCount { get; set; }
        public int totalValue { get; set; }
        public int monthAvg { get; set; }
        public int minValue { get; set; }
        public int maxValue { get; set; }
        public object firstTransaction { get; set; }
        public object lastTransaction { get; set; }
        public int period { get; set; }
        public bool periodIsRegular { get; set; }
        public List<object> transactions { get; set; }
    }

    public class Medicare
    {
        public int transactionCount { get; set; }
        public int totalValue { get; set; }
        public int monthAvg { get; set; }
        public int minValue { get; set; }
        public int maxValue { get; set; }
        public object firstTransaction { get; set; }
        public object lastTransaction { get; set; }
        public int period { get; set; }
        public bool periodIsRegular { get; set; }
        public List<object> transactions { get; set; }
    }

    public class Other
    {
        public int transactionCount { get; set; }
        public int totalValue { get; set; }
        public int monthAvg { get; set; }
        public int minValue { get; set; }
        public int maxValue { get; set; }
        public object firstTransaction { get; set; }
        public object lastTransaction { get; set; }
        public int period { get; set; }
        public bool periodIsRegular { get; set; }
        public List<object> transactions { get; set; }
    }

    public class Benefits
    {
        public Total total { get; set; }

        [JsonProperty("Maternity Payment")]
        public MaternityPayment MaternityPayment { get; set; }

        [JsonProperty("Family Benefits")]
        public FamilyBenefits FamilyBenefits { get; set; }

        [JsonProperty("Schoolkids Bonus")]
        public SchoolkidsBonus SchoolkidsBonus { get; set; }

        [JsonProperty("Parenting Payment")]
        public ParentingPayment ParentingPayment { get; set; }

        [JsonProperty("Carers Benefits")]
        public CarersBenefits CarersBenefits { get; set; }

        [JsonProperty("Youth Allowance")]
        public YouthAllowance YouthAllowance { get; set; }
        public Newstart Newstart { get; set; }
        public Pension Pension { get; set; }
        public AusStudy AusStudy { get; set; }
        public Medicare Medicare { get; set; }
        public Other Other { get; set; }
    }

    public class Overdrawn
    {
        public int transactionCount { get; set; }
        public int totalValue { get; set; }
        public int monthAvg { get; set; }
        public int minValue { get; set; }
        public int maxValue { get; set; }
        public object firstTransaction { get; set; }
        public object lastTransaction { get; set; }
        public int period { get; set; }
        public bool periodIsRegular { get; set; }
        public List<object> transactions { get; set; }
    }

    public class Dishonour
    {
        public int transactionCount { get; set; }
        public int totalValue { get; set; }
        public int monthAvg { get; set; }
        public int minValue { get; set; }
        public int maxValue { get; set; }
        public object firstTransaction { get; set; }
        public object lastTransaction { get; set; }
        public int period { get; set; }
        public bool periodIsRegular { get; set; }
        public List<object> transactions { get; set; }
    }

    public class Return
    {
        public int transactionCount { get; set; }
        public int totalValue { get; set; }
        public int monthAvg { get; set; }
        public int minValue { get; set; }
        public int maxValue { get; set; }
        public object firstTransaction { get; set; }
        public object lastTransaction { get; set; }
        public int period { get; set; }
        public bool periodIsRegular { get; set; }
        public List<object> transactions { get; set; }
    }

    public class Reversal
    {
        public int transactionCount { get; set; }
        public double totalValue { get; set; }
        public double monthAvg { get; set; }
        public string minValue { get; set; }
        public string maxValue { get; set; }
        public string firstTransaction { get; set; }
        public string lastTransaction { get; set; }
        public double period { get; set; }
        public bool periodIsRegular { get; set; }
        public List<Transaction> transactions { get; set; }
    }

    public class Dishonours
    {
        public Total total { get; set; }
        public Overdrawn Overdrawn { get; set; }
        public Dishonour Dishonour { get; set; }
        public Return Return { get; set; }
        public Reversal Reversal { get; set; }
    }

    public class AmazingLoans
    {
        public int transactionCount { get; set; }
        public int totalValue { get; set; }
        public int monthAvg { get; set; }
        public int minValue { get; set; }
        public int maxValue { get; set; }
        public object firstTransaction { get; set; }
        public object lastTransaction { get; set; }
        public int period { get; set; }
        public bool periodIsRegular { get; set; }
        public List<object> transactions { get; set; }
    }

    public class AMXMoney
    {
        public int transactionCount { get; set; }
        public int totalValue { get; set; }
        public int monthAvg { get; set; }
        public int minValue { get; set; }
        public int maxValue { get; set; }
        public object firstTransaction { get; set; }
        public object lastTransaction { get; set; }
        public int period { get; set; }
        public bool periodIsRegular { get; set; }
        public List<object> transactions { get; set; }
    }

    public class AusFinancial
    {
        public int transactionCount { get; set; }
        public int totalValue { get; set; }
        public int monthAvg { get; set; }
        public int minValue { get; set; }
        public int maxValue { get; set; }
        public object firstTransaction { get; set; }
        public object lastTransaction { get; set; }
        public int period { get; set; }
        public bool periodIsRegular { get; set; }
        public List<object> transactions { get; set; }
    }

    public class Aussie
    {
        public int transactionCount { get; set; }
        public int totalValue { get; set; }
        public int monthAvg { get; set; }
        public int minValue { get; set; }
        public int maxValue { get; set; }
        public object firstTransaction { get; set; }
        public object lastTransaction { get; set; }
        public int period { get; set; }
        public bool periodIsRegular { get; set; }
        public List<object> transactions { get; set; }
    }

    public class AussieCash
    {
        public int transactionCount { get; set; }
        public int totalValue { get; set; }
        public int monthAvg { get; set; }
        public int minValue { get; set; }
        public int maxValue { get; set; }
        public object firstTransaction { get; set; }
        public object lastTransaction { get; set; }
        public int period { get; set; }
        public bool periodIsRegular { get; set; }
        public List<object> transactions { get; set; }
    }

    public class Baycorp
    {
        public int transactionCount { get; set; }
        public int totalValue { get; set; }
        public int monthAvg { get; set; }
        public int minValue { get; set; }
        public int maxValue { get; set; }
        public object firstTransaction { get; set; }
        public object lastTransaction { get; set; }
        public int period { get; set; }
        public bool periodIsRegular { get; set; }
        public List<object> transactions { get; set; }
    }

    public class CannonFinance
    {
        public int transactionCount { get; set; }
        public int totalValue { get; set; }
        public int monthAvg { get; set; }
        public int minValue { get; set; }
        public int maxValue { get; set; }
        public object firstTransaction { get; set; }
        public object lastTransaction { get; set; }
        public int period { get; set; }
        public bool periodIsRegular { get; set; }
        public List<object> transactions { get; set; }
    }

    public class CashAdvance
    {
        public int transactionCount { get; set; }
        public int totalValue { get; set; }
        public int monthAvg { get; set; }
        public int minValue { get; set; }
        public int maxValue { get; set; }
        public object firstTransaction { get; set; }
        public object lastTransaction { get; set; }
        public int period { get; set; }
        public bool periodIsRegular { get; set; }
        public List<object> transactions { get; set; }
    }

    public class CashConverters
    {
        public int transactionCount { get; set; }
        public int totalValue { get; set; }
        public int monthAvg { get; set; }
        public int minValue { get; set; }
        public int maxValue { get; set; }
        public object firstTransaction { get; set; }
        public object lastTransaction { get; set; }
        public int period { get; set; }
        public bool periodIsRegular { get; set; }
        public List<object> transactions { get; set; }
    }

    public class CashDoctors
    {
        public int transactionCount { get; set; }
        public int totalValue { get; set; }
        public int monthAvg { get; set; }
        public int minValue { get; set; }
        public int maxValue { get; set; }
        public object firstTransaction { get; set; }
        public object lastTransaction { get; set; }
        public int period { get; set; }
        public bool periodIsRegular { get; set; }
        public List<object> transactions { get; set; }
    }

    public class CashFirst
    {
        public int transactionCount { get; set; }
        public int totalValue { get; set; }
        public int monthAvg { get; set; }
        public int minValue { get; set; }
        public int maxValue { get; set; }
        public object firstTransaction { get; set; }
        public object lastTransaction { get; set; }
        public int period { get; set; }
        public bool periodIsRegular { get; set; }
        public List<object> transactions { get; set; }
    }

    public class CashInAFlash
    {
        public int transactionCount { get; set; }
        public int totalValue { get; set; }
        public int monthAvg { get; set; }
        public int minValue { get; set; }
        public int maxValue { get; set; }
        public object firstTransaction { get; set; }
        public object lastTransaction { get; set; }
        public int period { get; set; }
        public bool periodIsRegular { get; set; }
        public List<object> transactions { get; set; }
    }

    public class CashMoney
    {
        public int transactionCount { get; set; }
        public int totalValue { get; set; }
        public int monthAvg { get; set; }
        public int minValue { get; set; }
        public int maxValue { get; set; }
        public object firstTransaction { get; set; }
        public object lastTransaction { get; set; }
        public int period { get; set; }
        public bool periodIsRegular { get; set; }
        public List<object> transactions { get; set; }
    }

    public class CashNow
    {
        public int transactionCount { get; set; }
        public int totalValue { get; set; }
        public int monthAvg { get; set; }
        public int minValue { get; set; }
        public int maxValue { get; set; }
        public object firstTransaction { get; set; }
        public object lastTransaction { get; set; }
        public int period { get; set; }
        public bool periodIsRegular { get; set; }
        public List<object> transactions { get; set; }
    }

    public class CashOz
    {
        public int transactionCount { get; set; }
        public int totalValue { get; set; }
        public int monthAvg { get; set; }
        public int minValue { get; set; }
        public int maxValue { get; set; }
        public object firstTransaction { get; set; }
        public object lastTransaction { get; set; }
        public int period { get; set; }
        public bool periodIsRegular { get; set; }
        public List<object> transactions { get; set; }
    }

    public class CashSolutions
    {
        public int transactionCount { get; set; }
        public int totalValue { get; set; }
        public int monthAvg { get; set; }
        public int minValue { get; set; }
        public int maxValue { get; set; }
        public object firstTransaction { get; set; }
        public object lastTransaction { get; set; }
        public int period { get; set; }
        public bool periodIsRegular { get; set; }
        public List<object> transactions { get; set; }
    }

    public class CashSmart
    {
        public int transactionCount { get; set; }
        public int totalValue { get; set; }
        public int monthAvg { get; set; }
        public int minValue { get; set; }
        public int maxValue { get; set; }
        public object firstTransaction { get; set; }
        public object lastTransaction { get; set; }
        public int period { get; set; }
        public bool periodIsRegular { get; set; }
        public List<object> transactions { get; set; }
    }

    public class CashStop
    {
        public int transactionCount { get; set; }
        public int totalValue { get; set; }
        public int monthAvg { get; set; }
        public int minValue { get; set; }
        public int maxValue { get; set; }
        public object firstTransaction { get; set; }
        public object lastTransaction { get; set; }
        public int period { get; set; }
        public bool periodIsRegular { get; set; }
        public List<object> transactions { get; set; }
    }

    public class CashToday
    {
        public int transactionCount { get; set; }
        public int totalValue { get; set; }
        public int monthAvg { get; set; }
        public int minValue { get; set; }
        public int maxValue { get; set; }
        public object firstTransaction { get; set; }
        public object lastTransaction { get; set; }
        public int period { get; set; }
        public bool periodIsRegular { get; set; }
        public List<object> transactions { get; set; }
    }

    public class CashTrain
    {
        public int transactionCount { get; set; }
        public int totalValue { get; set; }
        public int monthAvg { get; set; }
        public int minValue { get; set; }
        public int maxValue { get; set; }
        public object firstTransaction { get; set; }
        public object lastTransaction { get; set; }
        public int period { get; set; }
        public bool periodIsRegular { get; set; }
        public List<object> transactions { get; set; }
    }

    public class CenterOne
    {
        public int transactionCount { get; set; }
        public int totalValue { get; set; }
        public int monthAvg { get; set; }
        public int minValue { get; set; }
        public int maxValue { get; set; }
        public object firstTransaction { get; set; }
        public object lastTransaction { get; set; }
        public int period { get; set; }
        public bool periodIsRegular { get; set; }
        public List<object> transactions { get; set; }
    }

    public class ChampionLoans
    {
        public int transactionCount { get; set; }
        public int totalValue { get; set; }
        public int monthAvg { get; set; }
        public int minValue { get; set; }
        public int maxValue { get; set; }
        public object firstTransaction { get; set; }
        public object lastTransaction { get; set; }
        public int period { get; set; }
        public bool periodIsRegular { get; set; }
        public List<object> transactions { get; set; }
    }

    public class ChampionMoney
    {
        public int transactionCount { get; set; }
        public int totalValue { get; set; }
        public int monthAvg { get; set; }
        public int minValue { get; set; }
        public int maxValue { get; set; }
        public object firstTransaction { get; set; }
        public object lastTransaction { get; set; }
        public int period { get; set; }
        public bool periodIsRegular { get; set; }
        public List<object> transactions { get; set; }
    }

    public class CityFinance
    {
        public int transactionCount { get; set; }
        public int totalValue { get; set; }
        public int monthAvg { get; set; }
        public int minValue { get; set; }
        public int maxValue { get; set; }
        public object firstTransaction { get; set; }
        public object lastTransaction { get; set; }
        public int period { get; set; }
        public bool periodIsRegular { get; set; }
        public List<object> transactions { get; set; }
    }

    public class ClearCash
    {
        public int transactionCount { get; set; }
        public int totalValue { get; set; }
        public int monthAvg { get; set; }
        public int minValue { get; set; }
        public int maxValue { get; set; }
        public object firstTransaction { get; set; }
        public object lastTransaction { get; set; }
        public int period { get; set; }
        public bool periodIsRegular { get; set; }
        public List<object> transactions { get; set; }
    }

    public class Credit24
    {
        public int transactionCount { get; set; }
        public int totalValue { get; set; }
        public int monthAvg { get; set; }
        public int minValue { get; set; }
        public int maxValue { get; set; }
        public object firstTransaction { get; set; }
        public object lastTransaction { get; set; }
        public int period { get; set; }
        public bool periodIsRegular { get; set; }
        public List<object> transactions { get; set; }
    }

    public class CreditCorp
    {
        public int transactionCount { get; set; }
        public int totalValue { get; set; }
        public int monthAvg { get; set; }
        public int minValue { get; set; }
        public int maxValue { get; set; }
        public object firstTransaction { get; set; }
        public object lastTransaction { get; set; }
        public int period { get; set; }
        public bool periodIsRegular { get; set; }
        public List<object> transactions { get; set; }
    }

    public class DebtFix
    {
        public int transactionCount { get; set; }
        public int totalValue { get; set; }
        public int monthAvg { get; set; }
        public int minValue { get; set; }
        public int maxValue { get; set; }
        public object firstTransaction { get; set; }
        public object lastTransaction { get; set; }
        public int period { get; set; }
        public bool periodIsRegular { get; set; }
        public List<object> transactions { get; set; }
    }

    public class DollarsDirect
    {
        public int transactionCount { get; set; }
        public int totalValue { get; set; }
        public int monthAvg { get; set; }
        public int minValue { get; set; }
        public int maxValue { get; set; }
        public object firstTransaction { get; set; }
        public object lastTransaction { get; set; }
        public int period { get; set; }
        public bool periodIsRegular { get; set; }
        public List<object> transactions { get; set; }
    }

    public class EasyFinancing
    {
        public int transactionCount { get; set; }
        public int totalValue { get; set; }
        public int monthAvg { get; set; }
        public int minValue { get; set; }
        public int maxValue { get; set; }
        public object firstTransaction { get; set; }
        public object lastTransaction { get; set; }
        public int period { get; set; }
        public bool periodIsRegular { get; set; }
        public List<object> transactions { get; set; }
    }

    public class FairGoFinance
    {
        public int transactionCount { get; set; }
        public int totalValue { get; set; }
        public int monthAvg { get; set; }
        public int minValue { get; set; }
        public int maxValue { get; set; }
        public object firstTransaction { get; set; }
        public object lastTransaction { get; set; }
        public int period { get; set; }
        public bool periodIsRegular { get; set; }
        public List<object> transactions { get; set; }
    }

    public class Ferratum
    {
        public int transactionCount { get; set; }
        public double totalValue { get; set; }
        public double monthAvg { get; set; }
        public string minValue { get; set; }
        public string maxValue { get; set; }
        public string firstTransaction { get; set; }
        public string lastTransaction { get; set; }
        public double period { get; set; }
        public bool periodIsRegular { get; set; }
        public List<Transaction> transactions { get; set; }
    }

    public class FirstStopMoney
    {
        public int transactionCount { get; set; }
        public int totalValue { get; set; }
        public int monthAvg { get; set; }
        public int minValue { get; set; }
        public int maxValue { get; set; }
        public object firstTransaction { get; set; }
        public object lastTransaction { get; set; }
        public int period { get; set; }
        public bool periodIsRegular { get; set; }
        public List<object> transactions { get; set; }
    }

    public class FoxSymes
    {
        public int transactionCount { get; set; }
        public int totalValue { get; set; }
        public int monthAvg { get; set; }
        public int minValue { get; set; }
        public int maxValue { get; set; }
        public object firstTransaction { get; set; }
        public object lastTransaction { get; set; }
        public int period { get; set; }
        public bool periodIsRegular { get; set; }
        public List<object> transactions { get; set; }
    }

    public class FundCo
    {
        public int transactionCount { get; set; }
        public int totalValue { get; set; }
        public int monthAvg { get; set; }
        public int minValue { get; set; }
        public int maxValue { get; set; }
        public object firstTransaction { get; set; }
        public object lastTransaction { get; set; }
        public int period { get; set; }
        public bool periodIsRegular { get; set; }
        public List<object> transactions { get; set; }
    }

    public class JacarandaFinance
    {
        public int transactionCount { get; set; }
        public int totalValue { get; set; }
        public int monthAvg { get; set; }
        public int minValue { get; set; }
        public int maxValue { get; set; }
        public object firstTransaction { get; set; }
        public object lastTransaction { get; set; }
        public int period { get; set; }
        public bool periodIsRegular { get; set; }
        public List<object> transactions { get; set; }
    }

    public class JetLending
    {
        public int transactionCount { get; set; }
        public int totalValue { get; set; }
        public int monthAvg { get; set; }
        public int minValue { get; set; }
        public int maxValue { get; set; }
        public object firstTransaction { get; set; }
        public object lastTransaction { get; set; }
        public int period { get; set; }
        public bool periodIsRegular { get; set; }
        public List<object> transactions { get; set; }
    }

    public class JPCreditline
    {
        public int transactionCount { get; set; }
        public int totalValue { get; set; }
        public int monthAvg { get; set; }
        public int minValue { get; set; }
        public int maxValue { get; set; }
        public object firstTransaction { get; set; }
        public object lastTransaction { get; set; }
        public int period { get; set; }
        public bool periodIsRegular { get; set; }
        public List<object> transactions { get; set; }
    }

    public class K24
    {
        public int transactionCount { get; set; }
        public int totalValue { get; set; }
        public int monthAvg { get; set; }
        public int minValue { get; set; }
        public int maxValue { get; set; }
        public object firstTransaction { get; set; }
        public object lastTransaction { get; set; }
        public int period { get; set; }
        public bool periodIsRegular { get; set; }
        public List<object> transactions { get; set; }
    }

    public class KangarooPayday
    {
        public int transactionCount { get; set; }
        public int totalValue { get; set; }
        public int monthAvg { get; set; }
        public int minValue { get; set; }
        public int maxValue { get; set; }
        public object firstTransaction { get; set; }
        public object lastTransaction { get; set; }
        public int period { get; set; }
        public bool periodIsRegular { get; set; }
        public List<object> transactions { get; set; }
    }

    public class Kreditech
    {
        public int transactionCount { get; set; }
        public int totalValue { get; set; }
        public int monthAvg { get; set; }
        public int minValue { get; set; }
        public int maxValue { get; set; }
        public object firstTransaction { get; set; }
        public object lastTransaction { get; set; }
        public int period { get; set; }
        public bool periodIsRegular { get; set; }
        public List<object> transactions { get; set; }
    }

    public class KwikFinance
    {
        public int transactionCount { get; set; }
        public int totalValue { get; set; }
        public int monthAvg { get; set; }
        public int minValue { get; set; }
        public int maxValue { get; set; }
        public object firstTransaction { get; set; }
        public object lastTransaction { get; set; }
        public int period { get; set; }
        public bool periodIsRegular { get; set; }
        public List<object> transactions { get; set; }
    }

    public class LionFinance
    {
        public int transactionCount { get; set; }
        public int totalValue { get; set; }
        public int monthAvg { get; set; }
        public int minValue { get; set; }
        public int maxValue { get; set; }
        public object firstTransaction { get; set; }
        public object lastTransaction { get; set; }
        public int period { get; set; }
        public bool periodIsRegular { get; set; }
        public List<object> transactions { get; set; }
    }

    public class LoansByPhone
    {
        public int transactionCount { get; set; }
        public int totalValue { get; set; }
        public int monthAvg { get; set; }
        public int minValue { get; set; }
        public int maxValue { get; set; }
        public object firstTransaction { get; set; }
        public object lastTransaction { get; set; }
        public int period { get; set; }
        public bool periodIsRegular { get; set; }
        public List<object> transactions { get; set; }
    }

    public class LoanRanger
    {
        public int transactionCount { get; set; }
        public int totalValue { get; set; }
        public int monthAvg { get; set; }
        public int minValue { get; set; }
        public int maxValue { get; set; }
        public object firstTransaction { get; set; }
        public object lastTransaction { get; set; }
        public int period { get; set; }
        public bool periodIsRegular { get; set; }
        public List<object> transactions { get; set; }
    }

    public class MaxFinance
    {
        public int transactionCount { get; set; }
        public int totalValue { get; set; }
        public int monthAvg { get; set; }
        public int minValue { get; set; }
        public int maxValue { get; set; }
        public object firstTransaction { get; set; }
        public object lastTransaction { get; set; }
        public int period { get; set; }
        public bool periodIsRegular { get; set; }
        public List<object> transactions { get; set; }
    }

    public class MaxFunding
    {
        public int transactionCount { get; set; }
        public int totalValue { get; set; }
        public int monthAvg { get; set; }
        public int minValue { get; set; }
        public int maxValue { get; set; }
        public object firstTransaction { get; set; }
        public object lastTransaction { get; set; }
        public int period { get; set; }
        public bool periodIsRegular { get; set; }
        public List<object> transactions { get; set; }
    }

    public class MoneyCentre
    {
        public int transactionCount { get; set; }
        public int totalValue { get; set; }
        public int monthAvg { get; set; }
        public int minValue { get; set; }
        public int maxValue { get; set; }
        public object firstTransaction { get; set; }
        public object lastTransaction { get; set; }
        public int period { get; set; }
        public bool periodIsRegular { get; set; }
        public List<object> transactions { get; set; }
    }

    public class MoneyMe
    {
        public int transactionCount { get; set; }
        public double totalValue { get; set; }
        public double monthAvg { get; set; }
        public string minValue { get; set; }
        public string maxValue { get; set; }
        public string firstTransaction { get; set; }
        public string lastTransaction { get; set; }
        public double period { get; set; }
        public bool periodIsRegular { get; set; }
        public List<Transaction> transactions { get; set; }
    }

    public class MoneyNow
    {
        public int transactionCount { get; set; }
        public int totalValue { get; set; }
        public int monthAvg { get; set; }
        public int minValue { get; set; }
        public int maxValue { get; set; }
        public object firstTransaction { get; set; }
        public object lastTransaction { get; set; }
        public int period { get; set; }
        public bool periodIsRegular { get; set; }
        public List<object> transactions { get; set; }
    }

    public class MoneyPlus
    {
        public int transactionCount { get; set; }
        public int totalValue { get; set; }
        public int monthAvg { get; set; }
        public int minValue { get; set; }
        public int maxValue { get; set; }
        public object firstTransaction { get; set; }
        public object lastTransaction { get; set; }
        public int period { get; set; }
        public bool periodIsRegular { get; set; }
        public List<object> transactions { get; set; }
    }

    public class Money3
    {
        public int transactionCount { get; set; }
        public int totalValue { get; set; }
        public int monthAvg { get; set; }
        public int minValue { get; set; }
        public int maxValue { get; set; }
        public object firstTransaction { get; set; }
        public object lastTransaction { get; set; }
        public int period { get; set; }
        public bool periodIsRegular { get; set; }
        public List<object> transactions { get; set; }
    }

    public class MoneyStart
    {
        public int transactionCount { get; set; }
        public int totalValue { get; set; }
        public int monthAvg { get; set; }
        public int minValue { get; set; }
        public int maxValue { get; set; }
        public object firstTransaction { get; set; }
        public object lastTransaction { get; set; }
        public int period { get; set; }
        public bool periodIsRegular { get; set; }
        public List<object> transactions { get; set; }
    }

    public class MorganFinance
    {
        public int transactionCount { get; set; }
        public int totalValue { get; set; }
        public int monthAvg { get; set; }
        public int minValue { get; set; }
        public int maxValue { get; set; }
        public object firstTransaction { get; set; }
        public object lastTransaction { get; set; }
        public int period { get; set; }
        public bool periodIsRegular { get; set; }
        public List<object> transactions { get; set; }
    }

    public class MyBudget
    {
        public int transactionCount { get; set; }
        public int totalValue { get; set; }
        public int monthAvg { get; set; }
        public int minValue { get; set; }
        public int maxValue { get; set; }
        public object firstTransaction { get; set; }
        public object lastTransaction { get; set; }
        public int period { get; set; }
        public bool periodIsRegular { get; set; }
        public List<object> transactions { get; set; }
    }

    public class NeedyMoney
    {
        public int transactionCount { get; set; }
        public int totalValue { get; set; }
        public int monthAvg { get; set; }
        public int minValue { get; set; }
        public int maxValue { get; set; }
        public object firstTransaction { get; set; }
        public object lastTransaction { get; set; }
        public int period { get; set; }
        public bool periodIsRegular { get; set; }
        public List<object> transactions { get; set; }
    }

    public class Nimble
    {
        public int transactionCount { get; set; }
        public int totalValue { get; set; }
        public int monthAvg { get; set; }
        public int minValue { get; set; }
        public int maxValue { get; set; }
        public object firstTransaction { get; set; }
        public object lastTransaction { get; set; }
        public int period { get; set; }
        public bool periodIsRegular { get; set; }
        public List<object> transactions { get; set; }
    }

    public class OKMoney
    {
        public int transactionCount { get; set; }
        public int totalValue { get; set; }
        public int monthAvg { get; set; }
        public int minValue { get; set; }
        public int maxValue { get; set; }
        public object firstTransaction { get; set; }
        public object lastTransaction { get; set; }
        public int period { get; set; }
        public bool periodIsRegular { get; set; }
        public List<object> transactions { get; set; }
    }

    public class PaydayKing
    {
        public int transactionCount { get; set; }
        public int totalValue { get; set; }
        public int monthAvg { get; set; }
        public int minValue { get; set; }
        public int maxValue { get; set; }
        public object firstTransaction { get; set; }
        public object lastTransaction { get; set; }
        public int period { get; set; }
        public bool periodIsRegular { get; set; }
        public List<object> transactions { get; set; }
    }

    public class PaydayLand
    {
        public int transactionCount { get; set; }
        public int totalValue { get; set; }
        public int monthAvg { get; set; }
        public int minValue { get; set; }
        public int maxValue { get; set; }
        public object firstTransaction { get; set; }
        public object lastTransaction { get; set; }
        public int period { get; set; }
        public bool periodIsRegular { get; set; }
        public List<object> transactions { get; set; }
    }

    public class PaydayMate
    {
        public int transactionCount { get; set; }
        public int totalValue { get; set; }
        public int monthAvg { get; set; }
        public int minValue { get; set; }
        public int maxValue { get; set; }
        public object firstTransaction { get; set; }
        public object lastTransaction { get; set; }
        public int period { get; set; }
        public bool periodIsRegular { get; set; }
        public List<object> transactions { get; set; }
    }

    public class Payday247
    {
        public int transactionCount { get; set; }
        public int totalValue { get; set; }
        public int monthAvg { get; set; }
        public int minValue { get; set; }
        public int maxValue { get; set; }
        public object firstTransaction { get; set; }
        public object lastTransaction { get; set; }
        public int period { get; set; }
        public bool periodIsRegular { get; set; }
        public List<object> transactions { get; set; }
    }

    public class PerfectPayday
    {
        public int transactionCount { get; set; }
        public int totalValue { get; set; }
        public int monthAvg { get; set; }
        public int minValue { get; set; }
        public int maxValue { get; set; }
        public object firstTransaction { get; set; }
        public object lastTransaction { get; set; }
        public int period { get; set; }
        public bool periodIsRegular { get; set; }
        public List<object> transactions { get; set; }
    }

    public class PersonalFinanceCo
    {
        public int transactionCount { get; set; }
        public int totalValue { get; set; }
        public int monthAvg { get; set; }
        public int minValue { get; set; }
        public int maxValue { get; set; }
        public object firstTransaction { get; set; }
        public object lastTransaction { get; set; }
        public int period { get; set; }
        public bool periodIsRegular { get; set; }
        public List<object> transactions { get; set; }
    }

    public class PrimeLenders
    {
        public int transactionCount { get; set; }
        public int totalValue { get; set; }
        public int monthAvg { get; set; }
        public int minValue { get; set; }
        public int maxValue { get; set; }
        public object firstTransaction { get; set; }
        public object lastTransaction { get; set; }
        public int period { get; set; }
        public bool periodIsRegular { get; set; }
        public List<object> transactions { get; set; }
    }

    public class RapidLoans
    {
        public int transactionCount { get; set; }
        public int totalValue { get; set; }
        public int monthAvg { get; set; }
        public int minValue { get; set; }
        public int maxValue { get; set; }
        public object firstTransaction { get; set; }
        public object lastTransaction { get; set; }
        public int period { get; set; }
        public bool periodIsRegular { get; set; }
        public List<object> transactions { get; set; }
    }

    public class SecureFunding
    {
        public int transactionCount { get; set; }
        public int totalValue { get; set; }
        public int monthAvg { get; set; }
        public int minValue { get; set; }
        public int maxValue { get; set; }
        public object firstTransaction { get; set; }
        public object lastTransaction { get; set; }
        public int period { get; set; }
        public bool periodIsRegular { get; set; }
        public List<object> transactions { get; set; }
    }

    public class SpeedyFinance
    {
        public int transactionCount { get; set; }
        public int totalValue { get; set; }
        public int monthAvg { get; set; }
        public int minValue { get; set; }
        public int maxValue { get; set; }
        public object firstTransaction { get; set; }
        public object lastTransaction { get; set; }
        public int period { get; set; }
        public bool periodIsRegular { get; set; }
        public List<object> transactions { get; set; }
    }

    public class SpeedyMoney
    {
        public int transactionCount { get; set; }
        public int totalValue { get; set; }
        public int monthAvg { get; set; }
        public int minValue { get; set; }
        public int maxValue { get; set; }
        public object firstTransaction { get; set; }
        public object lastTransaction { get; set; }
        public int period { get; set; }
        public bool periodIsRegular { get; set; }
        public List<object> transactions { get; set; }
    }

    public class SpotLoans
    {
        public int transactionCount { get; set; }
        public int totalValue { get; set; }
        public int monthAvg { get; set; }
        public int minValue { get; set; }
        public int maxValue { get; set; }
        public object firstTransaction { get; set; }
        public object lastTransaction { get; set; }
        public int period { get; set; }
        public bool periodIsRegular { get; set; }
        public List<object> transactions { get; set; }
    }

    public class SRGFinance
    {
        public int transactionCount { get; set; }
        public int totalValue { get; set; }
        public int monthAvg { get; set; }
        public int minValue { get; set; }
        public int maxValue { get; set; }
        public object firstTransaction { get; set; }
        public object lastTransaction { get; set; }
        public int period { get; set; }
        public bool periodIsRegular { get; set; }
        public List<object> transactions { get; set; }
    }

    public class StressLess
    {
        public int transactionCount { get; set; }
        public int totalValue { get; set; }
        public int monthAvg { get; set; }
        public int minValue { get; set; }
        public int maxValue { get; set; }
        public object firstTransaction { get; set; }
        public object lastTransaction { get; set; }
        public int period { get; set; }
        public bool periodIsRegular { get; set; }
        public List<object> transactions { get; set; }
    }

    public class SunshineLoans
    {
        public int transactionCount { get; set; }
        public double totalValue { get; set; }
        public double monthAvg { get; set; }
        public string minValue { get; set; }
        public string maxValue { get; set; }
        public string firstTransaction { get; set; }
        public string lastTransaction { get; set; }
        public double period { get; set; }
        public bool periodIsRegular { get; set; }
        public List<Transaction> transactions { get; set; }
    }

    public class SwooshFinance
    {
        public int transactionCount { get; set; }
        public int totalValue { get; set; }
        public int monthAvg { get; set; }
        public int minValue { get; set; }
        public int maxValue { get; set; }
        public object firstTransaction { get; set; }
        public object lastTransaction { get; set; }
        public int period { get; set; }
        public bool periodIsRegular { get; set; }
        public List<object> transactions { get; set; }
    }

    public class TeleLoans
    {
        public int transactionCount { get; set; }
        public int totalValue { get; set; }
        public int monthAvg { get; set; }
        public int minValue { get; set; }
        public int maxValue { get; set; }
        public object firstTransaction { get; set; }
        public object lastTransaction { get; set; }
        public int period { get; set; }
        public bool periodIsRegular { get; set; }
        public List<object> transactions { get; set; }
    }

    public class Thorn
    {
        public int transactionCount { get; set; }
        public int totalValue { get; set; }
        public int monthAvg { get; set; }
        public int minValue { get; set; }
        public int maxValue { get; set; }
        public object firstTransaction { get; set; }
        public object lastTransaction { get; set; }
        public int period { get; set; }
        public bool periodIsRegular { get; set; }
        public List<object> transactions { get; set; }
    }

    public class VictoryFunding
    {
        public int transactionCount { get; set; }
        public int totalValue { get; set; }
        public int monthAvg { get; set; }
        public int minValue { get; set; }
        public int maxValue { get; set; }
        public object firstTransaction { get; set; }
        public object lastTransaction { get; set; }
        public int period { get; set; }
        public bool periodIsRegular { get; set; }
        public List<object> transactions { get; set; }
    }

    public class WebMoneyline
    {
        public int transactionCount { get; set; }
        public int totalValue { get; set; }
        public int monthAvg { get; set; }
        public int minValue { get; set; }
        public int maxValue { get; set; }
        public object firstTransaction { get; set; }
        public object lastTransaction { get; set; }
        public int period { get; set; }
        public bool periodIsRegular { get; set; }
        public List<object> transactions { get; set; }
    }

    public class YesLoans
    {
        public int transactionCount { get; set; }
        public int totalValue { get; set; }
        public int monthAvg { get; set; }
        public int minValue { get; set; }
        public int maxValue { get; set; }
        public object firstTransaction { get; set; }
        public object lastTransaction { get; set; }
        public int period { get; set; }
        public bool periodIsRegular { get; set; }
        public List<object> transactions { get; set; }
    }

    public class CollectionHouse
    {
        public int transactionCount { get; set; }
        public int totalValue { get; set; }
        public int monthAvg { get; set; }
        public int minValue { get; set; }
        public int maxValue { get; set; }
        public object firstTransaction { get; set; }
        public object lastTransaction { get; set; }
        public int period { get; set; }
        public bool periodIsRegular { get; set; }
        public List<object> transactions { get; set; }
    }

    public class ToyotaFinance
    {
        public int transactionCount { get; set; }
        public int totalValue { get; set; }
        public int monthAvg { get; set; }
        public int minValue { get; set; }
        public int maxValue { get; set; }
        public object firstTransaction { get; set; }
        public object lastTransaction { get; set; }
        public int period { get; set; }
        public bool periodIsRegular { get; set; }
        public List<object> transactions { get; set; }
    }

    public class ImpactFinancial
    {
        public int transactionCount { get; set; }
        public int totalValue { get; set; }
        public int monthAvg { get; set; }
        public int minValue { get; set; }
        public int maxValue { get; set; }
        public object firstTransaction { get; set; }
        public object lastTransaction { get; set; }
        public int period { get; set; }
        public bool periodIsRegular { get; set; }
        public List<object> transactions { get; set; }
    }

    public class YamahaMotorFinance
    {
        public int transactionCount { get; set; }
        public int totalValue { get; set; }
        public int monthAvg { get; set; }
        public int minValue { get; set; }
        public int maxValue { get; set; }
        public object firstTransaction { get; set; }
        public object lastTransaction { get; set; }
        public int period { get; set; }
        public bool periodIsRegular { get; set; }
        public List<object> transactions { get; set; }
    }

    public class HomeLoan
    {
        public int transactionCount { get; set; }
        public int totalValue { get; set; }
        public int monthAvg { get; set; }
        public int minValue { get; set; }
        public int maxValue { get; set; }
        public object firstTransaction { get; set; }
        public object lastTransaction { get; set; }
        public int period { get; set; }
        public bool periodIsRegular { get; set; }
        public List<object> transactions { get; set; }
    }

    public class Generic
    {
        public int transactionCount { get; set; }
        public double totalValue { get; set; }
        public double monthAvg { get; set; }
        public string minValue { get; set; }
        public string maxValue { get; set; }
        public string firstTransaction { get; set; }
        public string lastTransaction { get; set; }
        public double period { get; set; }
        public bool periodIsRegular { get; set; }
        public List<Transaction> transactions { get; set; }
    }

    public class Loans
    {
        public Total total { get; set; }

        [JsonProperty("Amazing Loans")]
        public AmazingLoans AmazingLoans { get; set; }

        [JsonProperty("AMX Money")]
        public AMXMoney AMXMoney { get; set; }

        [JsonProperty("Aus Financial")]
        public AusFinancial AusFinancial { get; set; }
        public Aussie Aussie { get; set; }

        [JsonProperty("Aussie Cash")]
        public AussieCash AussieCash { get; set; }
        public Baycorp Baycorp { get; set; }

        [JsonProperty("Cannon Finance")]
        public CannonFinance CannonFinance { get; set; }

        [JsonProperty("Cash Advance")]
        public CashAdvance CashAdvance { get; set; }

        [JsonProperty("Cash Converters")]
        public CashConverters CashConverters { get; set; }

        [JsonProperty("Cash Doctors")]
        public CashDoctors CashDoctors { get; set; }

        [JsonProperty("Cash First")]
        public CashFirst CashFirst { get; set; }

        [JsonProperty("Cash in a Flash")]
        public CashInAFlash CashInAFlash { get; set; }

        [JsonProperty("Cash Money")]
        public CashMoney CashMoney { get; set; }

        [JsonProperty("Cash Now")]
        public CashNow CashNow { get; set; }

        [JsonProperty("Cash Oz")]
        public CashOz CashOz { get; set; }

        [JsonProperty("Cash Solutions")]
        public CashSolutions CashSolutions { get; set; }

        [JsonProperty("Cash Smart")]
        public CashSmart CashSmart { get; set; }

        [JsonProperty("Cash Stop")]
        public CashStop CashStop { get; set; }
        public CashToday CashToday { get; set; }

        [JsonProperty("Cash Train")]
        public CashTrain CashTrain { get; set; }

        [JsonProperty("Center One")]
        public CenterOne CenterOne { get; set; }

        [JsonProperty("Champion Loans")]
        public ChampionLoans ChampionLoans { get; set; }

        [JsonProperty("Champion Money")]
        public ChampionMoney ChampionMoney { get; set; }

        [JsonProperty("City Finance")]
        public CityFinance CityFinance { get; set; }

        [JsonProperty("Clear Cash")]
        public ClearCash ClearCash { get; set; }
        public Credit24 Credit24 { get; set; }

        [JsonProperty("Credit Corp")]
        public CreditCorp CreditCorp { get; set; }

        [JsonProperty("Debt Fix")]
        public DebtFix DebtFix { get; set; }

        [JsonProperty("Dollars Direct")]
        public DollarsDirect DollarsDirect { get; set; }

        [JsonProperty("Easy Financing")]
        public EasyFinancing EasyFinancing { get; set; }

        [JsonProperty("Fair Go Finance")]
        public FairGoFinance FairGoFinance { get; set; }
        public Ferratum Ferratum { get; set; }

        [JsonProperty("First Stop Money")]
        public FirstStopMoney FirstStopMoney { get; set; }

        [JsonProperty("Fox Symes")]
        public FoxSymes FoxSymes { get; set; }
        public FundCo FundCo { get; set; }

        [JsonProperty("Jacaranda Finance")]
        public JacarandaFinance JacarandaFinance { get; set; }

        [JsonProperty("Jet Lending")]
        public JetLending JetLending { get; set; }

        [JsonProperty("JP Creditline")]
        public JPCreditline JPCreditline { get; set; }
        public K24 K24 { get; set; }

        [JsonProperty("Kangaroo Payday")]
        public KangarooPayday KangarooPayday { get; set; }
        public Kreditech Kreditech { get; set; }

        [JsonProperty("Kwik Finance")]
        public KwikFinance KwikFinance { get; set; }

        [JsonProperty("Lion Finance")]
        public LionFinance LionFinance { get; set; }

        [JsonProperty("Loans by Phone")]
        public LoansByPhone LoansByPhone { get; set; }

        [JsonProperty("Loan Ranger")]
        public LoanRanger LoanRanger { get; set; }

        [JsonProperty("Max Finance")]
        public MaxFinance MaxFinance { get; set; }

        [JsonProperty("Max Funding")]
        public MaxFunding MaxFunding { get; set; }
        public MoneyCentre MoneyCentre { get; set; }
        public MoneyMe MoneyMe { get; set; }

        [JsonProperty("Money Now")]
        public MoneyNow MoneyNow { get; set; }
        public MoneyPlus MoneyPlus { get; set; }
        public Money3 Money3 { get; set; }
        public MoneyStart MoneyStart { get; set; }

        [JsonProperty("Morgan Finance")]
        public MorganFinance MorganFinance { get; set; }

        [JsonProperty("My Budget")]
        public MyBudget MyBudget { get; set; }

        [JsonProperty("Needy Money")]
        public NeedyMoney NeedyMoney { get; set; }
        public Nimble Nimble { get; set; }

        [JsonProperty("OK Money")]
        public OKMoney OKMoney { get; set; }

        [JsonProperty("Payday King")]
        public PaydayKing PaydayKing { get; set; }

        [JsonProperty("Payday Land")]
        public PaydayLand PaydayLand { get; set; }

        [JsonProperty("Payday Mate")]
        public PaydayMate PaydayMate { get; set; }
        public Payday247 Payday247 { get; set; }

        [JsonProperty("Perfect Payday")]
        public PerfectPayday PerfectPayday { get; set; }

        [JsonProperty("Personal Finance Co")]
        public PersonalFinanceCo PersonalFinanceCo { get; set; }

        [JsonProperty("Prime Lenders")]
        public PrimeLenders PrimeLenders { get; set; }

        [JsonProperty("Rapid Loans")]
        public RapidLoans RapidLoans { get; set; }

        [JsonProperty("Secure Funding")]
        public SecureFunding SecureFunding { get; set; }

        [JsonProperty("Speedy Finance")]
        public SpeedyFinance SpeedyFinance { get; set; }

        [JsonProperty("Speedy Money")]
        public SpeedyMoney SpeedyMoney { get; set; }

        [JsonProperty("Spot Loans")]
        public SpotLoans SpotLoans { get; set; }

        [JsonProperty("SRG Finance")]
        public SRGFinance SRGFinance { get; set; }

        [JsonProperty("Stress Less")]
        public StressLess StressLess { get; set; }

        [JsonProperty("Sunshine Loans")]
        public SunshineLoans SunshineLoans { get; set; }

        [JsonProperty("Swoosh Finance")]
        public SwooshFinance SwooshFinance { get; set; }

        [JsonProperty("Tele Loans")]
        public TeleLoans TeleLoans { get; set; }
        public Thorn Thorn { get; set; }

        [JsonProperty("Victory Funding")]
        public VictoryFunding VictoryFunding { get; set; }

        [JsonProperty("Web Moneyline")]
        public WebMoneyline WebMoneyline { get; set; }

        [JsonProperty("Yes Loans")]
        public YesLoans YesLoans { get; set; }

        [JsonProperty("Collection House")]
        public CollectionHouse CollectionHouse { get; set; }

        [JsonProperty("Toyota Finance")]
        public ToyotaFinance ToyotaFinance { get; set; }

        [JsonProperty("Impact Financial")]
        public ImpactFinancial ImpactFinancial { get; set; }

        [JsonProperty("Yamaha Motor Finance")]
        public YamahaMotorFinance YamahaMotorFinance { get; set; }

        [JsonProperty("Home Loan")]
        public HomeLoan HomeLoan { get; set; }
        public Generic Generic { get; set; }
    }

    public class _10Bet
    {
        public int transactionCount { get; set; }
        public int totalValue { get; set; }
        public int monthAvg { get; set; }
        public int minValue { get; set; }
        public int maxValue { get; set; }
        public object firstTransaction { get; set; }
        public object lastTransaction { get; set; }
        public int period { get; set; }
        public bool periodIsRegular { get; set; }
        public List<object> transactions { get; set; }
    }

    public class AusBet
    {
        public int transactionCount { get; set; }
        public int totalValue { get; set; }
        public int monthAvg { get; set; }
        public int minValue { get; set; }
        public int maxValue { get; set; }
        public object firstTransaction { get; set; }
        public object lastTransaction { get; set; }
        public int period { get; set; }
        public bool periodIsRegular { get; set; }
        public List<object> transactions { get; set; }
    }

    public class Bet365
    {
        public int transactionCount { get; set; }
        public int totalValue { get; set; }
        public int monthAvg { get; set; }
        public int minValue { get; set; }
        public int maxValue { get; set; }
        public object firstTransaction { get; set; }
        public object lastTransaction { get; set; }
        public int period { get; set; }
        public bool periodIsRegular { get; set; }
        public List<object> transactions { get; set; }
    }

    public class BetFair
    {
        public int transactionCount { get; set; }
        public int totalValue { get; set; }
        public int monthAvg { get; set; }
        public int minValue { get; set; }
        public int maxValue { get; set; }
        public object firstTransaction { get; set; }
        public object lastTransaction { get; set; }
        public int period { get; set; }
        public bool periodIsRegular { get; set; }
        public List<object> transactions { get; set; }
    }

    public class BetStar
    {
        public int transactionCount { get; set; }
        public int totalValue { get; set; }
        public int monthAvg { get; set; }
        public int minValue { get; set; }
        public int maxValue { get; set; }
        public object firstTransaction { get; set; }
        public object lastTransaction { get; set; }
        public int period { get; set; }
        public bool periodIsRegular { get; set; }
        public List<object> transactions { get; set; }
    }

    public class Bookmaker
    {
        public int transactionCount { get; set; }
        public int totalValue { get; set; }
        public int monthAvg { get; set; }
        public int minValue { get; set; }
        public int maxValue { get; set; }
        public object firstTransaction { get; set; }
        public object lastTransaction { get; set; }
        public int period { get; set; }
        public bool periodIsRegular { get; set; }
        public List<object> transactions { get; set; }
    }

    public class Centrebet
    {
        public int transactionCount { get; set; }
        public int totalValue { get; set; }
        public int monthAvg { get; set; }
        public int minValue { get; set; }
        public int maxValue { get; set; }
        public object firstTransaction { get; set; }
        public object lastTransaction { get; set; }
        public int period { get; set; }
        public bool periodIsRegular { get; set; }
        public List<object> transactions { get; set; }
    }

    public class ClassicBet
    {
        public int transactionCount { get; set; }
        public int totalValue { get; set; }
        public int monthAvg { get; set; }
        public int minValue { get; set; }
        public int maxValue { get; set; }
        public object firstTransaction { get; set; }
        public object lastTransaction { get; set; }
        public int period { get; set; }
        public bool periodIsRegular { get; set; }
        public List<object> transactions { get; set; }
    }

    public class CrownBet
    {
        public int transactionCount { get; set; }
        public double totalValue { get; set; }
        public double monthAvg { get; set; }
        public string minValue { get; set; }
        public string maxValue { get; set; }
        public string firstTransaction { get; set; }
        public string lastTransaction { get; set; }
        public double period { get; set; }
        public bool periodIsRegular { get; set; }
        public List<Transaction> transactions { get; set; }
    }

    public class DigiMedia
    {
        public int transactionCount { get; set; }
        public int totalValue { get; set; }
        public int monthAvg { get; set; }
        public int minValue { get; set; }
        public int maxValue { get; set; }
        public object firstTransaction { get; set; }
        public object lastTransaction { get; set; }
        public int period { get; set; }
        public bool periodIsRegular { get; set; }
        public List<object> transactions { get; set; }
    }

    public class Ladbrokes
    {
        public int transactionCount { get; set; }
        public int totalValue { get; set; }
        public int monthAvg { get; set; }
        public int minValue { get; set; }
        public int maxValue { get; set; }
        public object firstTransaction { get; set; }
        public object lastTransaction { get; set; }
        public int period { get; set; }
        public bool periodIsRegular { get; set; }
        public List<object> transactions { get; set; }
    }

    public class LeoVegas
    {
        public int transactionCount { get; set; }
        public int totalValue { get; set; }
        public int monthAvg { get; set; }
        public int minValue { get; set; }
        public int maxValue { get; set; }
        public object firstTransaction { get; set; }
        public object lastTransaction { get; set; }
        public int period { get; set; }
        public bool periodIsRegular { get; set; }
        public List<object> transactions { get; set; }
    }

    public class Luxbet
    {
        public int transactionCount { get; set; }
        public int totalValue { get; set; }
        public int monthAvg { get; set; }
        public int minValue { get; set; }
        public int maxValue { get; set; }
        public object firstTransaction { get; set; }
        public object lastTransaction { get; set; }
        public int period { get; set; }
        public bool periodIsRegular { get; set; }
        public List<object> transactions { get; set; }
    }

    public class OzBet
    {
        public int transactionCount { get; set; }
        public int totalValue { get; set; }
        public int monthAvg { get; set; }
        public int minValue { get; set; }
        public int maxValue { get; set; }
        public object firstTransaction { get; set; }
        public object lastTransaction { get; set; }
        public int period { get; set; }
        public bool periodIsRegular { get; set; }
        public List<object> transactions { get; set; }
    }

    public class Palmerbet
    {
        public int transactionCount { get; set; }
        public int totalValue { get; set; }
        public int monthAvg { get; set; }
        public int minValue { get; set; }
        public int maxValue { get; set; }
        public object firstTransaction { get; set; }
        public object lastTransaction { get; set; }
        public int period { get; set; }
        public bool periodIsRegular { get; set; }
        public List<object> transactions { get; set; }
    }

    public class Punters
    {
        public int transactionCount { get; set; }
        public int totalValue { get; set; }
        public int monthAvg { get; set; }
        public int minValue { get; set; }
        public int maxValue { get; set; }
        public object firstTransaction { get; set; }
        public object lastTransaction { get; set; }
        public int period { get; set; }
        public bool periodIsRegular { get; set; }
        public List<object> transactions { get; set; }
    }

    public class Pokerstars
    {
        public int transactionCount { get; set; }
        public int totalValue { get; set; }
        public int monthAvg { get; set; }
        public int minValue { get; set; }
        public int maxValue { get; set; }
        public object firstTransaction { get; set; }
        public object lastTransaction { get; set; }
        public int period { get; set; }
        public bool periodIsRegular { get; set; }
        public List<object> transactions { get; set; }
    }

    public class RoxyPalace
    {
        public int transactionCount { get; set; }
        public int totalValue { get; set; }
        public int monthAvg { get; set; }
        public int minValue { get; set; }
        public int maxValue { get; set; }
        public object firstTransaction { get; set; }
        public object lastTransaction { get; set; }
        public int period { get; set; }
        public bool periodIsRegular { get; set; }
        public List<object> transactions { get; set; }
    }

    public class Sportsbet
    {
        public int transactionCount { get; set; }
        public int totalValue { get; set; }
        public int monthAvg { get; set; }
        public int minValue { get; set; }
        public int maxValue { get; set; }
        public object firstTransaction { get; set; }
        public object lastTransaction { get; set; }
        public int period { get; set; }
        public bool periodIsRegular { get; set; }
        public List<object> transactions { get; set; }
    }

    public class Sportsbetting
    {
        public int transactionCount { get; set; }
        public int totalValue { get; set; }
        public int monthAvg { get; set; }
        public int minValue { get; set; }
        public int maxValue { get; set; }
        public object firstTransaction { get; set; }
        public object lastTransaction { get; set; }
        public int period { get; set; }
        public bool periodIsRegular { get; set; }
        public List<object> transactions { get; set; }
    }

    public class Sportingbet
    {
        public int transactionCount { get; set; }
        public int totalValue { get; set; }
        public int monthAvg { get; set; }
        public int minValue { get; set; }
        public int maxValue { get; set; }
        public object firstTransaction { get; set; }
        public object lastTransaction { get; set; }
        public int period { get; set; }
        public bool periodIsRegular { get; set; }
        public List<object> transactions { get; set; }
    }

    public class TABTouch
    {
        public int transactionCount { get; set; }
        public int totalValue { get; set; }
        public int monthAvg { get; set; }
        public int minValue { get; set; }
        public int maxValue { get; set; }
        public object firstTransaction { get; set; }
        public object lastTransaction { get; set; }
        public int period { get; set; }
        public bool periodIsRegular { get; set; }
        public List<object> transactions { get; set; }
    }

    public class Tatts
    {
        public int transactionCount { get; set; }
        public int totalValue { get; set; }
        public int monthAvg { get; set; }
        public int minValue { get; set; }
        public int maxValue { get; set; }
        public object firstTransaction { get; set; }
        public object lastTransaction { get; set; }
        public int period { get; set; }
        public bool periodIsRegular { get; set; }
        public List<object> transactions { get; set; }
    }

    public class ThePalaceGroup
    {
        public int transactionCount { get; set; }
        public int totalValue { get; set; }
        public int monthAvg { get; set; }
        public int minValue { get; set; }
        public int maxValue { get; set; }
        public object firstTransaction { get; set; }
        public object lastTransaction { get; set; }
        public int period { get; set; }
        public bool periodIsRegular { get; set; }
        public List<object> transactions { get; set; }
    }

    public class TomWaterhouse
    {
        public int transactionCount { get; set; }
        public int totalValue { get; set; }
        public int monthAvg { get; set; }
        public int minValue { get; set; }
        public int maxValue { get; set; }
        public object firstTransaction { get; set; }
        public object lastTransaction { get; set; }
        public int period { get; set; }
        public bool periodIsRegular { get; set; }
        public List<object> transactions { get; set; }
    }

    public class UBET
    {
        public int transactionCount { get; set; }
        public int totalValue { get; set; }
        public int monthAvg { get; set; }
        public int minValue { get; set; }
        public int maxValue { get; set; }
        public object firstTransaction { get; set; }
        public object lastTransaction { get; set; }
        public int period { get; set; }
        public bool periodIsRegular { get; set; }
        public List<object> transactions { get; set; }
    }

    public class Unibet
    {
        public int transactionCount { get; set; }
        public int totalValue { get; set; }
        public int monthAvg { get; set; }
        public int minValue { get; set; }
        public int maxValue { get; set; }
        public object firstTransaction { get; set; }
        public object lastTransaction { get; set; }
        public int period { get; set; }
        public bool periodIsRegular { get; set; }
        public List<object> transactions { get; set; }
    }

    public class WilliamHill
    {
        public int transactionCount { get; set; }
        public int totalValue { get; set; }
        public int monthAvg { get; set; }
        public int minValue { get; set; }
        public int maxValue { get; set; }
        public object firstTransaction { get; set; }
        public object lastTransaction { get; set; }
        public int period { get; set; }
        public bool periodIsRegular { get; set; }
        public List<object> transactions { get; set; }
    }

    public class Casino
    {
        public int transactionCount { get; set; }
        public int totalValue { get; set; }
        public int monthAvg { get; set; }
        public int minValue { get; set; }
        public int maxValue { get; set; }
        public object firstTransaction { get; set; }
        public object lastTransaction { get; set; }
        public int period { get; set; }
        public bool periodIsRegular { get; set; }
        public List<object> transactions { get; set; }
    }

    public class Lottery
    {
        public int transactionCount { get; set; }
        public int totalValue { get; set; }
        public int monthAvg { get; set; }
        public int minValue { get; set; }
        public int maxValue { get; set; }
        public object firstTransaction { get; set; }
        public object lastTransaction { get; set; }
        public int period { get; set; }
        public bool periodIsRegular { get; set; }
        public List<object> transactions { get; set; }
    }

    public class Gambling
    {
        public Total total { get; set; }
        public _10Bet _10Bet { get; set; }
        public AusBet AusBet { get; set; }
        public Bet365 Bet365 { get; set; }
        public BetFair BetFair { get; set; }
        public BetStar BetStar { get; set; }
        public Bookmaker Bookmaker { get; set; }
        public Centrebet Centrebet { get; set; }
        public ClassicBet ClassicBet { get; set; }
        public CrownBet CrownBet { get; set; }
        public DigiMedia DigiMedia { get; set; }
        public Ladbrokes Ladbrokes { get; set; }
        public LeoVegas LeoVegas { get; set; }
        public Luxbet Luxbet { get; set; }
        public OzBet OzBet { get; set; }
        public Palmerbet Palmerbet { get; set; }
        public Punters Punters { get; set; }
        public Pokerstars Pokerstars { get; set; }

        [JsonProperty("Roxy Palace")]
        public RoxyPalace RoxyPalace { get; set; }
        public Sportsbet Sportsbet { get; set; }
        public Sportsbetting Sportsbetting { get; set; }
        public Sportingbet Sportingbet { get; set; }
        public TABTouch TABTouch { get; set; }
        public Tatts Tatts { get; set; }

        [JsonProperty("The Palace Group")]
        public ThePalaceGroup ThePalaceGroup { get; set; }

        [JsonProperty("Tom Waterhouse")]
        public TomWaterhouse TomWaterhouse { get; set; }
        public UBET UBET { get; set; }
        public Unibet Unibet { get; set; }

        [JsonProperty("William Hill")]
        public WilliamHill WilliamHill { get; set; }
        public Casino Casino { get; set; }
        public Lottery Lottery { get; set; }
    }

    public class PaygatePayments
    {
        public int transactionCount { get; set; }
        public int totalValue { get; set; }
        public int monthAvg { get; set; }
        public int minValue { get; set; }
        public int maxValue { get; set; }
        public object firstTransaction { get; set; }
        public object lastTransaction { get; set; }
        public int period { get; set; }
        public bool periodIsRegular { get; set; }
        public List<object> transactions { get; set; }
    }

    public class SPER
    {
        public int transactionCount { get; set; }
        public int totalValue { get; set; }
        public int monthAvg { get; set; }
        public int minValue { get; set; }
        public int maxValue { get; set; }
        public object firstTransaction { get; set; }
        public object lastTransaction { get; set; }
        public int period { get; set; }
        public bool periodIsRegular { get; set; }
        public List<object> transactions { get; set; }
    }

    public class Certegy
    {
        public int transactionCount { get; set; }
        public int totalValue { get; set; }
        public int monthAvg { get; set; }
        public int minValue { get; set; }
        public int maxValue { get; set; }
        public object firstTransaction { get; set; }
        public object lastTransaction { get; set; }
        public int period { get; set; }
        public bool periodIsRegular { get; set; }
        public List<object> transactions { get; set; }
    }

    public class OtherDebits
    {
        public Total total { get; set; }

        [JsonProperty("Paygate Payments")]
        public PaygatePayments PaygatePayments { get; set; }
        public SPER SPER { get; set; }
        public Certegy Certegy { get; set; }
    }

    public class Analysis
    {
        public Income Income { get; set; }
        public Benefits Benefits { get; set; }
        public Dishonours Dishonours { get; set; }
        public Loans Loans { get; set; }
        public Rent Rent { get; set; }
        public Gambling Gambling { get; set; }

        [JsonProperty("Other Debits")]
        public OtherDebits OtherDebits { get; set; }
    }

    public class StatementData
    {
        public List<Detail> details { get; set; }
        public string totalCredits { get; set; }
        public string totalDebits { get; set; }
        public string openingBalance { get; set; }
        public string closingBalance { get; set; }
        public string startDate { get; set; }
        public string endDate { get; set; }
        public string minBalance { get; set; }
        public string maxBalance { get; set; }
        public List<DayEndBalance> dayEndBalances { get; set; }
        public string minDayEndBalance { get; set; }
        public string maxDayEndBalance { get; set; }
        public int daysInNegative { get; set; }
        public string errorMessage { get; set; }
        public Analysis analysis { get; set; }
    }

    /*public class Account
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
        public StatementData statementData { get; set; }
        public string institution { get; set; }
        public string interestRate { get; set; }
        public BankOfStatements bank_of_statements { get; set; }
    }

    public class BankOfStatements
    {
        public List<Account> accounts { get; set; }
    }


    /*
    public class Customer
    {
        public string customerId { get; set; }
        public string encryptionKey { get; set; }
    }
    */
    public class bankStateAccountData
    {
        public Accounts accounts { get; set; }
        public string user_token { get; set; }
        public string referral_code { get; set; }
        public string reportsLink { get; set; }
        public Customer customer { get; set; }
    }


}
