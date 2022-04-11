using FluentAssertions;
using Xunit;

namespace Banking.Tests;

public class DollarTests
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
}