using System.Net;
using Newtonsoft.Json;
using Wraptor.Core.Exceptions;

namespace Wraptor.Core.Models;

public class WraptorResponse<T>(HttpStatusCode responseStatusCode, T? deserializeObject)
    where T : class
{
    public HttpStatusCode StatusCode { get; private set; } = responseStatusCode;
    public T? Data { get; private set; } = deserializeObject;

    public bool IsSuccess()
    {
        return (int)StatusCode >= 200 && (int)StatusCode <= 299;
    }

    public T EnsureData()
    {
        if (!IsSuccess() || Data is null)
        {
            throw new WraptorApiFailure(StatusCode, "No data returned.");
        }
        return Data;
    }

    protected internal static WraptorResponse<T> FromResponse(HttpResponseMessage response)
    {
        string body = response.Content.ReadAsStringAsync().GetAwaiter().GetResult();
        if (!response.IsSuccessStatusCode)
        {
            throw new WraptorApiFailure(response.StatusCode, body);
        }
        return new WraptorResponse<T>(
            response.StatusCode,
            response.IsSuccessStatusCode ? JsonConvert.DeserializeObject<T>(body) : null
        );
    }

    public static implicit operator T?(WraptorResponse<T> response)
    {
        return response?.Data;
    }
}
