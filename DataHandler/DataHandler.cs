using System;
using System.Collections.Generic;

namespace BloomFilter
{
    class DataHandler
    {

        private static Filter filter = new Filter();

        public bool isKeyInCache(String key)
        {
            return filter.notPresentInCache(key);
        }

        public bool addDataToCache(String key, String value)
        {
            filter.addKey(key);
            return false;
        }

        public bool addDataToDb(String key, String valuer)
        {
            return false;
        }

        public bool getDataFromCache(String key)
        {
            return false;
        }

        public bool getDataFromDb(String key)
        {
            return false;
        }


    }
}