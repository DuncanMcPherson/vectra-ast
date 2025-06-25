using Vectra.AST.Declarations.Interfaces;
using Vectra.AST.Models;

namespace Vectra.AST.Declarations;

public class PropertyDeclarationNode : IMemberNode
{
    public string Name { get; }
    public string Type { get; }
    public bool HasGetter { get; }
    public bool HasSetter { get; }
    public SourceSpan Span { get; }
    
    public PropertyDeclarationNode(string name, string type, bool hasGetter, bool hasSetter, SourceSpan span)
    {
        Name = name;
        Type = type;
        HasGetter = hasGetter;
        HasSetter = hasSetter;
        Span = span;
    }
    
    public T Accept<T>(IAstVisitor<T> visitor) => visitor.VisitPropertyDeclaration(this);
    
    public override string ToString()
    {
        return $"PropertyDeclarationNode({Name}, {Type}, {HasGetter}, {HasSetter})";
    }
}