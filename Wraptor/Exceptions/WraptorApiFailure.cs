using System.Net;

namespace Wraptor.Core.Exceptions;

public class WraptorApiFailure : Exception
{
    public HttpStatusCode StatusCode { get; }
    public string? ResponseBody { get; }

    public WraptorApiFailure(HttpStatusCode statusCode, string? responseBody = null)
        : base($"Wraptor API request failed with status {(int)statusCode} ({statusCode}).")
    {
        StatusCode = statusCode;
        ResponseBody = responseBody;
    }
}