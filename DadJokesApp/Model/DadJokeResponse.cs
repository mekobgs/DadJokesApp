namespace DadJokesApp.Model
{
    public class DadJokeResponse
    {
        public bool success { get; set; }
        public List<Body> body { get; set; }
        public string message { get; set; }
    }

    public class Body
    {
        public string _id { get; set; }
        public string setup { get; set; }
        public string punchline { get; set; }
    }

    public class DadJokeCountResponse
    {
        public bool success { get; set; }
        public int body { get; set; }
    }
}
