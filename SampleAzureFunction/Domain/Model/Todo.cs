namespace SampleAzureFunction.Domain.Model
{
    public class Todo
    {
        public int Id {get; set;}
        public string Name {get; set;}
        public bool Status {get; set;}

        public Todo() {}
        public Todo(int id, string name, bool status)
        {
            this.Id = id;
            this.Name = name;
            this.Status = status;
        }
    }
}