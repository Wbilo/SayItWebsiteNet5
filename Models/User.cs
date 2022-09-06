using SayItWebsiteNet5.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SayItWebsiteNet5.Models
{
    public class User
    {
        [Required]
        [Display(Name = "Brugernavn")]
        public string UserName {get;set;}
        [Required]
        [Display(Name = "Kodeord")]
        public string Password { get; set; }
        [Required]
        [Compare(nameof(Password), ErrorMessage = "Kodeord matcher ikke")]
        [Display(Name ="Bekræft kodeord")]
        public string ConfirmPassword { get; set; }
        public List<string> Roles { get; set; }
        [Required]
        [Display(Name = "Fornavn")]
        public string Name { get; set; }
        [Required]
        [Display(Name = "Efternavn")]        
        public string Surname { get; set; }
        public DateTime EnrollmentCreated { get; set; }
        public int DaysTotal { get; set; }
        public int AbsentDaysTotal { get; set; }
        [Display(Name = "Noter")]
        public List<string> Notes { get; set; }
        public List<SIEvents> ActiveEvents { get; set; }
    }
}
