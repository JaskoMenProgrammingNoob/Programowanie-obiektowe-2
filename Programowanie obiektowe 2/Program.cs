using System.ComponentModel.Design;

class Pierwiastki
{
    double a;
    double b;
    double c;
    double x1;
    double x2;
    double x0;
    double rownanie;
    double delta;
    double pierwiastek;
    bool czyprawda = true;
    public void czytaj_dane()
    {
        Console.WriteLine("Podaj a: ");
        a = double.Parse(Console.ReadLine());
        switch (a)
        {
            case 0:
                Console.WriteLine("A = 0 - to nie funkcja kwadratowa tylko liniowa ");
                czyprawda = false;
                break;
            default:
                Console.WriteLine("Podaj b: ");
                b = double.Parse(Console.ReadLine());
                Console.WriteLine("Podaj c: ");
                c = double.Parse(Console.ReadLine());
                break;
        }
    }
    public void przetworz_dane()
    {
        switch (czyprawda)
        {
            case false:
                return;
            case true:
                delta = b * b - 4 * a * c;
                switch (delta)

                {
                    case 0:
                        Console.WriteLine("Wyliczam jedno miejsce zerowe: ");
                        x0 = -b / (2 * a);
                        break;
                    default:
                        if (delta < 0)
                        {
                            Console.WriteLine("Brak miejsc zerowych! ");
                        }
                        else
                        {
                            Console.WriteLine("Wyliczam x1 i x2: ");
                            x1 = -b - Math.Sqrt(delta) / (2 * a);
                            x2 = -b + Math.Sqrt(delta) / (2 * a);
                        }
                        break;

                }
                break;
        }
    }



    public void wyswietl_dane()
    {
        switch (czyprawda)
        {
            case false:
                return;
            case true:
                if (delta == 0 )
                {
                    Console.WriteLine($"A: {a:F2}");
                    Console.WriteLine($"B: {b:F2}");
                    Console.WriteLine($"C: {c:F2}");
                    Console.WriteLine($"X0: {x0:F2}");
                } else
                {
                    Console.WriteLine($"A: {a:F2}");
                    Console.WriteLine($"B: {b:F2}");
                    Console.WriteLine($"C: {c:F2}");
                    Console.WriteLine($"X1: {x1:F2}");
                    Console.WriteLine($"X2: {x2:F2}");
                }
                break;
        }
            
       /* Console.WriteLine($"A: {a:F2}");
        Console.WriteLine($"B: {b:F2}");
        Console.WriteLine($"C: {c:F2}");
        Console.WriteLine($"X1: {x1:F2}");
        Console.WriteLine($"X2: {x2:F2}");
        Console.WriteLine($"X0: {x0:F2}"); */


    }
    static void Main(string[] args)
    {

        Pierwiastki pierwiastki = new Pierwiastki();
        pierwiastki.czytaj_dane();
        pierwiastki.przetworz_dane();
        pierwiastki.wyswietl_dane();
        Console.ReadLine();


    }
}





                



















