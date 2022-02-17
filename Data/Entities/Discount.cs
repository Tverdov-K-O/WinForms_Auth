using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForms_Auth.Data.Entities
{
    public class Discount
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public DateTime Start { get; set; }
        public DateTime Finish { get; set; }
        public int Percent { get; set; }
        public virtual ICollection<Book> Books { get; set; }
        public override string ToString()
        {
            return this.Name + " " + this.Percent.ToString() + "%";
        }
    }
}
