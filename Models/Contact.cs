using System.ComponentModel.DataAnnotations;
namespace SayItWebsiteNet5.Models
{
    public class Contact
    {   
        [Required]
        [Display(Name ="Navn")]
        public string Name { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required]
        [Display(Name="Besked")]
        public string Message { get; set; }
        [Display(Name= "Telefonnummer")]
        public string PhoneNumber { get; set; }
    }
}
