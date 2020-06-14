using System;
using System.Collections.Generic;
using System.Text;

namespace Queuing
{
	public class Queue
	{
		private string[] QueueArray;

		public string Peek()
		{
			return QueueArray[0];
		}

		public void Enqueue(string NewItem)
        {
			string[] EmbiggenedQueue = new string[QueueArray.Length + 1];
			EmbiggenedQueue[EmbiggenedQueue.Length - 1] = NewItem;
			for(int i = 0; i < QueueArray.Length; i++)
            {
				EmbiggenedQueue[i] = QueueArray[i];
            }
			QueueArray = EmbiggenedQueue;
        }

		public void Dequeue(string DeletedItem)
        {
			//:)
        }

		public Queue()
		{
			QueueArray = new string[0];
		}

		public void PrintTheQueue()
        {
			Console.WriteLine("I am printing");
			for(int i = 0; i < QueueArray.Length; i++)
            {
                Console.WriteLine(QueueArray[i]);
            }
        }
	}

}
