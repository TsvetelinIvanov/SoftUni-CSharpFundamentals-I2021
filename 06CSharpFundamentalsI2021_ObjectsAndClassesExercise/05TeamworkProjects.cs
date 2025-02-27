using System;
using System.Linq;
using System.Collections.Generic;

namespace _05TeamworkProjects
{
    class Team
    {
        public Team(string teamName, string creator)
        {
            this.TeamName = teamName;
            this.Creator = creator;
            this.Members = new List<string>();
        }

        public string TeamName { get; }

        public string Creator { get; }

        public List<string> Members { get; }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            List<Team> teams = new List<Team>();
            int teamsCount = int.Parse(Console.ReadLine());
            for (int i = 0; i < teamsCount; i++)
            {
                string[] teamCreation = Console.ReadLine().Split('-');
                string creator = teamCreation[0];
                string teamName = teamCreation[1];

                if (teams.Any(t => t.TeamName == teamName))
                {
                    Console.WriteLine($"Team {teamName} was already created!");
                    continue;
                }

                if (teams.Any(t => t.Creator == creator))
                {
                    Console.WriteLine(creator + " cannot create another team!");
                    continue;
                }

                Team team = new Team(teamName, creator);
                teams.Add(team);
                Console.WriteLine($"Team {teamName} has been created by {creator}!");
            }

            string teamMember;
            while ((teamMember = Console.ReadLine()) != "end of assignment")
            {
                string memberName = teamMember.Split("->").First();
                string wishTeamName = teamMember.Split("->").Last();
                Team wishTeam = teams.FirstOrDefault(t => t.TeamName == wishTeamName);
                if (wishTeam == null)
                {
                    Console.WriteLine($"Team {wishTeamName} does not exist!");
                    continue;
                }

                if (teams.Any(t => t.Members.Contains(memberName) || t.Creator == memberName))
                {
                    Console.WriteLine($"Member {memberName} cannot join team {wishTeamName}!");
                    continue;
                }

                wishTeam.Members.Add(memberName);
            }

            PrintTeams(teams);
        }

        private static void PrintTeams(List<Team> teams)
        {
            List<Team> createdTeams = teams.Where(t => t.Members.Count > 0).OrderByDescending(t => t.Members.Count).ThenBy(t => t.TeamName).ToList();
            foreach (Team createdTeam in createdTeams)
            {
                Console.WriteLine(createdTeam.TeamName);
                Console.WriteLine("- " + createdTeam.Creator);
                foreach (string member in createdTeam.Members.OrderBy(m => m))
                {
                    Console.WriteLine("-- " + member);
                }
            }

            List<Team> disbandedTeams = teams.Where(t => t.Members.Count == 0).OrderBy(t => t.TeamName).ToList();
            Console.WriteLine("Teams to disband:");
            foreach (Team disbandedTeam in disbandedTeams)
            {
                Console.WriteLine(disbandedTeam.TeamName);
            }
        }
    }
}
