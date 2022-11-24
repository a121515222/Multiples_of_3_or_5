using Multiples_of_3_or_5;
using NUnit.Framework;
namespace UniTestMultiples_of_3_or_5;

public class UnitTest
{
    
    [TestCase(4)]
    public void TestDivisibleby3(int num)
    {
        Assert.AreEqual(3, Multiples.Multiples3Or5(num));
    }
    [TestCase(6)]
    public void TestDivisibleby5(int num)
    {
        Assert.AreEqual(8, Multiples.Multiples3Or5(num));
    }
    [TestCase(16)]
    public void TestDivisibleby3And5(int num)
    {
        Assert.AreEqual(60, Multiples.Multiples3Or5(num));
    }
}