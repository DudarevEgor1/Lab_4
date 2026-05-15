using System;
using System.Windows.Forms;

namespace Inovoice
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Включаем визуальные стили (современный вид кнопок)
            Application.EnableVisualStyles();

            // Настраиваем рендеринг текста
            Application.SetCompatibleTextRenderingDefault(false);

            // Запускаем твою основную форму
            // Убедись, что класс в Form1.cs называется именно Form1
            Application.Run(new Form1());
        }
    }
}