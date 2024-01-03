using System;

namespace CzyMozeszZostacPrezydentem;


class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("Podaj swój wiek:");
        int wiek;

        if (int.TryParse(Console.ReadLine(), out wiek))
        {
            if (wiek >= 35)
            {
                Console.WriteLine("Możesz zostać prezydentem");
            }
            else
                Console.WriteLine("Nie możesz zostać prezydentem");

            if(wiek >= 30)
            {
                Console.WriteLine("Możesz zostać senatorem");
            }
            else
            {
                Console.WriteLine("Nie możesz zostać senatorem");
            }
            
            if (wiek >= 21 )
            {
                Console.WriteLine("Możesz zostać posłem");
            }
            else
            {
                Console.WriteLine("Nie możesz zostać posłem");
            }
            
        
        }

    }

}