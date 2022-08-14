using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project4.Entities
{
    public class Customer:IEntity
    {

        public int customerId { get; set; }
        public string customerName { get; set; }

        public string customerSurname { get; set; }

        public int customerPhone { get; set; }
    }
}
