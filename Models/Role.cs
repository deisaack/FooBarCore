using System.Collections.Generic;

namespace FooBar.Models
{
    public class Role
    {
        public Role()
        {
            Users = new HashSet<UserRole>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        private ICollection<UserRole> Users { get; set; }
    }
}