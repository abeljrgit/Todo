namespace Todo.Repository
{
    public class CreateTodoDTO
    {
        public required string Title { get; set; }
        public required string Description { get; set; }
    }
}
