namespace DesignPatterns.Implementations
{
    public class SingletonClass
    {
        private static SingletonClass _instance;

        private SingletonClass() { }

        public int SomeProperty { get; set; }

        public static SingletonClass GetInstance()
        {
            if (_instance == null) _instance = new SingletonClass();

            return _instance;
        }
    }
}
