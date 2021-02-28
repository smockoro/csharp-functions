using SampleAzureFunction.Domain.Model;

namespace SampleAzureFunction.Domain.Repository
{
    public interface ITodoRepository
    {
        Todo SelectOne(int id);
        Todo[] SelectAll();
    }
}