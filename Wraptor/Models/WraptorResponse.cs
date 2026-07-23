using System.Net;
using Newtonsoft.Json;

namespace Wraptor.Core.Models;

// Credit: https://github.com/1FriendlyDoge/BloxlinkSharp/blob/master/BloxlinkSharp/Models/BloxlinkResponse.cs
public class WraptorResponse<T>(HttpStatusCode responseStatusCode, T? deserializeObject) where T: class
{
    public HttpStatusCode StatusCode { get; private set; }
    public T? Data { get; private set; }

    public bool IsSuccess()
    {
        return (int) StatusCode >= 200 && (int) StatusCode <= 299;
    }

    protected internal static WraptorResponse<T> FromResponse(HttpResponseMessage response)
    {
        return new WraptorResponse<T>(
            response.StatusCode, 
            response.IsSuccessStatusCode 
                ? JsonConvert.DeserializeObject<T>(response.Content.ReadAsStringAsync().GetAwaiter().GetResult()) 
                : null
        );
    }
    public static implicit operator T?(WraptorResponse<T> response)
    {
        return response?.Data;
    }
}