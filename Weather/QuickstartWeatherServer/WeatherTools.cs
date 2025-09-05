
// Import the ModelContextProtocol.Server namespace for MCP server tool attributes
using ModelContextProtocol.Server;
// Import for adding descriptions to methods and parameters
using System.ComponentModel;
// Import for culture-specific operations (not used here, but often included for string ops)
using System.Globalization;
// Import for JSON serialization (not used here, but useful for JSON handling)
using System.Text.Json;

// Declare the namespace for the tools in this project
namespace QuickstartWeatherServer.Tools;

// Attribute to mark this class as a container for MCP server tools
[McpServerToolType]
// Define a static class to hold all weather-related MCP tools
public static class WeatherTools
{
    // Attribute to mark this method as an MCP tool and provide a description
    [McpServerTool, Description("Get weather alerts for a US state.")]
    // Define a static method to get alerts for a given US state
    public static Task<string> GetAlerts(
        // Add a description to the 'state' parameter for documentation
        [Description("The US state to get alerts for.")] string state)
    {
        // Create a dictionary mapping state codes to alert JSON strings
        var alerts = new Dictionary<string, string>
        {
            // Add a dummy alert for California (CA)
            { "CA", "[{\"event\":\"Flood Advisory\",\"area\":\"Imperial, CA\",\"severity\":\"Minor\",\"description\":\"Flooding caused by excessive rainfall is expected.\"}]" },
            // Add a dummy alert for New York (NY)
            { "NY", "[{\"event\":\"Winter Storm Warning\",\"area\":\"Albany, NY\",\"severity\":\"Severe\",\"description\":\"Heavy snow expected.\"}]" }
        };
        // Try to get the alert for the requested state (case-insensitive)
        alerts.TryGetValue(state.ToUpperInvariant(), out var result);
        // Return the alert JSON string, or an empty array if not found
        return Task.FromResult(result ?? "[]");
    }

    // Attribute to mark this method as an MCP tool and provide a description
    [McpServerTool, Description("Get weather forecast for a location.")]
    // Define a static method to get the weather forecast for a given location
    public static Task<string> GetForecast(
        // Add a description to the latitude parameter
        [Description("Latitude of the location.")] double latitude,
        // Add a description to the longitude parameter
        [Description("Longitude of the location.")] double longitude)
    {
        // Create a dummy forecast JSON string
        var forecast = "{\"periods\":[{\"name\":\"Today\",\"temperature\":75,\"shortForecast\":\"Sunny\"},{\"name\":\"Tonight\",\"temperature\":60,\"shortForecast\":\"Clear\"}]}";
        // Return the forecast JSON string
        return Task.FromResult(forecast);
    }

    // Attribute to mark this method as an MCP tool and provide a description
    [McpServerTool, Description("Get current weather observations for a location.")]
    // Define a static method to get current weather observations for a given location
    public static Task<string> GetCurrentObservations(
        // Add a description to the latitude parameter
        [Description("Latitude of the location.")] double latitude,
        // Add a description to the longitude parameter
        [Description("Longitude of the location.")] double longitude)
    {
        // Create a dummy observation JSON string
        var obs = "{\"temperature\":72,\"humidity\":50,\"windSpeed\":\"5 mph\",\"description\":\"Clear\"}";
        // Return the observation JSON string
        return Task.FromResult(obs);
    }

    // Attribute to mark this method as an MCP tool and provide a description
    [McpServerTool, Description("Get list of weather stations near a location.")]
    // Define a static method to get a list of nearby weather stations for a given location
    public static Task<string> GetNearbyStations(
        // Add a description to the latitude parameter
        [Description("Latitude of the location.")] double latitude,
        // Add a description to the longitude parameter
        [Description("Longitude of the location.")] double longitude)
    {
        // Create a dummy stations JSON string
        var stations = "[{\"stationId\":\"STN001\",\"name\":\"Downtown Station\"},{\"stationId\":\"STN002\",\"name\":\"Airport Station\"}]";
        // Return the stations JSON string
        return Task.FromResult(stations);
    }

    // Attribute to mark this method as an MCP tool and provide a description
    [McpServerTool, Description("Get general weather service info.")]
    // Define a static method to get general information about the weather service
    public static Task<string> GetServiceInfo()
    {
        // Create a dummy service info JSON string
        var info = "{\"service\":\"Local Weather MCP Server\",\"version\":\"1.0\"}";
        // Return the service info JSON string
        return Task.FromResult(info);
    }
}
