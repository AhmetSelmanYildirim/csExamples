namespace abstractt
{

    public abstract class Car
    {

        public int HowManyTires()
        {
            return 4;
        }

        public virtual Color StandardColor()
        {
            return Color.White;
        }

        public abstract Brand WhichBrand();

    }

}