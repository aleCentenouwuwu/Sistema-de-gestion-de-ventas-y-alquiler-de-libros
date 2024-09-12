using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_gestion_de_ventas_y_alquiler_de_libros
{
    public class InicioDeSecion
    {
        private bool identidadCorrecta = false;

        //Matrices de usuarios Clientes
        private string[] identidadCliente = { "2024001", "2024002", "2024003" };
        private string[] nombresIdentidadClientes = { "anna_101", "marcelo_102", "catalina_103" };

        //matrices de usuarios Docentes
        private string[] identidadDocente = { "2024004", "2024005", "2024006" };
        private string[] nombresIdentidadDocentes = { "reina_104", "andres_105", "simon-106" };

        //matrices de usuarios estudiantes
        private string[] identidadEstudiante = { "2024007", "2024008", "2024009" };
        private string[] nombresIdentidadEstudiantes = { "nilo_107", "carmen_108", "pankesitosabroso_109" };

        public void _VerificarIdentidad(byte pOpcionInicioDeSecion){
            identidadCorrecta = false;
        Console.Clear();
            Console.WriteLine("Ingrese el nombre de usuario");
            Console.Write(">>");
            string nombreUsuarioTM = Console.ReadLine();
            Console.WriteLine("\nIngrese el ID del usuario");
            Console.Write(">>");
            string identidadusuarioTM = Console.ReadLine();

            if (pOpcionInicioDeSecion == 1) {
                //verifica el ID de clientes
                if (identidadCliente.Contains(identidadusuarioTM) && nombresIdentidadClientes.Contains(nombreUsuarioTM))
                {
                    Console.WriteLine("welcome");
                    identidadCorrecta = true;
                }else { Console.Clear(); Console.WriteLine("Error! datos ingresados invalidos"); }
            }
            else if (pOpcionInicioDeSecion == 2)
            {
                //verifica el ID de docentes
                if (identidadDocente.Contains(identidadusuarioTM) && nombresIdentidadDocentes.Contains(nombreUsuarioTM))
                {
                    Console.WriteLine("welcome");
                    identidadCorrecta = true;
                }else { Console.Clear(); Console.WriteLine("Error! datos ingresados invalidos"); }
            }
            else if (pOpcionInicioDeSecion == 3)
            {
                //verifica el ID de docentes
                if (identidadEstudiante.Contains(identidadusuarioTM) && nombresIdentidadEstudiantes.Contains(nombreUsuarioTM))
                {
                    Console.WriteLine("welcome");
                    identidadCorrecta = true;
                }else { Console.Clear(); Console.WriteLine("Error! datos ingresados invalidos"); }
            }
        }
    }
}
