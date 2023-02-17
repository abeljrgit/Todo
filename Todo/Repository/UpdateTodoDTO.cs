namespace Todo.Repository
{
    public class UpdateTodoDTO
    {
        public required int Id { get; set; }
        public required string Title { get; set; }
        public required string Description { get; set; }
    }
}
