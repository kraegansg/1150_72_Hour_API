using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _72.Hour.Models
{
    public class ReplyCreate
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public Guid OwnerId { get; set; }
    }
}
