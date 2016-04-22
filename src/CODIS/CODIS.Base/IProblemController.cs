using System.Collections.Generic;

namespace CODIS.Base
{
    public interface IProblemController
    {
        ICollection<Problem> GetCollection(long collectionId);
        string GetStatementUrl(long problemId);
    }
}