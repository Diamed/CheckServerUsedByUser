﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace CheckServerUsedByUser.Model
{
    /// <summary>
    /// User, who can be logged
    /// </summary>
    internal sealed class User
    {
        public string Name { get; private set; }
        public IPAddress IPAddress { get; private set; }
    }
}