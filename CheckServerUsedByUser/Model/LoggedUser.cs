using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckServerUsedByUser.Model
{
    /// <summary>
    /// User, whom we will check
    /// </summary>
    internal sealed class LoggedUser
    {
        public string Name { get; private set; }
        public Server Server { get; private set; }
    }
}