using System.Collections.Generic;

namespace CODIS.Base
{
    public interface ISubmitsController
    {
        IRabbitQueue RabbitQueue { get; }
        ISubmitRepository SubmitRepository { get; }
        IAuthManager AuthManager { get; }
        ITestingManager TestingManager { get; }

        ICollection<long> Send(ICollection<Submit> submits, string token);
        void Rejudge(ICollection<long> submitIds, string token);
    }
}