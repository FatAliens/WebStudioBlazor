using LiteDB;

namespace WebStudio.Models
{
    public class Project
    {
        [BsonId]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public double Price { get; set; }
        public bool IsCompleted { get; set; }
        [BsonRef("Customers")]
        public Customer CustomerForeingKey { get; set; }

        [BsonIgnore]
        public string PriceString
        {
            get => Price.ToString();
            set => Price = double.Parse(value);
        }

        public override string ToString()
        {
            return $"[{CustomerForeingKey}]{Title} : {Price}$\n{Description}\n[{StartDate} - {EndDate}]";
        }
    }
}
