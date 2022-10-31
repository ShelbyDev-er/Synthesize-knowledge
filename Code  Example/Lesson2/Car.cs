using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2
{
	// Be able: what can do?
	public interface ICar
	{
		public void OpenMusic();
		public void OpenTrunk();
	}

	public interface ICarAssistant
	{
		public void AutoBrake();
	}

	// Is a
	public abstract class Vehicle
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

		public abstract void StartEngine();

		public virtual void FillFuel()
		{
			//Open nap xang
			TestMethod();
		}

		protected void TestMethod()
		{

		}
	}

	public class Car : Vehicle, ICar, ICarAssistant
	{
		// Constructor
		public Car(string carName) : base(carName)
		{
			Console.WriteLine($"Car is created !!!");
		}

		public override void StartEngine()
		{
			//Code
		}

		public override void FillFuel()
		{

		}

		public void OpenMusic()
		{
			throw new NotImplementedException();
		}

		public void OpenTrunk()
		{
			throw new NotImplementedException();
		}

		public void AutoBrake()
		{
			throw new NotImplementedException();
		}
	}

	public class Motobike : Vehicle
	{
		// Constructor
		public Motobike(string motobikeName) : base(motobikeName)
		{
		}

		public override void StartEngine()
		{
			//Code
			FillFuel();
		}
	}

	public static class MathTool
	{
		public static int SumOf2Num(int a, int b)
		{
			return a + b;
		}

		public static int SumOf3Num(int a, int b)
		{
			return a + b;
		}
	}
}
