namespace CODIS.Base
{
    public class Token
    {
        public long UserId { get; set; }
    }

    public interface IAuthManager
    {
        bool CheckToken(string token);
        Token GetData(string token);
    }
}