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
        public static ListDL lst = new ListDL();

        public FormAddEvent()
        {
            InitializeComponent();
        }

        private void AddEvent_Load(object sender, EventArgs e)
        {
           
        }

        private void dateTimePickerDate_ValueChanged(object sender, EventArgs e)
        {
             
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            DateTime dt = dateTimePickerDate.Value.Date +
                    dateTimePickerTime.Value.TimeOfDay;
            DLSaveFile m = new DLSaveFile(dt, textBoxNameDL.Text);
            lst.Add(m);
            lst.SaveToFile();
            
            Close();

        }
    }
}
