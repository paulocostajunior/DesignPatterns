using DesignPatterns.Entities;

namespace DesignPatterns.Repository.LocalRepository
{
    public static class InMemoryPlayerRepository
    {
        public static List<Player> players = new()
        {
            { new Player(1, "Vinicius", "Junior", "Vini Jr.") },
            { new Player(2, "Neymar", "Junior", "Ney") },
        };

        public static List<Player> GetAllPlayers()
        {
            return players;
        }

        public static Player? GetPlayerById(int id)
        {
            return players.FirstOrDefault(p => p.Id.Equals(id));
        }
    }
}