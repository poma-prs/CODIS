using System.Collections.Generic;
using Checking.API.Models;

namespace Checking.Base
{
    public interface ITestingManager
    {
        IRabbitQueue RabbitQueue { get; }

        ICollection<long> Submit(params Submit[] submits);
        ICollection<long> Rejudge(params long[] submitIds);
        ICollection<SubmitResult> GetResults(params long[] resultIds);
        ICollection<Language> GetLangs();
    }
}