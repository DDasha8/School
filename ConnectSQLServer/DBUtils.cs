﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ConnectSQLServer
{
    class DBUtils
    {
        public static SqlConnection GetDBConnection()
        {
            string datasource = @"tran-vmware\SQLEXPRESS";

            string database = "ElectronicSchool";
            string username = "sa";
            string password = "1234";

            return DBSQLServerUtils.GetDBConnection(datasource, database, username, password);
        }
    }
}
