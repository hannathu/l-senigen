﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LösenRenskriv
{
    public class Server
    {
        //public Dictionary<string, string> EncryptedVault { get; set; }
        public byte[] IV { get; set; }
        public string Path {get; set;}
    }
}
