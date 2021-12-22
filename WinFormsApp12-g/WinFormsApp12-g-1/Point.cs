using System;
using System.Collections.Generic;
using System.Text;

namespace WinFormsApp12_g_1
{
    class Point
    {
        // поля
        private int m_x;
        private int m_y;

        // свойства
        public int X
        {
            get { return m_x; }
            set { m_x = value; }
        }
        public int Y
        {
            get { return m_y; }
            set { m_y = value; }
        }
        public int MultiplyPointOnScalar
        {
            set 
            {
                m_x *= value;
                m_y *= value;
            }
        }
        // индексатор
        public int this[int index]
        {
            get
            {
                switch (index)
                {
                    case 0:return m_x;
                    case 1: return m_y;
                    default:throw new IndexOutOfRangeException();
                }
            }
            set
            {
                switch (index)
                {
                    case 0: m_x=value;break;
                    case 1: m_y=value;break;
                    default: throw new IndexOutOfRangeException();
                }
            }
        }
        // констркуторы
        public Point()
        {

        }
        public Point(int x, int y)
        {
            m_x = x;
            m_y = y;
        }
        // перегрузки
        public static Point operator ++(Point point)
        {
            point[0]++;
            point[1]++;
            return point;
        }
        public static Point operator --(Point point)
        {
            point[0]--;
            point[1]--;
            return point;
        }
        public static bool operator true(Point point)
        {
            return point.X == point.Y;
        }

        public static bool operator false(Point point)
        {
            return point.X == point.Y;
        }
        public static Point operator +(Point point, int scalar)
        {
            point.X += scalar;
            point.Y += scalar;
            return point;
        }
        public static explicit operator string(Point point)
        {
            return $"{point.X} {point.Y}";
        }
        public static explicit operator Point(string str)
        {
            string[] strings = str.Split(' ');
            return new Point(int.Parse(strings[0]), int.Parse(strings[1]));
        }
        public void PrintPoint()
        {
            Console.WriteLine($"{m_x},{m_y}");
        }
        public float CalcLengthToCoordinatesStart()
        {
            return MathF.Sqrt(m_x * m_x + m_x * m_y);
        }
        public void ReplacePoint(int a,int b)
        {
            m_x += a;
            m_y += b;
        }

    }
}
