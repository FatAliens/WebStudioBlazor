using LiteDB;

namespace WebStudio.Services
{
    public class LiteDbContext
    {
        public LiteDatabase Database { get; private set; }
        public LiteDbContext()
        {
            Database = new LiteDatabase(@"D:\MyData.db");
        }
    }
}
