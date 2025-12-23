using System;

namespace Client;

public class EquationGenerator {
  public Range Roots = new Range(-5, 5);
  public Range Values = new Range(-10, 10);
  public Range Multipliers = new Range(-5, 5);
  private Random _rand = new Random();

  public Equation Generate(int power)
  {
    var roots = GetRandomRoots(power);
    var multiplier = _rand.Next(Multipliers.Min, Multipliers.Max);
    var polynomial = new Polynomial(multiplier, roots);
    return new Equation("", polynomial.ToArray(), roots);
  }

  private int[] GetRandomRoots(int power)
  {
    var res = new int[power];
    for (var i = 0; i < power; i++) {
      res[i] = _rand.Next(Roots.Min, Roots.Max);
    }
    return res;
  }
  
  public struct Range(int min, int max) {
    public readonly int Min = min;
    public readonly int Max = max;
  }
}