using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace KeyValuePair.Mainifest
{
    public class DisplayBoxB : IDisplayBox
    {
        public DisplayBoxB()
        { 
        
        }

        public void DisplayBox()
        {
            MessageBox.Show("B:当前对话框是DisplayBoxB类型实现接口展现的，如需变动可以修改KeyValuePair.Register中的注册信息", "有一个按钮的警告框", 
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
