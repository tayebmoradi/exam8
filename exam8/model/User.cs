namespace exam8.model
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public int PeriodId{ get; set; }
        public Period Period { get; set; }
    }
}
