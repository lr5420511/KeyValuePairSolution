using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace KeyValuePair.Mainifest
{
    public class DisplayTextB : IDisplayText
    {
        public DisplayTextB()
        { 
        
        }

        public void DisplayText()
        {
            MessageBox.Show("B:当前对话框是DisplayTextB类型实现接口展现的，如需变动可以修改KeyValuePair.Register中的注册信息");
        }
    }
}
