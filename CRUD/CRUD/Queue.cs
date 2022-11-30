using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Presentation
{
	public class Queue
	{
		List<int> queue = new List<int>();
		int count = 0;


		public void Push(int value)
		{
			queue.Add(value);
			count++;
		}
		
		public int Pop()
		{
			var first = queue[0];
			queue.RemoveAt(0);
			count--;
			return first;
		}

		public int Count()
		{
			return count;
		}

		public void Clear()
		{
			while(count != 0)
			{
				queue.RemoveAt(0);
				count--;
			}

			this.count = 0;
		}
	}
}
