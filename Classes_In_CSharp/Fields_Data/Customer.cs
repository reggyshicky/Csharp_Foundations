namespace Fields_Data
{
    public class Customer
    {
        public string Name;
        public int Id;
        public readonly List<Order> orders = new List<Order>(); 

        public Customer(int id)
        {
            this.Id = id;
            
        }
        public Customer(int id, string name)
            : this(id)
        {
            this.Name = name;
        }
        public void Promote()
        {
;        
        }

    }


}
