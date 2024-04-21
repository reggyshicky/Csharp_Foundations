using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    public class Customer
    {
        public int Id;
        public string Name;
        public List<Order> Orders;


        public Customer()
        {
            Orders = new List<Order>();
        }
   

        public Customer(int id)
            :this()
        {
            this.Id = id;
        }

        public Customer(int id, string name)
            : this(id)
        {
            this.Name = name;
        }

        //public Customer(int id, string name)
        //    : this()
        //{
        //    this.Id = id;
        //    this.Name = name;
        //}

        //when you have a class and that class has a list of objects make sure that list is always initialized
        //But, let's say you have more than one constructor, will you initialized in every constructor? yes you can
        //but there is an either way, use of ths like above. this() will first call the empty constructor when the
        //list has been initialized.
        //this(id) means the constructor that takes id will first be called
    }
}
