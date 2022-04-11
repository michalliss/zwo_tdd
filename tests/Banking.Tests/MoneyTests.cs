using FluentAssertions;
using Xunit;

namespace Banking.Tests;

public class MoneyTests
{
    // $5 * 2 = $10
    [Fact]
    public void DollarMultiplicationWorks()
    {
        var five = new Dollar(5);
        var ten = five.Times(2);
        
        five.Should().Be(new Dollar(5));
        ten.Should().Be(new Dollar(10));
    }

    [Fact]
    public void DollarsIdentityIsItsValue()
    {
        new Dollar(5).Should().Be(new Dollar(5));
    }
    
    // 5 CHF * 2 = $10 CHF
    [Fact]
    public void FrancMultiplicationWorks()
    {
        var five = new Franc(5);
        var ten = five.Times(2);
        
        five.Should().Be(new Franc(5));
        ten.Should().Be(new Franc(10));
    }

    [Fact]
    public void FrancIdentityIsItsValue()
    {
        new Franc(5).Should().Be(new Franc(5));
    }

    [Fact]
    public void OneFrancIsNotOneDollar()
    {
        new Franc(1).Should().NotBe(new Dollar(1));
    }
}