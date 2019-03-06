using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex57_StackAndQueues
{
	public class MyStack<T>
	{
		private List<T> stack = new List<T>();


		public MyStack()
		{
		}

		public void Push(T item)
		{
			stack.Add(item);
		}

		public T Pop()
		{
			T item = stack[stack.Count -1];
			stack.Remove(item);
			return item;
		}

		public T Peek()
		{
			T item = stack[stack.Count - 1];
			return item;
		}

		public int Count()
		{
			return stack.Count;
		}

		public Boolean IsEmpty()
		{
			if(stack.Count < 1)
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
