using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex57_StackAndQueues
{
	public class MyQueue<T>
	{
		private List<T> queue = new List<T>();

		public MyQueue()
		{
		}

		
		public void Enqueue(T item)
		{
			queue.Add(item);
		}

		public T Dequeue()
		{
			T item = queue[0];
			queue.Remove(item);
			return item;
		}

		public int Count()
		{
			return queue.Count;
		}

		public Boolean IsEmpty()
		{
			if(queue.Count < 1)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
	}
}


