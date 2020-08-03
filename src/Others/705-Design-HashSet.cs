public class MyHashSet {

    List<int>[] elements;

    /** Initialize your data structure here. */
    public MyHashSet() {
        elements = new List<int>[1024];
        for(int i = 0; i < 1024; i++) elements[i] = new List<int>();
    }
    
    public void Add(int key) {
        var index = key % 1024;
        var element = elements[index];
        if(!element.Contains(key)) element.Add(key);
    }
    
    public void Remove(int key) {
        var index = key % 1024;
        var element = elements[index];
        if(element.Contains(key)) element.Remove(key);
    }
    
    /** Returns true if this set contains the specified element */
    public bool Contains(int key) {
        int index = key % 1024;
        var element = elements[index];
        if(element.Contains(key))
            return true;
        else
            return false;
    }
}

/**
 * Your MyHashSet object will be instantiated and called as such:
 * MyHashSet obj = new MyHashSet();
 * obj.Add(key);
 * obj.Remove(key);
 * bool param_3 = obj.Contains(key);
 */
