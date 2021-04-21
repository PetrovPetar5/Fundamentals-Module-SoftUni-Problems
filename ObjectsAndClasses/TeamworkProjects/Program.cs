namespace TeamworkProjects
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    class Program
    {
        static void Main(string[] args)
        {
            var teamsToRegisterCount = int.Parse(Console.ReadLine());
            var teams = new List<Team>();
            var sb = new StringBuilder();

            for (int i = 0; i < teamsToRegisterCount; i++)
            {
                var teamArgs = Console.ReadLine().Split('-').ToArray();
                var userName = teamArgs[0];
                var teamName = teamArgs[1];

                var creator = new User(userName);
                var curTeam = new Team(teamName, creator);

                if (teams.Any(x => x == curTeam))
                {
                    continue;
                }

                teams.Add(curTeam);
                sb.AppendLine($"Team {curTeam.Name} has been created by {curTeam.Creator.UserName}!");
            }

            Console.WriteLine(sb.ToString().TrimEnd());
        }
    }
}
