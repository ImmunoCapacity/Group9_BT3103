using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace EventDriven.Project.UI
{
    public class PlaceholderTextBox : TextBox
    {
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern IntPtr SendMessage(IntPtr hWnd, int msg, int wParam, string lParam);

        private const int EM_SETCUEBANNER = 0x1501;

        public string Placeholder
        {
            set { SendMessage(this.Handle, EM_SETCUEBANNER, 0, value); }
        }
    }
}
