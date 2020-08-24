using System.ComponentModel.DataAnnotations;

namespace CustomAbpProject.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}