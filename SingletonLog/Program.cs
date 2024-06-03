namespace SingletonLog
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Logger logger = Logger.Instance;
            logger.Log("Programmet är i gång");
            DoSomething();
            DoSomethingElse();
            logger.Log("Programmet har stoppats");

        }
        static void DoSomething()
        {
            // Hämtar singleton-instansen av Logger och loggar ett meddelande om att något görs
            Logger logger = Logger.Instance;
            logger.Log("Doing something...");
        }

        // En annan metod som representerar en annan verksamhet i programmet och loggar ett meddelande
        static void DoSomethingElse()
        {
            // Hämtar singleton-instansen av Logger och loggar ett meddelande om att något annat görs
            Logger logger = Logger.Instance;
            logger.Log("Doing something else...");
        }
    }
}
