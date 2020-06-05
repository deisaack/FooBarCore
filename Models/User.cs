
using System.Collections.Generic;

namespace FooBar.Models
{
    public class User
    {
        public User()
        {
            Addresses = new HashSet<Address>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public UserProfile Profile { get; set; }
        public ICollection<Address> Addresses { get; set; }
    }
}