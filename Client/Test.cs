namespace equation_trainer.Client;

public class Test {
  public static void Start()
  {
    var node = new OperationNode(new OperationNode(new ValueNode(3), new ValueNode(4), new Addition()),
      new ValueNode(5), new Multiplication());
    Console.WriteLine(node);
    Console.WriteLine(node.Value);
  }
}