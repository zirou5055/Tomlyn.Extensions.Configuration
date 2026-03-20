using System;
using System.Collections.Generic;

namespace Tomlyn.Extensions.Configuration.Tests;

public class Sample
{
    public string Title { get; init; } = string.Empty;
    public Owner Owner { get; init; } = new();
    public Database Database { get; init; } = new();
    public Dictionary<string, Server> Servers { get; init; } = [];
}

public class Owner
{
    public string Name { get; init; } = string.Empty;
    public DateTime DoB { get; init; }
}

public class Database
{
    public bool Enabled { get; init; }
    public ushort[] Ports { get; init; } = [];
    public Dictionary<string, decimal> Temp_Targets { get; init; } = [];
}

public class Server
{
    public string Ip { get; init; } = string.Empty;
    public Role Role { get; init; }
}

public enum Role
{
    Unknown,
    Frontend,
    Backend,
}