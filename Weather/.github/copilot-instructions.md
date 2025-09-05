# MCP Server (C#) Quickstart

This project demonstrates how to build a simple Model Context Protocol (MCP) server in C# using the official SDK.

## References
- [MCP Documentation](https://modelcontextprotocol.io/)
- [C# SDK](https://github.com/modelcontextprotocol/csharp-sdk)
- [Server Quickstart Guide](https://modelcontextprotocol.io/quickstart/server)
- [Specification](https://spec.modelcontextprotocol.io/)

## Steps to Build a C# MCP Server

1. **Install .NET 8.0 or higher**
2. **Create a new console project:**
   ```powershell
   dotnet new console -n QuickstartWeatherServer
   cd QuickstartWeatherServer
   ```
3. **Add dependencies:**
   ```powershell
   dotnet add package ModelContextProtocol --prerelease
   dotnet add package Microsoft.Extensions.Hosting
   ```
4. **Replace `Program.cs` with the sample code from the [official quickstart](https://github.com/modelcontextprotocol/csharp-sdk/tree/main/samples/QuickstartWeatherServer).**
5. **Run the server:**
   ```powershell
   dotnet run
   ```
6. **Configure your MCP client (e.g., Claude Desktop, VS Code) to connect to this server.**

---

For more details, see the official documentation and SDK repository links above.
