using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace WebApplication1.GenericClassImplementation
{
    public class GenericImplemClass<T> where T : class
    {
        public T ValidateData(T item)
        {
            foreach (PropertyInfo propertyInfo in typeof(T).GetProperties())
            {
                if (propertyInfo.CanRead)
                {
                    if (propertyInfo != null)
                    {
                        var x = propertyInfo.GetValue(item);
                        return item;
                    }
                }
            }

            return null;
        }
    }
}
