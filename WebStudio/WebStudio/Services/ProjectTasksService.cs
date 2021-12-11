using WebStudio.Models;

namespace WebStudio.Services
{
    public class ProjectTasksService
    {
        private LiteDbContext _context;
        public ProjectTasksService(LiteDbContext context)
        {
            _context = context;
        }

        public List<ProjectTask> GetAll()
        {
            return _context.Database.GetCollection<ProjectTask>("ProjectTasks").FindAll().ToList();
        }

        public ProjectTask Get(int id)
        {
            return _context.Database.GetCollection<ProjectTask>("ProjectTasks").FindById(id);
        }

        public int Insert(ProjectTask projectTask)
        {
            _context.Database.GetCollection<ProjectTask>("ProjectTasks").Insert(projectTask);
            return 0;
        }

        public bool Update(ProjectTask projectTask)
        {
            return _context.Database.GetCollection<ProjectTask>("ProjectTasks").Update(projectTask);
        }

        public bool Delete(int id)
        {
            return _context.Database.GetCollection<ProjectTask>("ProjectTasks").Delete(id);
        }
    }
}
