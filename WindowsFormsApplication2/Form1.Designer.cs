namespace WindowsFormsApplication2
{
    partial class Countdown
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.hours_input = new System.Windows.Forms.TextBox();
            this.hours_label = new System.Windows.Forms.Label();
            this.seconds_input = new System.Windows.Forms.TextBox();
            this.seconds_label = new System.Windows.Forms.Label();
            this.minutes_input = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.time_label = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.elapsed = new System.Windows.Forms.Label();
            this.elapsed_progress = new System.Windows.Forms.ProgressBar();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.pause = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter the countdown here!";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(166, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(142, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Start the countdown";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 250;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // hours_input
            // 
            this.hours_input.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.hours_input.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hours_input.Location = new System.Drawing.Point(12, 41);
            this.hours_input.MaxLength = 9;
            this.hours_input.Name = "hours_input";
            this.hours_input.Size = new System.Drawing.Size(63, 22);
            this.hours_input.TabIndex = 1;
            // 
            // hours_label
            // 
            this.hours_label.AutoSize = true;
            this.hours_label.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hours_label.Location = new System.Drawing.Point(13, 64);
            this.hours_label.Name = "hours_label";
            this.hours_label.Size = new System.Drawing.Size(37, 13);
            this.hours_label.TabIndex = 3;
            this.hours_label.Text = "hours";
            // 
            // seconds_input
            // 
            this.seconds_input.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.seconds_input.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seconds_input.Location = new System.Drawing.Point(245, 41);
            this.seconds_input.MaxLength = 2;
            this.seconds_input.Name = "seconds_input";
            this.seconds_input.Size = new System.Drawing.Size(63, 22);
            this.seconds_input.TabIndex = 3;
            this.seconds_input.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // seconds_label
            // 
            this.seconds_label.AutoSize = true;
            this.seconds_label.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seconds_label.Location = new System.Drawing.Point(259, 64);
            this.seconds_label.Name = "seconds_label";
            this.seconds_label.Size = new System.Drawing.Size(49, 13);
            this.seconds_label.TabIndex = 5;
            this.seconds_label.Text = "seconds";
            // 
            // minutes_input
            // 
            this.minutes_input.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minutes_input.Location = new System.Drawing.Point(131, 41);
            this.minutes_input.MaxLength = 2;
            this.minutes_input.Name = "minutes_input";
            this.minutes_input.Size = new System.Drawing.Size(63, 22);
            this.minutes_input.TabIndex = 2;
            this.minutes_input.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(131, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "minutes";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // time_label
            // 
            this.time_label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.time_label.BackColor = System.Drawing.Color.Transparent;
            this.time_label.Location = new System.Drawing.Point(12, 129);
            this.time_label.Name = "time_label";
            this.time_label.Size = new System.Drawing.Size(134, 13);
            this.time_label.TabIndex = 0;
            this.time_label.Visible = false;
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(12, 103);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(296, 23);
            this.progressBar.TabIndex = 0;
            this.progressBar.Visible = false;
            // 
            // elapsed
            // 
            this.elapsed.BackColor = System.Drawing.Color.Transparent;
            this.elapsed.Location = new System.Drawing.Point(163, 129);
            this.elapsed.Name = "elapsed";
            this.elapsed.Size = new System.Drawing.Size(145, 13);
            this.elapsed.TabIndex = 0;
            this.elapsed.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.elapsed.Visible = false;
            // 
            // elapsed_progress
            // 
            this.elapsed_progress.Location = new System.Drawing.Point(12, 145);
            this.elapsed_progress.Name = "elapsed_progress";
            this.elapsed_progress.Size = new System.Drawing.Size(296, 23);
            this.elapsed_progress.TabIndex = 0;
            this.elapsed_progress.Visible = false;
            // 
            // timer2
            // 
            this.timer2.Interval = 5000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // pause
            // 
            this.pause.Location = new System.Drawing.Point(12, 175);
            this.pause.Name = "pause";
            this.pause.Size = new System.Drawing.Size(296, 23);
            this.pause.TabIndex = 8;
            this.pause.Text = "Pause the countdown";
            this.pause.UseVisualStyleBackColor = true;
            this.pause.Visible = false;
            this.pause.Click += new System.EventHandler(this.pause_Click);
            // 
            // Countdown
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(320, 206);
            this.Controls.Add(this.elapsed_progress);
            this.Controls.Add(this.pause);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.minutes_input);
            this.Controls.Add(this.seconds_label);
            this.Controls.Add(this.seconds_input);
            this.Controls.Add(this.hours_label);
            this.Controls.Add(this.hours_input);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.time_label);
            this.Controls.Add(this.elapsed);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "Countdown";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Countdown";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox hours_input;
        private System.Windows.Forms.Label hours_label;
        private System.Windows.Forms.TextBox seconds_input;
        private System.Windows.Forms.Label seconds_label;
        private System.Windows.Forms.TextBox minutes_input;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label time_label;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label elapsed;
        private System.Windows.Forms.ProgressBar elapsed_progress;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Button pause;
    }
}

