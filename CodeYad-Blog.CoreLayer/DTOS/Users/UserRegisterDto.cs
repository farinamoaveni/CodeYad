using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeYad_Blog.CoreLayer.DTOS.Users
{
    public class UserRegisterDto
    {
        [Required(ErrorMessage = "نام کاربری الزامی است")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "کلمه عبور الزامی است")]
        [MinLength(6, ErrorMessage = "کلمه عبور باید حداقل 6 کاراکتر باشد")]
        public string Password { get; set; }

        [Required(ErrorMessage = "تکرار کلمه عبور الزامی است")]
        [Compare(nameof(Password), ErrorMessage = "کلمه عبور و تکرار آن مطابقت ندارند")]
        public string ConfirmPassword { get; set; }

        [Required(ErrorMessage = "نام کامل الزامی است")]
        public string FullName { get; set; }
    }
}
