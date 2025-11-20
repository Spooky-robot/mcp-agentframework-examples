using System;
using System.ComponentModel;
using ModelContextProtocol.Server;

namespace UserMgmtServer.Tools;

[McpServerToolType]
public class UserTools
{
    // Normaly youl declare your Http Client dependencys here

    public UserTools()
    {
    }

    [McpServerTool, Description("Get all users in the system")]
    [McpMeta("category", "User Management")]
    [McpMeta("dataSource", "UserDB")]
    public IEnumerable<string> GetAllUsers()
    {
        // Normally you would call your user database here
        return new List<string>
        {
            "Alice",
            "Bob",
            "Charlie"
        };
    }

    [McpServerTool, Description("Get all auth groups in the system")]
    [McpMeta("category", "User Management")]
    [McpMeta("dataSource", "AuthGroupDB")]
    public IEnumerable<string> GetAllAuthGroups()
    {
        // Normally you would call your auth group database here
        return new List<string>
        {
            "Admins",
            "Users",
            "Guests"
        };
    }

    [McpServerTool, Description("Get all users whith thier assigned auth groups in the system")]
    [McpMeta("category", "User Management")]
    [McpMeta("dataSource", "AuthGroupDB")]
    public IEnumerable<UserData> GetDetailedUserData()
    {
        // Normally you would call your user database here
        return new List<UserData>
        {
            new UserData { UserName = "Alice", AuthGroup = "Guests" },
            new UserData { UserName = "Bob", AuthGroup = "Users" },
            new UserData { UserName = "Charlie", AuthGroup = "Admins" }
        };
    }

    public class UserData
    {
        public string UserName { get; set; }
        public string AuthGroup { get; set; }
    }
}
