using System.Collections.Generic;

namespace CODIS.Base
{
    public class Problem
    {
        public Dictionary<string, ProblemInfo> Info { get; set; }
        public Statement Statement { get; set; }
        public ProblemResourceLimits ResourceLimits { get; set; }
    }

    public class Statement
    {
        public StatementVersion Version { get; set; }
    }

    public class StatementVersion
    {
        public string Language { get; set; }
        public string Format { get; set; }
    }

    public class ProblemInfo
    {
        public string Name { get; set; }
    }

    public class ProblemResourceLimits
    {
        public long TimeLimitMillis { get; set; }
        public long MemoryLimitBytes { get; set; }
    }
}