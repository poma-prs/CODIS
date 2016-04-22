namespace CODIS.Base
{
    public interface IRoleManager
    {
        void SetAccess(string methodId, string token);
    }
}