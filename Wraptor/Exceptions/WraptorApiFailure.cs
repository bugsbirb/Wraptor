using System.Net;

namespace Wraptor.Core.Exceptions;

public class WraptorApiFailure(HttpStatusCode statusCode, string? responseBody = null)
    : Exception($"Wraptor API request failed with status {(int)statusCode} ({statusCode}).")
{
    public HttpStatusCode StatusCode { get; } = statusCode;
    public string? ResponseBody { get; } = responseBody;
}
