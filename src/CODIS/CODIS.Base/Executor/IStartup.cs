using CODIS.Base;

namespace Executor.Base
{
    public interface IStartup
    {
        IExecutorWebSpec WebSpec { get; }
        ILangsController LangController { get; }
        IResultsController ResultsController { get; }
        ISubmitsController SubmitsController { get; }
    }
}