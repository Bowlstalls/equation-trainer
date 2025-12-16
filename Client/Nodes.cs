using System.Globalization;

namespace equation_trainer.Client;

public abstract class Node {
  public abstract float Value { get; }
}

public class ValueNode(float value) : Node {
  public override float Value => value;
  public override string ToString() => Value.ToString(CultureInfo.InvariantCulture);
}

public class OperationNode(Node lhs, Node rhs, Operation op) : Node {
  public override float Value => Op.Compute(Lhs.Value, Rhs.Value);
  public readonly Operation Op = op;
  public readonly Node Lhs = lhs;
  public readonly Node Rhs = rhs;

  public override string ToString()
  {
    return $"{GetArgument(Lhs)} {Op.Sign} {GetArgument(Rhs)}";

    string GetArgument(Node node)
    {
      var str = node.ToString();
      if (node is not OperationNode opNode || opNode.Op.Order >= Op.Order) {
        return str!;
      }
      return $"({str})";
    }
  }
}
