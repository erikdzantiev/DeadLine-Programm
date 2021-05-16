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
    public partial class FormOneDay : Form
    {
        public FormOneDay()
        {
            InitializeComponent();
        }

        private void FormOneDay_Load(object sender, EventArgs e)
        {
            foreach (string el in ListClass.Names)
            {
               if()
                listBoxOD.Items.Add(el); //////////////////////////////////////////////////////////////////////////////////////////////////////  ЗАПИСЬ В ЛИСТБОКС
            }
        }
    }
}
