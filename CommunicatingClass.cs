// CommunicatingClass.cs
using System;

public enum PlayerMessageType
{
    Action,
    Information
}

public delegate void GetPlayerAction(string action);
public delegate void InformPlayer(string information);

