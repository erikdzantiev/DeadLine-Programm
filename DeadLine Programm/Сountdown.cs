using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace DeadLine_Programm
{
    public class Сountdown
    {
        public DateTime Time { get; set; }

        public static int[] SearchTime()
        {
            List<Сountdown> listDL = new List<Сountdown>();

            int xDay = 700000;
            int xHours = 69930097;
            int xMinutes = 1195890788;
            int xSeconds = 217425368;


            using (StreamReader sr = new StreamReader("listDL.json"))
            {
                listDL = JsonConvert.DeserializeObject<List<Сountdown>>(sr.ReadToEnd());
            }


            foreach (var el in listDL)
            {
                try
                {
                    int minDay = (el.Time - DateTime.Today).Days;
                    int minHours = (el.Time - DateTime.Today).Hours;
                    int minMinutes = (el.Time - DateTime.Today).Minutes;
                    int minSeconds = (el.Time - DateTime.Today).Seconds;
                    if (minDay < xDay)
                    {
                        xDay = minDay;
                        xHours = minHours;
                        xMinutes = minMinutes;
                        xSeconds = minSeconds;
                    }
                    if (minDay == xDay)
                    {
                        if (minHours < xHours)
                        {
                            xHours = minHours;
                            xMinutes = minMinutes;
                            xSeconds = minSeconds;
                        }
                    }
                    if (minDay == xDay)
                    {
                        if (minHours == xHours)
                        {
                            if (minMinutes < xMinutes)
                            {
                                xMinutes = minMinutes;
                                xSeconds = minSeconds;
                            }
                        }
                    }
                    if (minDay == xDay)
                    {
                        if (minHours == xHours)
                        {
                            if (minMinutes == xMinutes)
                            {
                                if (Convert.ToUInt32(minSeconds) < xSeconds)
                                {
                                    xSeconds = minSeconds;
                                }
                            }
                        }
                    }
                }
                catch { }
            }

            int[] countTime = new int[4];
            countTime[0] = xDay;
            countTime[1] = xHours;
            countTime[2] = xMinutes;
            countTime[3] = xSeconds;

            return countTime;
        }

    }
}
