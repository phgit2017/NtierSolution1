using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Reflection;

namespace Helpers.Common
{
    public static class CommonExtensions
    {
        /// <summary>
        /// Checks if the specified object is null.
        /// </summary>
        /// <param name="obj">THe object to check.</param>
        /// <returns>(Boolean) True if null, False if not null.</returns>
        public static bool IsNull(this object obj)
        {
            return obj == null;
        }

        public static DataTable ConvertToDataTable<T>(this List<T> items)
        {
            DataTable dataTable = new DataTable(typeof(T).Name);
            //Get all the properties
            PropertyInfo[] Props = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance);
            foreach (PropertyInfo prop in Props)
            {
                dataTable.Columns.Add(prop.Name);
            }
            foreach (T item in items)
            {
                var values = new object[Props.Length];
                for (int i = 0; i < Props.Length; i++)
                {
                    values[i] = Props[i].GetValue(item, null);
                }
                dataTable.Rows.Add(values);
            }

            return dataTable;
        }
    }

    public static class VariableExtensions
    {

    }
}
