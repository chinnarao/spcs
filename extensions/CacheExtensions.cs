﻿using Microsoft.Extensions.Caching.Distributed;
using System.IO;
using System.Threading.Tasks;

namespace extensions
{
    public static class CacheExtensions
    {
        public static async Task<bool> GetBooleanAsync(this IDistributedCache cache, string key)
        {
            byte[] bytes = await cache.GetAsync(key);
            using (MemoryStream memoryStream = new MemoryStream(bytes))
            {
                BinaryReader binaryReader = new BinaryReader(memoryStream);
                return binaryReader.ReadBoolean();
            }
        }

        public static async Task<char> GetCharAsync(this IDistributedCache cache, string key)
        {
            byte[] bytes = await cache.GetAsync(key);
            using (MemoryStream memoryStream = new MemoryStream(bytes))
            {
                BinaryReader binaryReader = new BinaryReader(memoryStream);
                return binaryReader.ReadChar();
            }
        }

        public static async Task<decimal> GetDecimalAsync(this IDistributedCache cache, string key)
        {
            byte[] bytes = await cache.GetAsync(key);
            using (MemoryStream memoryStream = new MemoryStream(bytes))
            {
                BinaryReader binaryReader = new BinaryReader(memoryStream);
                return binaryReader.ReadDecimal();
            }
        }

        public static async Task<double> GetDoubleAsync(this IDistributedCache cache, string key)
        {
            byte[] bytes = await cache.GetAsync(key);
            using (MemoryStream memoryStream = new MemoryStream(bytes))
            {
                BinaryReader binaryReader = new BinaryReader(memoryStream);
                return binaryReader.ReadDouble();
            }
        }

        public static async Task<short> GetShortAsync(this IDistributedCache cache, string key)
        {
            byte[] bytes = await cache.GetAsync(key);
            using (MemoryStream memoryStream = new MemoryStream(bytes))
            {
                BinaryReader binaryReader = new BinaryReader(memoryStream);
                return binaryReader.ReadInt16();
            }
        }

        public static async Task<int> GetIntAsync(this IDistributedCache cache, string key)
        {
            byte[] bytes = await cache.GetAsync(key);
            using (MemoryStream memoryStream = new MemoryStream(bytes))
            {
                BinaryReader binaryReader = new BinaryReader(memoryStream);
                return binaryReader.ReadInt32();
            }
        }

        public static async Task<long> GetLongAsync(this IDistributedCache cache, string key)
        {
            byte[] bytes = await cache.GetAsync(key);
            using (MemoryStream memoryStream = new MemoryStream(bytes))
            {
                BinaryReader binaryReader = new BinaryReader(memoryStream);
                return binaryReader.ReadInt64();
            }
        }

        public static async Task<float> GetFloatAsync(this IDistributedCache cache, string key)
        {
            byte[] bytes = await cache.GetAsync(key);
            using (MemoryStream memoryStream = new MemoryStream(bytes))
            {
                BinaryReader binaryReader = new BinaryReader(memoryStream);
                return binaryReader.ReadSingle();
            }
        }

        public static async Task<string> GetStringAsync(this IDistributedCache cache, string key)
        {
            byte[] bytes = await cache.GetAsync(key);
            using (MemoryStream memoryStream = new MemoryStream(bytes))
            {
                BinaryReader binaryReader = new BinaryReader(memoryStream);
                return binaryReader.ReadString();
            }
        }

        public static Task SetAsync(this IDistributedCache cache, string key, bool value, DistributedCacheEntryOptions options)
        {
            byte[] bytes;
            using (MemoryStream memoryStream = new MemoryStream())
            {
                BinaryWriter binaryWriter = new BinaryWriter(memoryStream);
                binaryWriter.Write(value);
                bytes = memoryStream.ToArray();
            }
            return cache.SetAsync(key, bytes, options);
        }

        public static Task SetAsync(this IDistributedCache cache, string key, char value, DistributedCacheEntryOptions options)
        {
            byte[] bytes;
            using (MemoryStream memoryStream = new MemoryStream())
            {
                BinaryWriter binaryWriter = new BinaryWriter(memoryStream);
                binaryWriter.Write(value);
                bytes = memoryStream.ToArray();
            }
            return cache.SetAsync(key, bytes, options);
        }

        public static Task SetAsync(this IDistributedCache cache, string key, decimal value, DistributedCacheEntryOptions options)
        {
            byte[] bytes;
            using (MemoryStream memoryStream = new MemoryStream())
            {
                BinaryWriter binaryWriter = new BinaryWriter(memoryStream);
                binaryWriter.Write(value);
                bytes = memoryStream.ToArray();
            }
            return cache.SetAsync(key, bytes, options);
        }

        public static Task SetAsync(this IDistributedCache cache, string key, double value, DistributedCacheEntryOptions options)
        {
            byte[] bytes;
            using (MemoryStream memoryStream = new MemoryStream())
            {
                BinaryWriter binaryWriter = new BinaryWriter(memoryStream);
                binaryWriter.Write(value);
                bytes = memoryStream.ToArray();
            }
            return cache.SetAsync(key, bytes, options);
        }

        public static Task SetAsync(this IDistributedCache cache, string key, short value, DistributedCacheEntryOptions options)
        {
            byte[] bytes;
            using (MemoryStream memoryStream = new MemoryStream())
            {
                BinaryWriter binaryWriter = new BinaryWriter(memoryStream);
                binaryWriter.Write(value);
                bytes = memoryStream.ToArray();
            }
            return cache.SetAsync(key, bytes, options);
        }

        public static Task SetAsync(this IDistributedCache cache, string key, int value, DistributedCacheEntryOptions options)
        {
            byte[] bytes;
            using (MemoryStream memoryStream = new MemoryStream())
            {
                BinaryWriter binaryWriter = new BinaryWriter(memoryStream);
                binaryWriter.Write(value);
                bytes = memoryStream.ToArray();
            }
            return cache.SetAsync(key, bytes, options);
        }

        public static Task SetAsync(this IDistributedCache cache, string key, long value, DistributedCacheEntryOptions options)
        {
            byte[] bytes;
            using (MemoryStream memoryStream = new MemoryStream())
            {
                BinaryWriter binaryWriter = new BinaryWriter(memoryStream);
                binaryWriter.Write(value);
                bytes = memoryStream.ToArray();
            }
            return cache.SetAsync(key, bytes, options);
        }

        public static Task SetAsync(this IDistributedCache cache, string key, float value, DistributedCacheEntryOptions options)
        {
            byte[] bytes;
            using (MemoryStream memoryStream = new MemoryStream())
            {
                BinaryWriter binaryWriter = new BinaryWriter(memoryStream);
                binaryWriter.Write(value);
                bytes = memoryStream.ToArray();
            }
            return cache.SetAsync(key, bytes, options);
        }

        public static Task SetAsync(this IDistributedCache cache, string key, string value, DistributedCacheEntryOptions options)
        {
            byte[] bytes;
            using (MemoryStream memoryStream = new MemoryStream())
            {
                BinaryWriter binaryWriter = new BinaryWriter(memoryStream);
                binaryWriter.Write(value);
                bytes = memoryStream.ToArray();
            }
            return cache.SetAsync(key, bytes, options);
        }
    }
}