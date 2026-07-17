using System;

namespace CalculoISR
{
    class Program
    {
        static void Main(string[] args)
        {
            double sueldoAnual;
            double isr = 0;

            Console.WriteLine("CALCULO DE ISR");
            Console.Write("Digite el sueldo anual del empleado: ");
            sueldoAnual = Convert.ToDouble(Console.ReadLine());

            if (sueldoAnual <= 416220)
            {
                Console.WriteLine("\nSueldo Anual: RD$ " + sueldoAnual);
                Console.WriteLine("ISR: N/A");
            }
            else if (sueldoAnual <= 624329)
            {
                isr = (sueldoAnual - 416220) * 0.15;

                Console.WriteLine("\nSueldo Anual: RD$ " + sueldoAnual);
                Console.WriteLine("ISR a pagar: RD$ " + isr);
            }
            else if (sueldoAnual <= 867123)
            {
                isr = 31216 + ((sueldoAnual - 624329) * 0.20);

                Console.WriteLine("\nSueldo Anual: RD$ " + sueldoAnual);
                Console.WriteLine("ISR a pagar: RD$ " + isr);
            }
            else
            {
                isr = 79776 + ((sueldoAnual - 867123) * 0.25);

                Console.WriteLine("\nSueldo Anual: RD$ " + sueldoAnual);
                Console.WriteLine("ISR a pagar: RD$ " + isr);
            }

            Console.WriteLine("\nPresione una tecla para finalizar...");
            Console.ReadKey();
        }
    }
}