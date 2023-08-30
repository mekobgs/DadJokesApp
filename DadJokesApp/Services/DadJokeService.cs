using DadJokesApp.Interface;
using DadJokesApp.Model;
using System.Net.Http.Json;
using System.Text.Json;

namespace DadJokesApp.Services
{
    public class DadJokeService: IDadJokesService
    {
        private readonly HttpClient _httpClient;
        private readonly IConfiguration _configuration;

        public DadJokeService(HttpClient httpClient, IConfiguration configuration)
        {
            _httpClient = httpClient;
            _configuration = configuration;
        }

        public async Task<DadJokeResponse> GetRandomJokeAsync()
        {
            try
            {
                var request = new HttpRequestMessage
                {
                    Method = HttpMethod.Get,
                    RequestUri = new Uri($"{_configuration["ApiSettings:BaseUri"]}/random/joke"),
                    Headers =
                    {
                        { "X-RapidAPI-Key", _configuration["ApiSettings:X-RapidAPI-Key"] },
                        { "X-RapidAPI-Host", _configuration["ApiSettings:X-RapidAPI-Host"] },
                    },
                };
                using (var response = await _httpClient.SendAsync(request))
                {
                    response.EnsureSuccessStatusCode();
                    return await response.Content.ReadFromJsonAsync<DadJokeResponse>(); ;
                    
                        
                }
            }
            catch (HttpRequestException ex)
            {
                return new DadJokeResponse
                {
                    success = false,
                    message = "50 request per day reached (Random Jokes). Invalid API key. Go to https:\\\\docs.rapidapi.com\\docs\\keys for more info."
                }; ;
            }
            catch (Exception ex)
            {
                return new DadJokeResponse
                {
                    success = false,
                    message = ex.Message
                };
            }
        }

        public async Task<DadJokeCountResponse> GetJokeCountAsync()
        {
            try
            {
                var request = new HttpRequestMessage
                {
                    Method = HttpMethod.Get,
                    RequestUri = new Uri($"{_configuration["ApiSettings:BaseUri"]}/joke/count"),
                    Headers =
                    {
                        { "X-RapidAPI-Key", _configuration["ApiSettings:X-RapidAPI-Key"] },
                        { "X-RapidAPI-Host", _configuration["ApiSettings:X-RapidAPI-Host"] },
                    },
                };

                using (var response = await _httpClient.SendAsync(request))
                {
                    response.EnsureSuccessStatusCode();
                    return await response.Content.ReadFromJsonAsync<DadJokeCountResponse>();
                }
            }
            catch (HttpRequestException ex)
            {
                // Log the exception or handle it as needed
                Console.WriteLine("HTTP Request Exception: " + ex.Message);
                return null;
            }
            catch (Exception ex)
            {
                // Log the exception or handle it as needed
                Console.WriteLine("Exception: " + ex.Message);
                return null;
            }
        }
    }
}
