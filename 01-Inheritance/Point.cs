using System;

namespace Classes.Inheritance
{
    public class Point
    {
        public int x, y;
        private int distance;
        public Point(int x, int y) // constructor - very similar to Dart
        {
            this.x = x;
            this.y = y;
        }
        protected void DistanceCalc()
        {
            DistanceCalc2();
        }
        private void DistanceCalc2()
        {

        }
        public virtual void DistanceCalc3() // when using virtual, it makes it possible that child class modifies its behavior - overrides
        {

        }
    }

}
