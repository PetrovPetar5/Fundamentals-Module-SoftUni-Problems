namespace TeamworkProjects
{
    using System.Collections.Generic;
    using System.Text;
    public class Team
    {
        ICollection<User> members;

        private Team()
        {
            this.members = new List<User>();
        }
        public Team(string name, User creator) : this()
        {
            this.Name = name;
            this.Creator = creator;
        }

        public string Name { get; set; }

        public User Creator { get; set; }

        public int MembersCount => this.members.Count;

        public IReadOnlyCollection<User> Members => (IReadOnlyCollection<User>)this.members;

        public void AddMember(User member)
        {
            this.members.Add(member);
        }

        public override string ToString()
        {
            var sb = new StringBuilder();

            sb.AppendLine($"{this.Name}:");
            sb.AppendLine($"-{this.Creator.UserName}:");
            foreach (var member in this.members)
            {
                sb.AppendLine($"-- {member.UserName}");
            }

            return sb.ToString().TrimEnd();
        }
    }
}
