using FluentAssertions;
using Xunit;

namespace Banking.Tests;

public class BankTests
{
  [Fact]
  public void RatesAreStoredCorrectly()
  {
    var bank = new Bank();
    
    var from = "USD";
    var to = "CHF";

    bank.GetRate(from, to).Should().Be(0);
    bank.AddRate(from, to, 2);
    bank.GetRate(from, to).Should().Be(2);
  }
}