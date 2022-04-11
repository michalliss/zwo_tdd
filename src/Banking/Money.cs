namespace Banking;

public abstract class Money : IEquatable<Money>
{
  public int Value { get; }
  
  public Money(int value)
  {
    
  }
  
  public Money Times(int amount)
  {
    return new Dollar(Value * amount);
  }
  
  #region Equality
  
  public bool Equals(Money? other)
  {
    if (ReferenceEquals(null, other)) return false;
    if (ReferenceEquals(this, other)) return true;
    return Value == other.Value;
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
    return Value;
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