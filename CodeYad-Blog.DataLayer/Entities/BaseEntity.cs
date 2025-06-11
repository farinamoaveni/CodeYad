using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeYad_Blog.DataLayer
{
    public class BaseEntity
    {
        public DateTime CreationDate { get; set; }
        public  bool IsDelete { get; set; }
    }
}
