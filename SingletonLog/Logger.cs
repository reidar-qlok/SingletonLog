namespace SingletonLog
{
    // Implementerar en singleton för bara en instans
    public class Logger
    {
        // privat statisk variable som håller en logger instans
        private static volatile Logger instance;
        private static readonly object lockObject = new object();
        private Logger() { }
        public static Logger Instance
        {
            get
            {
                // Första kontrollen av instansen utan lås för att förbättra prestanda
                if (instance == null)
                {
                    // Låsning av kritisk sektion för att säkerställa trådsäkerhet
                    lock (lockObject)
                    {
                        // Andra kontrollen av instansen inom lås för att säkerställa att endast en instans skapas
                        if (instance == null)
                        {
                            instance = new Logger();
                        }
                    }
                }
                return instance;
            }
        }
        // publik metod för att logga till konsollen
        public void Log(string message)
        {
            Console.WriteLine($"[{DateTime.Now}] {message}");
        }

    }
}
