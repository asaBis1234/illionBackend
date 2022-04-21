namespace Illion0.Entities
{

    public class Credentials
    {
        public string institution { get; set; }
        public string username { get; set; }
        public string password { get; set; }
    }
    public class CustomerCredential
    {
        

       
            public Credentials credentials { get; set; }
        
    }
}
