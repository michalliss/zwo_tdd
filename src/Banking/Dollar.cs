namespace Banking;
public class Dollar
{
  public int Value { get; }

  public Dollar(int value)
  {
    Value = value;
  }

  public Dollar Times(int amount)
  {
    return new Dollar(Value * amount);
  }
}
