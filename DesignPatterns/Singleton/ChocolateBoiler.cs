namespace DesignPatterns.Singleton
{
    internal class ChocolateBoiler
    {
        // Можна заранє створити екземпляр
        // private static readonly Singleton instance = new Singleton();
        // Тоді необхідність в синхронізації відпадає
        private static ChocolateBoiler instance;
        private static object syncRoot = new object();

        public bool isEmpty { get; private set; }
        public bool isBoiled { get; private set; }

        private ChocolateBoiler()
        {
            isEmpty = true;
            isBoiled = false;
        }

        public static ChocolateBoiler GetInstance()
        {
            if (instance == null)
            {
                lock (syncRoot)
                {
                    if (instance == null)
                        instance = new ChocolateBoiler();
                }
            }
            return instance;
        }

        public void Fill()
        {
            if (isEmpty)
            {
                isEmpty = false;
                isBoiled = false;
                // Заполнение нагревателя молочно-шоколадной смесью
            }
        }
        public void drain()
        {
            if (!isEmpty && isBoiled)
            {
                // Слить нагретое молоко и шоколад
                isEmpty = true;
            }
        }
        public void boil()
        {
            if (!isEmpty && !isBoiled)
            {
                // Довести содержимое до кипения
                isBoiled = true;
            }
        }
    }
}
