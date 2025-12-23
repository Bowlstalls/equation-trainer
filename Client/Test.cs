namespace Client;

public class Test {
  public static void Start()
  {
    var gen = new EquationGenerator(new EquationGenerator.Range(-10, 10), new EquationGenerator.Range(-10, 10));
    gen.Generate(2);
  }
}