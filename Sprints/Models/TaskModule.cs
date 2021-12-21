namespace Sprints.Models
{
    public class TaskModule
    {
        public int Id { get; set; }
        public int ProjectId { get; set; }
        public int StatusId { get; set; }
        public int AssignedToUserId { get; set; }

        public string Detail { get; set; }

        public string CreatedOn { get; set; }

    }
}
