using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppClase2Darley.modelo.Apis
{
    internal class EjercicioApi1 : Ejercicio
    {
        public override void Ejecutar()
        {
            conectarApi();
        }
        public async Task conectarApi()
        {
            string url = "https://jsonplaceholder.typicode.com/posts/1";

            using (HttpClient client = new HttpClient())
            {
                try
                {
                    HttpResponseMessage response = await client.GetAsync(url);
                    response.EnsureSuccessStatusCode();

                    string responseBody = await response.Content.ReadAsStringAsync();

                    Console.WriteLine("Respuesta de API");
                    Console.WriteLine(responseBody);
                    Console.ReadLine();
                }
                catch (HttpRequestException ex) {
                    
                    Console.WriteLine(ex.Message);
                    Console.ReadLine();


                }
            }
            Console.ReadLine();
        }
    }
}
