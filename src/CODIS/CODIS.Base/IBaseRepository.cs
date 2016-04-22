namespace CODIS.Base
{
    public interface IBaseRepository<T>
    {
        T Get(long id);
        T Add(T entry);
        void Update(T entry);
        void Delete(T entry);
    }
}