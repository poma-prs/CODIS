using System.Collections.Generic;

namespace CODIS.Base
{
    public interface ITestingManager
    {
        ICollection<long> Send(ICollection<Submit> submits);
        void Rejudge(ICollection<long> submitIds);
        ICollection<SubmitResult> GetSubmitResults(ICollection<long> ids);
        ICollection<Language> GetLangs();
    }
}