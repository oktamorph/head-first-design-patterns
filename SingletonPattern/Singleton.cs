namespace SingletonPattern
{
    public class Singleton
    {
        // Lazy instantiation of the Singleton Pattern.
        private static Singleton _uniqueInstance;
        private Singleton() { }
        public static Singleton GetInstance()
        {
            lock (_uniqueInstance)
            {
                if (_uniqueInstance == null)
                {
                    _uniqueInstance = new Singleton();
                }
                return _uniqueInstance;
            }
        }

        // Eagerly instantiation of the Singleton Pattern.
        //private static Singleton _uniqueInstance = new Singleton();
        //private Singleton() { }
        //public static Singleton GetInstance()
        //{
        //    return _uniqueInstance;
        //}

        // Double-checked locking to reduce the use of synchronization.
        //private volatile static Singleton _uniqueInstance;
        //private Singleton() { }
        //public static Singleton GetInstance()
        //{
        //    if (_uniqueInstance == null)
        //    {
        //        lock (_uniqueInstance)
        //        {
        //            if (_uniqueInstance == null)
        //            {
        //                _uniqueInstance = new Singleton();
        //            }
        //        }
        //    }
        //    return _uniqueInstance;
        //}

    }

    // Implementation of the Singleton Pattern using enum.
    //public enum Singletons
    //{
    //    UNIQUE_INSTANCE
    //}
    //public class SingletonClient
    //{
    //    public static void Main(string[] args)
    //    {
    //        Singletons singleton = Singletons.UNIQUE_INSTANCE;
    //    }
    //}
}
