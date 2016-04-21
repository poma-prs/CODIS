using System.Collections.Generic;

namespace Archive.API.Models
{
    public class ProblemResourceLimits
    {
        public long TimeLimitMillis { get; set; }
        public long MemoryLimitBytes { get; set; }
    }
}