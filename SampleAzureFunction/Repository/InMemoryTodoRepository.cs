using SampleAzureFunction.Domain.Model;
using SampleAzureFunction.Domain.Repository;

namespace SampleAzureFunction.Repository
{
    public class InMemoryTodoRepository : ITodoRepository
    {
        public Todo SelectOne(int id)
        {
            //TODO: not implement method.
            return null;
        }

        public Todo[] SelectAll()
        {
            var todos = new Todo[]{
                new Todo(id: 1, name: "sample todo 1", status: false),
                new Todo(id: 2, name: "sample todo 2", status: false),
                new Todo(id: 3, name: "sample todo 3", status: false),
            };
            return todos;
        }
    }
}