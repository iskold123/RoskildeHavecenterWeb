using System;
using PlanteShopService.Model;
using System.Collections;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ConsumeREST
{
    internal class RestWorker
    {
        // Lokal
        //private const string URI = "http://localhost:51793/api/localItems/";

        // Azure
        private const string URI = "https://planteshopservice20.azurewebsites.net/api/localItems/";

        public RestWorker()
        {

        }

        public async void Start()
        {
            IList<Plante> AllePlanter = await GetAllPlanterAsync();

            foreach (Plante plante in AllePlanter)
            {
                Console.WriteLine(plante);
            }

            Console.WriteLine();
            Console.WriteLine("Nu prøver vi med en plante ud fra et id");
            try
            {
                Plante plante1 = await GetOnePlanteAsync(3);
                Console.WriteLine("plante= " + plante1);
            }
            catch (KeyNotFoundException knfe)
            {
                Console.WriteLine(knfe.Message);
            }

        }
        public async Task<IList<Plante>> GetAllPlanterAsync()
        {
            using (HttpClient client = new HttpClient())
            {
                string json = await client.GetStringAsync(URI);
                IList<Plante> items =
                    JsonConvert.DeserializeObject<IList<Plante>>(json);
                return items;
            }
        }

        private async Task<Plante> GetOnePlanteAsync(int id)
        {
            using (HttpClient client = new HttpClient())
            {
                var resp = await client.GetAsync(URI + id);

                if (resp.IsSuccessStatusCode)
                {
                    string json = await resp.Content.ReadAsStringAsync();
                    Plante plante = JsonConvert.DeserializeObject<Plante>(json);
                    return plante;
                }

                throw new KeyNotFoundException($"Fejl code={resp.StatusCode} message={await resp.Content.ReadAsStringAsync()}");
            }
        }
    }
}