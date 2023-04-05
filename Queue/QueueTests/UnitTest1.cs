using Queue;

namespace QueueTests
{
	public class Tests
	{
		[SetUp]
		public void Setup()
		{
		}

		[Test]
		public void ShouldEnqueue()
		{
			MyQueue<string> myQueue = new MyQueue<string>();
			myQueue.Enqueue("a");
			myQueue.Enqueue("b");

			Assert.AreEqual(2, myQueue.Count);
			Assert.That(myQueue.GetItem(0), Is.EqualTo("a"));
			Assert.That(myQueue.GetItem(1), Is.EqualTo("b"));
		}

		[Test]
		public void ShouldDequeue()
		{
			MyQueue<string> myQueue = new MyQueue<string>();
			myQueue.Enqueue("a");
			myQueue.Enqueue("b");

			var item = myQueue.Dequeue();
			var item2 = myQueue.Dequeue();

			Assert.That(item, Is.EqualTo("a"));
			Assert.That(item2, Is.EqualTo("b"));
		}

		[Test]
		public void DequeueShouldReturnNullWhenQueueIsEmpty()
		{
			MyQueue<string> myQueue = new MyQueue<string>();

			var item = myQueue.Dequeue();

			Assert.That(item, Is.Null);
		}
	}
}