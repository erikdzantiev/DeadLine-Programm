using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeadLine_Programm
{
    class ListClass
    {
        //Переменная для хранения добавляемой даты
        DateTime datetime;

        //Переменная для передачи даты в компонент textBoxDateEdit
        DateTime date = new DateTime();

        //Список хранения Часов этапов Дедлайна
        public static List<string> Hours = new List<string>();

        //Список хранения Минут этапов Дедлайна
        public static List<string> Minutes = new List<string>();

        //Список хранения Дат этапов Дедлайна
        public static List<string> Dates = new List<string>();

        //Список хранения Названий Дедлайна
        public static List<string> Names = new List<string>();

        //Список хранения описаний Дедлайнов
        public static List<string> Purpose = new List<string>();

    }
}
