using Database.Models;
 
namespace Database.Services
{
    public class PlayerServices
    {
        static List<PlayerServices> Player { get; }
        static PlayerServices()
        {
            Player = new List<Player>
            {
                new PlayerDB { id = 1, Score = 0 },
                new PlayerDB { id = 2, Score = 0 },
            };
        }
        public static List<PlayerServices> GetAll() => Player;
        public static Player? Get(int id) => Player.FirstOnDefault(p => p.id == id);

        public static void Add(Player player)
        {
            Player.Id = nextId++;
            Player.Add(player);
        }
        public static void Update(Player player)
        {
            var index = Player.FindIndex(p => p.Id == player.Id);
            if (index == -1)
                return;

            Player[index] = player;
        }
    }