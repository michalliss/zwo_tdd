using FluentAssertions;
using Xunit;

namespace Banking.Tests;

public class MoneyTests
{
    // $5 * 2 = $10
    [Fact]
    public void DollarMultiplicationWorks()
    {
        var five = new Money(5, "USD");
        var ten = five.Times(2);
        
        five.Should().Be(new Money(5, "USD"));
        ten.Should().Be(new Money(10, "USD"));
    }

    [Fact]
    public void DollarsIdentityIsItsValue()
    {
        new Money(5, "USD").Should().Be(new Money(5, "USD"));
    }

    [Fact]
    public void OneFrancIsNotOneDollar()
    {
        new Money(1, "CHF").Should().NotBe(new Money(1, "USD"));
    }

    [Fact]
    public void CurrenciesMatch()
    {
        new Money(5, "CHF").Currency.Should().Be("CHF");
        new Money(5, "USD").Currency.Should().Be("USD");
    }

    [Fact]
    public void AddCurrencies()
    {
        var bank = new Bank();
        bank.AddRate("CHF", "USD", 0.5);
        new Money(5, "USD").Add(new Money(6, "CHF"), bank).Should().Be(new Money(8, "USD"));
    }
}