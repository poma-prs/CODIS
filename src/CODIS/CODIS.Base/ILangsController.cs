using System.Collections.Generic;

namespace CODIS.Base
{
    public interface ILangsController
    {
        ITestingManager TestingManager { get; }

        ICollection<Language> GetLangs();
    }
}