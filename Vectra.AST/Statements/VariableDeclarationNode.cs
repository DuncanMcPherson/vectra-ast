using Vectra.AST.Expressions;
using Vectra.AST.Models;

namespace Vectra.AST.Statements;

public class VariableDeclarationNode : IStatementNode
{
    public string Name { get; }
    public string? ExplicitType { get; }
    public IExpressionNode? Initializer { get; }
    
    public SourceSpan Span { get; }

    public VariableDeclarationNode(string name, string? explicitType, IExpressionNode? initializer, SourceSpan span)
    {
        Name = name;
        ExplicitType = explicitType;
        Initializer = initializer;
        Span = span;
    }

    public T Accept<T>(IAstVisitor<T> visitor)
    {
        return visitor.VisitVariableDeclaration(this);
    }
}