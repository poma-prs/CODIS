using Checking.API.Models;
using CODIS.Data;

namespace Checking.Base
{
    public interface ISubmitCallbackServer
    {
        IBaseRepository<Submit> SubmitRepository { get; }

        void Start();
    }
}