using System.Globalization;

namespace Client.Nodes;

public class ValueNode : Node {
  public ValueNode(float value, int power)
  {
    Values[power] = value;
    Power = power;
    Str = value.ToString(CultureInfo.CurrentCulture);
  }
}
