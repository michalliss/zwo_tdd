namespace Banking;
public class Dollar
{
  public int Value { get; private set; }

  public Dollar(int value)
  {
    Value = value;
  }

  public void Times(int amount)
  {
    Value *= amount;
  }
}
