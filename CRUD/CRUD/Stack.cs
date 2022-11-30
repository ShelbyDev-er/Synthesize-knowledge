using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Presentation
{
	public class Stack
	{
		List<int> stack = new List<int>();
		int count = 0;


		public void Push(int value)
		{
			stack.Add(value);
			count++;
		}
		
		public int Pop()
		{
			var last = stack[stack.Count - 1];
			stack.RemoveAt(stack.Count - 1);
			count--;
			return last;
		}

		public int Count()
		{
			return count;
		}

		public void Clear()
		{
			var count = this.count - 1;
			for(var i = count; i >= 0; i--)
			{
				stack.RemoveAt(i);
			}

			this.count = 0;
		}
	}
}
