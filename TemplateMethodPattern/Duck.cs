namespace TemplateMethodPattern
{
    public class Duck : IComparable<Duck>
    {
        string name;
        int weight;

        public Duck(string name, int weight)
        {
            this.name = name;
            this.weight = weight;
        }
        public override string ToString()
        {
            return name + " weighs " + weight;
        }
        public int CompareTo(Duck otherDuck)
        {
            if (this.weight < otherDuck.weight)
                return -1;
            else if (this.weight == otherDuck.weight)
                return 0;
            else
                return 1;
        }
    }
}
