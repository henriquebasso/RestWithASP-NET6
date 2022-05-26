using RestWithASP_NET6.Model;
using System.Collections.Generic;
namespace RestWithASP_NET6.Services.Implementations
{
    public interface IPersonService
    {
        Person Create(Person person);
        Person FindByID(long id);

        List<Person> FindAll();

        Person Update(Person person);

        void Delete(long id);

    }
}