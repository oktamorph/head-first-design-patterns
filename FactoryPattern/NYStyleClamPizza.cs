namespace FactoryPattern
{
    public class NYStyleClamPizza : Pizza
    {
        public NYStyleClamPizza()
        {
            name = "NY Style Clam Pizza";
            toppings.Add("Clams");
        }
        public override void Prepare()
        {
            throw new NotImplementedException();
        }
    }
}
