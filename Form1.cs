using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Taimer
{
    //الكود إندومي , الي فيه حيل يعدله    
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        struct TimerSMH
        {
            public int Seconds;
            public int Minutes;
            public int MilliSeconds;
            public int Hours;
            public int ClockSeconds;
            public int ClockMinutes ;
            public int ClockHours;
            public int LabCount;
            public string AM_PM;

        }

        TimerSMH timerSMH;
        bool BreakTime = false, Check = true;
        DateTime dateTime = DateTime.Now;
              
        private void timer2_Tick(object sender, EventArgs e)
        {
            Clock();
        }
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            ShowTimer();
        }
        
        private void gunaStartStop_Click(object sender, EventArgs e)
        {
           
            if (timer1.Enabled)
            {
                timer1.Stop();
                gunaLabReset.Text = "Reset";
                gunaStartStop.Text = "Start";
            }
            else
            {
                timer1.Enabled = true;
                gunaLabReset.Text = "Lab";
                gunaLabReset.Enabled = true;
                gunaStartStop.Text = "Stop";
            }
        }
        
        private void gunaLabReset_Click(object sender, EventArgs e)
        {
            
            if (gunaLabReset.Text == "Reset")
            {
                timerSMH.Seconds = 0;
                timerSMH.Minutes = 0;
                timerSMH.Hours = 0;
                timerSMH.MilliSeconds = 0;
                labStudyTimer.Text = $"{timerSMH.Hours:00}:{timerSMH.Minutes:00}:{timerSMH.Seconds:00}.{timerSMH.MilliSeconds:00}";
                gunaLabReset.Text = "Lab";
                gunaLabReset.Enabled = false;
                timerSMH.LabCount = 0;
                lstBoxData.Items.Clear();
            }
            
            else if (gunaLabReset.Text == "Lab")
            {
                timerSMH.LabCount++;
                // lstBoxData.Items.Add("Lab\t\t" + timerSMH.LabCount);
                lstBoxData.Items.Add("Lab " + timerSMH.LabCount + "              \t\t\t" + $"{timerSMH.Minutes:00}:{timerSMH.Seconds:00}.{timerSMH.MilliSeconds:00}");
            }
        }
        
        void Clock()
        {
            if(Check)
            {
                timerSMH.ClockHours = dateTime.Hour % 12 ;
                timerSMH.ClockMinutes = dateTime.Minute;
                timerSMH.ClockSeconds = dateTime.Second - 1;

                timerSMH.AM_PM = dateTime.Hour < 12 ? "AM" : "PM";
                Check = false;
            }

            timerSMH.ClockSeconds++;

            if (timerSMH.ClockSeconds == 60)
            {
                timerSMH.ClockMinutes++;
                timerSMH.ClockSeconds = 0;

                if(timerSMH.ClockMinutes == 59)
                {
                    timerSMH.ClockHours++;
                    timerSMH.ClockMinutes = 0;
                }

            }

            this.Text = $"{timerSMH.ClockHours:00}:{timerSMH.ClockMinutes:00}:{timerSMH.ClockSeconds:00} {timerSMH.AM_PM}";
        }
        
        void ShowTimer()
        {
            if (BreakTime == false)
            {
                timerSMH.MilliSeconds++;

                if (timerSMH.MilliSeconds == 99)
                {
                    timerSMH.MilliSeconds = 0;
                    timerSMH.Seconds++;
                }
                if (timerSMH.Seconds == 60)
                {
                    timerSMH.Seconds = 0;
                    timerSMH.Minutes++;
                }
                if (timerSMH.Minutes == 60)
                {
                    timerSMH.Minutes = 0;
                    timerSMH.Hours++;
                }
                labStudyTimer.Text = $"{timerSMH.Hours:00}:{timerSMH.Minutes:00}:{timerSMH.Seconds:00}.{timerSMH.MilliSeconds:00}";

            }

        }
      
    }
}
