using static System.Console;

namespace Iterators
{
    public partial class Showing
    {
        static void OceanariumShow()
        {
            Oceanarium oceanarium = new Oceanarium();
            WriteLine("Oceanarium inhabitants: ");
            foreach (var item in oceanarium)
                WriteLine(item.ToString());
        }
        static void FootballTeamShow()
        {
            Team team = new Team();
            WriteLine("Team players: ");
            foreach (var item in team)
                WriteLine(item.ToString());
            WriteLine(team[2].PlayFootball());
        }
        static void CafeShow()
        {
            Cafe cafe = new Cafe();
            WriteLine("Cafe workers: ");
            foreach (var item in cafe)
                WriteLine(item.ToString());
        }
    }
}