using LiteDB;

namespace WebStudio.Models
{
    public class Customer
    {
        [BsonId]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        public override string ToString()
        {
            return $"{Title}\n{Description}";
        }
    }
}
