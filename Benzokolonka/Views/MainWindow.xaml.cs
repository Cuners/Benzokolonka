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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace Benzokolonka
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        private DispatcherTimer timer = new DispatcherTimer();
        private DispatcherTimer timer2=new DispatcherTimer();
        private int secondsRemaining = MyBenz.curtime;
        private int timeToStart = 2;
        private double nowObj;
        private double rubNow;
        public MainWindow()
        {
            InitializeComponent();
            
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += Timer_Tick;
            timer2.Interval=TimeSpan.FromSeconds(1);
            timer2.Tick += Timer_Tick2;
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            secondsRemaining--;
            nowObj = MyBenz.Objem/10 + Convert.ToDouble(FuelNum.Text);
            rubNow=MyBenz.RubObjem/10 + Convert.ToDouble(RubNow.Text);
            
            FuelNum.Text = nowObj.ToString();
            RubNow.Text = rubNow.ToString();
            if (secondsRemaining <= 0)
            {
                //mediaPlayer.Stop();
                timer.Stop();
                
                secondsRemaining = MyBenz.curtime;
            }
        }
        private void Timer_Tick2(object sender, EventArgs e)
        {
            timeToStart--;
           
            if (timeToStart <= 0)
            {
                //mediaPlayer.Stop();
                timer2.Stop();
                timer.Start();
                timeToStart = 2;
            }
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (MyBenz.NumOfBenz == 80)
            {
                FuelNum.Text = "0";
                RubNow.Text = "0";
                if (Canvas.GetLeft(But80) == 0 && Canvas.GetTop(But80) == 0)
                {
                    InWindow inWindow = new InWindow();
                    inWindow.Show();
                    PointAnimation animation1 = new PointAnimation
                    {
                        Duration = TimeSpan.FromSeconds(2.2),
                        To = new Point(200, 80)
                    };

                    PointAnimation animation2 = new PointAnimation
                    {
                        Duration = TimeSpan.FromSeconds(2.2),
                        To = new Point(-60, -10)
                    };

                    PointAnimation animation3 = new PointAnimation
                    {
                        Duration = TimeSpan.FromSeconds(2.8),
                        To = new Point(-330, -190)
                    };

                    hosePipeBezier80.BeginAnimation(BezierSegment.Point1Property, animation1);
                    hosePipeBezier80.BeginAnimation(BezierSegment.Point2Property, animation2);
                    hosePipePathFigure80.BeginAnimation(PathFigure.StartPointProperty, animation3);
                    But80.BeginAnimation(Canvas.LeftProperty, new DoubleAnimation(-500, TimeSpan.FromSeconds(2.4)));
                    But80.BeginAnimation(Canvas.TopProperty, new DoubleAnimation(200, TimeSpan.FromSeconds(2.4)));
                    But80.RenderTransform.BeginAnimation(RotateTransform.AngleProperty, new DoubleAnimation(-90, TimeSpan.FromSeconds(2.4)));
                    
                   // mediaPlayer.Play();
                    timer2.Start();
                    
                }
                else if(!timer.IsEnabled)
                {
                    // Второе нажатие - возвращаем кнопку на исходное местоположение
                    PointAnimation animation1 = new PointAnimation
                    {
                        Duration = TimeSpan.FromSeconds(2),
                        To = new Point(-20, 80)
                    };

                    PointAnimation animation2 = new PointAnimation
                    {
                        
                        Duration = TimeSpan.FromSeconds(2),
                        To = new Point(-60, -10)
                    };

                    PointAnimation animation3 = new PointAnimation
                    {
                        Duration = TimeSpan.FromSeconds(2.6),
                        To = new Point(25, 0)
                    };
                    hosePipeBezier80.BeginAnimation(BezierSegment.Point1Property, animation1);
                    hosePipeBezier80.BeginAnimation(BezierSegment.Point2Property, animation2);
                    hosePipePathFigure80.BeginAnimation(PathFigure.StartPointProperty, animation3);
                    But80.BeginAnimation(Canvas.LeftProperty, new DoubleAnimation(0, TimeSpan.FromSeconds(3)));
                    But80.BeginAnimation(Canvas.TopProperty, new DoubleAnimation(0, TimeSpan.FromSeconds(3)));
                    But80.RenderTransform.BeginAnimation(RotateTransform.AngleProperty, new DoubleAnimation(0, TimeSpan.FromSeconds(3)));
                    MyBenz.NumOfBenz = 0;
                }
                else if (timer.IsEnabled)
                {
                    MessageBox.Show("Подождите пока бензин зальется");
                }
            }
            else if (MyBenz.NumOfBenz == 0)
            {
                MessageBox.Show("Вы не выбрали процентность бензина");
            }
            else
            {
                MessageBox.Show("Вам нужен " + MyBenz.NumOfBenz.ToString() + " процентность бензина");
            }
        }

        private void But92_Click(object sender, RoutedEventArgs e)
        {
            if (MyBenz.NumOfBenz == 92)
            {
                FuelNum.Text = "0";
                RubNow.Text = "0";
                if (Canvas.GetLeft(But92) == 0 && Canvas.GetTop(But92) == 0)
                {
                    InWindow inWindow = new InWindow();
                    inWindow.Show();
                    // Первое нажатие - запускаем анимации, которые перемещают кнопку влево и вверх
                    PointAnimation animation1 = new PointAnimation
                    {
                        Duration = TimeSpan.FromSeconds(2.2),
                        To = new Point(200, 80)
                    };

                    PointAnimation animation2 = new PointAnimation
                    {
                        Duration = TimeSpan.FromSeconds(2.2),
                        To = new Point(-60, -10)
                    };

                    PointAnimation animation3 = new PointAnimation
                    {
                        Duration = TimeSpan.FromSeconds(2.6),
                        To = new Point(-470, -195)
                    };

                    hosePipeBezier92.BeginAnimation(BezierSegment.Point1Property, animation1);
                    hosePipeBezier92.BeginAnimation(BezierSegment.Point2Property, animation2);
                    hosePipePathFigure92.BeginAnimation(PathFigure.StartPointProperty, animation3);
                    But92.BeginAnimation(Canvas.LeftProperty, new DoubleAnimation(-495, TimeSpan.FromSeconds(2.7)));
                    But92.BeginAnimation(Canvas.TopProperty, new DoubleAnimation(320, TimeSpan.FromSeconds(2.7)));
                    But92.RenderTransform.BeginAnimation(RotateTransform.AngleProperty, new DoubleAnimation(-90, TimeSpan.FromSeconds(2.7)));
                    //mediaPlayer.Play();
                    timer2.Start();
                }
                else if(!timer.IsEnabled)
                {
                    // Второе нажатие - возвращаем кнопку на исходное местоположение
                    PointAnimation animation1 = new PointAnimation
                    {
                        Duration = TimeSpan.FromSeconds(2),
                        To = new Point(10, 30)
                    };

                    PointAnimation animation2 = new PointAnimation
                    {

                        Duration = TimeSpan.FromSeconds(2),
                        To = new Point(60, 30)
                    };

                    PointAnimation animation3 = new PointAnimation
                    {
                        Duration = TimeSpan.FromSeconds(2),
                        To = new Point(0, 0)
                    };

                    hosePipeBezier92.BeginAnimation(BezierSegment.Point1Property, animation1);
                    hosePipeBezier92.BeginAnimation(BezierSegment.Point2Property, animation2);
                    hosePipePathFigure92.BeginAnimation(PathFigure.StartPointProperty, animation3);
                    But92.BeginAnimation(Canvas.LeftProperty, new DoubleAnimation(0, TimeSpan.FromSeconds(2)));
                    But92.BeginAnimation(Canvas.TopProperty, new DoubleAnimation(0, TimeSpan.FromSeconds(2)));
                    But92.RenderTransform.BeginAnimation(RotateTransform.AngleProperty, new DoubleAnimation(0, TimeSpan.FromSeconds(2)));
                    MyBenz.NumOfBenz = 0;
                }
                else if (timer.IsEnabled)
                {
                    MessageBox.Show("Подождите пока бензин зальется");
                }
            }
            else if (MyBenz.NumOfBenz == 0)
            {
                MessageBox.Show("Вы не выбрали процентность бензина");
            }
            else
            {
                MessageBox.Show("Вам нужен " + MyBenz.NumOfBenz.ToString() + " процентность бензина");
            }

        }

        private void But95_Click(object sender, RoutedEventArgs e)
        {
            if (MyBenz.NumOfBenz == 95)
            {
                FuelNum.Text = "0";
                RubNow.Text = "0";
                if (Canvas.GetLeft(But95) == 0 && Canvas.GetTop(But95) == 0)
                {
                    InWindow inWindow = new InWindow();
                    inWindow.Show();
                    // Первое нажатие - запускаем анимации, которые перемещают кнопку влево и вверх
                    PointAnimation animation1 = new PointAnimation
                    {
                        Duration = TimeSpan.FromSeconds(2.2),
                        To = new Point(200, 80)
                    };

                    PointAnimation animation2 = new PointAnimation
                    {
                        Duration = TimeSpan.FromSeconds(2.2),
                        
                        To = new Point(-60, -10)
                    };

                    PointAnimation animation3 = new PointAnimation
                    {
                        Duration = TimeSpan.FromSeconds(0.2),
                        BeginTime=TimeSpan.FromSeconds(0.3),
                        To = new Point(-20, -30)
                    };
                    PointAnimation animation5 = new PointAnimation
                    {
                        Duration = TimeSpan.FromSeconds(0.4),
                        BeginTime = TimeSpan.FromSeconds(0.3),
                        From=new Point(-20,-30),
                        To = new Point(-100, -100)
                    };
                    PointAnimation animation4 = new PointAnimation
                    {
                        Duration = TimeSpan.FromSeconds(1.9),
                        BeginTime = TimeSpan.FromSeconds(0.5),
                        From=new Point(-100,-100),
                        To = new Point(-580, -190)
                    };

                    hosePipeBezier95.BeginAnimation(BezierSegment.Point1Property, animation1);
                    hosePipeBezier95.BeginAnimation(BezierSegment.Point2Property, animation2);
                    hosePipePathFigure95.BeginAnimation(PathFigure.StartPointProperty, animation3);
                    hosePipePathFigure95.BeginAnimation(PathFigure.StartPointProperty, animation5);
                    hosePipePathFigure95.BeginAnimation(PathFigure.StartPointProperty, animation4);
                    But95.BeginAnimation(Canvas.LeftProperty, new DoubleAnimation(-495, TimeSpan.FromSeconds(2.6)));
                    But95.BeginAnimation(Canvas.TopProperty, new DoubleAnimation(430, TimeSpan.FromSeconds(2.6)));
                    But95.RenderTransform.BeginAnimation(RotateTransform.AngleProperty, new DoubleAnimation(-90, TimeSpan.FromSeconds(2.6)));
                   // mediaPlayer.Play();
                    timer2.Start();
                }
                else if(!timer.IsEnabled)
                {
                    // Второе нажатие - возвращаем кнопку на исходное местоположение
                    PointAnimation animation1 = new PointAnimation
                    {
                        Duration = TimeSpan.FromSeconds(2),
                        To = new Point(10, 30)
                    };

                    PointAnimation animation2 = new PointAnimation
                    {

                        Duration = TimeSpan.FromSeconds(2),
                        To = new Point(60, 30)
                    };

                    PointAnimation animation3 = new PointAnimation
                    {
                        Duration = TimeSpan.FromSeconds(2),
                        To = new Point(0,0)
                    };

                    hosePipeBezier95.BeginAnimation(BezierSegment.Point1Property, animation1);
                    hosePipeBezier95.BeginAnimation(BezierSegment.Point2Property, animation2);
                    hosePipePathFigure95.BeginAnimation(PathFigure.StartPointProperty, animation3);
                    But95.BeginAnimation(Canvas.LeftProperty, new DoubleAnimation(0, TimeSpan.FromSeconds(3)));
                    But95.BeginAnimation(Canvas.TopProperty, new DoubleAnimation(0, TimeSpan.FromSeconds(3)));
                    But95.RenderTransform.BeginAnimation(RotateTransform.AngleProperty, new DoubleAnimation(0, TimeSpan.FromSeconds(3)));
                    MyBenz.NumOfBenz = 0;
                }
                else if (timer.IsEnabled)
                {
                    MessageBox.Show("Подождите пока бензин зальется");
                }
            }
            else if(MyBenz.NumOfBenz == 0)
            {
                MessageBox.Show("Вы не выбрали процентность бензина");
            }
            else
            {
                MessageBox.Show("Вам нужен " + MyBenz.NumOfBenz.ToString() + " процентность бензина");
            }
        }

    

        private void PamyatkaButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Памятка");
        }
    }
}
