﻿using System;
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
            using (StreamReader sr = new StreamReader("listDL.json"))
            {
                listDL = JsonConvert.DeserializeObject<List<DLSaveFile>>(sr.ReadToEnd());
            }

            if (listDL.Count > 0)
            {
                int n = 0;
                foreach (var el in listDL)
                {
                    n++;
                    l.Items.Add(n + ") " + el);
                }
            }
            else MessageBox.Show("сначала добавьте дату!");

        }

        public void Today(ListBox l)
        {
            using (StreamReader sr = new StreamReader("listDL.json"))
            {
                listDL = JsonConvert.DeserializeObject<List<DLSaveFile>>(sr.ReadToEnd());
            }

            if (listDL.Count > 0)
            {
                int n = 0;
                foreach (var el in listDL)
                {
                    n++;
                    l.Items.Add(n + ") " + el);
                }
            }
            else MessageBox.Show("сначала добавьте дату!");

        }

        public void Week(ListBox l)
        {
            using (StreamReader sr = new StreamReader("listDL.json"))
            {
                listDL = JsonConvert.DeserializeObject<List<DLSaveFile>>(sr.ReadToEnd());
            }

            if (listDL.Count > 0)
            {
                int n = 0;
                foreach (var el in listDL)
                {
                    n++;
                    l.Items.Add(n + ") " + el);
                }
            }
            else MessageBox.Show("сначала добавьте дату!");

        }


        public void OtherTime(ListBox l)
        {
            using (StreamReader sr = new StreamReader("listDL.json"))
            {
                listDL = JsonConvert.DeserializeObject<List<DLSaveFile>>(sr.ReadToEnd());
            }

            if (listDL.Count > 0)
            {
                int n = 0;
                foreach (var el in listDL)
                {
                    n++;
                    l.Items.Add(n + ") " + el);
                }
            }
            else MessageBox.Show("сначала добавьте дату!");

        }


        public void Add(DLSaveFile m)
        {
            listDL.Add(m);
        }

        public void ViewToListBox(ListBox l)
        {
            using (StreamReader sr = new StreamReader("listDL.json"))
            {
                    listDL = JsonConvert.DeserializeObject<List<DLSaveFile>>(sr.ReadToEnd());
            }

            if (listDL.Count > 0)
            {
                int n = 0;
                foreach (var el in listDL)
                {
                    n++;
                    l.Items.Add(n + ") " + el);
                }
            }
            else MessageBox.Show("сначала добавьте дату!");
            
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
