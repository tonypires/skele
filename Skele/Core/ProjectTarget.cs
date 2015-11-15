﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skele.Core
{
    public class ProjectTarget
    {
        public ProjectTarget(string name, string driverName, string connString)
        {
            Name = name;
            DriverName = driverName;
            ConnectionString = connString;

            var csb = new SqlConnectionStringBuilder(connString);
            Database = csb.InitialCatalog;
        }

        public string Name
        {
            get;
            private set;
        }

        public string Database
        {
            get;
            private set;
        }

        public string DriverName
        {
            get;
            private set;
        }

        public string ConnectionString
        {
            get;
            private set;
        }
    }
}
