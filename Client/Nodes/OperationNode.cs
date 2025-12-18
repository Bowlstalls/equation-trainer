namespace equation_trainer.Client.Nodes;

public abstract class OperationNode : Node {
  public readonly Node Lhs;
  public readonly Node Rhs;
  public required string Str;

  public OperationNode(Node lhs, Node rhs)
  {
    Lhs = lhs;
    Rhs = rhs;
  }
}
