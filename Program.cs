using System.Collections;
using System.Globalization;

namespace ConsoleApp1;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Wybierz nr zadania:");
                int nr =Int16.Parse(Console.ReadLine());
                Console.Clear();
                switch (nr)
                {
                    case 1:
                        Zadanie1();
                        break;
                    case 2:
                        Zadanie2();
                        break;
                    default:
                        Console.WriteLine("Zły numer.");
                        break;
                }
                
    }
    public static void Zadanie1()
    {
        List<Shape> list = new List<Shape>();
        Rectangle s1 = new Rectangle();
        Triangle r1 = new Triangle();
        Circle c1 = new Circle();
        list.Add(s1);
        list.Add(r1);
        list.Add(c1);
        foreach (var shape in list)
        {
            shape.Draw();
        }
    }
    public static void Zadanie2()
    {
        Uczen u1 = new Uczen();
        u1.SetFirstName("Anna");
        u1.SetFirstName("Nowak");
        u1.SetPesel("12221766522");
        Console.WriteLine("Wiek: "+u1.GetAge());
        Console.WriteLine("Płeć: "+u1.GetGender());
        u1.SetSchool("UR");
        u1.SetCanGoHomeAlone(true);
        u1.GetEducationInfo();
        u1.GetFullName();
        u1.CanGoAloneToHome();
        u1.SetCanGoHomeAlone(false);
        u1.CanGoAloneToHome();
        
        List <Uczen> uczniowie= new List <Uczen>();
        uczniowie.Add(u1);
        Uczen u2 = new Uczen("Iza", "Kowalska","08211538226","UR",false);
        uczniowie.Add(u2);
        Uczen u3 = new Uczen("Kamil", "Hołyszko","14231997798","UR",true);
        uczniowie.Add(u3);
        Nauczyciel n1 = new Nauczyciel("doktor", uczniowie);
        n1.WhichStudentCanGoHomeAlone();
        
    }

}