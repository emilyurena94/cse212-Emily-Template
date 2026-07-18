using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Three people with different priorities are added to the priority queue.
    // Expected Result: The person with the highest priority should be dequeued first.
    // Defect(s) Found: The loop did not check the last element in the queue, causing the highest priority person to be missed.
    public void TestPriorityQueue_1()
    {
        var priorityQueue = new PriorityQueue();

        priorityQueue.Enqueue("Isa", 1);
        priorityQueue.Enqueue("Bob", 5);
        priorityQueue.Enqueue("Tim", 3);

        Assert.AreEqual("Bob", priorityQueue.Dequeue());


    }

    [TestMethod]
     // Scenario: Three people with different priorities are added to the priority queue.
    // Expected Result: The person with the highest priority should be dequeued before the others.
    // Defect(s) Found: The priority comparison logic did not include the last item in the queue, which could return the wrong person.
    public void TestPriorityQueue_2()
    {
        var priorityQueue = new PriorityQueue();

        priorityQueue.Enqueue("Isa", 1);
        priorityQueue.Enqueue("Bob", 2);
        priorityQueue.Enqueue("Tim", 8);

        Assert.AreEqual("Tim", priorityQueue.Dequeue());

    }

    [TestMethod]
    // Scenario: Multiple people are added to the priority queue and removed one by one.
    // Expected Result: People should be dequeued in descending order of priority until the queue is empty.
    // Defect(s) Found: The Dequeue method returned the highest priority person but did not remove them from the queue, causing repeated results.
    public void TestPriorityQueue_3()
    {
        var priorityQueue = new PriorityQueue();

        priorityQueue.Enqueue("Isa", 1);
        priorityQueue.Enqueue("Bob", 2);
        priorityQueue.Enqueue("Tim", 8);

        Assert.AreEqual("Tim", priorityQueue.Dequeue());
        Assert.AreEqual("Bob", priorityQueue.Dequeue());
        Assert.AreEqual("Isa", priorityQueue.Dequeue());

    }

}