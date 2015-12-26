using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Countdown : Form
    {
        public Countdown()
        {
            InitializeComponent();
        }

        int miliseconds, taskbar;

        private void button1_Click(object sender, EventArgs e)
        {
            //Composing the time in h,m,s
            if (hours_input.Text == "") hours_input.Text = "00";
            if (minutes_input.Text == "") minutes_input.Text = "00";
            if (seconds_input.Text == "") seconds_input.Text = "00";
            for (int i = 0; i <= 9; i++)
            {
                if (Convert.ToInt32(hours_input.Text) == i) hours_input.Text = "0" + i;
                if (Convert.ToInt32(minutes_input.Text) == i) minutes_input.Text = "0" + i;
                if (Convert.ToInt32(seconds_input.Text) == i) seconds_input.Text = "0" + i;
            }
            int hours, minutes, seconds;
            hours = Convert.ToInt32(hours_input.Text);
            minutes = Convert.ToInt32(minutes_input.Text);
            seconds = Convert.ToInt32(seconds_input.Text);

            //Composing the time in miliseconds
            miliseconds = (hours * 3600 + minutes * 60 + seconds) * 4 + 1;

            progressBar.Maximum = miliseconds - 1;
            progressBar.Value = miliseconds - 1;
            elapsed_progress.Maximum = progressBar.Maximum;

            //Starting countdown
            timer1.Enabled = true;
            progressBar.Visible = true;
            time_label.Visible = true;
            elapsed_progress.Visible = true;
            elapsed.Visible = true;
            taskbar = 0;
            seconds_input.ReadOnly = true;
            minutes_input.ReadOnly = true;
            hours_input.ReadOnly = true;
            button1.Enabled = false;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            elapsed_progress.Visible = false;
            elapsed.Visible = false;
            taskbar = 0;
            progressBar.Value = 0;
            elapsed_progress.Value = 0;
            elapsed.Text = "";
            this.Text = "Countdown";
            seconds_input.ReadOnly = false;
            minutes_input.ReadOnly = false;
            hours_input.ReadOnly = false;
            button1.Enabled = true;
            progressBar.Visible = false;

            hours_input.Text = "";
            minutes_input.Text = "";
            seconds_input.Text = "";

            ModifyProgressBarColor.SetState(elapsed_progress, 1);
            ModifyProgressBarColor.SetState(progressBar, 1);

            TaskbarProgress.SetState(this.Handle, TaskbarProgress.TaskbarStates.NoProgress);

            timer2.Enabled = false;
        }

        private void minutes_input_TextChanged(object sender, EventArgs e)
        {

        }

        private void time_label_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (taskbar > 50) taskbar = 0;
            if (taskbar < 20 && taskbar >= 0)
            {
                this.Text = (miliseconds / 4) + " seconds left!";
                //TaskbarProgress.SetValue(this.Handle, progressBar.Value, progressBar.Maximum);
            }
            if (taskbar >= 20 && taskbar <= 40) 
            {
                this.Text = (elapsed_progress.Maximum / 4) - (miliseconds / 4) + " seconds elapsed!";
                //TaskbarProgress.SetValue(this.Handle, elapsed_progress.Value, elapsed_progress.Maximum);
            }
            if (taskbar > 40 && taskbar <= 50)
            {
                this.Text = (elapsed_progress.Maximum / 4) + " seconds countdown";
            }
            taskbar++;
            TaskbarProgress.SetValue(this.Handle, progressBar.Value, progressBar.Maximum);


            miliseconds--;
            progressBar.Value = miliseconds;
            time_label.Text = ( miliseconds / 4 ) + " seconds left!";
            elapsed_progress.Value = progressBar.Maximum - progressBar.Value;
            elapsed.Text = (elapsed_progress.Maximum / 4) - (miliseconds / 4) + " seconds elapsed!";

            if ( miliseconds == 0 )
            {
                timer1.Enabled = false;
                time_label.Text = "Countdown expired!";
                timer2.Enabled = true;
                this.Text = "Countdown expired!";
                ModifyProgressBarColor.SetState(elapsed_progress, 2);
                ModifyProgressBarColor.SetState(progressBar, 2);

                TaskbarProgress.SetValue(this.Handle, progressBar.Maximum, progressBar.Maximum);
                TaskbarProgress.SetState(this.Handle, TaskbarProgress.TaskbarStates.Error);
            }
        }
    }



    //Progress bar color

    public static class ModifyProgressBarColor
    {
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = false)]
        static extern IntPtr SendMessage(IntPtr hWnd, uint Msg, IntPtr w, IntPtr l);
        public static void SetState(this ProgressBar pBar, int state)
        {
            SendMessage(pBar.Handle, 1040, (IntPtr)state, IntPtr.Zero);
        }
    }

    //Taskbar progressbar

    public static class TaskbarProgress
    {
        public enum TaskbarStates
        {
            NoProgress = 0,
            Indeterminate = 0x1,
            Normal = 0x2,
            Error = 0x4,
            Paused = 0x8
        }

        [ComImportAttribute()]
        [GuidAttribute("ea1afb91-9e28-4b86-90e9-9e9f8a5eefaf")]
        [InterfaceTypeAttribute(ComInterfaceType.InterfaceIsIUnknown)]
        private interface ITaskbarList3
        {
            // ITaskbarList
            [PreserveSig]
            void HrInit();
            [PreserveSig]
            void AddTab(IntPtr hwnd);
            [PreserveSig]
            void DeleteTab(IntPtr hwnd);
            [PreserveSig]
            void ActivateTab(IntPtr hwnd);
            [PreserveSig]
            void SetActiveAlt(IntPtr hwnd);

            // ITaskbarList2
            [PreserveSig]
            void MarkFullscreenWindow(IntPtr hwnd, [MarshalAs(UnmanagedType.Bool)] bool fFullscreen);

            // ITaskbarList3
            [PreserveSig]
            void SetProgressValue(IntPtr hwnd, UInt64 ullCompleted, UInt64 ullTotal);
            [PreserveSig]
            void SetProgressState(IntPtr hwnd, TaskbarStates state);
        }

        [GuidAttribute("56FDF344-FD6D-11d0-958A-006097C9A090")]
        [ClassInterfaceAttribute(ClassInterfaceType.None)]
        [ComImportAttribute()]
        private class TaskbarInstance
        {
        }

        private static ITaskbarList3 taskbarInstance = (ITaskbarList3)new TaskbarInstance();
        private static bool taskbarSupported = Environment.OSVersion.Version >= new Version(6, 1);

        public static void SetState(IntPtr windowHandle, TaskbarStates taskbarState)
        {
            if (taskbarSupported) taskbarInstance.SetProgressState(windowHandle, taskbarState);
        }

        public static void SetValue(IntPtr windowHandle, double progressValue, double progressMax)
        {
            if (taskbarSupported) taskbarInstance.SetProgressValue(windowHandle, (ulong)progressValue, (ulong)progressMax);
        }
    }
}
