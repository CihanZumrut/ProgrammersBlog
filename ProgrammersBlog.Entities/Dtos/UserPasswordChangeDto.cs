using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ProgrammersBlog.Entities.Dtos
{
    public class UserPasswordChangeDto
    {

        [DisplayName("Şu Anki Şifreniz")]
        [Required(ErrorMessage = "{0} Boş geçilmemelidir.")]
        [MaxLength(30, ErrorMessage = "{0} {1} karakterden büyük olmamalıdır.")]
        [MinLength(5, ErrorMessage = "{0} {1} karakterden az olmamalıdır..")]
        [DataType(DataType.Password)]
        public string CurrentPassword { get; set; }


        [DisplayName("Yeni Şifreniz")]
        [Required(ErrorMessage = "{0} Boş geçilmemelidir.")]
        [MaxLength(30, ErrorMessage = "{0} {1} karakterden büyük olmamalıdır.")]
        [MinLength(5, ErrorMessage = "{0} {1} karakterden az olmamalıdır..")]
        [DataType(DataType.Password)]
        public string NewPassword { get; set; }


        [DisplayName("Yeni Şifrenizin Tekrarı")]
        [Required(ErrorMessage = "{0} Boş geçilmemelidir.")]
        [MaxLength(30, ErrorMessage = "{0} {1} karakterden büyük olmamalıdır.")]
        [MinLength(5, ErrorMessage = "{0} {1} karakterden az olmamalıdır..")]
        [DataType(DataType.Password)]
        [Compare("NewPassword", ErrorMessage ="Girmiş olduğunuz yeni şifreniz ile yeni şifrenizin tekrarı alanları birbiriyle uyuşmalıdır.")]
        public string RepeatPassword { get; set; }
    }
}
