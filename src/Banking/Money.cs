namespace Banking;

public class Money : IEquatable<Money>
{
  public int Value { get; }
  public string Currency { get; }
  
  public Money(int value, string currency)
  {
    Value = value;
    Currency = currency;
  }
  
  public Money Times(int amount)
  {
    return new Money(Value * amount, Currency);
  }

  public Money Add(Money money, Bank bank)
  {
    if (money.Currency == Currency)
    {
      return new Money(Value + money.Value, Currency);
    }
    
    var rate = bank.GetRate(money.Currency, Currency);
    return new Money(Value + (int) (rate * money.Value), Currency);
  }
  
  #region Equality

  public bool Equals(Money? other)
  {
    if (ReferenceEquals(null, other)) return false;
    if (ReferenceEquals(this, other)) return true;
    return Value == other.Value && Currency == other.Currency;
  }

  public override bool Equals(object? obj)
  {
    if (ReferenceEquals(null, obj)) return false;
    if (ReferenceEquals(this, obj)) return true;
    if (obj.GetType() != this.GetType()) return false;
    return Equals((Money) obj);
  }

  public override int GetHashCode()
  {
    return HashCode.Combine(Value, Currency);
  }

  public static bool operator ==(Money? left, Money? right)
  {
    return Equals(left, right);
  }

  public static bool operator !=(Money? left, Money? right)
  {
    return !Equals(left, right);
  }
  
  #endregion
}