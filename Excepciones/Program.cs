using System;
using System.IO;
using System.Reflection; //Nos ayuda a leer archivos 

namespace Excepciones
{
    class Program
    {
        static void Main(string[] args)
        {

            //Manejo de Excepciones o manejo de errores
            try //En try se escribe el codigo a evaluar
            {
                //Con using System.IO podemos leer archivos de nuestro equipo
                //File -> Clase   .ReadAllTect -> Metodo estatico
                string contenido = File.ReadAllText(@"C:\Users\Zaval3ta\Documents\Prueba.txt");
                //@ -> Para decir que todo los caracteres son parte de la cadena
                Console.WriteLine(contenido);
                //string contenido2 = File.ReadAllText(@"C:\Users\Zaval3ta\Documents\Prueba2.txt");
                //Console.WriteLine(contenido2);

                //Arrojar un error a catch(Exception ex)
                //throw new Exception("Un error que no detectamos");
            }
            catch (FileNotFoundException ex) //En catch se maneja el error y damos una excepcion o una solucion momentania
            {
                //Estamos manejando una excepcion enfocada al problema 
                Console.WriteLine("No existe el archivo. excepcion enfocada al problema; Podemos deducir que es lo que esta fallando");
            }
            catch (Exception ex) //Estamos manejando una Excepcion global
            //Se recomienda ponerla
            {
                //Esto es una excepcion global. Esto pasa cuando no sabemos en donde ocurre el problema
                Console.WriteLine(ex.Message); 
                //Para mostrar el error de throw new Exception("Un error que no detectamos"); que esta en try(){}
            }
            finally //Se recomienda usar finally para poder cerrar programas o terminar una tarea
            {
                Console.WriteLine("No importa lo que pase, error o solucion. Siempre se ejecuta finally para hacer una tarea");
            }

            /*
                try(){

                }catch()
                {

                }finally
                {

                }
Nos sirve para poder hacer un control de errores. Esto nos ayuda a ver el error y que se siga ejecutando el sistema
Hay excepciones que podemos manejar y saber que error es cuando pase
Exception es una excepcion global. Nos permite mostrar un error que no hayamos tomado en cuenta
finally siempre se ejecuta para hacer una tarea

    throw new Exception es una clase que nos permite arrojar de forma voluntaria un error a catch(Exception)
             */
            Console.WriteLine("\nCodigo que esta fuera de try catch y que se sigue ejecutando");
        } //Fin de Main



    } //Fin de class Program



}// Fin de namespace