/* Florentino Aguirre
 * CPSC 23000 .NET Programming
 * Week 4 Lab Assignment
 * SoccerPlayer class 
 * This class represents a soccer player with properties for name, jersey number, goals scored, and assists.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestSoccer
{
    internal class SoccerPlayer
    {
        // Properties for the SoccerPlayer class
        public string Name { get; set; }
        public int JerseyNumber { get; set; }
        public int Assists { get; set; }
        public int GoalsScored { get; set; }

        // Constructor to initialize the SoccerPlayer object
        public SoccerPlayer(string name, int jerseyNumber, int goalsScored, int assists )
        {
            Name = name;
            JerseyNumber = jerseyNumber;
            GoalsScored = goalsScored;
            Assists = assists;
        }

        // Override ToString method to provide a string representation of the SoccerPlayer object
        public override string ToString()
        {
            return $"{Name}, Jersey Number: {JerseyNumber}, Goals Scored: {GoalsScored}, Assists: {Assists}";
        }
    }
}
