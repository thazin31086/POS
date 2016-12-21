namespace Jasmine.POS.Common.Models
{
    public class OperationStatus
    {
        public bool Success { get; set; }
        public string Message { get; set; }
        public string InnerExceptionMessage { get; set; }
        public object ResultData { get; set; }
    }
}
