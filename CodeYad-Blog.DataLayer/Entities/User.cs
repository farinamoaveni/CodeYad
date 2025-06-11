using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeYad_Blog.DataLayer.Entities

{
    public class User : BaseEntity
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public  string UserName { get; set; }
        public  string FullName  { get; set; }
        [Required]
        public  string Password { get; set; }
      
        public UserRole Role { get; set; }
        
        #region Relations
        public ICollection<Post> Posts { get; set; }
        public ICollection<PostComment> PostComments { get; set; }
        #endregion

    }
    public enum UserRole
    {
       Admin,
       User,
       Writer
    }
}
