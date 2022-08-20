namespace IteratorAndCompositePatterns
{
    public interface Iterator<T>
    {
        bool HasNext();
        MenuItem Next();
    }
}
