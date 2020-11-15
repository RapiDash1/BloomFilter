using System;
using StackExchange.Redis;

namespace BloomFilter
{
    class Redis
    {

        private IDatabase conn;
        
        public Redis()
        {
            ConfigurationOptions option = new ConfigurationOptions
            {
                AbortOnConnectFail = false,
                EndPoints = { "hostname:6379" }
            };
            ConnectionMultiplexer muxer = ConnectionMultiplexer.Connect("localhost,AbortOnConnectFail:false");
            conn = muxer.GetDatabase();
        }

        public void addData(String key, String value)
        {
            conn.StringSet(key, value);
        }
        
        public String getData(String key)
        {
            return conn.StringGet(key);
        }

    }
}