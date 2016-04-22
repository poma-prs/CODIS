using Checking.API.Models;

namespace Checking.Base
{
    public interface IRabbitQueue
    {
        void Push(Submit submit);
        SubmitResult GetSubmitResult();
    }
}