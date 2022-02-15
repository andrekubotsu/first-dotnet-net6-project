namespace Classes.Inheritance
{
    public class Point3D : Point // inheritance
    {
        public int z;
        public Point3D(int x, int y, int z) : base(x, y)
        {
            this.z = z;
            DistanceCalc();
        }
        public static void Calc() // it does not belong to the instance, but to the class -> Point3D.Calc to access
        {

        }
        public override void DistanceCalc3()
        {
            // do something else
            // call:
            base.DistanceCalc3();
        }
    }
}