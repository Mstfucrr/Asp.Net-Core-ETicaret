using ETicaret.Domain.Entities.Common;

namespace ETicaret.Domain.Entities
{
    public class AppUser : BaseEntity
    {
        public string Name { get; set; }
        public string Lastname { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

    }
}
