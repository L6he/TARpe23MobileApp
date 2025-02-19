using System;
using System.Collections.Generic;
using System.Text;

namespace Data
{
    public class DatabaseContext
    {
        private const string DbName = "CRUDdb3";
        private static string DbPath => Path.Combine(".", DbName);

        private SQLiteAsyncConnection _connection;

    }
}
