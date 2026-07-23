using Wraptor.Models;

namespace Wraptor.Services.Health;

public interface IHealth
{
    /// <summary>
    /// Checks the status of the bot
    /// </summary>
    /// <returns>True if the API is reachable.</returns>
    Task<WraptorResponse<Live>> Live();
    
    /// <summary>
    ///  Get metrics from Melonly's server
    /// </summary>
    /// <returns>Metric information for the status & data pool size</returns>
    Task<WraptorResponse<Metrics>> Metrics();
    
    /// <summary>
    ///  Check if Melonly services are up
    /// </summary>
    /// <returns>Returns the status of redis and the database.</returns>
    Task<WraptorResponse<Ready>> Ready();
    

}