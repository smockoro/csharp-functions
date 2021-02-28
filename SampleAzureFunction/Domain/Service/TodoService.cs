using SampleAzureFunction.Domain.Model;
using SampleAzureFunction.Domain.Repository;

namespace SampleAzureFunction.Domain.Service
{
    public class TodoService : ITodoService
    {
        private readonly ITodoRepository _todoRepository;

        public TodoService(ITodoRepository todoRepository)
        {
            this._todoRepository = todoRepository;
        }

        public Todo FindTodo(int id)
        {
            return new Todo();
        }
        public Todo[] FindTodos()
        {
            return this._todoRepository.SelectAll();
        }
        public Todo CreateTodo(Todo todo)
        {
            return new Todo();
        }
        public Todo UpdateTodo(Todo todo)
        {
            return new Todo();
        }
        public int DeleteTodo(int id)
        {
            return 1;
        }
    }
}