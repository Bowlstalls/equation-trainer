using Client;

namespace Test;

public class PolynomialGenTest {
  private EquationGenerator _gen = new EquationGenerator(new EquationGenerator.Range(-10, 10), new EquationGenerator.Range(-10, 10));
  
  [Test]
  [Repeat(100)]
  public void CheckValid()
  {
    var pwr = 2;
    var eq = _gen.Generate(pwr);
    double val = eq.Polynomial[pwr];
    for (var i = 0; i < pwr; i++) {
      val += Math.Pow(eq.Roots[i], pwr - i) * eq.Polynomial[pwr];
    }
    Assert.That(val, Is.EqualTo(0));
  }
}