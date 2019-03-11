// First version: Single linked list
// Runtime: 476 ms
// Memory Usage: 47.6 MB

public class LRUCache {    
    
    public class node{
        public int mKey;
        public int mValue;
        public node mNext;
        
        public node(int key, int value)
        {
            mKey = key;
            mValue = value;
            mNext = null;
        }
    }
    
    private int count;
    private int cap;
    private node head; 

    public LRUCache(int capacity) {
        count = 0;
        cap = capacity;        
        head = null;
    }
    
    public int Get(int key) {
        if(head == null) return -1;
        
        int rst = -1;
        node tmp = head, prev = null;
        while(tmp != null)
        {
            if(tmp.mKey == key)
            {
                rst = tmp.mValue;
                if(prev != null)
                {
                    prev.mNext = tmp.mNext;
                    tmp.mNext = head;
                    head = tmp;
                }
                break;
            }
            else
            {
                prev = tmp;
                tmp = tmp.mNext;
            }
        }        
        
        return rst;        
    }
    
    public void Put(int key, int value) {
        if(cap == 0) return;        
        if(head == null)
        {
            head = new node(key,value);   
            count++;
            return;
        }
        
        node cur = head, prev = null, tail = null;
        bool found = false;
        while(cur != null)
        {
            if(cur.mKey == key)
            {
                cur.mValue = value;
                found = true;
                break;
            }
            else
            {
                prev = cur;
                cur = cur.mNext;                
            }            
        }
        
        if(found)
        {            
            // if prev == null, found this in head node, do nothing
            if(prev != null)
            {
                // count not update, move this node to the front
                prev.mNext = cur.mNext;
                cur.mNext = head;
                head = cur;                            
            }            
        }
        else
        {
            // if count < cap, insert this node to the front
            if(count < cap)
            {
                cur = new node(key,value);
                cur.mNext = head;
                head = cur;
                count++;                
            }
            // if count == cap, invalidate the LRU node
            else
            {
                tail = head; prev = null;
                while(tail.mNext != null)
                {
                    prev = tail;
                    tail = tail.mNext;
                }
                
                // cap == 1
                if(prev == null)
                {
                    head = new node(key, value);
                }
                else
                {                    
                    prev.mNext = null;
                    node newNode = new node(key,value);
                    newNode.mNext = head;
                    head = newNode;
                }
            }            
        }        
        return;
    }
}

/**
 * Your LRUCache object will be instantiated and called as such:
 * LRUCache obj = new LRUCache(capacity);
 * int param_1 = obj.Get(key);
 * obj.Put(key,value);
 */