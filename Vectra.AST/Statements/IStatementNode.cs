using System.Diagnostics.CodeAnalysis;
using Vectra.AST.Models;

namespace Vectra.AST.Statements;

/// <summary>
/// Represents the base class for all statement nodes in the abstract syntax tree (AST).
/// </summary>
/// <remarks>
/// This class encapsulates the source span information for the statement
/// and is inherited by all statement-specific node types.
/// StatementNode is abstract and cannot be instantiated directly.
/// </remarks>
public interface IStatementNode : IAstNode
{
}