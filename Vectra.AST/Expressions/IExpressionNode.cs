using Vectra.AST.Models;

namespace Vectra.AST.Expressions;

/// <summary>
/// Represents a base class for all expression nodes in the abstract syntax tree (AST).
/// </summary>
/// <remarks>
/// The ExpressionNode class provides a common base for specific types of expressions in the AST.
/// It implements the <see cref="IAstNode"/> interface and includes a <see cref="SourceSpan"/>
/// property to define the span of source code associated with the expression.
/// </remarks>
public interface IExpressionNode : IAstNode
{
}