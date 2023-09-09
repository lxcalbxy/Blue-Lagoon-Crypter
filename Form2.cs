using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Blue_Lagoon_Crypter__Windowed_
{
    public partial class Output_Name_Text_Form : Form
    {
        public static Output_Name_Text_Form instance;

        public Output_Name_Text_Form()
        {
            InitializeComponent();
            instance = this;
        }

        private void button_Output_Name_Text_Box_Click(object sender, EventArgs e)
        {
            string outputAppName = Enter_Output_Name_Text_Box.Text;
            Form1.instance.lab1.Text = outputAppName;

            Close();
        }

        private void Enter_Output_Name_Text_Box_TextChanged(object sender, EventArgs e)
        {

        }

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd,
                         int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private void DragWindow(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void ColseWindow(object sender, EventArgs e)
        {
            Close();
        }

        private void Output_Name_Text_Form_Load(object sender, EventArgs e)
        {

        }
    }
}
