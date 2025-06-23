/* Florentino Aguirre
 * CPSC 23000 .NET Programming
 * Week 4 Lab Assignment
 * TestSoccer Program
 * This program instantiates a SoccerPlayer object and prints its details to the console.
 */

namespace TestSoccer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Instantiate a SoccerPlayer object with sample data
            SoccerPlayer player = new SoccerPlayer("Tino", 69, 102, 68);

            // Call the PrintPlayer method to display the player's details
            PrintPlayer(player);
        } 
        public static void PrintPlayer(SoccerPlayer player)
        {
            // Print the player's details to the console
            Console.WriteLine(player.ToString());
        }
    }
}
