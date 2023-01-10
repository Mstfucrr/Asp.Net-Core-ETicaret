using ETicaret.Domain.Entities.Common;
using System.Text.RegularExpressions;
using static System.Text.RegularExpressions.Regex;

namespace ETicaret.Domain.Entities
{
    public class Category : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public bool Status { get; set; }
        public string Slug { get; set; }
        public virtual Category? ParentCategory { get; set; }
        public virtual ICollection<Product> Products { get; set; }

        
    }
}
