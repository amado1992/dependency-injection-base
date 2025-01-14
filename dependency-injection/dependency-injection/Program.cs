
namespace dependency_injection
{
    class Program
    {
        static void Main(string[] args)
        {
            IPlayable table = new Table("Table");
            IPlayable pc = new PC("Windows");

            Player player = new Player(table);
            //Player player = new Player(pc);

            //Player player = new Player("Player");

            Console.WriteLine(player.Play());
            Console.ReadKey();

        }
    }
}
