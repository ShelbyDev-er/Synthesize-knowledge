using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2
{
	public class Vehicle
	{
		// Attribute
		private int height;
		public int weight;
		public int lenght;
		public string name;

		public Vehicle(string vehicleName)
		{
			Console.WriteLine($"{vehicleName} is created !!!");
		}

		public void SetHeight(int height)
		{
			if (height < 0)
			{
				this.height = 0;
			}
			else
			{
				this.height = height;
			}
		}

		public void SetHeight(decimal height)
		{
			if (height < 0)
			{
				this.height = 0;
			}
			else
			{
				this.height = (int)height;
			}
		}

		public void SetHeight(int height, int tmp)
		{
			if (height < 0)
			{
				this.height = 0;
			}
			else
			{
				this.height = (int)height;
			}
		}

		public int GetHeight()
		{
			return this.height;
		}
	}

	public class Car : Vehicle
	{
		// Constructor
		public Car(string carName) : base(carName)
		{
			Console.WriteLine($"Car is created !!!");
		}
	}

	public class Motobike : Vehicle
	{
		// Constructor
		public Motobike(string motobikeName) : base(motobikeName)
		{
		}
	}
}
