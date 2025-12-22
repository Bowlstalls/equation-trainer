namespace Client;

public class Equation {
  public string View;
  public int[] Polynomial;
  public int[] Roots;

  public Equation(string view, int[] polynomial, int[] roots)
  {
    View = view;
    Roots = roots;
    Polynomial = polynomial;
  }
}