namespace equation_trainer.Client.Nodes;

public abstract class OperationNode : Node {
  public readonly Node Lhs;
  public readonly Node Rhs;

  public OperationNode(Node lhs, Node rhs)
  {
    Lhs = lhs;
    Rhs = rhs;
  }

  public abstract int Priority { get; }
  
  protected string GetString(Node source)
  {
    var res = source.Str;
    if (source is not OperationNode opNode) return res;
    if (opNode.Priority > Priority) {
      res = $"({res})";
    }
    return res;
  }
}
