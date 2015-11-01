using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataLayer.Model
{
    public class Customer : BaseEntity
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public DateTime BirthdayDate { get; set; }
        public string ContactPerson { get; set; }
        public string PhoneNumber { get; set; }
        public string Note { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
    }
}
