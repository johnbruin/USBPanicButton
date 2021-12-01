using HidLibrary;
using System;
using System.Diagnostics;
using System.Windows.Forms;
using System.Linq;

///  <summary>
/// Project: USB Panic Button
/// 
/// ***********************************************************************
/// Software License Agreement
///
/// Licensor grants any person obtaining a copy of this software ("You") 
/// a worldwide, royalty-free, non-exclusive license, for the duration of 
/// the copyright, free of charge, to store and execute the Software in a 
/// computer system and to incorporate the Software or any portion of it 
/// in computer programs You write.   
/// 
/// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
/// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
/// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
/// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
/// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
/// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
/// THE SOFTWARE.
/// ***********************************************************************
/// 
/// Author
/// John Bruin http://www.johnbruin.net
/// 
/// </summary> 

namespace USBPanicButton
{
    internal class FrmMain : System.Windows.Forms.Form
    {
        #region '"Windows Form Designer generated code "'
        public FrmMain()
            : base()
        {

            // This call is required by the Windows Form Designer.
            InitializeComponent();
        }
        // Form overrides dispose to clean up the component list.
        protected override void Dispose(bool Disposing)
        {
            if (Disposing)
            {
                if (!(components == null))
                {
                    components.Dispose();
                }
            }
            base.Dispose(Disposing);
        }

        // Required by the Windows Form Designer
        private System.ComponentModel.IContainer components;
        public System.Windows.Forms.ToolTip ToolTip1;
        public System.Windows.Forms.Timer tmrContinuousDataCollect;
        private NotifyIcon notifyIcon1;
        private TextBox txtWav;
        private Button cmdWav;
        private Label label1;
        private Label label2;
        private Button cmdCommand;
        private TextBox txtCommand;
        private CheckBox chkPowerPoint;
        private CheckBox chkEarthQuake;
        private Label label3;
        private Button cmdPicture;
        private TextBox txtPicture;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem Settings;
        private Button cmdPictureClear;
        private Button cmdCommandClear;
        private Button cmdSoundClear;
        private Button cmdTest;
        private ToolStripMenuItem Exit;
        // NOTE: The following procedure is required by the Windows Form Designer
        // It can be modified using the Windows Form Designer.
        // Do not modify it using the code editor.   

