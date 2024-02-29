using System.ComponentModel.DataAnnotations;

namespace Artisan.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}