using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp11_с_1
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
        // констркуторы
        public Point()
        {

        }
        public Point(int x, int y)
        {
            m_x = x;
            m_y = y;
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
