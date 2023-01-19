namespace ContosoUniversity.Models
{
    public class ErrorViewModel
    {
        // Removed nullable ta from string? for compliance with EF
        public string? RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}