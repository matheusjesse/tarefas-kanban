namespace tarefas_kanban.Model {
    public class TaskModel
    {
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public List<SubTask> SubTasks { get; set; }
        public bool IsCompleted { get; set; }
        public DateTime DueDate { get; set; }
        public string Label { get; set; } = string.Empty;

        public TaskModel()
        {
            SubTasks = new List<SubTask>();
        }
    }

    public class SubTask
    {
        public string? Title { get; set; }
        public string? Description { get; set; }
    }

}
