using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioInformacionFinaciera
{
    class Program
    {
        public static void Main(string[] args)
        {
            int saldoApertura = 0;
            int saldoRestar = 0;
            int consignar = 0;
            int saldoSumar = 0;
            int retirar = 0;
            int edad;
            string identificacion;
            string nombre;
            Double Cuenta;
            ConsoleKeyInfo opcion;


            int OpcionSeleccionada = 0;
            int x;

            while (OpcionSeleccionada != 5)
            {
                Console.WriteLine("1) Registro de cuenta finaciera");
                Console.WriteLine("2) Consignar cuenta finaciera");
                Console.WriteLine("3) Retirar cuenta financiera");
                Console.WriteLine("4) Consultar cuenta financiera");
                Console.WriteLine("5) Salir");
                Console.WriteLine("****************************************");
                Console.Write("Ingrese una opcion: ");

                string OpcionSeleccionadaTemporal = Console.ReadLine();
                if (int.TryParse(OpcionSeleccionadaTemporal, out x))
                {
                    OpcionSeleccionada = int.Parse(OpcionSeleccionadaTemporal);
                    switch (OpcionSeleccionada)
                    {
                        case 1:



                            Console.Clear();
                            Console.WriteLine("*  Dijite Los Siguientes Datos de la Cuenta financiera:  *\n\n");
                            Console.Write("Digite Numero de Cuenta:");
                            edad = int.Parse(Console.ReadLine());

                            Console.Write("Identificacion:");
                            identificacion = Console.ReadLine();

                            Console.Write("Nombre:");
                            nombre = Console.ReadLine();

                            Console.Write("Dijite Saldo de apertura:");
                            saldoApertura = Convert.ToInt32(Console.ReadLine());

                           
                            Console.WriteLine("Presione una tecla para volver al menu principal");
                             Console.ReadKey();
                            Console.Clear();

                            break;
                        case 2:
                            Console.Clear();
                            Console.WriteLine("\n\n * **  Consignacion de cuenta finaciera:  ***");
                            Console.Write("Dijite Saldo a Consignar:");
                            saldoSumar = Convert.ToInt32(Console.ReadLine());
                            consignar = saldoSumar + saldoApertura;
                            Console.WriteLine($"su saldo actual es ahora: {consignar}\n\n");
                            Console.WriteLine("Presione una tecla para volver al menu principal");
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        case 3:
                            Console.Clear();
                            Console.WriteLine("***  restirar de cuenta finaciera:  ***");
                            Console.Write("Dijite Saldo a Retirar:");
                            saldoRestar = Convert.ToInt32(Console.ReadLine());
                            retirar = consignar - saldoRestar;
                            Console.WriteLine($"su saldo actual es ahora: {retirar}\n\n");
                            Console.WriteLine("Presione una tecla para volver al menu principal");
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        case 4:
                            Console.Clear();
                            Console.WriteLine("***  Consultar de cuenta finaciera:  ***");
                            Console.WriteLine($"su cuenta financiera tiene al final:{retirar}\n\n");
                            
                            Console.WriteLine("Presione una tecla para volver al menu principal");
                            Console.ReadKey();
                            Console.Clear();
                            break;
                    }
                }
            }

        }
    }
}
