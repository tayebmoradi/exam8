namespace exam8.model
{
    public class Coustomer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }


        public Period Period { get; set; }

        public ICollection<Token> Tokens { get; set; }
    }
}
