using System;

namespace MiPrimerConsola
{
    class Program
    {
        static void Main(string[] args)
        {
           

            if (args.Length > 0)
            {
                Console.WriteLine("Muy buenas  tardes le  agradecemos por habernos escogido.");
            }


            // variables 

            string nombre;

            string carrera;

            int codigo;

            string ciudad;

           

            //metodo 

            bool validarDatos(string datos)// metodo bool  puede tomar   dos valores  verdadero  o falso 
            {
                if (datos != null) 

                {
                    return true;
                    
                }
                else
                {
                    return false;
                }
            }

            Console.WriteLine("BIENVENIDO A ELEGIR   TU CARRERA LLENA LOS SIGUIENTES DATOS");
            Console.WriteLine(" ");
            

            Console.Write("Cúal  es su nombre: ");
            nombre = Console.ReadLine();
            Console.WriteLine(" ");

            Console.Write("Escribe la  carrera  a la que quieres   asistir: ");
            carrera = Console.ReadLine();
            Console.WriteLine(" ");

            Console.Write("¿Ciudad donde vive?");
            ciudad = Console.ReadLine();
            Console.WriteLine(" ");

            Console.Write("Ingrese su codigo ");
            codigo = Console.Read();
            Console.WriteLine(" ");


            Console.WriteLine("PRESIONA ENTER PARA  CONTINUAR");

            Console.ReadKey();

             //validar datos

            if (validarDatos(nombre) == true 
                
                && validarDatos(carrera)

                && validarDatos(ciudad) == true ) 

            {
                //mensaje   de   concatenando  variables

                Console.WriteLine("Bienvenido " + nombre + " la carrera que escogiste  es "

                    + carrera + " Gracias  por  registrate::::::: ");

                Console.ReadKey();
            }

        }
    }
}
