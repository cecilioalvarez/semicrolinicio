
using ES.Semicrol.Fundanet;
using semicrolinicio.basico2;
using semicrolinicio.basico4;
using semicrolinicio.basico5;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace semicrolinicio.basico3
{
    class Programa25
    {
        static void Main(string[] args)
        {

            string ruta = @"C:\Users\cecilio\Desktop\prueba.txt";
           
            try
            {
                using (StreamReader sr = File.OpenText(ruta))
                {
                    string s = "";
                    while ((s = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(s);
                    }
                }

                  

            }
            catch (Exception e )
            {
                Console.WriteLine("ha ocurrido una excepcion");
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);
              
            }
            /*
            finally
            {
               
                Console.WriteLine("todo termino");
            
            }*/
            Console.ReadLine(); 
        }

        
    }
}
