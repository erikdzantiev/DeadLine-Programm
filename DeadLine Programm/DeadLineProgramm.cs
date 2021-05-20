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

namespace DeadLine_Programm
{
    public partial class FormDeadLines : Form
    {


        ////Переменная для хранения добавляемой даты
        //DateTime datetime;

        ////Переменная для передачи даты в компонент textBoxDateEdit
        //DateTime date = new DateTime();

        ////Список хранения Часов этапов Дедлайна
        //public List<string> Hours = new List<string>();

        ////Список хранения Минут этапов Дедлайна
        //public List<string> Minutes = new List<string>();

        ////Список хранения Дат этапов Дедлайна
        //public List<string> Dates = new List<string>();

        ////Список хранения Названий Дедлайна
        //public List<string> Names = new List<string>();

        ////Список хранения описаний Дедлайнов
        //public List<string> Purpose = new List<string>();


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

        private void buttonCloseProgramm_Click(object sender, EventArgs e)
        {


           
        }

        private void buttonDay_Click(object sender, EventArgs e)
        {
           
        }

        private void buttonTomorrow_Click(object sender, EventArgs e)
        {

        }

        private void buttonWeek_Click(object sender, EventArgs e)
        { 
          //FormAddEvent.lst 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormAddEvent.lst.LoadFromFile();
            FormAddEvent.lst.ViewToListBox(listBoxShowDeadline);
        }
    }
}
