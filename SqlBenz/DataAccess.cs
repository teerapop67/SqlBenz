using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace SqlBenz
{
    public class DataAccess
    {
        public List<Person> Getpeople(string lastname)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("SampleDatabase")))
            {
                var output = connection.Query<Person>($"select * from people where Lastname = '{ lastname }'").ToList();
                return output;
            }
        }
    }
}
