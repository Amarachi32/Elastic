using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elastic
{
    public static class Extension
    {
        public static object GetPropVale(this object itemprop, string propertyName)
        {
            return itemprop.GetType()?.GetProperty(propertyName)?.GetValue(itemprop);
        }
    }
}
