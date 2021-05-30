using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace DeadLine_Programm
{
    public class DLSaveFile
    {
        public DateTime Time { get; set; }
        public string Name { get; set; }   

        public DLSaveFile(DateTime time, string name)
        {
            Time = time;
            Name = name;
        }

        public override string ToString()
        {
            return Name + " " + Time;
        }
    }

    public class ListDL
    {
        List<DLSaveFile> listDL = new List<DLSaveFile>();

        public void Tomorrow(ListBox l)
        {
            using (StreamReader sr = new StreamReader("listDL.json"))
            {
                listDL = JsonConvert.DeserializeObject<List<DLSaveFile>>(sr.ReadToEnd());
            }

            int n = 0;
            foreach (var el in listDL)
            {
                if ((el.Time - DateTime.Today).Days == 1)
                {
                    n++;
                    l.Items.Add(n + ") " + el);
                }
            }
        }

        public void Today(ListBox l)
        {
            using (StreamReader sr = new StreamReader("listDL.json"))
            {
                listDL = JsonConvert.DeserializeObject<List<DLSaveFile>>(sr.ReadToEnd());
            }
            int n = 0;
            foreach (var el in listDL)
            {
                if ((el.Time - DateTime.Today).Days < 1)
                {
                    n++;
                    l.Items.Add(n + ") " + el);
                }
            }
        }

        public void Week(ListBox l)
        {
            using (StreamReader sr = new StreamReader("listDL.json"))
            {
                listDL = JsonConvert.DeserializeObject<List<DLSaveFile>>(sr.ReadToEnd());
            }

            int n = 0;
            foreach (var el in listDL)
            {
                if ((el.Time - DateTime.Today).Days <= 7 && (el.Time - DateTime.Today).Days > 1)
                {
                    n++;
                    l.Items.Add(n + ") " + el);
                }
            }
        }


        public void OtherTime(ListBox l)
        {
            using (StreamReader sr = new StreamReader("listDL.json"))
            {
                listDL = JsonConvert.DeserializeObject<List<DLSaveFile>>(sr.ReadToEnd());
            }

            int n = 0;
            foreach (var el in listDL)
            {
                if ((el.Time - DateTime.Today).Days > 7)
                {
                    n++;
                    l.Items.Add(n + ") " + el);
                }
            }
        }


        public void Add(DLSaveFile m)
        {
            listDL.Add(m);
        }

        public void ViewToListBox(ListBox l)
        {
            int n = 0;
            foreach (var el in listDL)
            {
                n++;
                l.Items.Add(n + ") " + el);
            }
        }

        public void LoadFromFile()
        {
            using (StreamReader sr = new StreamReader("listDL.json"))
            {
                listDL = JsonConvert.DeserializeObject<List<DLSaveFile>>(sr.ReadToEnd());
            }
        }
        public void SaveToFile()
        {
            var mdJson = JsonConvert.SerializeObject(listDL);
           // MessageBox.Show(mdJson);
            using (StreamWriter sw = new StreamWriter("listDL.json"))
                sw.WriteLine(mdJson);
        }
    }
}
