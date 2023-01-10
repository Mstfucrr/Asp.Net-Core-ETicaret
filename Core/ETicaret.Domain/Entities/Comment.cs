using ETicaret.Domain.Entities.Common;

namespace ETicaret.Domain.Entities
{
    public class Comment : BaseEntity
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public int Rating { get; set; }
        public bool IsApproved { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual Product Product { get; set; }
        
    }
}
