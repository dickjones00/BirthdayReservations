using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataLayer.Model
{
    public class Order : BaseEntity
    {
        public bool Accontation { get; set; }
        public DateTime OrderDate { get; set; }
        public int TimeSpanFrom { get; set; }
        public int TimeSpanTo { get; set; }
        public string Package { get; set; }
        public string Note { get; set; }

        public Guid CakeId { get; set; }
        public Guid CustomerId { get; set; }

        public virtual Cake Cake { get; set; }
        public virtual Customer Customer { get; set; }

        public string CustomerName { get; set; }
        public string CakeName { get; set; }
    }
}
