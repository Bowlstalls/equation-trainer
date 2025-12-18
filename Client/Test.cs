using equation_trainer.Client.Nodes;

namespace Client;

public class Test {
  public static void Start()
  {
    var node = new MultiplicationNode(new AdditionNode(new ValueNode(3, 0), new ValueNode(4, 0)),
      new ValueNode(5, 0));
    Console.WriteLine(node.Str);
    for (var i = 0; i <= node.Power; i++) {
      Console.WriteLine(node.Values[i]);
    }
  }
}