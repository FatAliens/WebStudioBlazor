using WebStudio.Models;

namespace WebStudio.Services
{
    public class CustomersService
    {
        private LiteDbContext _context;
        public CustomersService(LiteDbContext context)
        {
            _context = context;
        }

        public List<Customer> GetAll()
        {
            return _context.Database.GetCollection<Customer>("Customers").FindAll().ToList();
        }

        public Customer Get(int id)
        {
            return _context.Database.GetCollection<Customer>("Customers").FindById(id);

        }

        public int Insert(Customer customer)
        {
            _context.Database.GetCollection<Customer>("Customers").Insert(customer);
            return 0;
        }

        public bool Update(Customer customer)
        {
            return _context.Database.GetCollection<Customer>("Customers").Update(customer);
        }

        public bool Delete(int id)
        {
            return _context.Database.GetCollection<Customer>("Customers").Delete(id);
        }
    }
}
