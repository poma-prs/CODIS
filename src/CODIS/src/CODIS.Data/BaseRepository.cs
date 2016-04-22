namespace CODIS.Data
{
    public interface IBaseRepository<T>
    {
        T Get(long id);
        T Add(T entry);
        void Update(long id, T entry);
        void Delete(long id);
    }
}