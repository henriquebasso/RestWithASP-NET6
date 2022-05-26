namespace RestWithASP_NET6.Services
{
    public interface iPersonService
    {
        iPersonService Create(iPersonService person);
        iPersonService FindByID(long id);
        List<iPersonService> FindAll();
        iPersonService Update(iPersonService person);
        void Delete(long id);
    }
}
