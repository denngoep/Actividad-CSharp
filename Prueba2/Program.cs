namespace Prueba2;

class Program
{
    static void Main(string[] args)
    {
        int width = 7;
        int height = 5;
        int area = width * height;
        int perimeter =( 2 * width + 2 * height);
        width += 3;
        height -=2;
        area = width * height;
        perimeter = ( 2 * width + 2 * height);

        

        Console.WriteLine("El ancho final es: " + width);
        Console.WriteLine("La altura final es: " + height);
        Console.WriteLine("El área final es: " + area);
        Console.WriteLine("El perímetro final es: " + perimeter);
    }
}
