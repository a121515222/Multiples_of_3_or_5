using Multiples_of_3_or_5;
using NUnit.Framework;

namespace TestProject1;

public class UnitTest
{
    
    [TestCase(4)]
    public void Divisibleby3Test(int num)
    {
        Assert.AreEqual(3, Multiples.Multiples3Or5(num));
    }
    [TestCase(6)]
    public void Divisibleby5Test(int num)
    {
        Assert.AreEqual(8, Multiples.Multiples3Or5(num));
    }
    [TestCase(16)]
    public void Divisibleby3And5Test(int num)
    {
        Assert.AreEqual(60, Multiples.Multiples3Or5(num));
    }
}