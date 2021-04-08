using System.ComponentModel.DataAnnotations;
namespace montanari.giorgia._5H.SecondaWeb.dto
{
    public class RegistraDto
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
         
        [DataType(DataType.Password)]
        [Display(Name ="Confirm Password")]
        [Compare("Password",ErrorMessage ="Password and confirmation password not match.")]
        public string ConfirmPassword { get; set; }
        
        [Display(Name = "Privacy Policy")]
        public bool Privacy { get; set; }
    }

}