using NearshoreDevs.Application.CQRS.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NearshoreDevs.Application.CQRS
{
    public class Customer
    {
        public Customer()
        {
            Invoices = new List<Invoice>();
        }
        public int Id { get; set; }
        public string Title { get; set; }
        public string Name { get; set; }
       
        public string Address { get; set; }
        public virtual IList<Invoice> Invoices { get; set; }
    }
   
}
