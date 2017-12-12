using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KeyValuePair.Core
{
    public static class KeyValuePairManager<TKey, TValue>
    {
        private static IDictionary<TKey, TValue> _keyValuePairsCache = new Dictionary<TKey, TValue>();

        public static void RegistNewKeyValuePair(TKey newKey, TValue newValue)
        {
            var isExistKey = _keyValuePairsCache.ContainsKey(newKey);
            if (isExistKey)
            {
                throw new ArgumentException("新注册的键已经存在，不能注册该键值对", "newKey");
            }
            _keyValuePairsCache.Add(newKey, newValue);
        }

        public static void RemoveKeyValuePair(TKey currentKey)
        {
            var isExistKey = _keyValuePairsCache.ContainsKey(currentKey);
            if (!isExistKey)
            {
                throw new ArgumentException("要删除的键值对不存在，不能注销该键值对", "currentKey");
            }
            _keyValuePairsCache.Remove(currentKey);
        }

        public static void ClearCache()
        {
            var pairCount = _keyValuePairsCache.Count;
            if (pairCount <= 0)
            {
                throw new ArgumentException("不能清空该类型键值对集合，因为集合内元素数量不在有效的范围内");
            }
            _keyValuePairsCache.Clear();
        }

        public static void ModifyKeyValuePair(TKey currentKey, TValue newValue)
        {
            var isExistKey = _keyValuePairsCache.ContainsKey(currentKey);
            if (!isExistKey)
            {
                throw new ArgumentException("要修改的键值对不存在，不能覆盖该键对应的值", "currentKey");
            }
            _keyValuePairsCache[currentKey] = newValue;
        }

        public static TValue GetValueByKey(TKey currentKey)
        {
            var isExistKey = _keyValuePairsCache.ContainsKey(currentKey);
            if (!isExistKey)
            {
                throw new ArgumentException("无法找到要获取的键对应的值", "currentKey");
            }
            return _keyValuePairsCache[currentKey];
        }
    }
}
