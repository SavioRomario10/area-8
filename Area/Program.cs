using Area.Entities.Enums;
using Area.Entities;
using System.Formats.Asn1;

namespace Area
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Shape> list = new List<Shape>();

            Console.Write("numero de figuras: ");
            int n = int.Parse(Console.ReadLine());

            for(int i=1; i<=n; i++)
            {
                Console.WriteLine($"figura #{i}");
                Console.Write("retnagulo ou circulo?");
                char c = char.Parse(Console.ReadLine());
                Console.Write("qual a cor: ");
                Color color = Enum.Parse<Color>(Console.ReadLine());

                if(c == 'r')
                {
                    Console.Write("Largura: ");
                    double width = double.Parse(Console.ReadLine());
                    Console.Write("Altura: ");
                    double heigth = double.Parse(Console.ReadLine());

                    list.Add(new Rectangle(width, heigth, color));
                }
                else if(c == 'c')
                {
                    Console.Write("Raio: ");
                    double radio = double.Parse(Console.ReadLine());

                    list.Add(new Circle(radio, color));
                }

            }
            Console.WriteLine();
            Console.WriteLine("Area das figuras");

            foreach(Shape shape in list)
            {
                Console.WriteLine(shape.Area());
            }
        }
    }
}