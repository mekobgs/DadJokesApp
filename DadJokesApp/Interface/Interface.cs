using DadJokesApp.Model;

namespace DadJokesApp.Interface
{
    public interface IDadJokesService
    {
        Task<DadJokeResponse> GetRandomJokeAsync();
        Task<DadJokeCountResponse> GetJokeCountAsync();
    }
}
