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
        
        public string Description { get; set; }

        public DLSaveFile(DateTime time, string name, string description)
        {
            Time = time;
            Name = name;
            Description = description;
        }

        public override string ToString()
        {
            return Name + " " + Time + " : " + Description;
        }
    }

    public class ListDL
    {
        List<DLSaveFile> listDL = new List<DLSaveFile>();

        public void Tomorrow(ListBox l)
        {
            try
            {
                using (StreamReader sr = new StreamReader("listDL.json"))
                {
                    listDL = JsonConvert.DeserializeObject<List<DLSaveFile>>(sr.ReadToEnd());
                }


                if (listDL.Count == 0) MessageBox.Show("Сначала добавьте дату");
                else
                {
                    int n = 0;
                    foreach (var el in listDL)
                    {
                        if ((el.Time - DateTime.Today).Days > 0 && (el.Time - DateTime.Today).Days <2)
                        { 
                            n++;
                            l.Items.Add(n + ") " + el);
                        }
                    }
                }
            }
            catch { MessageBox.Show("сначала добавьте дату!"); }

        }

        public void Today(ListBox l)
        {
            try
            {
                using (StreamReader sr = new StreamReader("listDL.json"))
                {
                    listDL = JsonConvert.DeserializeObject<List<DLSaveFile>>(sr.ReadToEnd());
                }


                if (listDL.Count == 0) MessageBox.Show("Сначала добавьте дату");
                int n = 0;
                foreach (var el in listDL)
                {
                    if ((el.Time - DateTime.Today).Days == 0)
                    {
                        n++;
                        l.Items.Add(n + ") " + el);
                    }
                }
            }
            catch { MessageBox.Show("сначала добавьте дату!"); }

        }

        public void Week(ListBox l)
        {
            try
            {
                using (StreamReader sr = new StreamReader("listDL.json"))
                {
                    listDL = JsonConvert.DeserializeObject<List<DLSaveFile>>(sr.ReadToEnd());
                }


                if (listDL.Count == 0) MessageBox.Show("Сначала добавьте дату");
                int n = 0;
                foreach (var el in listDL)
                {
                    if ((el.Time - DateTime.Today).Days <= 7)
                    {
                        n++;
                        l.Items.Add(n + ") " + el);
                    }
                }
            }
            catch { MessageBox.Show("сначала добавьте дату!"); }


        }


        public void OtherTime(ListBox l)
        {
            try
            {
                using (StreamReader sr = new StreamReader("listDL.json"))
                {
                    listDL = JsonConvert.DeserializeObject<List<DLSaveFile>>(sr.ReadToEnd());
                }


                if (listDL.Count == 0) MessageBox.Show("Сначала добавьте дату");
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
            catch { MessageBox.Show("сначала добавьте дату!"); }

        }
    

        public void AllTime(ListBox l)
        {
            try
            {
                using (StreamReader sr = new StreamReader("listDL.json"))
                {
                    listDL = JsonConvert.DeserializeObject<List<DLSaveFile>>(sr.ReadToEnd());
                }


                if (listDL.Count == 0) MessageBox.Show("Сначала добавьте дату");
                int n = 0;
                foreach (var el in listDL)
                {
                        n++;
                        l.Items.Add(n + ") " + el);
                }
            
            }
            catch { MessageBox.Show("Сначала добавьте дату"); }

        }

        public void Add(DLSaveFile m)
        {
            listDL.Add(m);
        }

        public void SaveToFile()
        {
            var mdJson = JsonConvert.SerializeObject(listDL);
            using (StreamWriter sw = new StreamWriter("listDL.json"))
                sw.WriteLine(mdJson);
        }
    }
}
