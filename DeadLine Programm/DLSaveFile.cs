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
            return Time + " " + Name;
        }
    }

    public class ListDL
    {
        List<DLSaveFile> listDL = new List<DLSaveFile>();


        public void Add(DLSaveFile m)
        {
            listDL.Add(m);
        }

        public void ViewToListBox(ListBox l)
        {
            foreach (var v in listDL)
                l.Items.Add(v);
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
            MessageBox.Show(mdJson);
            using (StreamWriter sw = new StreamWriter("listDL.json"))
                sw.WriteLine(mdJson);
        }
    }
}
