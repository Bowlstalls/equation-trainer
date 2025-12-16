namespace equation_trainer.Client;

public abstract class Operation {
  public abstract string Sign { get; }
  public abstract int Order { get; }

  public abstract float Compute(float lhs, float rhs);
}

public class Addition : Operation {
  public override string Sign => "+";
  public override int Order => 1;

  public override float Compute(float lhs, float rhs) => lhs + rhs;
}

public class Multiplication : Operation {
  public override string Sign => "*";
  public override int Order => 2;
  public override float Compute(float lhs, float rhs) => lhs * rhs;
}
