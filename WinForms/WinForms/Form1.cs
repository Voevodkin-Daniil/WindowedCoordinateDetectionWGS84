using System;
using System.Windows.Forms;

namespace WinForms
{
    /// <summary>
    /// Главная форма приложения для расчёта координат цели и БПЛА.
    /// </summary>
    public partial class Form1 : Form
    {
        /// <summary>
        /// Инициализирует новый экземпляр класса Form1.
        /// </summary>
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Обработчик нажатия кнопки "Расчёт координат цели".
        /// Вычисляет координаты БПЛА и цели на основе входных данных.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Аргументы события.</param>
        private void button2_Click(object sender, EventArgs e)
        {
            // Очищаем поля с результатами перед новым расчётом
            ClearResultFields();

            try
            {
                // СБОР ВХОДНЫХ ДАННЫХ  
                double observer1X = double.Parse(textBox_Input_OO1_B.Text);
                double observer1Y = double.Parse(textBox_Input_OO1_L.Text);
                double observer1Z = double.Parse(textBox_Input_OO1_Z.Text);
                double observer2X = double.Parse(textBox_Input_OO2_B.Text);
                double observer2Y = double.Parse(textBox_Input_OO2_L.Text);
                double observer2Z = double.Parse(textBox_Input_OO2_Z.Text);

                double distanceToDroneFromObs1 = double.Parse(textBox_Input_L1.Text);
                double distanceToDroneFromObs2 = double.Parse(textBox_Input_L2.Text);
                double distanceToTargetFromDrone = double.Parse(textBox_Input_L3.Text);
                double angleC = double.Parse(textBox_Input_с.Text);

                double angleA = double.Parse(textBox_Input_a.Text);
                double angleAA = double.Parse(textBox_Input_aa.Text);
                double angleB = double.Parse(textBox_Input_b.Text);
                double angleBB = double.Parse(textBox_Input_bb.Text);

                // ВЫЧИСЛЕНИЕ КООРДИНАТ  
                double[][] result = TargetLocator.GetTargetCoordinates(
                    observer1X, observer1Y, observer1Z, observer2X, observer2Y, observer2Z,
                    distanceToDroneFromObs1, distanceToDroneFromObs2, distanceToTargetFromDrone,
                    angleA, angleB, angleAA, angleBB, angleC);

                // ВЫВОД РЕЗУЛЬТАТОВ ДЛЯ БПЛА
                textBox_Rez_BPLA_B.Text = Math.Round(result[0][0], 5).ToString() + " X";
                textBox_Rez_BPLA_L.Text = Math.Round(result[0][1], 5).ToString() + " Y";
                textBox_Rez_BPLA_Z.Text = Math.Round(result[0][2], 5).ToString() + " Z";

                // ВЫВОД РЕЗУЛЬТАТОВ ДЛЯ ЦЕЛИ
                textBox_Rez_T_B.Text = Math.Round(result[1][0], 5).ToString() + " X";
                textBox_Rez_T_L.Text = Math.Round(result[1][1], 5).ToString() + " Y";
                textBox_Rez_T_Z.Text = Math.Round(result[1][2], 5).ToString() + " Z";

                // ПРОВЕРКА ТОЧНОСТИ РАСЧЁТА (если указаны эталонные координаты)
                try
                {
                    double referenceBPLA_X = double.Parse(textBox_BPLA_B.Text);
                    double referenceBPLA_Y = double.Parse(textBox_BPLA_L.Text);
                    double referenceBPLA_Z = double.Parse(textBox_BPLA_Z.Text);

                    double referenceTarget_X = double.Parse(textBox_T_B.Text);
                    double referenceTarget_Y = double.Parse(textBox_T_L.Text);
                    double referenceTarget_Z = double.Parse(textBox_T_Z.Text);

                    // Вычисление погрешности для БПЛА
                    double errorBPLA = Math.Sqrt(
                        Math.Pow(result[0][0] - referenceBPLA_X, 2) +
                        Math.Pow(result[0][1] - referenceBPLA_Y, 2) +
                        Math.Pow(result[0][2] - referenceBPLA_Z, 2)
                    );
                    textBox_Rez_BPLA.Text = Math.Round(errorBPLA, 7).ToString();

                    // Вычисление погрешности для цели
                    double errorTarget = Math.Sqrt(
                        Math.Pow(result[1][0] - referenceTarget_X, 2) +
                        Math.Pow(result[1][1] - referenceTarget_Y, 2) +
                        Math.Pow(result[1][2] - referenceTarget_Z, 2)
                    );
                    textBox_Rez_T.Text = Math.Round(errorTarget, 7).ToString();
                }
                catch (Exception ex)
                {
                    // Если эталонные координаты не указаны, пропускаем расчёт погрешностей
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Ошибка расчёта",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        /// <summary>
        /// Очищает все поля с результатами расчёта.
        /// </summary>
        private void ClearResultFields()
        {
            // Очистка полей для БПЛА
            textBox_Rez_BPLA_B.Text = "";
            textBox_Rez_BPLA_L.Text = "";
            textBox_Rez_BPLA_Z.Text = "";
            textBox_Rez_BPLA.Text = "";

            // Очистка полей для цели
            textBox_Rez_T_B.Text = "";
            textBox_Rez_T_L.Text = "";
            textBox_Rez_T_Z.Text = "";
            textBox_Rez_T.Text = "";

        }

        //   ОБРАБОТЧИКИ СОБЫТИЙ ДЛЯ ПОДСКАЗОК ПО ПАРАМЕТРАМ  

        /// <summary>
        /// Показывает подсказку для параметра ∠C (угол места для цели).
        /// </summary>
        private void label17_Click(object sender, EventArgs e)
        {
            ShowParameterInfo(
                "Параметр ∠C",
                "∠C — угол места для Цели.\nЭто угловая высота объекта над горизонтом.\nРезультат измеряется в градусах."
            );
        }

        /// <summary>
        /// Показывает подсказку для координат Опорного Объекта 1.
        /// </summary>
        private void label2_Click(object sender, EventArgs e)
        {
            ShowParameterInfo(
                "Опорный Объект 1",
                "Пожалуйста, введите координаты Опорного Объекта 1.\nТри поля соответствуют координатам X, Y и Z соответственно."
            );
        }

        /// <summary>
        /// Показывает подсказку для координат Опорного Объекта 2.
        /// </summary>
        private void label3_Click(object sender, EventArgs e)
        {
            ShowParameterInfo(
                "Опорный Объект 2",
                "Пожалуйста, введите координаты Опорного Объекта 2.\nТри поля соответствуют координатам X, Y и Z соответственно."
            );
        }

        /// <summary>
        /// Показывает подсказку для координат БПЛА.
        /// </summary>
        private void label5_Click(object sender, EventArgs e)
        {
            ShowParameterInfo(
                "БПЛА",
                "Пожалуйста, введите координаты БПЛА.\nТри поля соответствуют координатам X, Y и Z соответственно."
            );
        }

        /// <summary>
        /// Показывает подсказку для координат Цели.
        /// </summary>
        private void label4_Click(object sender, EventArgs e)
        {
            ShowParameterInfo(
                "Цель",
                "Пожалуйста, введите координаты Цели.\nТри поля соответствуют координатам X, Y и Z соответственно."
            );
        }

        /// <summary>
        /// Показывает подсказку для параметра L1 (расстояние от ОО1 до БПЛА).
        /// </summary>
        private void label8_Click(object sender, EventArgs e)
        {
            ShowParameterInfo(
                "Параметр L1",
                "L1 — расстояние между Опорным Объектом 1 (ОО1) и БПЛА.\nПараметр измеряется дальномером."
            );
        }

        /// <summary>
        /// Показывает подсказку для параметра L2 (расстояние от ОО2 до БПЛА).
        /// </summary>
        private void label9_Click(object sender, EventArgs e)
        {
            ShowParameterInfo(
                "Параметр L2",
                "L2 — расстояние между Опорным Объектом 2 (ОО2) и БПЛА.\nПараметр измеряется дальномером."
            );
        }

        /// <summary>
        /// Показывает подсказку для параметра L3 (расстояние от БПЛА до цели).
        /// </summary>
        private void label10_Click(object sender, EventArgs e)
        {
            ShowParameterInfo(
                "Параметр L3",
                "L3 — расстояние между Целью и БПЛА.\nПараметр измеряется дальномером."
            );
        }

        /// <summary>
        /// Показывает подсказку для параметра ∠a (угол азимута между целью, БПЛА и ОО1).
        /// </summary>
        private void label11_Click(object sender, EventArgs e)
        {
            ShowParameterInfo(
                "Параметр ∠a - Азимут",
                "∠a — угол (азимут) между Целью, БПЛА и Опорным Объектом 1 (ОО1).\nРезультат измеряется в градусах.\nПараметр измеряется угломером."
            );
        }

        /// <summary>
        /// Показывает подсказку для параметра ∠b (угол азимута между целью, БПЛА и ОО2).
        /// </summary>
        private void label19_Click(object sender, EventArgs e)
        {
            ShowParameterInfo(
                "Параметр ∠b - Азимут",
                "∠b — угол (азимут) между Целью, БПЛА и Опорным Объектом 2 (ОО2).\nРезультат измеряется в градусах.\nПараметр измеряется угломером."
            );
        }

        /// <summary>
        /// Показывает подсказку для параметра ∠A (угол места для ОО1).
        /// </summary>
        private void label12_Click(object sender, EventArgs e)
        {
            ShowParameterInfo(
                "Параметр ∠A",
                "∠A — угол места для Опорного Объекта 1 (ОО1).\nЭто угловая высота объекта над горизонтом.\nРезультат измеряется в градусах."
            );
        }

        /// <summary>
        /// Показывает подсказку для параметра ∠B (угол места для ОО2).
        /// </summary>
        private void label18_Click(object sender, EventArgs e)
        {
            ShowParameterInfo(
                "Параметр ∠B",
                "∠B — угол места для Опорного Объекта 2 (ОО2).\nЭто угловая высота объекта над горизонтом.\nРезультат измеряется в градусах."
            );
        }


        private void label7_Click(object sender, EventArgs e) {
            ShowParameterInfo(
                "ОО1",
                "Первый опорный объект от которого проводятся расчеты"
            );
        }
        private void label6_Click(object sender, EventArgs e) {
            ShowParameterInfo(
                "ОО2",
                "Второй опорный объект от которого проводятся расчеты"
            );
        }
        /// <summary>
        /// Вспомогательный метод для отображения подсказок по параметрам.
        /// </summary>
        /// <param name="title">Заголовок окна подсказки.</param>
        /// <param name="message">Текст подсказки.</param>
        private void ShowParameterInfo(string title, string message)
        {
            MessageBox.Show(
                message,
                title,
                MessageBoxButtons.OK,
                MessageBoxIcon.None
            );
        }
    }
}