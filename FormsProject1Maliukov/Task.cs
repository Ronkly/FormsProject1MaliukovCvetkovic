namespace FormsProject1MaliukovCvetkovic
{
    public class Task
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime DueDate { get; set; }
        public bool IsCompleted { get; set; }
        public string author_ID { get; set; }
        public Task(string title, string description, DateTime dueDate, string ID)
        {
            Title = title;
            Description = description;
            DueDate = dueDate;
            IsCompleted = false;
            author_ID = ID;
        }
        public void MarkAsCompleted()
        {
            IsCompleted = true;
        }
    }
}
