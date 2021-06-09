using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Threading;

namespace DeadLine_Programm
{
    public partial class FormDeadLines : Form
    {


        public FormDeadLines()
        {
            InitializeComponent();
            
        }

        private void DeadLines_Load(object sender, EventArgs e)
        {

        }

       private FormAddEvent fam;
        private void buttonAddEvent_Click(object sender, EventArgs e)
        {
            fam = new FormAddEvent();
            fam.ShowDialog();
        }


        private void buttonDay_Click(object sender, EventArgs e)
        {
            listBoxShowDeadline.Items.Clear();
            FormAddEvent.lst.Today(listBoxShowDeadline);
        }

        private void buttonTomorrow_Click(object sender, EventArgs e)
        {
            listBoxShowDeadline.Items.Clear();
            FormAddEvent.lst.Tomorrow(listBoxShowDeadline);
        }

        private void buttonWeek_Click(object sender, EventArgs e)
        {
            listBoxShowDeadline.Items.Clear();
            FormAddEvent.lst.Week(listBoxShowDeadline);
        }

        private void buttonOtherTime_Click(object sender, EventArgs e)
        {
            listBoxShowDeadline.Items.Clear();
            FormAddEvent.lst.OtherTime(listBoxShowDeadline);
        }

        private void buttonAll_Click(object sender, EventArgs e)
        {
            
                listBoxShowDeadline.Items.Clear();
                FormAddEvent.lst.ViewToListBox(listBoxShowDeadline);
           
        }
        
        TimeSpan ts = new TimeSpan();
        
        public void Coutndown()
        {
            int[] countTime = new int[4];
            countTime = Сountdown.SearchTime();
            string nameMin = Сountdown.SearchName();
            ts = new TimeSpan(countTime[0], countTime[1], countTime[2], countTime[3]);
            labelTime.Text = nameMin + ": " + ts.ToString();
        }

        private void buttonCountdown_Click(object sender, EventArgs e)
        {
            int[] countTime = new int[4];
            countTime = Сountdown.SearchTime();
            string nameMin = Сountdown.SearchName();
            ts = new TimeSpan(countTime[0], countTime[1], countTime[2], countTime[3]);
            labelTime.Text = nameMin + ": " + ts.ToString();
        }
    }
}
