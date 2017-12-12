using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace KeyValuePair.Mainifest
{
    public class DisplayBoxA : IDisplayBox
    {
        public DisplayBoxA()
        { 
        
        }

        public void DisplayBox()
        {
            MessageBox.Show("A:当前对话框是DisplayBoxA类型实现接口展现的，如需变动可以修改KeyValuePair.Register中的注册信息", "有两个按钮的错误框",
                  MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
        }
    }
}
