using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassSchedulingComputerAided
{
    public partial class CSD_ProfTimeTable : UserControl
    {
        public CSD_ProfTimeTable()
        {
            InitializeComponent();
        }

        MyDatabase md = new MyDatabase();
        public Label lblSched = new Label();
        public int callDay = 0;
        public int callStart = 0;
        public int callShade = 0;
        public string dayPrompt = "";
        public string startTimePrompt = "";
        public string endTimePrompt = "";
        public string[] GetEndTime = new string[] 
            {"7:00 AM",
            "7:30 AM",
            "8:00 AM",
            "8:30 AM",
            "9:00 AM",
            "9:30 AM",
            "10:00 AM",
            "10:30 AM",
            "11:00 AM",
            "11:30 AM",
            "12:00 PM",
            "12:30 PM",
            "1:00 PM",
            "1:30 PM",
            "2:00 PM",
            "2:30 PM",
            "3:00 PM",
            "3:30 PM",
            "4:00 PM",
            "4:30 PM",
            "5:00 PM",
            "5:30 PM",
            "6:00 PM",
            "6:30 PM",
            "7:00 PM",
            "7:30 PM",
            "8:00 PM",
            "8:30 PM",
            "9:00 PM"};

        //dynamic control
        public System.Windows.Forms.Label AddLabel()
        {
            System.Windows.Forms.Label lbl = new System.Windows.Forms.Label();
            pnlTimeTable.Controls.Add(lbl);
            lbl.Text = "" + dayPrompt + "\r\n" + startTimePrompt + " to " + endTimePrompt + "";
            lbl.Location = new System.Drawing.Point(callDay, callStart);
            lbl.Size = new System.Drawing.Size(79, callShade);
            lbl.BackColor = System.Drawing.Color.YellowGreen;
            lbl.TextAlign = ContentAlignment.MiddleCenter;
            return lbl;
        }

        //to get the start time
        public int GetStartTime(string startTime)
        {
            int startPoint = 0;
            switch (startTime)
            {
                case "7:00 AM":
                    startPoint = 1;
                    break;
                case "7:30 AM":
                    startPoint = 19;
                    break;
                case "8:00 AM":
                    startPoint = 37;
                    break;
                case "8:30 AM":
                    startPoint = 55;
                    break;
                case "9:00 AM":
                    startPoint = 73;
                    break;
                case "9:30 AM":
                    startPoint = 91;
                    break;
                case "10:00 AM":
                    startPoint = 109;
                    break;
                case "10:30 AM":
                    startPoint = 127;
                    break;
                case "11:00 AM":
                    startPoint = 145;
                    break;
                case "11:30 AM":
                    startPoint = 163;
                    break;
                case "12:00 PM":
                    startPoint = 181;
                    break;
                case "12:30 PM":
                    startPoint = 199;
                    break;
                case "1:00 PM":
                    startPoint = 217;
                    break;
                case "1:30 PM":
                    startPoint = 235;
                    break;
                case "2:00 PM":
                    startPoint = 253;
                    break;
                case "2:30 PM":
                    startPoint = 271;
                    break;
                case "3:00 PM":
                    startPoint = 289;
                    break;
                case "3:30 PM":
                    startPoint = 307;
                    break;
                case "4:00 PM":
                    startPoint = 325;
                    break;
                case "4:30 PM":
                    startPoint = 343;
                    break;
                case "5:00 PM":
                    startPoint = 361;
                    break;
                case "5:30 PM":
                    startPoint = 379;
                    break;
                case "6:00 PM":
                    startPoint = 397;
                    break;
                case "6:30 PM":
                    startPoint = 415;
                    break;
                case "7:00 PM":
                    startPoint = 433;
                    break;
                case "7:30 PM":
                    startPoint = 451;
                    break;
                case "8:00 PM":
                    startPoint = 469;
                    break;
                case "8:30 PM":
                    startPoint = 487;
                    break;
                case "9:00 PM":
                    startPoint = 505;
                    break;
                default:
                    break;
            }
            return startPoint;
        }

        //to get the Day
        public int GetDay(string day)
        {
            int pointDay = 0;
            switch (day)
            {
                case "Monday":
                    pointDay = 4;
                    break;
                case "Tuesday":
                    pointDay = 86;
                    break;
                case "Wednesday":
                    pointDay = 168;
                    break;
                case "Thursday":
                    pointDay = 250;
                    break;
                case "Friday":
                    pointDay = 332;
                    break;
                case "Saturday":
                    pointDay = 414;
                    break;
                case "Sunday":
                    pointDay = 496;
                    break;
                default:
                    break;
            }
            return pointDay;
        }

        private void CSD_ProfTimeTable_Load(object sender, EventArgs e)
        {
            for (int x = 0; x < md.Get_id_PSchedule(usersData.p_id).Length; x++)
            {
                string ps_id = md.Get_id_PSchedule(usersData.p_id).GetValue(x).ToString();
                if (ps_id != "")
                {
                    int day = GetDay(md.Get_info_PSchedule(ps_id).GetValue(2).ToString());
                    int st = GetStartTime(md.Get_info_PSchedule(ps_id).GetValue(0).ToString());

                    string ps_startTime = md.Get_info_PSchedule(ps_id).GetValue(0).ToString();
                    string ps_endTime = md.Get_info_PSchedule(ps_id).GetValue(1).ToString();
                    int shade = 0;
                    int startShade = 0;

                    for (int y = 0; y < GetEndTime.Length; y++)
                    {
                        if (ps_startTime == GetEndTime[y])
                        {
                            startShade = y;
                            y = GetEndTime.Length;
                        }
                    }

                    int c = 0;
                    for (int z = startShade; z < GetEndTime.Length; z++)
                    {
                        c++;
                        if (ps_endTime == GetEndTime[z])
                        {
                            shade += 18 * c;
                        }
                    }
                    callDay = day;
                    callStart = st;
                    callShade = shade;
                    dayPrompt = md.Get_info_PSchedule(ps_id).GetValue(2).ToString();
                    startTimePrompt = md.Get_info_PSchedule(ps_id).GetValue(0).ToString();
                    endTimePrompt = md.Get_info_PSchedule(ps_id).GetValue(1).ToString();
                    AddLabel();
                }
            }
        }
    }
}
