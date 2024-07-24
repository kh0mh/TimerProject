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
    //الكود سباغيتي , الي فيه حيل يعدله 
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }


        int seconds = 0, minutes = 0, MilleSeconds = 0, Hours = 0;
       
        bool BreakTime = false, Check = true;

        //int seconds2 = 0, minutes2 = 0, MilleSeconds2 = 0;
        short LabCount = 0;
        DateTime dateTime = DateTime.Now;
        int  ClockSeconds = 0, ClockMinuts = 0, ClockHors = 0;
     
        string ampm;

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
                seconds = 0;
                minutes = 0;
                Hours = 0;
                MilleSeconds = 0;
                labStudyTimer.Text = $"{Hours:00}:{minutes:00}:{seconds:00}.{MilleSeconds:00}";
                gunaLabReset.Text = "Lab";
                gunaLabReset.Enabled = false;
                LabCount = 0;
                lstBoxData.Items.Clear();
            }
            
            else if (gunaLabReset.Text == "Lab")
            {
                LabCount++;
                // lstBoxData.Items.Add("Lab\t\t" + LabCount);
                lstBoxData.Items.Add("Lab " + LabCount + "              \t\t\t" + $"{minutes:00}:{seconds:00}.{MilleSeconds:00}");
                                     
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        

        void Clock()
        {
            

            if(Check)
            {
                ClockHors = dateTime.Hour % 12 ;
                ClockMinuts = dateTime.Minute;
                ClockSeconds = dateTime.Second - 1;

                ampm = dateTime.Hour < 12 ? "AM" : "PM";
                Check = false;
            }

            ClockSeconds++;


            if (ClockSeconds == 60)
            {
                ClockMinuts++;
                ClockSeconds = 0;

                if(ClockMinuts == 59)
                {
                    ClockHors++;
                    ClockMinuts = 0;
                }

            }



            
            this.Text = $"{ClockHors:00}:{ClockMinuts:00}:{ClockSeconds:00} {ampm}";

        }

        //void SetBreakDuration(RadioButton radio)
        //{
        //    if(radio.Checked)
        //    {
        //        BreakDuration = Convert.ToInt32(radio.Tag);
        //    }
        //    else
        //    {
        //        BreakDuration = Convert.ToInt32(maskedTextBox1.Text);
        //    }
        //}


    
        //int BreakDuration = 1;
        void ShowTimer()
        {
            if (BreakTime == false)
            {

                MilleSeconds++;

                if (MilleSeconds == 99)
                {
                    MilleSeconds = 0;
                    seconds++;
                }

                if (seconds == 60)
                {
                    seconds = 0;
                    minutes++;

                }

                if (minutes == 60)
                {
                    minutes = 0;
                    Hours++;
                }

                labStudyTimer.Text = $"{Hours:00}:{minutes:00}:{seconds:00}.{MilleSeconds:00}";

            }

        }
      
    }
}
