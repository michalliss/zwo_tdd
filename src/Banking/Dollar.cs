namespace Banking;
public class Dollar : IEquatable<Dollar>
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

  #region Equality

  public bool Equals(Dollar? other)
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
    return Equals((Dollar) obj);
  }

  public override int GetHashCode()
  {
    return Value;
  }

  public static bool operator ==(Dollar? left, Dollar? right)
  {
    return Equals(left, right);
  }

  public static bool operator !=(Dollar? left, Dollar? right)
  {
    return !Equals(left, right);
  }

  #endregion
}
