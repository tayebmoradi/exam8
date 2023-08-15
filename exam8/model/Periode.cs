using System.ComponentModel.DataAnnotations;

namespace exam8.model
{
    public class Period
    {
        [Key]
        public int Id { get; set; }
        public string PersonalCode { get; set; }
        public string SerialNumber { get; set; }
        public bool IsActive { get; set; }
       

       

    }
}
