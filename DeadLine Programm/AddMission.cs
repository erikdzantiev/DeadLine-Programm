using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeadLine_Programm
{
    public partial class FormAddEvent : Form
    {
        DateTime date = new DateTime();

        public FormAddEvent()
        {
            InitializeComponent();
        }

        private void AddEvent_Load(object sender, EventArgs e)
        {
            //Добавление элементов в комбобоксы
            comboBoxHours.Items.AddRange(new string[] { "00", "01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23" });
           
            comboBoxMinutes.Items.AddRange(new string[] { "00", "01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24","25",
                "26", "27", "28", "29", "30", "31", "32", "33", "34", "35", "36", "37", "38", "39", "40","41", "42", "43", "44", "45", "46", "47", "48", "49", "50", "51", "52", "53", "54", "55", "56","57","58","59",});
        }

        private void dateTimePickerDate_ValueChanged(object sender, EventArgs e)
        {
            date = dateTimePickerDate.Value.Date;
            textBoxDate.Text = date.ToShortDateString();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            ValueClass.Date = textBoxDate.Text;
            ValueClass.Hours = comboBoxHours.Text;
            ValueClass.Minutes = comboBoxMinutes.Text;
            Close();

            //SerializeDeserialize.SerializeObject(frm.Hours, "Hours.xml");
            //SerializeDeserialize.SerializeObject(frm.Minutes, "Minutes.xml");
            //SerializeDeserialize.SerializeObject(frm.Dates, "Dates.xml");
            //SerializeDeserialize.SerializeObject(frm.Names, "Names.xml");
            //SerializeDeserialize.SerializeObject(frm.DeadlineNames, "DeadlineNames.xml");
        }
    }
}
