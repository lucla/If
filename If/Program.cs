using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace If
{
    class Program
    {
        static void Main(string[] args)
        {
            string comparacion;
            Console.WriteLine("Introduce un número:");
            double var1 = Convert.ToDouble(Console.ReadLine()); //Convierte string a double
			Console.WriteLine("Intoduce otro número:");
			double var2 = Convert.ToDouble(Console.ReadLine());
			if (var1 < var2)  //Comparación menor que
				comparacion = "menor que";
			else
			{
				if (var1 == var2)//Comparación igual que
                    comparacion = "igual que";
                else//Comparación mayor que, no es menor ni igual que.
                    comparacion = "mayor que";
			}
			Console.WriteLine($"El primer número ({var1}) es {comparacion} el segundo número ({var2})");
			Console.ReadKey();
        }
    }
}
