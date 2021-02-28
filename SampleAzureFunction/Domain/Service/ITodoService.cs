using SampleAzureFunction.Domain.Model;

namespace SampleAzureFunction.Domain.Service
{
    public interface ITodoService
    {
        Todo FindTodo(int id);
        Todo[] FindTodos();
        Todo CreateTodo(Todo todo);
        Todo UpdateTodo(Todo todo);
        int DeleteTodo(int id);
    }
}