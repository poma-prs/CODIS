namespace Checking.API.Models
{
    public class SubmitModel
    {
        public long Id { get; set; }
        public long LangId { get; set; }
        public byte[] Solution { get; set; }
    }
}