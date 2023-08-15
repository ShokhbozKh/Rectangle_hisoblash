namespace oop_vazifa_1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Rectangle rectangle = new Rectangle();
            rectangle.hight = 4;
            rectangle.width = 6;
            

            Console.WriteLine(rectangle.CalculateArea());// return resualt

            rectangle.DisplayInfo();// void method

        }

    }
    class Rectangle
    {
        public int hight { get; set; }
        public int width { get; set; }

        public int CalculateArea()
        { 

            double result = hight * width;

            return (int)result;
        }
        public void DisplayInfo()
        {
            int result = CalculateArea();

            Console.WriteLine($"Result: {result}");
        }
    }
}