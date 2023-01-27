namespace ASP_NetCore_6.Models;

public class ErrorViewModel
{
    public string? RequestId { get; set; } // ? means optional

    public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
}