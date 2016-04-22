using CODIS.Base;

namespace Archive.Base
{
    public interface IStartup
    {
         IArchiveWebSpec WebSpec { get; }
        IProblemsController ProblemsController { get; }
    }
}