using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CatRun
{
    public partial class MainForm : Form
    {
        private Icon[] icons = new Icon[5];
        private bool interval_flg;
        private int count_frame = 0;
        private PerformanceCounter pc;
        private const int WHITE = 1;
        private const int BLACK = 2;
        public MainForm()
        {
            InitializeComponent();
        }

        private void ColorButton_CheckedChanged(object sender, EventArgs e)
        {
            if (WhiteCat.Checked)
            { // 白猫
                Icon[] white ={
                    Properties.Resources.w1,
                    Properties.Resources.w2,
                    Properties.Resources.w3,
                    Properties.Resources.w4,
                    Properties.Resources.w5
                };
                icons = white;
            }
            else if (BlackCat.Checked)
            { // 黒猫
                Icon[] black ={
                    Properties.Resources.b1,
                    Properties.Resources.b2,
                    Properties.Resources.b3,
                    Properties.Resources.b4,
                    Properties.Resources.b5
                };
                icons = black;
            }
        }

        private void TaskTrayButton_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            this.ShowInTaskbar = false;
        }
        private int GetAppsUserThema()
        { /* ダーク:1 ライト:2 */
            int getmode = -1; // 操作するレジストリ・キーの名前
            string rKeyName = @"Software\Microsoft\Windows\CurrentVersion\Themes\Personalize";
            // 取得処理を行う対象となるレジストリの値の名前
            string rGetValueName = "AppsUseLightTheme";

            // レジストリの取得
            try
            {
                // レジストリ・キーのパスを指定してレジストリを開く
                Microsoft.Win32.RegistryKey rKey = Microsoft.Win32.Registry.CurrentUser.OpenSubKey(rKeyName);

                // レジストリの値を取得(DWord)
                getmode = (int)rKey.GetValue(rGetValueName);

                // 開いたレジストリ・キーを閉じる
                rKey.Close();
            }
            catch (NullReferenceException)
            {
                // レジストリ・キーまたは値が存在しない
                Console.WriteLine("レジストリ［" + rKeyName + "］の［" + rGetValueName + "］がありません！");
            }
            return getmode + 1;
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.tasktray)
                TasktrayCheck.Checked = true;
            else
                TasktrayCheck.Checked = false;

            if (Properties.Settings.Default.color == 0)
            {
                int userThema = GetAppsUserThema();
                if (userThema == 1) WhiteCat.Checked = true;
                else if (userThema == 2) BlackCat.Checked = true;
            }
            else if (Properties.Settings.Default.color == WHITE)
                WhiteCat.Checked = true;
            else if (Properties.Settings.Default.color == BLACK)
                BlackCat.Checked = true;
            else
                BlackCat.Checked = true;

            pc = new PerformanceCounter("Processor", "% Processor Time", "_Total", true);
            CatIcon.Visible = true;
            IntervalTimer.Start();
            FrameTimer.Start();
        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
            if (TasktrayCheck.Checked)
                Visible = false;
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (TasktrayCheck.Checked) Properties.Settings.Default.tasktray = true;
            else Properties.Settings.Default.tasktray = false;
            if (WhiteCat.Checked) Properties.Settings.Default.color = WHITE;
            else if (BlackCat.Checked) Properties.Settings.Default.color = BLACK;
            Properties.Settings.Default.Save();
        }

        private void IntervalTimer_Tick(object sender, EventArgs e)
        {
            interval_flg = true;
        }

        private void FrameTimer_Tick(object sender, EventArgs e)
        {
            if (interval_flg)
            {
                // CPU稼働率処理
                this.FrameTimer.Interval = 150 - (int)pc.NextValue(); // CPU使用率に応じて
                interval_flg = false;
            }
            count_frame = (count_frame + 1) % icons.Length;
            CatIcon.Icon = icons[count_frame];
        }

        private void CatIcon_Click(object sender, EventArgs e)
        {
            Visible = true;
        }
    }
}
