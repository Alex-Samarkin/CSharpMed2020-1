using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/// <summary>
/// для доступа к точкам серии диаграммы
/// </summary>
using System.Windows.Forms.DataVisualization.Charting;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /// Пишем код здесь
            /// 

            // получаем точки серии
            DataPointCollection pts = this.chart1.Series[0].Points;
            // чистим старое содержимое
            pts.Clear();

            // генератор случайных чисел, начальное число зависит от времени
            Random r = new Random();

            // N - количество точек графика
            // случайно от 100 до 500
            int N = r.Next(100, 500);

            // цикл добавления точек
            for (int i = 0; i < N; i++)
            {
                pts.AddXY(i, r.NextDouble());
            }
            
            /*
            double[] y = { 483, 655, 945, 1444, 2120, 2926, 5567, 6197, 8288, 11302, 13950, 
                                16758, 17498, 23865, 28276, 30814, 34375, 37111, 37598, 40632, 
                                    43145, 48076, 60414, 64474, 67195, 69289, 71450, 73439 };
            int N1 = y.Length;
            // цикл добавления точек
            for (int i = 0; i < N1; i++)
            {
                pts.AddXY(i, y[i]);
            }
            */
        }
    }
}
