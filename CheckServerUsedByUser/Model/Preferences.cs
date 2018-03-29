using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CheckServerUsedByUser.Model
{
    /// <summary>
    /// All preferences which will contain in application
    /// </summary>
    internal sealed class Preferences : INotifyPropertyChanged
    {
        private IEnumerable<User> _users;
        public IEnumerable<User> Users
        {
            get => _users;
            set
            {
                _users = value;
                OnPropertyChanged(nameof(Users));
            }
        }

        private IEnumerable<Server> _servers;
        public IEnumerable<Server> Servers
        {
            get => _servers;
            set
            {
                _servers = value;
                OnPropertyChanged(nameof(Servers));
            }
        }

        private IEnumerable<LoggedUser> _loggedUsers;
        public IEnumerable<LoggedUser> LoggedUsers
        {
            get => _loggedUsers;
            set
            {
                _loggedUsers = value;
                OnPropertyChanged(nameof(LoggedUsers));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
    }
}