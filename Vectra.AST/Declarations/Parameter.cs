﻿namespace Vectra.AST.Declarations;

public class Parameter(string name, string type)
{
    public string Name { get; } = name;
    public string Type { get; } = type;

    public override string ToString()
    {
        return $"{Type} {Name}";
    }
}