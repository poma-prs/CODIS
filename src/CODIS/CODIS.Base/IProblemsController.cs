using System.Collections.Generic;

namespace CODIS.Base
{
    public interface IProblemsController
    {
        ICollection<Problem> GetCollection(long collectionId, string token);
        string GetStatementUrl(long problemId, string token);
    }
}