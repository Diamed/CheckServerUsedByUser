using System.Collections.ObjectModel;

namespace CheckServerUsedByUser.Model
{
    /// <summary>
    /// All preferences which will contain in application
    /// </summary>
    internal sealed class Preferences
    {
        public ObservableCollection<User> Users { get; set; }
        public ObservableCollection<Server> Servers { get; set; }
        public ObservableCollection<LoggedUser> LoggedUsers { get; set; }
    }
}