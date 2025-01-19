namespace CRUD_MVC.Models
{
    public class ErrorViewModel
    {
        public string? RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
        public required string ErrorMessage { get; set; }
        public required string EnvironmentName { get; set; }
        public required string ReturnURL { get; set; }
    }
}
