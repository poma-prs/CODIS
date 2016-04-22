using System.Collections.Generic;

namespace CODIS.Base
{
    public interface ILangsController
    {
        ILangRepository LangRepository { get; }
        ITestingManager TestingManager { get; }

        ICollection<Language> GetLangs();
    }
}