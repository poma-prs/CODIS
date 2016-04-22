using System.Collections.Generic;

namespace CODIS.Base
{
    public interface ISubmitsController
    {
        ICollection<long> Send(ICollection<Submit> submits);
        void Rejudge(ICollection<long> submitIds);
    }
}