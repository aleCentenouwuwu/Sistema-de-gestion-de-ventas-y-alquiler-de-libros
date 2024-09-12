using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_gestion_de_ventas_y_alquiler_de_libros
{
    public class Program
    {
        InicioDeSecion sesion = new InicioDeSecion();
        public static void Main(string[] args)
        {
            bool salirPrograma = false;
            do
            {
                try
                {
                    Console.Clear();
                    Console.WriteLine("------------Inicio de Sesion-----------\n");
                    Console.WriteLine("[1].  Iniciar sesion como Cliente general");
                    Console.WriteLine("[2].  Iniciar sesion como Docente");
                    Console.WriteLine("[3].  Iniciar sesion como Estudiante\n");
                    Console.WriteLine("[0].  Salir del sistema\n\n");
                    Console.WriteLine("Nota: Tiene que poseer una tarjeta de identificacion para poder entrar");
                    byte opc1 = Convert.ToByte(Console.ReadLine());
                    sesion._VerificarIdentidad(opc1);
                    /*switch (opc1)
                    {
                        case 0:
                            Console.Clear();
                            salirPrograma = true;
                            break;
                        case 1:

                            break;
                    }*/
                }
                catch (Exception) { }
            } while (!salirPrograma);
        }
    }
}
