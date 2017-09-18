using MusicaWCFTest.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicaWCFTest
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceMusica.ServicioMusicaClient proxy = new ServiceMusica.ServicioMusicaClient();

            var artistas = JsonConvert.DeserializeObject<List<Artistas>>(proxy.ObtenerArtistas());

            foreach (var a in artistas)
            {
                Console.WriteLine($"{a.Id}. {a.Nombre} - {a.Pais}");
            }
        }
    }
}
