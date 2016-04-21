using System.Collections.Generic;

namespace Checking.API.Models
{
    public class SubmitResult
    {
        public long Id { get; set; }
        public BuildResult BuildResult { get; set; }
        public ICollection<TestGroupResult> TestResults { get; set; }
    }

    public class BuildResult
    {
        public BuildResultStatus Status { get; set; }
        public string Output { get; set; }
    }

    public enum BuildResultStatus
    {
        Ok = 0,
        Failed = 1
    }

    public class TestGroupResult
    {
        public bool Executed { get; set; }
        public ICollection<TestResult> TestResults { get; set; }
    }

    public class TestResult
    {
        public JudgeResultStatus Status { get; set; }
        public string JudgeMessage { get; set; }
        public ResourceUsage ResourceUsage { get; set; }
    }

    public class ResourceUsage
    {
        public ulong TimeUsageMillis { get; set; }
        public ulong MemoryUsageBytes { get; set; }
    }

    public enum JudgeResultStatus
    {
        Ok = 0,
        WrongAnswer = 1,
        PresentationError = 2,
        QueriesLimitExceeded = 3,
        IncorrectRequest = 4,
        InsufficientData = 5,
        ExcessData = 6,
        OutputLimitExceeded = 7,
        TerminationRealTimeLimitExceeded = 8,
        CustomFailure = 500,
        FailTest = 999,
        Failed = 1000,
        Skipped = 2000,
    }
}