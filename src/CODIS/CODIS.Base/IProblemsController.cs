﻿using System.Collections.Generic;

namespace CODIS.Base
{
    public interface IProblemsController
    {
        IArchiveManager ArchiveManager { get; }

        ICollection<Problem> GetCollection(long collectionId, string token);
        string GetStatementUrl(long problemId, string token);
    }
}