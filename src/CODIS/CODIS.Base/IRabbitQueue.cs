namespace CODIS.Base
{
    public interface IRabbitQueue
    {
        void Add(Submit submit);
        SubmitResult GetSubmitResult(long submitId);
    }
}