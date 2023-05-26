using Hotel_Booking_System.Models;
using Microsoft.EntityFrameworkCore;

namespace Hotel_Booking_System.Repositories.Customer_Repositories
{
    public class Customer_Repository:ICustomer
    {
        private readonly HotelContext _CustomerContext;
        public Customer_Repository(HotelContext context)
        {
            _CustomerContext = context;
        }
        //GetAllCustomer
        public IEnumerable<Customer> GetAllCustomers()
        {
            return _CustomerContext.Customers.ToList();
        }
        //GetCustomerById
        public Customer GetCustomersById(int Customer_Id)
        {
            return _CustomerContext.Customers.FirstOrDefault(x => x.Customer_Id == Customer_Id);
        }
        //PostCustomer
        public Customer PostCustomer(Customer Customer)
        {
            var emp = _CustomerContext.Hotels.Find(Customer.Hotel.Hotel_Id);
            Customer.Hotel = emp;
            _CustomerContext.Add(Customer);
            _CustomerContext.SaveChanges();
            return Customer;
        }
        //PutCustomer
        public Customer PutCustomer(int Customer_Id, Customer Customer)
        {
            var emp = _CustomerContext.Hotels.Find(Customer.Hotel.Hotel_Id);
            Customer.Hotel = emp;
            _CustomerContext.Entry(Customer).State = EntityState.Modified;
            _CustomerContext.SaveChangesAsync();
            return Customer;
        }
        //DeleteCustomer
        public Customer DeleteCustomer(int Customer_Id)
        {
            var emp = _CustomerContext.Customers.Find(Customer_Id);
            _CustomerContext.Customers.Remove(emp);
            _CustomerContext.SaveChanges();
            return emp;
        }
        //Filtering location
        public IEnumerable<Hotel> FilterLocation(string location)
        {
            var location_query = _CustomerContext.Hotels.Include(x => x.Rooms).AsQueryable();

            if (!string.IsNullOrEmpty(location))
            {
                location_query = location_query.Where(h => h.Hotel_Location.Contains(location));
            }
            return location_query.ToList();
        }
       
    }
}
 