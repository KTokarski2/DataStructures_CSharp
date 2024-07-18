using Xunit;

namespace MyDataStructures.Tests;


public class LinkedListTests
{
    

    [Fact]
    public void TestAddFirst()
    {
        int[] testData = { 0, 1, 2, 3 };
        MyLinkedList<int> testList = new MyLinkedList<int>();
        foreach (var number in testData)
        {
            testList.AddFirst(number);
        }

        int expectedResult = 3;
        int actualResult = testList.First.Value;
        Assert.Equal(expectedResult, actualResult);
    }

    [Fact]
    public void TestAddLast()
    {
        int[] testData = { 0, 1, 2, 3 };
        MyLinkedList<int> testList = new MyLinkedList<int>();
        foreach (var number in testData)
        {
            testList.AddLast(number);
        }

        int expectedResult = 3;
        int actualResult = testList.Last.Value;
        Assert.Equal(expectedResult, actualResult);
    }
    
}