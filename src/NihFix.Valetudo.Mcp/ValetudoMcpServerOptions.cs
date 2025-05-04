using NihFix.Valetudo.Mcp;

public class ValetudoMcpServerOptions
{
    public const string SectionName = "ValetudoMcp";
    
    public ServerType ServerType { get; set; }
    
    public string RobotUri { get; set; }
    
    public string? Username { get; set; }
    
    public string? Password { get; set; }
}