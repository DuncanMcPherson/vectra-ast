using Vectra.AST.Expressions;
using Vectra.AST.Models;

namespace Vectra.AST.Statements;

public class VariableDeclarationNode : IStatementNode
{
    /// <summary>
    /// The user declared name of the variable.
    /// </summary>
    public string Name { get; }
    /// <summary>
    /// The explicit type of the variable. Required if <see cref="Initializer"/> is null.
    /// </summary>
    public string? ExplicitType { get; }
    /// <summary>
    /// The initializer expression for the variable. Required if <see cref="ExplicitType"/> is null.
    /// </summary>
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