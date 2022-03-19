namespace DecoratorPattern
{
    public abstract class Beverage
    {
        public virtual string Description { get; protected set; } = "Unknown Beverage";
        public enum Size { TALL, GRANDE, VENTI };
        Size size = Size.TALL;
        public abstract double Cost();
        public void SetSize(Size size)
        {
            this.size = size;
        }
        public Size GetSize()
        {
            return this.size;
        }
    }
}
