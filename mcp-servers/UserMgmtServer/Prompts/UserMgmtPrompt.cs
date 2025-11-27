using System;
using System.ComponentModel;
using ModelContextProtocol.Server;

namespace UserMgmtServer.Prompts;

[McpServerPromptType]
public class UserMgmtPrompt
{
    
    [McpServerPrompt(Name ="Execute_fullRecon_prompt")]
    [Description("Get a prompt for executing a full recon action")]
    public static string ExecuteFullRecon()
    {
        return """
        You're an application manager who manages uses and you need to deliver a monthy report of the users, authorisation groups and which user has which authorisation group in your system.
        1. Use the `user-mgmt` MCP server.
        1. Provide a structured response in a table format that includes the users present in the system. 
           Here's an example of the table format:
           | nr | User         |
           |--------|--------------|
           | 1    | User    |

        1. Provide a structured response in a table format that includes the authorisation groups present in the system. 
           Here's an example of the table format:
           | nr | authorisation         |
           |--------|--------------|
           | 1    | autionrisationgroup   |

        1. Provide a structured response in a table format that includes the user and its assigned authorisation group. 
           Here's an example of the table format:
           | nr | User |authorisation         |
           |--------|--------------|--------------|
           | 1    | User |autionrisationgroup   |
        
        """;
    }

}