        [System.Diagnostics.DebuggerStepThrough()]
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.ToolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.tmrContinuousDataCollect = new System.Windows.Forms.Timer(this.components);
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Settings = new System.Windows.Forms.ToolStripMenuItem();
            this.Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.txtWav = new System.Windows.Forms.TextBox();
            this.cmdWav = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmdCommand = new System.Windows.Forms.Button();
            this.txtCommand = new System.Windows.Forms.TextBox();
            this.chkPowerPoint = new System.Windows.Forms.CheckBox();
            this.chkEarthQuake = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmdPicture = new System.Windows.Forms.Button();
            this.txtPicture = new System.Windows.Forms.TextBox();
            this.cmdPictureClear = new System.Windows.Forms.Button();
            this.cmdCommandClear = new System.Windows.Forms.Button();
            this.cmdSoundClear = new System.Windows.Forms.Button();
            this.cmdTest = new System.Windows.Forms.Button();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ToolTip1
            // 
            this.ToolTip1.ToolTipTitle = "Test";
            // 
            // tmrContinuousDataCollect
            // 
            this.tmrContinuousDataCollect.Interval = 1;
            this.tmrContinuousDataCollect.Tick += new System.EventHandler(this.tmrContinuousDataCollect_Tick);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "USB Panic Button";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.DoubleClick += new System.EventHandler(this.NotifyIcon1_DoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Settings,
            this.Exit});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(132, 52);
            // 
            // Settings
            // 
            this.Settings.Name = "Settings";
            this.Settings.Size = new System.Drawing.Size(131, 24);
            this.Settings.Text = "Settings";
            this.Settings.Click += new System.EventHandler(this.Settings_Click);
            // 
            // Exit
            // 
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(131, 24);
            this.Exit.Text = "Exit";
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // txtWav
            // 
            this.txtWav.Location = new System.Drawing.Point(150, 64);
            this.txtWav.Name = "txtWav";
            this.txtWav.Size = new System.Drawing.Size(400, 22);
            this.txtWav.TabIndex = 4;
            // 
            // cmdWav
            // 
            this.cmdWav.AutoSize = true;
            this.cmdWav.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.cmdWav.Location = new System.Drawing.Point(554, 64);
            this.cmdWav.Name = "cmdWav";
            this.cmdWav.Size = new System.Drawing.Size(30, 27);
            this.cmdWav.TabIndex = 5;
            this.cmdWav.Text = "...";
            this.cmdWav.Click += new System.EventHandler(this.CmdWav_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label1.Location = new System.Drawing.Point(22, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Sound File:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label2.Location = new System.Drawing.Point(22, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Command:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // cmdCommand
            // 
            this.cmdCommand.AutoSize = true;
            this.cmdCommand.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.cmdCommand.Location = new System.Drawing.Point(554, 99);
            this.cmdCommand.Name = "cmdCommand";
            this.cmdCommand.Size = new System.Drawing.Size(30, 27);
            this.cmdCommand.TabIndex = 8;
            this.cmdCommand.Text = "...";
            this.cmdCommand.UseVisualStyleBackColor = true;
            this.cmdCommand.Click += new System.EventHandler(this.CmdCommand_Click);
            // 
            // txtCommand
            // 
            this.txtCommand.Location = new System.Drawing.Point(150, 99);
            this.txtCommand.Name = "txtCommand";
            this.txtCommand.Size = new System.Drawing.Size(400, 22);
            this.txtCommand.TabIndex = 7;
            // 
            // chkPowerPoint
            // 
            this.chkPowerPoint.AutoSize = true;
            this.chkPowerPoint.Location = new System.Drawing.Point(150, 136);
            this.chkPowerPoint.Name = "chkPowerPoint";
            this.chkPowerPoint.Size = new System.Drawing.Size(211, 21);
            this.chkPowerPoint.TabIndex = 9;
            this.chkPowerPoint.Text = "PowerPoint next slide control";
            this.chkPowerPoint.UseVisualStyleBackColor = true;
            // 
            // chkEarthQuake
            // 
            this.chkEarthQuake.AutoSize = true;
            this.chkEarthQuake.Location = new System.Drawing.Point(150, 166);
            this.chkEarthQuake.Name = "chkEarthQuake";
            this.chkEarthQuake.Size = new System.Drawing.Size(103, 21);
            this.chkEarthQuake.TabIndex = 10;
            this.chkEarthQuake.Text = "Earthquake";
            this.chkEarthQuake.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label3.Location = new System.Drawing.Point(22, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Picture:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // cmdPicture
            // 
            this.cmdPicture.AutoSize = true;
            this.cmdPicture.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.cmdPicture.Location = new System.Drawing.Point(554, 28);
            this.cmdPicture.Name = "cmdPicture";
            this.cmdPicture.Size = new System.Drawing.Size(30, 27);
            this.cmdPicture.TabIndex = 2;
            this.cmdPicture.Text = "...";
            this.cmdPicture.UseVisualStyleBackColor = true;
            this.cmdPicture.Click += new System.EventHandler(this.CmdPicture_Click);
            // 
            // txtPicture
            // 
            this.txtPicture.Location = new System.Drawing.Point(150, 28);
            this.txtPicture.Name = "txtPicture";
            this.txtPicture.Size = new System.Drawing.Size(400, 22);
            this.txtPicture.TabIndex = 1;
            // 
            // cmdPictureClear
            // 
            this.cmdPictureClear.AutoSize = true;
            this.cmdPictureClear.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.cmdPictureClear.Location = new System.Drawing.Point(596, 26);
            this.cmdPictureClear.Name = "cmdPictureClear";
            this.cmdPictureClear.Size = new System.Drawing.Size(51, 27);
            this.cmdPictureClear.TabIndex = 3;
            this.cmdPictureClear.Text = "Clear";
            this.cmdPictureClear.Click += new System.EventHandler(this.CmdPictureClear_Click);
            // 
            // cmdCommandClear
            // 
            this.cmdCommandClear.AutoSize = true;
            this.cmdCommandClear.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.cmdCommandClear.Location = new System.Drawing.Point(596, 97);
            this.cmdCommandClear.Name = "cmdCommandClear";
            this.cmdCommandClear.Size = new System.Drawing.Size(51, 27);
            this.cmdCommandClear.TabIndex = 9;
            this.cmdCommandClear.Text = "Clear";
            this.cmdCommandClear.Click += new System.EventHandler(this.CmdCommandClear_Click);
            // 
            // cmdSoundClear
            // 
            this.cmdSoundClear.AutoSize = true;
            this.cmdSoundClear.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.cmdSoundClear.Location = new System.Drawing.Point(596, 62);
            this.cmdSoundClear.Name = "cmdSoundClear";
            this.cmdSoundClear.Size = new System.Drawing.Size(51, 27);
            this.cmdSoundClear.TabIndex = 6;
            this.cmdSoundClear.Text = "Clear";
            this.cmdSoundClear.Click += new System.EventHandler(this.CmdSoundClear_Click);
            // 
            // cmdTest
            // 
            this.cmdTest.AutoSize = true;
            this.cmdTest.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.cmdTest.Location = new System.Drawing.Point(601, 165);
            this.cmdTest.Name = "cmdTest";
            this.cmdTest.Size = new System.Drawing.Size(46, 27);
            this.cmdTest.TabIndex = 11;
            this.cmdTest.Text = "Test";
            this.cmdTest.Click += new System.EventHandler(this.CmdTest_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(699, 228);
            this.Controls.Add(this.cmdTest);
            this.Controls.Add(this.cmdSoundClear);
            this.Controls.Add(this.cmdCommandClear);
            this.Controls.Add(this.cmdPictureClear);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmdPicture);
            this.Controls.Add(this.txtPicture);
            this.Controls.Add(this.chkEarthQuake);
            this.Controls.Add(this.chkPowerPoint);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmdCommand);
            this.Controls.Add(this.txtCommand);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmdWav);
            this.Controls.Add(this.txtWav);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(21, 28);
            this.MaximizeBox = false;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "USB Panic Button";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.Closed += new System.EventHandler(this.FrmMain_Closed);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMain_FormClosing);
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.Resize += new System.EventHandler(this.FrmMain_Resize);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private HidDevice _device;
        private const int VendorId = 0x1130;
        private const int ProductId = 0x0202;

        ///  <summary>
        ///  Perform shutdown operations.
        ///  </summary>
        private void FrmMain_Closed(System.Object eventSender, System.EventArgs eventArgs)
        {
            try
            {
                Shutdown();
            }
            catch (Exception ex)
            {
                DisplayException(this.Name, ex);
                throw;
            }
        }

        ///  <summary>
        ///  Perform startup operations.
        ///  </summary>
        private void FrmMain_Load(System.Object eventSender, System.EventArgs eventArgs)
        {
            Hide();

            notifyIcon1.Visible = true;

            try
            {
                Startup();
            }
            catch (Exception ex)
            {
                DisplayException(this.Name, ex);
            }
        }

        ///  <summary>
        ///  Perform actions that must execute when the program ends.
        ///  </summary>
        private void Shutdown()
        {
            try
            {
                SaveSettings();
                if (_device != null)
                {
                    _device.CloseDevice();
                }
            }
            catch (Exception ex)
            {
                DisplayException(this.Name, ex);
            }
            finally
            {
                Application.Exit();
            }
        }

        ///  <summary>
        ///  Perform actions that must execute when the program starts.
        ///  </summary>
        private void Startup()
        {
            try
            {
                _device = HidDevices.Enumerate(VendorId, ProductId).FirstOrDefault();
                if (_device != null)
                {
                    _device.MonitorDeviceEvents = true;
                    _device.Removed += Device_Removed;
                    _device.Inserted += Device_Inserted;
                    _device.OpenDevice();
                }
                else
                {
                    NotConnectedNotification();
                }

                tmrContinuousDataCollect.Enabled = false;
                tmrContinuousDataCollect.Interval = 10;
                tmrContinuousDataCollect.Enabled = true;

                LoadSettings();
            }
            catch (Exception ex)
            {
                DisplayException(this.Name, ex);
            }
        }

        private void Device_Removed()
        {
            NotConnectedNotification();
        }

        private void Device_Inserted()
        {
            ConnectedNotification();
        }

        private void NotConnectedNotification()
        {
            notifyIcon1.BalloonTipTitle = "USB Panic Button";
            notifyIcon1.BalloonTipIcon = ToolTipIcon.Warning;
            notifyIcon1.BalloonTipText = "Device not connected";
            notifyIcon1.ShowBalloonTip(1000);
        }

        private void ConnectedNotification()
        {
            notifyIcon1.BalloonTipTitle = "USB Panic Button";
            notifyIcon1.BalloonTipIcon = ToolTipIcon.Info;
            notifyIcon1.BalloonTipText = "Device connected";
            notifyIcon1.ShowBalloonTip(1000);
        }

        private void tmrContinuousDataCollect_Tick(System.Object eventSender, System.EventArgs eventArgs)
        {
            try
            {
                if (_device == null)
                {
                    _device = HidDevices.Enumerate(VendorId, ProductId).FirstOrDefault();
                    if (_device != null)
                    {
                        _device.MonitorDeviceEvents = true;
                        _device.Removed += Device_Removed;
                        _device.OpenDevice();
                        ConnectedNotification();
                    }
                }
                else
                {
                    _device.ReadFeatureData(out byte[] output);
                    if (output[1] == 1)
                    {
                        DoAction();
                    }
                }
            }
            catch (Exception ex)
            {
                DisplayException(this.Name, ex);
                throw;
            }
        }

        private static void DisplayException(String moduleName, Exception e)
        {
            var message = "Exception: " + e.Message + "\r\n" + "Module: " + moduleName + "\r\n" + "Method: " + e.TargetSite.Name;
            MessageBox.Show(message);
        }

        [STAThread]
        public static void Main()
        {
            Process aProcess = Process.GetCurrentProcess();
            string aProcName = aProcess.ProcessName;

            if (Process.GetProcessesByName(aProcName).Length > 1)
            {
                Application.ExitThread();
            }
            else
            {
                Application.Run(new FrmMain());
            }
        }
                
        private void NotifyIcon1_DoubleClick(object sender, EventArgs e)
        {
            Show();
            WindowState = FormWindowState.Normal;
        }

        private void FrmMain_Resize(object sender, EventArgs e)
        {
            if (FormWindowState.Minimized == this.WindowState)
            {
                Hide();
            }
        }

        private void CmdWav_Click(object sender, EventArgs e)
        {
            var fd = new OpenFileDialog();
            fd.Filter = "Wav files (*.wav) | *.wav";
            fd.ShowDialog();
            if (!string.IsNullOrEmpty(fd.FileName))
            {
                txtWav.Text = fd.FileName;
            }
        }

        private void CmdCommand_Click(object sender, EventArgs e)
        {
            var fd = new OpenFileDialog();
            fd.ShowDialog();
            if (!string.IsNullOrEmpty(fd.FileName))
            {
                txtCommand.Text = fd.FileName;
            }                
        }

        private void DoAction()
        {
            if (Actions.frmPicture == null)
            {
                if (!string.IsNullOrEmpty(txtWav.Text.Trim())) Actions.PlaySound(txtWav.Text);

                if (!string.IsNullOrEmpty(txtPicture.Text.Trim())) Actions.ShowPicture(txtPicture.Text, chkEarthQuake.Checked);

                if (Actions.frmPicture == null && chkEarthQuake.Checked) Actions.EarthQuake();

                if (chkPowerPoint.Checked) Actions.PowerPointNextSlide();

                if (!string.IsNullOrEmpty(txtCommand.Text.Trim())) Actions.DoCommand(txtCommand.Text);
            }
            else
            {
                Actions.frmPicture.Dispose();
                Actions.frmPicture = null;
            }

            SaveSettings();
        }

        private void LoadSettings()
        {
            Properties.Settings settings = new Properties.Settings();
            settings.Reload();
            chkEarthQuake.Checked = settings.EarthQuake;
            chkPowerPoint.Checked = settings.PowerPoint;
            txtCommand.Text = settings.Command;
            txtWav.Text = settings.SoundFile;
            txtPicture.Text = settings.Picture;
        }

        private void SaveSettings()
        {
            Properties.Settings settings = new Properties.Settings();
            settings.EarthQuake = chkEarthQuake.Checked;
            settings.PowerPoint = chkPowerPoint.Checked;
            settings.Command = txtCommand.Text;
            settings.SoundFile = txtWav.Text;
            settings.Picture = txtPicture.Text;
            settings.Save();
        }

        private void CmdPicture_Click(object sender, EventArgs e)
        {
            var fd = new OpenFileDialog();
            fd.Filter = "Image files (*.gif, *.jpg, *.jpeg, *.png) | *.gif;*.jpg;*.jpeg;*.png";
            fd.ShowDialog();
            if (!string.IsNullOrEmpty(fd.FileName))
            {
                txtPicture.Text = fd.FileName;
            }
        }

        private void Settings_Click(object sender, EventArgs e)
        {
            Show();
            WindowState = FormWindowState.Normal;
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Shutdown();
        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.WindowState != FormWindowState.Minimized)
            {
                this.WindowState = FormWindowState.Minimized;
                Hide();
                e.Cancel = true;
            }
        }

        private void CmdPictureClear_Click(object sender, EventArgs e)
        {
            txtPicture.Text = "";
        }

        private void CmdSoundClear_Click(object sender, EventArgs e)
        {
            txtWav.Text = "";
        }

        private void CmdCommandClear_Click(object sender, EventArgs e)
        {
            txtCommand.Text = "";
        }

        private void CmdTest_Click(object sender, EventArgs e)
        {
            DoAction();
        }
    }
}