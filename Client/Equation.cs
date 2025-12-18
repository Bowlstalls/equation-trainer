namespace equation_trainer.Client;

public class Equation {
  public string View;
  public float Value;

  private Equation(string view, float value)
  {
    View = view;
    Value = value;
  }

  public static Equation GenerateLinear()
  {
    throw new NotImplementedException();
  }
}