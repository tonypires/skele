﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skele.Interop.Sql
{
    public class SqlCreateTableBuilder : SqlTableBuilder
    {
        public SqlCreateTableBuilder(string table) 
            : base(table)
        {

        }
    }
}