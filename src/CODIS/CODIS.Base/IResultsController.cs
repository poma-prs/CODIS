using System.Collections.Generic;

namespace CODIS.Base
{
    public interface IResultsController
    {
        ITestingManager TestingManager { get; }

        ICollection<SubmitResult> GetSubmitResults(ICollection<long> ids, string token);
    }
}