using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4GuiaCAI
{
     class Ejercicio4GuiaCAI
    {
        

        public void EJ21()
        {
            //21. Presente al usuario la fecha actual.
            Console.WriteLine(DateTime.Today);

        }

        public void EJ22()
        {
            //22.Presente al usuario la fecha actual con el siguiente formato: dd / MM / yyyy
            Console.WriteLine(DateTime.Today.ToString("dd / MM / yyyy"));

        }

        public void EJ23()
        {
            //23.Solicite el ingreso de una fecha al usuario y determine si es un ingreso válido.
            while (true)
            {
                Console.WriteLine("por favor ingrese una fecha");
                string fecha = Console.ReadLine();
                if(!DateTime.TryParse(fecha, out DateTime salida))
                {
                    Console.WriteLine("El ingreso no es interpretado como una fecha");
                }
                else
                {
                    Console.WriteLine("la fecha ingresada es " + salida);
                }
                break;
            }
        }

        public void EJ24()
        {
            //24.Solicite el ingreso de una fecha al usuario utilizando, estrictamente, el formato dd/ MM / yyyy
            

        }

        public void Ej25()
        {
            //25.Le solicite al usuario el ingreso de tres números y determine si conforman una fecha válida interpretados como día / mes / año.

        }

        public void Ej26()
        {
            //26.Solicite el ingreso de una fecha al usuario y le presente: el día, el año, el número y nombre del mes y el nombre y número del día de la semana.
            while (true)
            {
                Console.WriteLine("por favor ingrese una fecha");
                string fecha = Console.ReadLine();
                if(!DateTime.TryParse(fecha, out DateTime salida))
                {
                    Console.WriteLine("El ingreso no es interpretado como una fecha");
                }
                else
                {
                    Console.WriteLine(salida.Day);
                    Console.WriteLine(salida.Year);
                    Console.WriteLine(salida.ToString("MMMM ") + salida.Month);
                    Console.WriteLine(salida.ToString("dddd ") + (int) salida.DayOfWeek);                    
                }
                break;
            }


        }

        public void EJ27()
        {
            //27.Solicite el ingreso de una fecha al usuario y presente las
            //fechas 30, 60, 90 y 180 días posteriores a la ingresada.
            while (true)
            {
                Console.WriteLine("por favor ingrese una fecha");
                string fecha = Console.ReadLine();
                if (!DateTime.TryParse(fecha, out DateTime salida))
                {
                    Console.WriteLine("El ingreso no es interpretado como una fecha");
                }
                else
                {
                    Console.WriteLine(salida.AddDays(30));
                    Console.WriteLine(salida.AddDays(60));
                    Console.WriteLine(salida.AddDays(90));
                    Console.WriteLine(salida.AddDays(180));
                }
                break;
            }

        }

        public void EJ28()
        {
            //28.Solicite el ingreso de un número al usuario y determine si corresponde a un año bisiesto.
            {
                int a;
                Console.WriteLine("Ingresa año");
                a = Convert.ToInt32(Console.ReadLine());
                if (a % 4 == 0 && (a % 100 != 0 || a % 400 == 0))
                {
                    Console.WriteLine("El año " + a + " es bisiesto ");
                }
                else
                {
                    Console.WriteLine("El año " + a + " no es bisiesto ");
                }
                Console.ReadLine();
            }
        }

        public void EJ29()
        {
            //29.Solicite el ingreso de una fecha al usuario y presente la
            //fecha correspondiente al primero de mes inmediato anterior.
            while (true)
            {
                Console.WriteLine("por favor ingrese una fecha");
                string fecha = Console.ReadLine();
                if (!DateTime.TryParse(fecha, out DateTime salida))
                {
                    Console.WriteLine("El ingreso no es interpretado como una fecha");
                }
                else
                {
                    Console.WriteLine(salida.AddMonths(-1));                    
                }
                break;
            }
        }

        public void EJ30()
        {
            //30.Solicite el ingreso de una fecha al usuario y muestre sólo la hora.

            while (true)
            {
                Console.WriteLine("por favor ingrese una fecha");
                string fecha = Console.ReadLine();
                if (!DateTime.TryParse(fecha, out DateTime salida))
                {
                    Console.WriteLine("El ingreso no es interpretado como una fecha");
                }
                else
                {
                    Console.WriteLine(salida.ToString("HH"));
                    
                }
                break;
            }
        }
        

    }
}
