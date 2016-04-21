using System.Collections.Generic;

namespace Archive.API.Models
{
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