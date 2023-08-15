namespace exam8.model
{
    public class Token
    {

        public int Id { get; set; }
        public string Name { get; set; }    
        public string Value { get; set; }

        public ICollection<Coustomer> coustomers{ get; set;}
    }
}
