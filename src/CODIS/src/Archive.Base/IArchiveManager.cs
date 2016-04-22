using System.Collections.Generic;
using Archive.API.Models;
using CODIS.Data;

namespace Archive.Base
{
    public interface IArchiveManager
    {
        IBaseRepository<Problem> ProblemRepository { get; }

        ICollection<Problem> GetCollection(long id);
        string GetStatementUrl(long problemId);
    }
}
