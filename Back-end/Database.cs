using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Back_end
{
    public static class Database
    {
        public static SqlConnection connection = new SqlConnection("Data Source=.;Initial Catalog=ElearningSystem;Integrated Security=True");

    }
}