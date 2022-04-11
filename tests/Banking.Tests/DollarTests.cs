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
        
        five.Value.Should().Be(5);
        ten.Value.Should().Be(10);
    }
}