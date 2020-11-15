using System;

namespace BloomFilter
{
    class Program
    {

        private static DataHandler dataHandler = new DataHandler();

        static void Main(string[] args)
        {

            // bool addKeyToCache = dataHandler.addDataToCache("Hi", "Hello");

            // if (dataHandler.isKeyInCache("Hi"))
            // {
            //     Console.WriteLine(dataHandler.getDataFromCache("Hi"));
            // } 
            // else
            // {

            // }
            dataHandler.addDataToDb("Hi", "Hello");
        }
    }
}
