using WebStudio.Models;

namespace WebStudio.Services
{
    public class EmployeesService
    {
        private LiteDbContext _context;
        public EmployeesService(LiteDbContext context)
        {
            _context = context;
        }

        public List<Employee> GetAll()
        {
            return _context.Database.GetCollection<Employee>("Employees").FindAll().ToList();
        }

        public Employee Get(int id)
        {
            return _context.Database.GetCollection<Employee>("Employees").FindById(id);

        }

        public int Insert(Employee employee)
        {
            return _context.Database.GetCollection<Employee>("Employees").Insert(employee);
            
        }

        public bool Update(Employee employee)
        {
            return _context.Database.GetCollection<Employee>("Employees").Update(employee);
        }

        public bool Delete(int id)
        {
            return _context.Database.GetCollection<Employee>("Employees").Delete(id);
        }
    }
}
