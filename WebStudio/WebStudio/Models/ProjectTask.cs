using LiteDB;

namespace WebStudio.Models
{
    public class ProjectTask
    {
        [BsonId]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public double Price { get; set; }
        public bool Completed { get; set; }
        //[BsonRef("Projects")]
        //public int ProjectForeingKey { get; set; }
        //[BsonRef("Employees")]
        //public int EmployeeForeingKey { get; set; }

        [BsonIgnore]
        public string PriceString
        {
            get => Price.ToString();
            set => Price = double.Parse(value);
        }

        //public override string ToString()
        //{
        //    return $"[{ProjectForeingKey}][{EmployeeForeingKey}]{Title} : {Price}$\n{Description}\n[{StartDate} - {EndDate}]";
        //}
    }
}
