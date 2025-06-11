using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeYad_Blog.DataLayer.Entities
{
    public class Post : BaseEntity
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(300)]
        public string Title { get; set; }
        [Required]
        public string Slug { get; set; }
        [Required]
        public  string Description { get; set; }
        public int Visit { get; set; }

        public  int  UserId { get; set; }
        [ForeignKey("UserId")]

        public  User User { get; set; }
        public int CategoryId { get; set; }
        [ForeignKey("CategoryId")]

        public Category Category { get; set; }
        #region Relations
        public ICollection<PostComment> PostComments { get; set; }
        #endregion





    }
}
