namespace TailSpin.SpaceGame.Web.Models
{
    public class ErrorViewModel
    {
        // Request Id assigned by error handling code.
        public string RequestId { get; set; }
        
        // Show request id
        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}