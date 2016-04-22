using System.Collections.Generic;

namespace CODIS.Base
{
    public interface ISubmitsController
    {
        ITestingManager TestingManager { get; }

        ICollection<long> Send(ICollection<Submit> submits, string token);
        void Rejudge(ICollection<long> submitIds, string token);
    }
}