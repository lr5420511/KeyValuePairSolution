using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using KeyValuePair.Core;
using KeyValuePair.Mainifest;

namespace KeyValuePair.Register
{
    /// <summary>
    /// 此处注册键值对信息
    /// </summary>
    public class InstanceRegister
    {
        /// <summary>
        /// 对于不常变化的过程（例如数据的持久化，数据库不会经常切换的情况下，可以采用该方法实现接口），可以按照该方法注册。
        /// 对于经常变化的过程，可以通过读取配置文件的方式进行匹配（本Demo中没有编写例子）
        /// 在工程中，当业务发生变化时，我们仅仅通过修改实例注册器（如本例子）或者修改配置文件就可以应对变化的出现
        /// </summary>
        public InstanceRegister()
        {
            KeyValuePairManager<Type, object>.RegistNewKeyValuePair(typeof(IDisplayText), new DisplayTextA());
            KeyValuePairManager<Type, object>.RegistNewKeyValuePair(typeof(IDisplayBox), new DisplayBoxA());

            KeyValuePairManager<Type, object>.ModifyKeyValuePair(typeof(IDisplayText), new DisplayTextB());
        }
    }
}
