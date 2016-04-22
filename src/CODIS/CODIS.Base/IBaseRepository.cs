namespace CODIS.Base
{
    public interface IBaseRepository
    {
        object Get(long id);
		object Add(object entry);
		void Update(object entry);
		void Delete(object entry);
    }
}