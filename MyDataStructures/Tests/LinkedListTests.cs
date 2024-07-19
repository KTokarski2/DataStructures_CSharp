using Xunit;

namespace MyDataStructures.Tests;


public class LinkedListTests
{

    public int[] GenerateArray()
    {
        int[] array = new int[100];
        for (int i = 1; i < array.Length; i++)
        {
            array[i] = i;
        }

        return array;
    }
    
    [Fact]
    public void TestAddFirst()
    {
        int[] testData = GenerateArray();
        MyLinkedList<int> testList = new MyLinkedList<int>();
        foreach (var number in testData)
        {
            testList.AddFirst(number);
        }

        int expectedResult = 99;
        int actualResult = testList.First.Value;
        Assert.Equal(expectedResult, actualResult);
    }

    [Fact]
    public void TestAddLast()
    {
        int[] testData = GenerateArray();
        MyLinkedList<int> testList = new MyLinkedList<int>();
        foreach (var number in testData)
        {
            testList.AddLast(number);
        }

        int expectedResult = 99;
        int actualResult = testList.Last.Value;
        Assert.Equal(expectedResult, actualResult);
    }

    [Fact]
    public void TestCount()
    {
        int[] testData = GenerateArray();
        MyLinkedList<int> testList = new MyLinkedList<int>();
        foreach (var number in testData)
        {
            testList.AddLast(number);
        }

        int expectedResult = 100;
        int actualResult = testList.Count;
        Assert.Equal(expectedResult, actualResult);
        
    }

    [Fact]
    public void TestGet()
    {
        int[] testData = GenerateArray();
        MyLinkedList<int> testList = new MyLinkedList<int>();
        foreach (var number in testData)
        {
            testList.AddLast(number);
        }

        int expectedResult = 3;
        int acutalResult = testList.GetAt(3);
    }

    [Fact]
    public void TestRemove()
    {
        int[] testData = GenerateArray();
        MyLinkedList<int> testList = new MyLinkedList<int>();
        foreach (var number in testData)
        {
            testList.AddLast(number);
        }
        
        testList.RemoveAt(testList.Count - 1);
        int expectedResult = 98;
        int actualResult = testList.GetAt(testList.Count - 1);
        Assert.Equal(expectedResult, actualResult);
    }
    
    
}