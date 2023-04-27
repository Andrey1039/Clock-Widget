using System;
using System.Timers;
using System.Windows.Controls;

namespace Clock_Widget
{
    /// <summary>
    /// Логика взаимодействия для Arrows.xaml
    /// </summary>
    public partial class Arrows : UserControl
    {
        public Timer Timer = new Timer(1000);

        public Arrows()
        {
            InitializeComponent();
            Timer.Elapsed += TimeChange;
            Timer.Enabled = true;
        }

        private void TimeChange(object? sender, ElapsedEventArgs e)
        {
            var time = DateTime.Now;

            Dispatcher.Invoke(() =>
            {
                rotsecond.Angle = 6 * (time.Second) - 90;
                rotminute.Angle = 6 * time.Minute + rotsecond.Angle / 60 - 90;
                rothour.Angle = 30 * (time.Hour % 12) + (DateTime.Now.Minute * 0.5) - 90;
            }
            );
        }

        private void CenterPoint_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
