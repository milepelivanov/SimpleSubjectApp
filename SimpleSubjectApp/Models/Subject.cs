namespace SimpleSubjectApp.Models
{
    public class Subject
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int WeeklyClasses { get; set; }
        public List<string> LiteratureUsed { get; set; }

      

    }
}
