namespace Banking;

public class Bank
{
  private readonly Dictionary<(string, string), double> _rates = new();

  public void AddRate(string from, string to, double rate)
  {
    _rates[(from, to)] = rate;
  }

  public double GetRate(string from, string to)
  {
    var key = (from, to);
    return _rates.ContainsKey(key) ? _rates[key] : 0.0;
  }
}