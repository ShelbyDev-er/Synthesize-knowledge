using System;
using System.Collections;
using System.Collections.Generic;

namespace Lesson2
{
	class Program
	{
		static void Main(string[] args)
		{
			// Phan biet, hieu va biet cach su dung cac kieu du lieu tap hop (danh sach) trong c#
			// Cu phap
			// Cac phuong thuc ma kieu du lieu ho tro(CRUD, search, sort)
			// Test

			// 4 thuoc tinh quan trong cua OOP
			// Tinh dong goi (Encapsulation)
			/*
			    Access Modifier:
					- public
					- private
					- protected
					- sealed
			*/


			// Tinh ke thua (Inheritance)


			// Tinh da hinh (Polymorphism)

			// Tinh truu tuong (Abstraction)
			/*
				- Abstract class
				- Interface
			 */


			// Override(ghi de) vs Overloading(nap chong ham)

			Vehicle car1 = new Car("BWM");
			Vehicle motobike2 = new Motobike("Honda");
			Car car3 = (Car)car1;
			Motobike motobike = (Motobike)motobike2;

			car1.SetHeight(10);
			motobike2.SetHeight(20);

			Console.WriteLine($"height of car1 is: {car1.GetHeight()}");

			car1.SetHeight(1);
			car1.SetHeight((decimal)10.5);
			car1.SetHeight(5, 6);

			var res = MathTool.SumOf2Num(1, 2);
		}
	}
}
