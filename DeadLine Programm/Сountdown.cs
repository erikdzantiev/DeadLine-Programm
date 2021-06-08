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

        public string Name { get; set; }

        public static int[] SearchTime()
        {
            List<Сountdown> listDL = new List<Сountdown>();

            int[] countTime = new int[4];
            countTime[0] = 0;
            countTime[1] = 0;
            countTime[2] = 0;
            countTime[3] = 0;

            using (StreamReader sr = new StreamReader("listDL.json"))
            {
                listDL = JsonConvert.DeserializeObject<List<Сountdown>>(sr.ReadToEnd());
            }
            if (listDL.Count > 0)
            {
                TimeSpan minDiff = TimeSpan.MaxValue;


                foreach (var el in listDL)
                {
                    if (el.Time > DateTime.Today)
                        if (el.Time - DateTime.Today < minDiff)
                        {
                            minDiff = el.Time - DateTime.Today;
                        }

                }
                countTime[0] = Convert.ToInt32(minDiff.Days);
                countTime[1] = Convert.ToInt32(minDiff.Hours);
                countTime[2] = Convert.ToInt32(minDiff.Minutes);
                countTime[3] = Convert.ToInt32(minDiff.Seconds);
                return countTime;
            }
            else
            {
                MessageBox.Show("Сначала добавьте дедлайн!");
                return countTime;
            }
        }


            public static string SearchName()
            {
                List<Сountdown> listD = new List<Сountdown>();
                string nameMinDL = "";


                using (StreamReader sr = new StreamReader("listDL.json"))
                {
                    listD = JsonConvert.DeserializeObject<List<Сountdown>>(sr.ReadToEnd());
                }
                if (listD.Count > 0)
                {
                    TimeSpan minDiff = TimeSpan.MaxValue;

                    foreach (var el in listD)
                    {
                        if (el.Time > DateTime.Today)
                            if (el.Time - DateTime.Today < minDiff)
                            {
                                minDiff = el.Time - DateTime.Today;
                                nameMinDL = el.Name;
                            }

                    }
                    return nameMinDL;
                }
                else
                {
                    MessageBox.Show("Сначала добавьте дедлайн!");
                    return nameMinDL;
                }

            }
        

    }
}
