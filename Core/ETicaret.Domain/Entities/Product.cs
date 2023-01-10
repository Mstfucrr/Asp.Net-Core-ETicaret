using ETicaret.Domain.Entities.Common;
using System.Text.RegularExpressions;
using static System.Text.RegularExpressions.Regex;

namespace ETicaret.Domain.Entities
{
    public class Product : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public bool Status { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }
        public virtual Category Category { get; set; }
        public string Slug { get; set; }

        public Product()
        {
            //Slug = GenerateSlug(Name);
        }

        public static string GenerateSlug(string title)
        {
            // Düzeltilmiş başlığı tutacak değişken
            var slug = "";

            // Başlıktaki tüm harfleri küçültün
            slug = title.ToLowerInvariant();

            // Başlıktaki tüm özel karakterleri kaldırın
            slug = Replace(slug, @"[^a-z0-9\s-]", "");

            // Başlıktaki tüm boşlukları tire (-) ile değiştirin
            slug = Replace(slug, @"\s+", " ").Trim();

            // Başlıktaki tüm boşlukları tire ile değiştirin
            slug = Replace(slug, @"\s", "-");

            // Slug'ı döndürün
            return slug;
        }

    }
}
