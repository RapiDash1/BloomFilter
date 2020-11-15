using System;
using System.Collections.Generic;

namespace BloomFilter
{
    class DataHandler
    {

        private static Filter filter = new Filter();

        private static Redis redis = new Redis();

        private static Postgres postgres = new Postgres();

        public bool isKeyInCache(String key)
        {
            return filter.notPresentInCache(key);
        }

        public bool addDataToCache(String key, String value)
        {
            filter.addKey(key);
            redis.addData(key, value);
            return true;
        }

        public bool addDataToDb(String key, String value)
        {
            postgres.addData(key, value);
            return true;
        }

        public String getDataFromCache(String key)
        {
            return redis.getData(key);
        }

        public bool getDataFromDb(String key)
        {
            return false;
        }


    }
}