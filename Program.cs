using System;

namespace BloomFilter
{
    class Program
    {

        private static DataHandler dataHandler = new DataHandler();

        static void Main(string[] args)
        {

            bool addKeyToCache = dataHandler.addDataToCache("Hi", "Hello");
            Console.WriteLine(addKeyToCache);

            bool isKeyPresent = dataHandler.isKeyInCache("Hi");
            Console.WriteLine(isKeyPresent);
        }
    }
}
