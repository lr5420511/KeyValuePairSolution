using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using KeyValuePair.Core;

namespace KeyValuePair.Mainifest
{
    public static class IocInstanceFactory<TDisplay> where TDisplay : class
    {
        public static TDisplay GetDisplayInstance()
        {
            return KeyValuePairManager<Type, object>.GetValueByKey(typeof(TDisplay)) as TDisplay;
        }
    }
}
