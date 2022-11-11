using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp15
{
    public partial class Form1 : Form
    {
        public int total = 0;
        public int left_click = 0;
        public int right_click = 0;
        public Form1()
        {
            InitializeComponent();
            
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            MouseEventArgs myArgs = (MouseEventArgs)e;
            total++;
            if (myArgs.Button == MouseButtons.Left)
                left_click++;
            if (myArgs.Button == MouseButtons.Right)
                right_click++;
            Вывод.Text = ("Общее количество : " + total.ToString()+ "Количество нажатий левой кнопки: " +left_click.ToString()+ "Количество нажатий правой кнопки: "+ right_click.ToString());
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
