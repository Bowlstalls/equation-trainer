namespace equation_trainer.Client.Nodes;

public class AdditionNode : OperationNode {
  public override int Priority => 1;
  
  public AdditionNode(Node lhs, Node rhs) : base(lhs, rhs)
  {
    Power = int.Max(lhs.Power, rhs.Power);
    Str = $"{GetString(lhs)} + {GetString(rhs)}";
    for (var i = 0; i <= Power; i++) {
      Values[i] = lhs.Values[i] + rhs.Values[i];
    }
  }
}
