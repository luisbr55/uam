using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UAM.OOP
{
    class Colecciones
    {
        public void ListaString<T>(T t)
        {

            // Create a list of strings.
            var salmons = new List<String>();
            salmons.Add("chinook");
            salmons.Add("coho");
            salmons.Add("pink");
            salmons.Add("sockeye");
            salmons.Add("chinook");

            // Iterate through the list.
            foreach (var salmon in salmons)
            {
                Console.WriteLine(salmon + " ");

            }
            // Output: chinook coho pink sockeye

            salmons.Remove("coho");
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("Remove ");


            // Iterate through the list.
            Imprimir(salmons);
            // Output: chinook pink sockeye
            try
            {
                //Insertando salmones
                Console.WriteLine("-----------------------------------------");
                Console.WriteLine("Insert");
                salmons.Insert(1, "Pancho");
                Imprimir(salmons);

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error [0]", ex.Message);

            }
            //Removiendo salmones
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("RemoveAt");
            salmons.RemoveAt(2);
            Imprimir(salmons);

            try
            {
                //Salmon
                Console.WriteLine("-----------------------------------------");
                Console.WriteLine("[]");
                var salmon =  salmons[0];
                Console.WriteLine("salmons = {0}", salmon);
                
                //Index
                Console.WriteLine("-----------------------------------------");
                Console.WriteLine("Index");
                var salmon1 = salmons.IndexOf("Sockeye");
                Console.WriteLine("salmons = {0}", salmon1);

                //Contains
                Console.WriteLine("-----------------------------------------");
                Console.WriteLine("Contains");
                var existe = salmons.Contains("chinook");
                Console.WriteLine("existe = {0}", existe);

                //Cantidad de elementos
                Console.WriteLine("-----------------------------------------");
                Console.WriteLine("Contains");
                var cantidad = salmons.Count;
                Console.WriteLine("cantidad = {0}", cantidad);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error [0]", ex.Message);
                throw;
            }
        }

        private void Imprimir(List<string> salmons)
        {
            foreach (var salmon in salmons)
            {
                Console.WriteLine(salmon + " ");

            }
        }
    }
}
