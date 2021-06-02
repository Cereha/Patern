namespace Patern
{
   public class SoftGirder 
    {
        public string Color { get;private set; }
        public string Size { get; private set; }
        public string Name { get; private set; }
        public int Price { get; private set; }
        public SoftGirder(string Color, string Size,string Name, int Price)
        {
            this.Color = Color;
            this.Size = Size;
            this.Name = Name;
            this.Price = Price;
        }
        public SoftGirder ShallowCopy()
        {
            return (SoftGirder)this.MemberwiseClone();
        }
        public SoftGirder Clone()
        {
            return new SoftGirder(Color, Size, Name, Price);
        }
    }
}
