using ClassLibrary1;

namespace StrykerTest;

public class Tests
{
    [Test]
    public void Test1()
    {
        var result = Class1.Add(25, 25);

        Assert.That(result, Is.EqualTo(50));
    }
}