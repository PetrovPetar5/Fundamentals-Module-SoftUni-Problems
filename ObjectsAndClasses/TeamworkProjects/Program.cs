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
            for (int i = 0; i < teamsToRegisterCount; i++)
            {
                var teamArgs = Console.ReadLine().Split('-').ToArray();
                var userName = teamArgs[0];
                var teamName = teamArgs[1];

                var creator = new User(userName);
                var curTeam = new Team(teamName, creator);

                if (teams.Any(x => x.Name == curTeam.Name))
                {
                    Console.WriteLine($"Team {curTeam.Name} was already created!");
                    continue;
                }

                if (teams.Any(x => x.Creator.UserName == curTeam.Creator.UserName))
                {
                    Console.WriteLine($"{curTeam.Creator.UserName} cannot create another team!");
                    continue;
                }

                teams.Add(curTeam);
                Console.WriteLine($"Team {curTeam.Name} has been created by {curTeam.Creator.UserName}!");
            }

            var endCommandInput = "end of assignment";
            var curCommand = String.Empty;
            while ((curCommand = Console.ReadLine()) != endCommandInput)
            {
                var commandArgs = curCommand.Split("->");
                var userName = commandArgs[0];
                var teamName = commandArgs[1];

                if (!teams.Any(x => x.Name == teamName))
                {
                    Console.WriteLine($"Team {teamName} does not exist!");
                    continue;
                }

                if (teams.Any(x => x.Members.Any(m => m.UserName == userName)))
                {
                    Console.WriteLine($"Member {userName} cannot join team {teamName}!");
                    continue;
                }

                var curUser = new User(userName);
                var curteam = teams.First(x => x.Name == teamName);
                curteam.AddMember(curUser);
            }

            teams = teams.OrderByDescending(x => x.MembersCount).ThenBy(x => x.Name).ToList();
            var disbandedTeams = teams.Where(x => x.MembersCount < 1).ToList();
            var registeredTeams = teams.Where(x => x.MembersCount >= 1).ToList();
            var sb = new StringBuilder();
            foreach (var team in registeredTeams)
            {
                sb.AppendLine($"{team.Name}:");
                sb.AppendLine($"- {team.Creator.UserName}:");
                foreach (var member in team.Members)
                {
                    sb.AppendLine($"-- {member.UserName}");
                }
            }

            sb.AppendLine("Teams to disband:");

            foreach (var team in disbandedTeams)
            {
                sb.AppendLine($"{team.Name}");
            }

            Console.WriteLine(sb.ToString().TrimEnd());
        }
    }
}
