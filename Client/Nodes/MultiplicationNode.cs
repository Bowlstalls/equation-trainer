namespace Client.Nodes;

public class MultiplicationNode : OperationNode {
  public override int Priority => 2;

  public MultiplicationNode(Node lhs, Node rhs) : base(lhs, rhs)
  {
    Power = lhs.Power + rhs.Power;
    Str = $"{GetString(lhs)} * {GetString(rhs)}";
    for (var i = 0; i <= lhs.Power; i++) {
      for (var j = 0; j <= rhs.Power; j++) {
        Values[i + j] += lhs.Values[i] * rhs.Values[j];
      }
    }
  }
}