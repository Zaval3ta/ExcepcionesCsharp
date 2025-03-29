using System;
using System.IO;
//Como personalizar una excepcion
namespace ExcepcionesPersonalizadas
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var cerveza = new Cerveza()
                {
                    nombre = "Modelo Especial",
                    //marca = "Grupo Modelo",
                };
                Console.WriteLine(cerveza);
            }catch(InvalidBeerException ex)
            {
                Console.WriteLine(ex.Message);
            }catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }// Fin de Main



    }//Fin de class Program
    //Heredando Exception para modificar el mensaje de Exception
    public class InvalidBeerException : Exception 
    {
        public InvalidBeerException() : base("La cerveza no tiene nombre o marca")
        { }
    }

    public class Cerveza
    {
        public string nombre { get; set; }
        public string marca { get; set; }

        //Modificamos ToString para poder tener un mensaje personalizado
        public override string ToString()
        {
            if (nombre == null || marca == null)
                throw new InvalidBeerException(); //Excepcion perosonalizada
            return $"Nombre: {nombre} Marca: {marca} ";
        }

    }


}//Fin de namespace