namespace abstractt
{
    public class NewCivic : Car
    {
        public override Brand WhichBrand()
        {
            return Brand.Honda;
        }

        public override Color StandardColor()
        {
            return Color.Gray;
        }
    }
}