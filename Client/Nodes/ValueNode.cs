using System.Globalization;

namespace equation_trainer.Client.Nodes;

public class ValueNode : Node {
  public ValueNode(float value, int power)
  {
    Values[power] = value;
    Power = power;
    Str = value.ToString(CultureInfo.CurrentCulture);
  }
}
