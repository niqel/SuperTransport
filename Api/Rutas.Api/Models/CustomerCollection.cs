
using Microsoft.Data.SqlClient.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TmsTcAPI.Models
{
    public class CustomerCollection : List<ExcelCustomer>, IEnumerable<SqlDataRecord>
    {
        IEnumerator<SqlDataRecord> IEnumerable<SqlDataRecord>.GetEnumerator()
        {
            var sqlRow = new SqlDataRecord(
                new SqlMetaData("Name", System.Data.SqlDbType.VarChar, 50),
                new SqlMetaData("Lastame", System.Data.SqlDbType.VarChar, 30),
                new SqlMetaData("Surname", System.Data.SqlDbType.VarChar, 30),
                new SqlMetaData("Gender", System.Data.SqlDbType.Int),
                new SqlMetaData("Birthday", System.Data.SqlDbType.DateTime2),
                new SqlMetaData("Email", System.Data.SqlDbType.VarChar, 50),
                new SqlMetaData("Phone", System.Data.SqlDbType.VarChar, 10),
                new SqlMetaData("Street", System.Data.SqlDbType.VarChar, 30),
                new SqlMetaData("Number", System.Data.SqlDbType.VarChar, 10),
                new SqlMetaData("Neighborhood", System.Data.SqlDbType.VarChar, 80),
                new SqlMetaData("City", System.Data.SqlDbType.VarChar, 30),
                new SqlMetaData("District", System.Data.SqlDbType.VarChar, 30),
                new SqlMetaData("PostalCode", System.Data.SqlDbType.VarChar, 7),
                new SqlMetaData("Latitude", System.Data.SqlDbType.Decimal, 18, 15),
                new SqlMetaData("Longitude", System.Data.SqlDbType.Decimal, 18, 15));

            foreach (ExcelCustomer customer in this)
            {
                sqlRow.SetSqlString(0, customer.Name);
                sqlRow.SetSqlString(1, customer.Lastname);
                sqlRow.SetSqlString(2, customer.Surname);
                sqlRow.SetSqlInt32(3, customer.Gender);
                sqlRow.SetSqlDateTime(4, customer.Birthday);
                sqlRow.SetSqlString(5, customer.Email);
                sqlRow.SetSqlString(6, customer.Phone);
                sqlRow.SetSqlString(7, customer.Street);
                sqlRow.SetSqlString(8, customer.Number);
                sqlRow.SetSqlString(9, customer.Neighborhood);
                sqlRow.SetSqlString(10, customer.City);
                sqlRow.SetSqlString(11, customer.District);
                sqlRow.SetSqlString(12, customer.PostalCode);
                sqlRow.SetSqlDecimal(13, customer.Latitude);
                sqlRow.SetSqlDecimal(14, customer.Longitude);

                yield return sqlRow;
            }
        }
    }
}