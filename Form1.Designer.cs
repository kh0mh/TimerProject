
namespace Taimer
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.labStudyTimer = new System.Windows.Forms.Label();
            this.lstBoxData = new System.Windows.Forms.ListBox();
            this.labBreakTimer = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.gunaLabReset = new Guna.UI2.WinForms.Guna2CircleButton();
            this.gunaStartStop = new Guna.UI2.WinForms.Guna2CircleButton();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // labStudyTimer
            // 
            this.labStudyTimer.Font = new System.Drawing.Font("Tahoma", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labStudyTimer.ForeColor = System.Drawing.Color.White;
            this.labStudyTimer.Location = new System.Drawing.Point(20, 23);
            this.labStudyTimer.Name = "labStudyTimer";
            this.labStudyTimer.Size = new System.Drawing.Size(324, 112);
            this.labStudyTimer.TabIndex = 7;
            this.labStudyTimer.Text = "00:00:00.00";
            this.labStudyTimer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lstBoxData
            // 
            this.lstBoxData.BackColor = System.Drawing.Color.Black;
            this.lstBoxData.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lstBoxData.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstBoxData.ForeColor = System.Drawing.Color.White;
            this.lstBoxData.FormattingEnabled = true;
            this.lstBoxData.ItemHeight = 19;
            this.lstBoxData.Location = new System.Drawing.Point(0, 275);
            this.lstBoxData.Name = "lstBoxData";
            this.lstBoxData.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstBoxData.Size = new System.Drawing.Size(368, 175);
            this.lstBoxData.TabIndex = 0;
            // 
            // labBreakTimer
            // 
            this.labBreakTimer.BackColor = System.Drawing.Color.Black;
            this.labBreakTimer.Font = new System.Drawing.Font("Tahoma", 26F);
            this.labBreakTimer.ForeColor = System.Drawing.Color.Black;
            this.labBreakTimer.Location = new System.Drawing.Point(308, 9);
            this.labBreakTimer.Name = "labBreakTimer";
            this.labBreakTimer.Size = new System.Drawing.Size(54, 62);
            this.labBreakTimer.TabIndex = 0;
            this.labBreakTimer.Text = "00:00:00.00";
            this.labBreakTimer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labBreakTimer.Visible = false;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.Font = new System.Drawing.Font("Verdana", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(309, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 59);
            this.label3.TabIndex = 10;
            this.label3.Text = "Break time : ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label3.Visible = false;
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // gunaLabReset
            // 
            this.gunaLabReset.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.gunaLabReset.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.gunaLabReset.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.gunaLabReset.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.gunaLabReset.Enabled = false;
            this.gunaLabReset.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.gunaLabReset.Font = new System.Drawing.Font("Segoe UI Semibold", 16.25F, System.Drawing.FontStyle.Bold);
            this.gunaLabReset.ForeColor = System.Drawing.Color.White;
            this.gunaLabReset.Location = new System.Drawing.Point(254, 153);
            this.gunaLabReset.Name = "gunaLabReset";
            this.gunaLabReset.PressedColor = System.Drawing.Color.White;
            this.gunaLabReset.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.gunaLabReset.Size = new System.Drawing.Size(90, 90);
            this.gunaLabReset.TabIndex = 11;
            this.gunaLabReset.Text = "Lab";
            this.gunaLabReset.Click += new System.EventHandler(this.gunaLabReset_Click);
            // 
            // gunaStartStop
            // 
            this.gunaStartStop.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.gunaStartStop.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.gunaStartStop.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.gunaStartStop.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.gunaStartStop.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.gunaStartStop.Font = new System.Drawing.Font("Segoe UI Semibold", 16.25F, System.Drawing.FontStyle.Bold);
            this.gunaStartStop.ForeColor = System.Drawing.Color.White;
            this.gunaStartStop.Location = new System.Drawing.Point(28, 153);
            this.gunaStartStop.Name = "gunaStartStop";
            this.gunaStartStop.PressedColor = System.Drawing.Color.White;
            this.gunaStartStop.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.gunaStartStop.Size = new System.Drawing.Size(90, 90);
            this.gunaStartStop.TabIndex = 12;
            this.gunaStartStop.Text = "Start";
            this.gunaStartStop.Click += new System.EventHandler(this.gunaStartStop_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(368, 450);
            this.Controls.Add(this.gunaStartStop);
            this.Controls.Add(this.gunaLabReset);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labBreakTimer);
            this.Controls.Add(this.lstBoxData);
            this.Controls.Add(this.labStudyTimer);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label labStudyTimer;
        private System.Windows.Forms.ListBox lstBoxData;
        private System.Windows.Forms.Label labBreakTimer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer timer2;
        private Guna.UI2.WinForms.Guna2CircleButton gunaLabReset;
        private Guna.UI2.WinForms.Guna2CircleButton gunaStartStop;
    }
}

