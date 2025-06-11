using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeYad_Blog.DataLayer.Entities
{
    public class PostComment : BaseEntity
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public  string Text { get; set; }
        

        public int PostId { get; set; }
        [ForeignKey("PostId")]

        public Post Post { get; set; }
        public int UserId { get; set; }
        [ForeignKey("UserId")]

        public User User { get; set; }
    }
}
