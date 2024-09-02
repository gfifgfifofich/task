namespace ConsoleApp
{ 

	class ConsoleApp1
	{
		static void Main()
		{

			Shape t = new Triangle(3.0f,5.0f,4.0f);
			Console.WriteLine(t.GetArea());
			Console.WriteLine(((Triangle)t).IsRectangular());
			
			Shape c = new Circle(2.0f);
			Console.WriteLine(c.GetArea());
			


		}
	}
}