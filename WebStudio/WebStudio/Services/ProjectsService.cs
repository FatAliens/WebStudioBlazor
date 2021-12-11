using WebStudio.Models;

namespace WebStudio.Services
{
    public class ProjectsService
    {
        private LiteDbContext _context;
        public ProjectsService(LiteDbContext context)
        {
            _context = context;
        }

        public List<Project> GetAll()
        {
            return _context.Database.GetCollection<Project>("Projects").FindAll().ToList();
        }

        public Project Get(int id)
        {
            return _context.Database.GetCollection<Project>("Projects").FindById(id);
            
        }

        public int Insert(Project project)
        {
            _context.Database.GetCollection<Project>("Projects").Insert(project);
            return 0;
        }

        public bool Update(Project project)
        {
            return _context.Database.GetCollection<Project>("Projects").Update(project);
        }

        public bool Delete(int id)
        {
            return _context.Database.GetCollection<Project>("Projects").Delete(id);
        }
    }
}
