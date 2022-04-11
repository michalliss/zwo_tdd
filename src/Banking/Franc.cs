namespace Banking;

public class Franc : Money
{
  public Franc(int value) : base(value)
  {
    
  }

  public override string Currency => "CHF";
}