namespace DadJokesApp.Model
{
    public class DadJokeResponse: DefaultModel
    {
        public List<Body> body { get; set; }
    }

    public class Body
    {
        public string _id { get; set; }
        public string setup { get; set; }
        public string punchline { get; set; }
    }

    public class DadJokeCountResponse: DefaultModel
    {
        public int body { get; set; }
    }
}
