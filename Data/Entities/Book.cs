using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForms_Auth.Data.Entities
{
    public class Book
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string NameAuthor { get; set; }
        public string NamePublisher { get; set; }
        public double Price { get; set; }
        public int CountPage { get; set; }
        public int TomNumber { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime DateRelease { get; set; }
        public virtual ICollection<Genre> Genres { get; set; }
        public virtual ICollection<Discount> Discounts { get; set; }
        public virtual ICollection<User> Users { get; set; }
        public byte[] Avatar { get; set; }

        public override string ToString()
        {
            return this.Name;
        }
    }
}
