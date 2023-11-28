using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Benzokolonka
{
    public class BezierProperties : INotifyPropertyChanged
    {
        public BezierProperties()
        {
            // Установка начальных значений
            Point1 = new Point(-20, 80);
            Point2 = new Point(-60, -10);
            Point3 = new Point(0, -600);
        }
        private Point _point1;

        public Point Point1
        {
            get { return _point1; }
            set
            {
                if (_point1 != value)
                {
                    _point1 = value;
                    OnPropertyChanged(nameof(Point1));
                }
            }
        }
        private Point _point2;

        public Point Point2
        {
            get { return _point2; }
            set
            {
                if (_point2 != value)
                {
                    _point2 = value;
                    OnPropertyChanged(nameof(Point2));
                }
            }
        }
        private Point _point3;

        public Point Point3
        {
            get { return _point3; }
            set
            {
                if (_point3 != value)
                {
                    _point3 = value;
                    OnPropertyChanged(nameof(Point3));
                }
            }
        }

        

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
