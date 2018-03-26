using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckServerUsedByUser.Model
{
    /// <summary>
    /// All preferences which will contain in application
    /// </summary>
    internal sealed class Preferences
    {
        public IEnumerable<User> Users { get; private set; }
        public IEnumerable<Server> Servers { get; private set; }
        public IEnumerable<LoggedUser> LoggedUsers { get; private set; }
    }
}