using Vectra.AST.Declarations.Interfaces;
using Vectra.AST.Expressions;
using Vectra.AST.Models;

namespace Vectra.AST.Declarations;

public class FieldDeclarationNode : IMemberNode
{
    public string Name { get; }
    public string Type { get; }
    public IExpressionNode? Initializer { get; }
    public SourceSpan Span { get; }
    
    public FieldDeclarationNode(string name, string type, IExpressionNode? initializer, SourceSpan span)
    {
        Name = name;
        Type = type;
        Initializer = initializer;
        Span = span;
    }
    
    public override string ToString()
    {
        return $"FieldDeclarationNode({Name}, {Type}, {Initializer})";
    }
    
    public T Accept<T>(IAstVisitor<T> visitor) => visitor.VisitFieldDeclaration(this);
}