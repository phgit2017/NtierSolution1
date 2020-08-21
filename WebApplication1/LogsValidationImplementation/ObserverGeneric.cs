using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace WebApplication1.LogsValidationImplementation
{
    public class ObserverGeneric
    {
        public List<T> AddLogHistory<T>(List<T> item, T oldValue, T newValue) where T : class
        {
            string tmnLogTag = "Y";

            List<string> columnNames = PopulateColumnNames();

            if (tmnLogTag == "Y")
            {
                ValidateClass<T>(newValue, columnNames);


            }

            return item;
        }

        private void ValidateClass<T>(T classToBeValidate, List<string> columnNames) where T : class
        {
            var propertyInfo = typeof(T).GetProperties();
            foreach (var item in columnNames)
            {
                var columnExists = propertyInfo.Where(p => p.Name == item).FirstOrDefault();
                if (columnExists != null)
                {
                    var valueToValidate = columnExists.GetValue(classToBeValidate);
                    
                }
            }
        }

        private List<string> PopulateColumnNames()
        {
            List<string> columns = new List<string>();
            columns.Add("WalletId");
            columns.Add("WalletName");
            columns.Add("IsMaster");
            columns.Add("ModelTypeId");
            return columns;
        }
    }
}
