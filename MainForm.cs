using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using MacControlClick.Properties;
using Microsoft.Win32;

namespace MacControlClick
{
    public partial class MainForm : Form
    {
        #region Windows API import
        // GetAsyncKeyState
        [DllImport("user32.dll")]
        internal static extern short GetAsyncKeyState(Keys vKey);

        // SendInput
        const int MOUSEEVENTF_RIGHTDOWN = 0x8;
        const int MOUSEEVENTF_RIGHTUP = 0x10;
        const int INPUT_MOUSE = 0;

        internal struct MOUSEINPUT
        {
            internal int dx;
            internal int dy;
            internal int mouseData;
            internal int dwFlags;
            internal int time;
            internal IntPtr dwExtraInfo;
        }

        internal struct INPUT
        {
            internal uint type;
            internal MOUSEINPUT mi;
        };

        [DllImport("user32.dll")]
        internal static extern int SendInput(int nInputs, ref INPUT pInputs, int cbSize);
        #endregion

        bool isLClicking = false;

        public MainForm()
        {
            InitializeComponent();
        }

        private void OnLoad(object sender, EventArgs e)
        {
            runOnLogin.Checked = Settings.Default.runOnLogin;
            minimizeOnStart.Checked = Settings.Default.minimizeOnStart;
            if (Settings.Default.minimizeOnStart)
            {
                WindowState = FormWindowState.Minimized;
            }
            if (Settings.Default.beforePath != Application.ExecutablePath)
            {
                if (Settings.Default.runOnLogin)
                {
                    RegistryKey regkey = Registry.CurrentUser.OpenSubKey(
                        @"SOFTWARE\Microsoft\Windows\CurrentVersion\Run", true);
                    regkey.SetValue("MacControlClick", Application.ExecutablePath);
                    regkey.Close();
                }
                Settings.Default.beforePath = Application.ExecutablePath;
                Settings.Default.Save();
            }
            infoUpdate.Start();
        }

        private void CheckInfo(object sender, EventArgs e)
        {
            if (GetAsyncKeyState(Keys.LButton) != 0)
            {
                if (!isLClicking) isLClicking = true;
            }
            else isLClicking = false;

            if (GetAsyncKeyState(Keys.ControlKey) != 0)
            {
                if (isLClicking)
                {
                    INPUT i = new INPUT
                    {
                        type = INPUT_MOUSE,
                        mi = {
                            dx = 0,
                            dy = 0,
                            dwFlags = MOUSEEVENTF_RIGHTDOWN,
                            dwExtraInfo = IntPtr.Zero,
                            mouseData = 0,
                            time = 0
                        }
                    };
                    SendInput(1, ref i, Marshal.SizeOf(i));
                    i.mi.dwFlags = MOUSEEVENTF_RIGHTUP;
                    SendInput(1, ref i, Marshal.SizeOf(i));
                }
            }
        }

        private void RunOnLoginCheckedChanged(object sender, EventArgs e)
        {
            Settings.Default.runOnLogin = runOnLogin.Checked;
            Settings.Default.Save();
            RegistryKey regkey = Registry.CurrentUser.OpenSubKey(
                @"SOFTWARE\Microsoft\Windows\CurrentVersion\Run", true);
            if (runOnLogin.Checked)
            {
                regkey.SetValue("MacControlClick", Application.ExecutablePath);
                regkey.Close();
            }
            else
            {
                regkey.DeleteValue("MacControlClick");
                regkey.Close();
            }
        }

        private void MinimizeOnStartCheckedChanged(object sender, EventArgs e)
        {
            Settings.Default.minimizeOnStart = minimizeOnStart.Checked;
            Settings.Default.Save();
        }
    }
}
