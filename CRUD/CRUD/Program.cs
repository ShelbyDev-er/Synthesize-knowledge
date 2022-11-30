using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Presentation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUD
{
	public class Program
	{
		public static void Main(string[] args)
		{
			//RecusiveAlgorithm runner = new RecusiveAlgorithm();
			//runner.Entry();

			//Stack myStack = new Stack();
			//myStack.Push(1);
			//myStack.Push(2);
			//myStack.Push(3);

			//Console.WriteLine(myStack.Pop());

			//myStack.Push(4);
			//Console.WriteLine(myStack.Pop());
			//Console.WriteLine(myStack.Count());

			//myStack.Clear();
			//Console.WriteLine(myStack.Count());

			Queue queue = new Queue();
			queue.Push(1);
			queue.Push(2);

			Console.WriteLine(queue.Pop());
			Console.WriteLine(queue.Pop());



			//CreateHostBuilder(args).Build().Run();
		}

		public static IHostBuilder CreateHostBuilder(string[] args) =>
			Host.CreateDefaultBuilder(args)
				.ConfigureWebHostDefaults(webBuilder =>
				{
					webBuilder.UseStartup<Startup>();
				});
	}
}
