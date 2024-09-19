using System.Text;

namespace FunctionToConsole
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            using (HttpClient client = new HttpClient())
            {
                var json = " {\"name\":\"John\"}";
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                HttpResponseMessage response = await client.PostAsync("https://rwanwig.azurewebsites.net/api/Function1", content);

                if (response.IsSuccessStatusCode)
                {
                    var responseString = await response.Content.ReadAsStringAsync();
                    Console.WriteLine(responseString);
                }
                else
                {
                    Console.WriteLine("Error : " + response.StatusCode);
                }
            }

        }
    }
}
