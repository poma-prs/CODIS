using System.Collections.Generic;

namespace CODIS.Base
{
    public interface IProblemsController
    {
        ICollection<Problem> GetCollection(long collectionId);
        string GetStatementUrl(long problemId);
    }
}