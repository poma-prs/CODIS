using System.Collections.Generic;

namespace CODIS.API.Models
{
    public class SubmitResultModel
    {
        public long Id { get; set; }
        public BuildResultModel BuildResult { get; set; }
        public ICollection<TestGroupResultModel> TestResults { get; set; }
    }

    public class BuildResultModel
    {
        public BuildResultStatus Status { get; set; }
        public string Output { get; set; }
    }

    public enum BuildResultStatus
    {
        Ok = 0,
        Failed = 1
    }

    public class TestGroupResultModel
    {
        public bool Executed { get; set; }
        public ICollection<TestResultModel> TestResults { get; set; }
    }

    public class TestResultModel
    {
        public JudgeResultStatus Status { get; set; }
        public string JudgeMessage { get; set; }
        public ResourceUsageModel ResourceUsage { get; set; }
    }

    public class ResourceUsageModel
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