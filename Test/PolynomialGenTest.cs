using System;
using Client;
using NUnit.Framework;

namespace Test;

public class PolynomialGenTest {
  private EquationGenerator _gen = new EquationGenerator();
  
  [Test]
  [Repeat(100)]
  public void CheckValid()
  {
    const int pwr = 14;
    var eq = _gen.Generate(pwr);
    var broke = false;
    for (var rootNum = 0; rootNum < pwr; rootNum++) {
      double val = eq.Polynomial[pwr];
      var root = eq.Roots[rootNum];
      for (var i = 0; i < pwr; i++) {
        val += Math.Pow(root, pwr - i) * eq.Polynomial[i];
      }

      if (val != 0) {
        broke = true;
        break;
      }
    }
    
    Assert.That(!broke);
  }
}