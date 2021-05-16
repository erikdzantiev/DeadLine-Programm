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

            try
            {
                //Проверка на ввод
                if (fam.textBoxNameDL.Text != "" && fam.textBoxDate.Text != "" && fam.comboBoxHours.Text != "" && fam.comboBoxMinutes.Text != "")
                {
                    ListClass.Names.Add(ValueClass.Name);// Добавление названия Дедлайна
                    ListClass.Dates.Add(ValueClass.Date);//Добавление даты в список Дат
                    ListClass.Hours.Add(ValueClass.Hours);//Добавление часов в список Часов
                    ListClass.Minutes.Add(ValueClass.Minutes);//Добавление минут в список Минут
                }
            }
            //catch при вводе неправильной даты
            catch
            {
                MessageBox.Show("Введите дату правильно!");
                fam.Close();
            }
        }

        private void buttonCloseProgramm_Click(object sender, EventArgs e)
        {
            //Очистка файлов перед сериализацией 
            StreamWriter Writer1 = new StreamWriter("Hours.xml", false, Encoding.UTF8);
            Writer1.WriteLine("");
            Writer1.Close();
            StreamWriter Writer2 = new StreamWriter("Minutes.xml", false, Encoding.UTF8);
            Writer2.WriteLine("");
            Writer2.Close();
            StreamWriter Writer3 = new StreamWriter("Dates.xml", false, Encoding.UTF8);
            Writer3.WriteLine("");
            Writer3.Close();
            StreamWriter Writer4 = new StreamWriter("Names.xml", false, Encoding.UTF8);
            Writer4.WriteLine("");
            Writer4.Close();
            StreamWriter Writer5 = new StreamWriter("DeadlineNames.xml", false, Encoding.UTF8);
            Writer5.WriteLine("");
            Writer5.Close();
            //Сериализация
            SerializeAndDeserialize.SerializeObject(ListClass.Hours, "Hours.xml");
            SerializeAndDeserialize.SerializeObject(ListClass.Minutes, "Minutes.xml");
            SerializeAndDeserialize.SerializeObject(ListClass.Dates, "Dates.xml");
            SerializeAndDeserialize.SerializeObject(ListClass.Names, "Names.xml");
            SerializeAndDeserialize.SerializeObject(ListClass.Purpose, "DeadlineNames.xml");
            Application.Exit();//Закрытие приложения
        }

        private FormOneDay fOD;
        private void buttonDay_Click(object sender, EventArgs e)
        {
            fOD = new FormOneDay();
            fOD.Show();
        }
    }
}
