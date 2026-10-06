public class LRUCache {
    private readonly List<KeyValuePair<int,int>> _cache;
    int maxCapacity = 0;
    public LRUCache(int capacity) {
        maxCapacity = capacity;
        _cache = new List<KeyValuePair<int,int>>();
    }
    
    public int Get(int key) {
        for(int i = 0;i < _cache.Count;i++)
        {
            if(_cache[i].Key == key)
            {
                var value = _cache[i].Value;
                _cache.RemoveAt(i);
                _cache.Add(new KeyValuePair<int,int>(key,value));
                return value;
            }
        }
        return -1;
    }
    
    public void Put(int key, int value) {
        if(_cache.Count == maxCapacity) 
        {
            _cache.RemoveAt(0);
        }
        for(int i = 0;i < _cache.Count;i++)
        {
            if(_cache[i].Key == key)
            {
                _cache.RemoveAt(i);
                _cache.Add(new KeyValuePair<int,int>(key,value));
                return;
            }
        }
        _cache.Add(new KeyValuePair<int,int>(key,value));
    }
}
