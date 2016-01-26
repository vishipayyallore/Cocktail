using System.ComponentModel.DataAnnotations;

namespace CocktailUI.ViewModels.Account
{
    public class ForgotPasswordViewModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}
