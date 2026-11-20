using System.Net.Http;
using System.Threading.Tasks;

namespace OSDe2Tests.src.tests;


public class HttpHelper
{
    //Declares the HttpClient
    readonly HttpClient http = new HttpClient();

    //Sets a variable for the url
    public string url;
    public async Task<string> checkUrl()
    {
        
        try
        {
            //Sends a GET request to the specified URL
            using HttpResponseMessage response = await http.GetAsync(url);
            string responseBody = await response.Content.ReadAsStringAsync();
            Console.WriteLine(response.StatusCode);
            return response.StatusCode.ToString();
        }
        catch (HttpRequestException e)
        {
            Console.WriteLine($"Request error: {e.Message}");
            return e.Message;
        }


    }



}