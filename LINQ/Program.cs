namespace LINQ
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<string> games = new List<string>()
            {
                "DOOM", "Farcry", "Team Fortres", "Spore", "Doki Doki Literature Club", "Bendy and the Ink Machine", "Armello","Oneshot"
            };
            games = games.OrderBy(x => x.Length).ToList();
            foreach (string game in games) 
            {
                Console.WriteLine(game);
            }
        }
    }
}
