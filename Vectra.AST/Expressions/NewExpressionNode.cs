using Vectra.AST.Models;

namespace Vectra.AST.Expressions;

public class NewExpressionNode : IExpressionNode
{
    public string TypeName { get; }
    public List<IExpressionNode> Arguments { get; }
    public SourceSpan Span { get; }
    
    public NewExpressionNode(string typeName, List<IExpressionNode> arguments, SourceSpan span)
    {
        TypeName = typeName;
        Arguments = arguments;
        Span = span;
    }
    
    public T Accept<T>(IAstVisitor<T> visitor)
    {
        return visitor.VisitNewExpression(this);
    }
}