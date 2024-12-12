
namespace retangle_datas
{
    class Retangle
    {
        public double width;
        public double height;

        public double Area()
        {
            return width * height;
        }
        public double Perimetro()
        {
            return 2 * (width + height);
        }
        public double Diagonal()
        {
            return Math.Sqrt(width * width + height * height);
        }
    }
}
