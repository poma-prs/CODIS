using System.Collections.Generic;

namespace CODIS.Base
{
    public interface ILangsController
    {
        ICollection<Language> GetLangs();
    }
}