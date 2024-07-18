using Xunit;

namespace MyDataStructures.Tests;


public class LinkedListTests
{
    private static int[] CreateTestArray()
    {
        int[] testData = new int[10];
        for (int i = 0; i < testData.Length; i++)
        {
            testData[i] = i;
        }

        return testData;
    }

    [Fact]
    public void TestAddFirst()
    {
        int[] testData = CreateTestArray();
        MyLinkedList<int> testList = new MyLinkedList<int>();
        foreach (var number in testData)
        {
            testList.AddFirst(number);
        }

        int expectedResult = 9;
        int actualResult = testList.First.Value;
        Assert.Equal(expectedResult, actualResult);
    }
    
}