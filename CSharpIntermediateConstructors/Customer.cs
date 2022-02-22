using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpIntermediateConstructors
{
    public class Customer
    {
        public int Id;
        public string Name;
        public List<Order> Orders;  //List is a generic class and takes a parameter. We can store type objects of orders.

        public Customer()
        {
            //Orders = new List<Order>();

        }

        public Customer(int id) //ctor this is code snippet

        {
            this.Id = Id;

        }

        public Customer(int id, string name)
        {
            this.Id= id;
            this.Name = name;
        }
    }
}

//ctrl tab to switch to files.