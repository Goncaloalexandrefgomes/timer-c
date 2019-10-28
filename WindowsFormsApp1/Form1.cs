using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        int contador = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            contador = 0;
            label1.Text = "00:00:00";
        }


        private void mostrar()
        {
            Console.Beep();
            int dia = 24 * (int)Math.Pow(60, 2);
            if (contador < 0) contador += dia;
            if (contador >= dia) contador -= dia;
            label1.Text = TimeSpan.FromSeconds(contador).ToString();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            contador++;
            mostrar();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Interval = 1000;
        }

        private void Horas_Click(object sender, EventArgs e)
        {
            contador += 3600;
            mostrar();
        }

        private void Minutos_Click(object sender, EventArgs e)
        {
            contador += 60;
            mostrar();
        }


        private void Acerta_Relogio(object sender, MouseEventArgs e)
        {

        }

        private void Acerta_Relogio_s(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) contador += 1;
            if (e.Button == MouseButtons.Right) contador -= 1;
            mostrar();
        }

        private void Acerta_Relogio_m(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) contador += 60;
            if (e.Button == MouseButtons.Right) contador -= 60;
            mostrar();

        }

        private void Acerta_Relogio_h(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) contador += 3600;
            if (e.Button == MouseButtons.Right) contador -= 3600;
            mostrar();

        }
    }
}
