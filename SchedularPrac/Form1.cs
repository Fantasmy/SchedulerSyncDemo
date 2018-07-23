using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchedularPrac
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "MM/dd/yyyy hh:mm:ss";
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
           DateTime date =  dateTimePicker1.Value;
            Scheduler sc = new Scheduler(); //instancia la clase
            sc.Start(date);  //llama al método start pasando la fecha
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
