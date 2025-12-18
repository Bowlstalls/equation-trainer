namespace equation_trainer.Client.Nodes;

public class ValueNode : Node {
  public ValueNode(float value, int power)
  {
    Values[power] = value;
  }
}
