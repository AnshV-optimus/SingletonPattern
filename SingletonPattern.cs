namespace Singleton
{
    public class SingletonPattern
    {
        private static SingletonPattern instance = null;

        // Private constructor to prevent instantiation from outside
        private SingletonPattern() { }

        // Public property to access the Singleton instance
        public static SingletonPattern Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new SingletonPattern();
                    Console.WriteLine("Object Created");
                }
                return instance;
            }
        }

        // Example method to demonstrate functionality
        public void DisplayMessage()
        {
            Console.WriteLine("Singleton Instance is being used.");
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            // Access the Singleton instance
            SingletonPattern singletonPattern = SingletonPattern.Instance;
            singletonPattern.DisplayMessage();

            // Try to access the Singleton instance again
            SingletonPattern anotherInstance = SingletonPattern.Instance;
            anotherInstance.DisplayMessage();

            // Verify both instances are the same
            Console.WriteLine($"Are both instances equal? {singletonPattern == anotherInstance}");
        }
    }
}
