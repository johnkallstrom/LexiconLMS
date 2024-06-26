namespace LexiconLMS.Core.Entities
{
    public class Module : BaseEntity
    {
        public string Name { get; set; } = default!;
        public string Description { get; set; } = default!;
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public int CourseId { get; set; }
        public Course Course { get; set; } = default!;

        public ICollection<Document> Documents { get; set; } = [];
        public ICollection<Activity> Activities { get; set; } = [];
    }
}
