using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace KeyValuePair.Mainifest
{
    public class DisplayTextA : IDisplayText
    {
        public DisplayTextA()
        { 
        
        }

        public void DisplayText()
        {
            MessageBox.Show("A:当前对话框是DisplayTextA类型实现接口展现的，如需变动可以修改KeyValuePair.Register中的注册信息");
        }
    }
}
