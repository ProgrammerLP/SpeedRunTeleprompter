using SpeedRunTeleprompter.Contexts;

namespace SpeedRunTeleprompter
{
    internal class Utilities
    {
        public static string defaultStorageLocation = $"C://Users/{Environment.UserName}/Pictures/Speedrunning";

        public static List<GamesContext> speedRunningGames = new List<GamesContext>();
        public static List<GamesContext> gameSplits = new List<GamesContext>();
        public static List<GamesContext> currentSplit = new List<GamesContext>();
    }
}
