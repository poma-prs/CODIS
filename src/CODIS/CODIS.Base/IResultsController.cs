using System.Collections.Generic;

namespace CODIS.Base
{
    public interface IResultsController
    {
        IResultRepository ResultRepository { get; }
        IAuthManager AuthManager { get; }
        ITestingManager TestingManager { get; }

        ICollection<SubmitResult> GetSubmitResults(ICollection<long> ids, string token);
    }
}