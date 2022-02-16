using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForms_Auth.Data.Entities
{
    public class User
    {
        public Guid Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public Guid RoleId { get; set; }
        public virtual  Role Role { get; set; }
        public virtual ICollection<Role> Roles { get; set; }
        public virtual ICollection<Book> Books { get; set; }
        public byte[] Avatar { get; set; }
    }
}
