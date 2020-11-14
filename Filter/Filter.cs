using System;
using System.Text;
using System.Collections.Generic;
using System.Security.Cryptography;

namespace BloomFilter
{
    class Filter
    {

        private ulong keysNotInCache = 0;

        private int hashInt(String key) {
            SHA256 hash = SHA256.Create();
            int hashInt = 0;
            foreach (var digit in hash.ComputeHash(Encoding.ASCII.GetBytes(key))) hashInt += digit; 
            return hashInt;
        }

        public bool notPresentInCache(String key)
        {
            int hash = hashInt(key);
            return (keysNotInCache & ((ulong)1 << hash)) != 0;
        }

        public void addKey(String key)
        {
            int hash = hashInt(key);
            keysNotInCache |= ((ulong)1 << hash);
        }

    }
}