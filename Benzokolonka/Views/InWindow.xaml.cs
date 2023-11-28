using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace Benzokolonka
{
    /// <summary>
    /// Логика взаимодействия для InWindow.xaml
    /// </summary>
    public partial class InWindow : Window
    {
        private DispatcherTimer timer;
        DispatcherTimer timer2;
        DispatcherTimer timer3;
        private double currentHeight;
        private double totalHeight = 200;
        private int curtime = MyBenz.curtime*100;
        private int endtime = 2;
        private int starttime = 3;
        private double percentage;
        
        Random Random = new Random();
        private MediaPlayer mediaPlayer = new MediaPlayer();
        public InWindow()
        {
            InitializeComponent();
            percentage = Random.Next(0, 40);
            timer = new DispatcherTimer();        
            timer.Interval = TimeSpan.FromMilliseconds(50);
            // Интервал таймера в миллисекундах
            timer.Tick += Timer_Tick;
            timer2 = new DispatcherTimer();
            timer2.Interval = TimeSpan.FromSeconds(1);
            timer2.Tick += Timer_Tick2;
            timer3 = new DispatcherTimer();
            timer3.Interval=TimeSpan.FromSeconds(1);
            timer3.Tick += Timer_Tick3;
            mediaPlayer.Open(new Uri(@"C:\Users\Марат\source\repos\Benzokolonka\Benzokolonka\Recourses\zapravka-mashyny-benzinom.mp3"));
            timer3.Start();
            
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            mediaPlayer.Play();
            curtime -= 10;
            currentHeight += 2;
            fuelRectangle.Height = currentHeight;
            percentage += (currentHeight / totalHeight);
            percentageTextBlock.Text = $"{percentage:F0}%";
            //if (fuelRectangle.Height < (MyBenz.Objem + ObjemIn) * 2)
            //{
            //    mediaPlayer.Play();

            //    currentHeight += 2;
            //    fuelRectangle.Height = currentHeight;
            //    percentage += (currentHeight / totalHeight);
            //    percentageTextBlock.Text = $"{percentage:F0}%";
            //}

            if (curtime <= 0)
            {
                
                timer.Stop();
               
                curtime = MyBenz.curtime*100;// Останавливаем таймер, когда достигнута полная высота
                gunRectangle.BeginAnimation(Rectangle.MarginProperty, new ThicknessAnimation(new Thickness(200, -20, 0, 200), TimeSpan.FromSeconds(2)));
                hosepipe80.BeginAnimation(Path.OpacityProperty, new DoubleAnimation(0, TimeSpan.FromSeconds(0.6)));
                
                timer2.Start();
            }
        }
        private void Timer_Tick2(object sender, EventArgs e)
        {
            endtime--;
            mediaPlayer.Stop();
            if (endtime <= 0)
            {
                timer2.Stop(); // Останавливаем второй таймер
                this.Close();
            }
        }
        private void Timer_Tick3(object sender, EventArgs e)
        {
            starttime--;

            if (starttime <= 0)
            {
                timer3.Stop();
                timer.Start();
            }
        }
    }
}
