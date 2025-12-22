namespace Client;

public class EquationGenerator(EquationGenerator.Range root, EquationGenerator.Range multiplier) {
  public Range Root = root;
  public Range Multiplier = multiplier;
  private Random _rand = new Random();

  public Equation Generate(int power)
  {
    var roots = GetRandomRoots(power);
    var polynomial = GetPolynomial(power, roots);
    return new Equation("", polynomial, roots);
  }

  private int[] GetRandomRoots(int power)
  {
    var res = new int[power];
    for (var i = 0; i < power; i++) {
      res[i] = _rand.Next(root.Min, root.Max);
    }
    return res;
  }
  
  private int[] GetPolynomial(int power, int[] roots)
  {
    var res = new int[power + 1];
    var n = _rand.Next(Multiplier.Min, Multiplier.Max);
    n = 1;
    res[0] = n;
    n *= -1;
    for (var i = 0; i < power - 1; i++) {
      var x = 0;
      for (var j = i; j < power; j++) {
        x += n * roots[j];
      }
      res[i + 1] = x;
      n *= -roots[i];
    }
    res[power] = n * roots[power - 1];
    return res;
  }
  
  public struct Range(int min, int max) {
    public readonly int Min = min;
    public readonly int Max = max;
  }
}