using Vectra.AST.Models;

namespace Vectra.AST.Expressions;

/// <summary>
/// Represents an identifier expression node within an abstract syntax tree (AST).
/// </summary>
/// <remarks>
/// The <c>IdentifierExpressionNode</c> class is a specific type of <see cref="IStatementNode"/>
/// that encapsulates an identifier expression and its associated location in the source code.
/// It is primarily used during the parsing and analysis phases of a compiler or interpreter.
/// </remarks>
public class IdentifierExpressionNode(string name, SourceSpan span) : IExpressionNode
{
    /// Gets the name associated with the identifier expression.
    /// This property represents the name of the identifier as a string.
    public string Name { get; } = name;

    /// Gets the source span associated with the identifier expression.
    /// This property represents the span of source code that the identifier occupies.
    public SourceSpan Span { get; } = span;

    /// <summary>
    /// Accepts a visitor that implements the <see cref="IAstVisitor{T}"/> interface.
    /// </summary>
    /// <typeparam name="T">The type of the result that the visitor will produce.</typeparam>
    /// <param name="visitor">An instance of a visitor implementing the <see cref="IAstVisitor{T}"/> interface.</param>
    /// <returns>The result of the visitor's operation, of type <typeparamref name="T"/>.</returns>
    public T Accept<T>(IAstVisitor<T> visitor)
    {
        return visitor.VisitIdentifierExpression(this);
    }
    
    public override string ToString()
    {
        return $"IdentifierExpressionNode({Name})";
    }
}