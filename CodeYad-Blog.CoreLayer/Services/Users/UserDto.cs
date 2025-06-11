using CodeYad_Blog.DataLayer.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeYad_Blog.CoreLayer.Services.Users
{
    public class UserDto
    {
        public  int UserId { get; set; }
        public  DateTime RegisterDate  { get; set; }
        public string UserName { get; set; }
        public string FullName { get; set; }
        [Required]
        public string Password { get; set; }

        public UserRole Role { get; set; }
    }
}
