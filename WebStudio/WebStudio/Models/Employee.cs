using LiteDB;

namespace WebStudio.Models
{
    public class Employee
    {
        [BsonId]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Post { get; set; }

        public override string ToString()
        {
            return $"{Name} :[{Post}]";
        }
    }
}
