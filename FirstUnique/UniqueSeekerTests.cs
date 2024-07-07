using FluentAssertions;
using NUnit.Framework;

namespace FirstUnique;

[TestFixture]
public class UniqueSeekerTests
{
    [Test]
    public void Check_Single()
    {
        var result = UniqueSeeker.Check(
        [
            4
        ]);

        result.Should().Be(4);
    }
    
    [Test]
    public void Check_NoUnique()
    {
        var result = UniqueSeeker.Check(
        [
            4, 10, 10, 4
        ]);

        result.Should().Be(-1);
    }
    
    [Test]
    public void Check_OneUnique()
    {
        var result = UniqueSeeker.Check(
        [
            4, 10, 5, 4, 2, 10, 2
        ]);

        result.Should().Be(5);
    }
    
    [Test]
    public void Check_TwoUnique()
    {
        var result = UniqueSeeker.Check(
        [
            4, 10, 5, 4, 2, 10
        ]);

        result.Should().Be(5);
    }
    
    [Test]
    public void Check_FirstUnique()
    {
        var result = UniqueSeeker.Check(
        [
            1, 4, 10, 5, 4, 2, 10
        ]);

        result.Should().Be(1);
    }
    
    [Test]
    public void Check_LastUnique()
    {
        var result = UniqueSeeker.Check(
        [
            4, 10, 5, 4, 5, 10, 1
        ]);

        result.Should().Be(1);
    }
    
    [Test]
    public void Check_LastNotUnique()
    {
        var result = UniqueSeeker.Check(
        [
            1, 10, 5, 4, 5, 10, 1
        ]);

        result.Should().Be(4);
    }
}