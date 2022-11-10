using System;

namespace CRUD
{
	public class RecusiveAlgorithm
	{
		public int i { get; set; }

		public void TestRecusive(int i) // i = 0
		{
			if (i == 3) return;

			Console.WriteLine($"Welcome {i}"); // Welcome 2
			i++; // 3
			TestRecusive(i);  // i = 2
			i--;
			Console.WriteLine($"Good bye {i}");
		}

		public void Entry()
		{
			i = 0;
			TestRecusive(0);
			Console.WriteLine("Exit");
		}
	}
}

// Welcome 0
// Welcome 1
// Welcome 2
// --> Kick
// Goodbye 2
// Goodbye 1
// Goodbye 0
// Exit

