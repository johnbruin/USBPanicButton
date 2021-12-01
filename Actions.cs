using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace USBPanicButton
{
    public static class Actions
    {
        [DllImport("user32.dll")]
        static extern bool SetForegroundWindow(IntPtr hWnd);
        
        [System.Runtime.InteropServices.DllImport("winmm.DLL", EntryPoint = "PlaySound", SetLastError = true)]
        private static extern bool PlaySound(string szSound, System.IntPtr hMod, PlaySoundFlags flags);

        [System.Flags]
        private enum PlaySoundFlags : int
        {
            SND_SYNC = 0x0000,
            SND_ASYNC = 0x0001,
            SND_NODEFAULT = 0x0002,
            SND_LOOP = 0x0008,
            SND_NOSTOP = 0x0010,
            SND_NOWAIT = 0x00002000,
            SND_FILENAME = 0x00020000,
            SND_RESOURCE = 0x00040004
        }

        public static void PlaySound(string strFile)
        {
            PlaySound(strFile, new System.IntPtr(), PlaySoundFlags.SND_ASYNC);
        }

        private static Bitmap bmpScreenshot;
        private static Graphics gfxScreenshot;
        public static void EarthQuake()
        {
            try
            {
                var width = Screen.PrimaryScreen.Bounds.Width;
                var height = Screen.PrimaryScreen.Bounds.Height;

                // Set the bitmap object to the size of the screen
                bmpScreenshot = new Bitmap(width, height);

                // Create a graphics object from the bitmap
                gfxScreenshot = Graphics.FromImage(bmpScreenshot);

                // Take the screenshot from the upper left corner to the right bottom corner
                gfxScreenshot.CopyFromScreen(new Point(0, 0), new Point(0, 0), new Size(width, height), CopyPixelOperation.SourceCopy);

                // Make a Form with a PictureBox
                Form _form = new Form();
                _form.WindowState = FormWindowState.Maximized;
                _form.FormBorderStyle = FormBorderStyle.None;
                _form.BackColor = Color.Black;
                _form.ShowInTaskbar = false;
                
                PictureBox _pictureBox = new PictureBox();
                _pictureBox.Width = width;
                _pictureBox.Height = height;
                _pictureBox.Image = bmpScreenshot;
                _form.Controls.Add(_pictureBox);
                _form.TopMost = true;
                _form.Focus();
                _form.BringToFront();
                _form.Show();

                ShakeIt(_pictureBox);
                
                _form.Dispose();
            }
            catch (Exception ex)
            {
                DisplayException(ex.Source, ex);
            } 
        }

        public static void ShakeIt(PictureBox _pictureBox)
        {
            var orgx = _pictureBox.Left;
            var orgy = _pictureBox.Top;
            var r = new Random();
            for (var i = 0; i < 50; i++)
            {
                var x = r.Next(-10, 10);
                var y = r.Next(-10, 10);
                _pictureBox.Left = orgx + x; 
                _pictureBox.Top = orgy + y;
                Application.DoEvents();
            }            
        }

        public static void DoCommand(string strCommand)
        {
            try
            {
                if (!string.IsNullOrEmpty(strCommand.Trim()))
                {
                    Process proc = new System.Diagnostics.Process();
                    proc.EnableRaisingEvents = false;
                    proc.StartInfo.FileName = strCommand;
                    proc.Start();
                }
            }
            catch (Exception ex)
            {
                DisplayException(ex.Source, ex);
            } 
        }

        public static void PowerPointNextSlide()
        {
            Process[] p;
            IntPtr powerPointHandle;

            try
            {
                p = Process.GetProcessesByName("powerpnt");
                powerPointHandle = p[0].MainWindowHandle;
                SetForegroundWindow(powerPointHandle);
                SendKeys.SendWait("{PGDN}");               
            }
            catch (Exception ex)
            {
                DisplayException(ex.Source, ex);
            }
            try
            {
                p = Process.GetProcessesByName("pptview");
                powerPointHandle = p[0].MainWindowHandle;
                SetForegroundWindow(powerPointHandle);
                SendKeys.SendWait("{PGDN}");
            }
            catch (Exception ex)
            {
                DisplayException(ex.Source, ex);
            } 
        }

        public static Form frmPicture;
        public static void ShowPicture(string p, bool blnShake)
        {
            Image _image = Image.FromFile(p);

            // Make a Form with a PictureBox
            frmPicture = new Form
            {
                AutoSize = true,
                WindowState = FormWindowState.Maximized,
                FormBorderStyle = FormBorderStyle.None,
                BackColor = Color.Black,
                ShowInTaskbar = false
            };

            var _pictureBox = new PictureBox
            {
                SizeMode = PictureBoxSizeMode.StretchImage,
                Width = Screen.PrimaryScreen.Bounds.Width,
                Height = Screen.PrimaryScreen.Bounds.Height,
                Image = _image
            };

            _pictureBox.Click += new EventHandler(PictureBox_Click);
            frmPicture.Controls.Add(_pictureBox);
            frmPicture.TopMost = true;
            frmPicture.Focus();
            frmPicture.BringToFront();
            frmPicture.Show();

            if (blnShake) ShakeIt(_pictureBox);
        }

        static void PictureBox_Click(object sender, EventArgs e)
        {
            frmPicture.Dispose();
            frmPicture = null;
        }

        private static void DisplayException(String moduleName, Exception e)
        {
            var message = "Exception: " + e.Message + "\r\n" + "Module: " + moduleName + "\r\n" + "Method: " + e.TargetSite.Name;
            Debug.Write(message);
        }
   }
}