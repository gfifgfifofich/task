namespace ConsoleApp
{ 
	public class Shape
	{
		public Shape()
		{
			
		}
		public virtual float GetArea()
		{			
			return 0.0f;
		}
	}
	public class Circle : Shape
	{
		public float R = 0.0f; 
		
		
		public Circle(float radius)
		{
			if(	radius < 0.0f )
				throw new InvalidOperationException("Radius cant be less than 0.0f");
			R= radius;			
		}
		public override float GetArea() 
		{			
			return MathF.PI * R * R;
		}
	}
	public class Triangle : Shape
	{
		public float Side1 = 0.0f;
		public float Side2 = 0.0f;
		public float Side3 = 0.0f; 
		public Triangle(float side1,float side2,float side3)
		{
			if(	side1 < 0.0f ||
				side2 < 0.0f ||
				side3 < 0.0f )
				throw new InvalidOperationException("Sides cant be less than 0.0f");
            Side1 = side1;
		    Side2 = side2;
		    Side3 = side3;
		}
		public override float GetArea() 
		{			
			if(Side1 <= 0.0f || Side2 <= 0.0f || Side3 <= 0.0f)
				return 0.0f;
			float S = (Side1 + Side2 + Side3) * 0.5f;
			return MathF.Sqrt(S * (S - Side1) * (S - Side2) * (S - Side3));
		}
		public bool IsRectangular() 
		{			
			float sqr1 = Side1 * Side1;
			float sqr2 = Side2 * Side2;
			float sqr3 = Side3 * Side3;

			bool IsRect = (sqr3 + sqr2 == sqr1 || sqr1 + sqr3 == sqr2 || sqr1 + sqr2 == sqr3);
			return IsRect;
		}
	}


}