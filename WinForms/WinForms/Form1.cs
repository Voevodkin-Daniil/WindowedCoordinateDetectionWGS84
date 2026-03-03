using System;
using System.Windows.Forms;

namespace WinForms
{
    /// <summary>
    /// Главная форма приложения для расчёта координат цели и Наблюдателя.
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
        /// Вычисляет координаты Наблюдателя и цели на основе входных данных.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Аргументы события.</param>
        private void buttonMath_Click(object sender, EventArgs e)
        {
            // Очищаем поля с результатами перед новым расчётом
            ClearResultFields();

            try
            {
                // СБОР ВХОДНЫХ ДАННЫХ  
                double observer1B = double.Parse(textBox_Input_OO1_B.Text);
                double observer1L = double.Parse(textBox_Input_OO1_L.Text);
                double observer1H = double.Parse(textBox_Input_OO1_H.Text);
                double observer2B = double.Parse(textBox_Input_OO2_B.Text);
                double observer2L = double.Parse(textBox_Input_OO2_L.Text);
                double observer2H = double.Parse(textBox_Input_OO2_H.Text);

                double distanceToDroneFromObs1 = double.Parse(textBox_Input_L1.Text);
                double distanceToDroneFromObs2 = double.Parse(textBox_Input_L2.Text);
                double distanceToTargetFromDrone = double.Parse(textBox_Input_L3.Text);
                double angleCC = double.Parse(textBox_Input_сс.Text);

                double angleA = double.Parse(textBox_Input_a.Text);
                double angleAA = double.Parse(textBox_Input_aa.Text);
                double angleB = double.Parse(textBox_Input_b.Text);
                double angleBB = double.Parse(textBox_Input_bb.Text);

                // ПРОЕЦИРОВАНИЕ ВСЕХ ДАННЫХ НА ПЛОСКОСТЬ

                var observer1 = TranslationWGS84.ConvertGeodeticToLocalTangent(
                                                (observer1B / 180 * Math.PI, observer1L / 180 * Math.PI, observer1H),
                                                (observer1B / 180 * Math.PI, observer1L / 180 * Math.PI, observer1H));
                var observer2 = TranslationWGS84.ConvertGeodeticToLocalTangent(
                                                (observer2B / 180 * Math.PI, observer2L / 180 * Math.PI, observer2H),
                                                (observer1B / 180 * Math.PI, observer1L / 180 * Math.PI, observer1H));

                // ВЫЧИСЛЕНИЕ КООРДИНАТ  
                var result = TargetLocator.GetTargetCoordinates(
                    observer1.east, observer1.north, observer1.up, observer2.east, observer2.north, observer2.up,
                    distanceToDroneFromObs1, distanceToDroneFromObs2, distanceToTargetFromDrone,
                    angleA, angleB, angleAA, angleBB, angleCC);


                // Выводим результаты для Наблюдателя
                var BPLA_WGS84 = TranslationWGS84.ConvertLocalTangentToGeodetic(result.A, (observer1B / 180 * Math.PI, observer1L / 180 * Math.PI, observer1H));

                textBox_Rez_BPLA_B.Text = $"{ (BPLA_WGS84.B / Math.PI * 180):f7}";
                textBox_Rez_BPLA_L.Text = $"{(BPLA_WGS84.L / Math.PI * 180):f7}";
                textBox_Rez_BPLA_Z.Text = $"{BPLA_WGS84.H:f3} M";
                //textBox_Rez_BPLA_Z.Text = "";

                // Выводим результаты для цели
                var T_WGS84 = TranslationWGS84.ConvertLocalTangentToGeodetic(result.B, (observer1B / 180 * Math.PI, observer1L / 180 * Math.PI, observer1H));
                textBox_Rez_T_B.Text = $"{(T_WGS84.B / Math.PI * 180):f7}";
                textBox_Rez_T_L.Text = $"{(T_WGS84.L / Math.PI * 180):f7}";
                textBox_Rez_T_Z.Text = $"{T_WGS84.H:f3} M";


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
            // Очистка полей для Наблюдателя
            textBox_Rez_BPLA_B.Text = "";
            textBox_Rez_BPLA_L.Text = "";
            textBox_Rez_BPLA_Z.Text = "";

            // Очистка полей для цели
            textBox_Rez_T_B.Text = "";
            textBox_Rez_T_L.Text = "";
            textBox_Rez_T_Z.Text = "";

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
        /// Показывает подсказку для координат Наблюдателя.
        /// </summary>
        private void label5_Click(object sender, EventArgs e)
        {
            ShowParameterInfo(
                "Наблюдателя",
                "Пожалуйста, введите координаты Наблюдателя.\nТри поля соответствуют координатам X, Y и Z соответственно."
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
        /// Показывает подсказку для параметра L1 (расстояние от ОО1 до Наблюдателя).
        /// </summary>
        private void label8_Click(object sender, EventArgs e)
        {
            ShowParameterInfo(
                "Параметр L1",
                "L1 — расстояние между Опорным Объектом 1 (ОО1) и Наблюдателем.\nПараметр измеряется дальномером."
            );
        }

        /// <summary>
        /// Показывает подсказку для параметра L2 (расстояние от ОО2 до Наблюдателя).
        /// </summary>
        private void label9_Click(object sender, EventArgs e)
        {
            ShowParameterInfo(
                "Параметр L2",
                "L2 — расстояние между Опорным Объектом 2 (ОО2) и Наблюдателем.\nПараметр измеряется дальномером."
            );
        }

        /// <summary>
        /// Показывает подсказку для параметра L3 (расстояние от Наблюдателя до цели).
        /// </summary>
        private void label10_Click(object sender, EventArgs e)
        {
            ShowParameterInfo(
                "Параметр L3",
                "L3 — расстояние между Целью и Наблюдателем.\nПараметр измеряется дальномером."
            );
        }

        /// <summary>
        /// Показывает подсказку для параметра ∠a (угол азимута между целью, Наблюдатель и ОО1).
        /// </summary>
        private void label11_Click(object sender, EventArgs e)
        {
            ShowParameterInfo(
                "Параметр ∠a - Азимут",
                "∠a — угол (азимут) между Целью, Наблюдатель и Опорным Объектом 1 (ОО1).\nРезультат измеряется в градусах.\nПараметр измеряется угломером."
            );
        }

        /// <summary>
        /// Показывает подсказку для параметра ∠b (угол азимута между целью, Наблюдатель и ОО2).
        /// </summary>
        private void label19_Click(object sender, EventArgs e)
        {
            ShowParameterInfo(
                "Параметр ∠b - Азимут",
                "∠b — угол (азимут) между Целью, Наблюдатель и Опорным Объектом 2 (ОО2).\nРезультат измеряется в градусах.\nПараметр измеряется угломером."
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


        private void label7_Click(object sender, EventArgs e)
        {
            ShowParameterInfo(
                "ОО1",
                "Первый опорный объект от которого проводятся расчеты"
            );
        }
        private void label6_Click(object sender, EventArgs e)
        {
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