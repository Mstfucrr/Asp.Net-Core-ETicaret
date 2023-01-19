using System.Text.Json.Serialization;
using ETicaret.Domain.Entities.Common;
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
        public virtual Guid? ParentCategoryId { get; set; }
        [JsonIgnore]
        public virtual ICollection<Category>? ChildCategories { get; set; }
        [JsonIgnore]
        public virtual ICollection<Product> Products { get; set; }


        public void CreateSlug()
        {
            var str = ParentCategory == null ? this.Name.ToLower() : this.ParentCategory.Slug + "-" + Name.ToLower();
            str = Replace(str, @"[^a-z0-9\s-]", "");
            str = Replace(str, @"\s+", " ").Trim();
            str = Replace(str, @"\s", "-");
            Slug = str;
        }

    }
}
