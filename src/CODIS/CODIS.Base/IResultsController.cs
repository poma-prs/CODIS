using System.Collections.Generic;

namespace CODIS.Base
{
    public interface IResultsController
    {
        ICollection<SubmitResult> GetSubmitResults(ICollection<long> ids, string token);
    }
}