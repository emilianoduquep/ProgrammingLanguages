using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerenciaExamples
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<Shape> shapes = new List<Shape>();

            shapes.Add(new Rectangle());
            shapes.Add(new Triangle());
            shapes.Add(new Circle());
            shapes.Add(new Square());

            foreach(Shape shape in shapes)
            {
                shape.draw();
            }
        }
    }

    public class Shape
    {
        public virtual void draw()
        {
            Console.WriteLine("Performig base class drawing tasks");
        }
    }

    public class Rectangle : Shape
    {
        public override void draw()
        {
            Console.WriteLine("Drawing a Circle");
            base.draw();
        }
    }

    public class Square : Shape
    {
        public override void draw()
        {
            Console.WriteLine("Drawing a Square");
            base.draw();
        }
    }

    public class Circle : Shape
    {
        public override void draw()
        {
            Console.WriteLine("Drawing a Circle");
            base.draw();
        }
    }

    public class Triangle : Shape
    {
        public override void draw()
        {
            Console.WriteLine("Drawing a Triangle");
            base.draw();
        }
    }

  
}
