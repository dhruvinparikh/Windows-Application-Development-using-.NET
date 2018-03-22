using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lecture2
{
    public partial class SameEventOnAllOptions : Form
    {
        private MessageBoxButtons ab;
        private MessageBoxIcon mi;
        public SameEventOnAllOptions()
        {
            InitializeComponent();
        }

        private void SameEventOnAllOptions_Load(object sender, EventArgs e)
        {
            
        }

        private void ButtonType_CheckedChanged(object sender, EventArgs e)
        {
            if(sender == rb_OK)
            {
                ab = MessageBoxButtons.OK;
            }
            else if(sender == rb_OKCancel)
            {
                ab = MessageBoxButtons.OKCancel;
            }
            else if(sender == rb_YesNo)
            {
                ab = MessageBoxButtons.YesNo;
            }
            else if(sender == rb_YesNoCancel)
            {
                ab = MessageBoxButtons.YesNoCancel;
            }
        }

        private void IconType_CheckedChanged(object sender, EventArgs e)
        {
            if(sender == rb_INFORMATION)
            {
                mi = MessageBoxIcon.Information;
            }
            else if(sender == rb_QUESTION)
            {
                mi = MessageBoxIcon.Question;
            }
            else if(sender == rb_ERROR)
            {
                mi = MessageBoxIcon.Error;
            }
            else if(sender == rb_WARNING)
            {
                mi = MessageBoxIcon.Warning;
            }
        }

        private void btn_Display_Click(object sender, EventArgs e)
        {
            MessageBox.Show(txt_Screen.Text, "message", ab, mi);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
