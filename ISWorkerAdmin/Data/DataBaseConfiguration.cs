using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;


namespace ISWorkerAdmin.Data
{
    public class DataBaseConfiguration
    {
        public string ServerName { get; set; }
        public string DataBaseName { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public DatabaseType TypeDatabase { get; set; }

    }
}