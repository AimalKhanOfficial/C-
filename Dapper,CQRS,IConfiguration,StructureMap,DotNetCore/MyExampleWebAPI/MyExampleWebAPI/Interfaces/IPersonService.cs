
using MyClassLibrary;

namespace MyExampleWebAPI.Interfaces
{
    public interface IPersonService
    {
        Person GetPersonByID(int personId);
    }
}
