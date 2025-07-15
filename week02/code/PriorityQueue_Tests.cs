using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Create a que with the following items PriorityItem("item-1", 2); PriorityItem("item-2", 5);
    // PriorityItem("item-3", 1);
    // PriorityItem("item-4", 2);
    // PriorityItem("item-5", 5); Then deque
    // Expected Result: First item on the que with the highest priority ("item-2", 5) is removed
    // Defect(s) Found: 
    public void TestPriorityQueue_1()
    {
        var item1 = new PriorityItem("item-1", 2);
        var item2 = new PriorityItem("item-2", 5);
        var item3 = new PriorityItem("item-3", 1);
        var item4 = new PriorityItem("item-4", 2);
        var item5 = new PriorityItem("item-5", 5);

        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue(item1.Value, item1.Priority);
        priorityQueue.Enqueue(item2.Value, item2.Priority);
        priorityQueue.Enqueue(item3.Value, item3.Priority);
        priorityQueue.Enqueue(item4.Value, item4.Priority);
        priorityQueue.Enqueue(item5.Value, item5.Priority);


        var dequeValue = priorityQueue.Dequeue();
        Assert.AreEqual(dequeValue, item2.Value);

    }

    [TestMethod]
    // Scenario: Create a que and add five items to the que then deque and check for the que length
    // Expected Result: Que length should be 4;
    public void TestPriorityQueue_2()
    {
        var priorityQueue = new PriorityQueue();
        var item1 = new PriorityItem("item-1", 2);
        var item2 = new PriorityItem("item-2", 5);
        var item3 = new PriorityItem("item-3", 1);
        var item4 = new PriorityItem("item-4", 2);
        var item5 = new PriorityItem("item-5", 5);


        priorityQueue.Enqueue(item1.Value, item1.Priority);
        priorityQueue.Enqueue(item2.Value, item2.Priority);
        priorityQueue.Enqueue(item3.Value, item3.Priority);
        priorityQueue.Enqueue(item4.Value, item4.Priority);
        priorityQueue.Enqueue(item5.Value, item5.Priority);

        var dequeuedValue = priorityQueue.Dequeue();
        Assert.AreEqual("item-2", dequeuedValue);

        Console.WriteLine(priorityQueue);
        Assert.AreEqual(4, priorityQueue.QueLenght());

    }

    [TestMethod]
    // Scenario: correct value is returned when deque priorities is different
    // Expected Result: Que length should be 4;
    public void TestPriorityQueue_3()
    {
        var priorityQueue = new PriorityQueue();
        var item1 = new PriorityItem("item-1", 1);
        var item2 = new PriorityItem("item-2", 2);
        var item3 = new PriorityItem("item-3", 3);
        var item4 = new PriorityItem("item-4", 4);
        var item5 = new PriorityItem("item-5", 5);

        priorityQueue.Enqueue(item1.Value, item1.Priority);
        priorityQueue.Enqueue(item2.Value, item2.Priority);
        priorityQueue.Enqueue(item3.Value, item3.Priority);
        priorityQueue.Enqueue(item4.Value, item4.Priority);
        priorityQueue.Enqueue(item5.Value, item5.Priority);

        var dequeValue = priorityQueue.Dequeue();
        Assert.AreEqual(dequeValue, item5.Value);



    }

    [TestMethod]
    // Scenario: correct value is returned when deque priorities are the same
    // Expected Result: Que length should be 4;
    public void TestPriorityQueue_4()
    {
        var priorityQueue = new PriorityQueue();
        var item1 = new PriorityItem("item-1", 1);
        var item2 = new PriorityItem("item-2", 1);
        var item3 = new PriorityItem("item-3", 1);
        var item4 = new PriorityItem("item-4", 1);
        var item5 = new PriorityItem("item-5", 1);

        priorityQueue.Enqueue(item1.Value, item1.Priority);
        priorityQueue.Enqueue(item2.Value, item2.Priority);
        priorityQueue.Enqueue(item3.Value, item3.Priority);
        priorityQueue.Enqueue(item4.Value, item4.Priority);
        priorityQueue.Enqueue(item5.Value, item5.Priority);

        var dequeValue = priorityQueue.Dequeue();
        Assert.AreEqual(dequeValue, item1.Value);



    }

    // Add more test cases as needed below.
}