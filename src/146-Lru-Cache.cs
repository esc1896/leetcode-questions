// Second version: HashMap + Double Linked List
// Runtime: 256 ms
// Memory Usage: 48 MB

public class LRUCache
{
    public class node
    {
        public int mKey;
        public int mValue;
        public node mPrev;
        public node mNext;

        public node(int key, int value)
        {
            mKey = key;
            mValue = value;
            mPrev = null;
            mNext = null;
        }
    }

    private int count;
    private int cap;
    private node head, tail;
    private Dictionary<int, node> dict;

    public LRUCache(int capacity)
    {
        count = 0;
        cap = capacity;
        head = new node(0, 0);
        tail = new node(0, 0);
        dict = new Dictionary<int, node>();
    }

    private void insertNodeAfterHead(node tmp)
    {
        tmp.mNext = head.mNext;
        head.mNext.mPrev = tmp;

        tmp.mPrev = head;
        head.mNext = tmp;
    }

    private void moveNodeAfterHead(node tmp)
    {
        tmp.mPrev.mNext = tmp.mNext;
        tmp.mNext.mPrev = tmp.mPrev;

        insertNodeAfterHead(tmp);
    }

    public int Get(int key)
    {
        int rst = -1;
        if (dict.Keys.Contains(key))
        {
            node tmp = dict[key];

            moveNodeAfterHead(tmp);

            rst = dict[key].mValue;
        }
        return rst;
    }

    public void Put(int key, int value)
    {
        if (cap == 0) return;

        // node in list
        if (dict.Keys.Contains(key))
        {
            node tmp = dict[key];
            tmp.mValue = value;

            moveNodeAfterHead(tmp);
        }
        else
        {
            // count < cap, add new node at head
            if (count < cap)
            {
                node tmp = new node(key, value);

                // First node, link to tail as well
                if (count == 0)
                {
                    head.mNext = tmp;
                    tmp.mPrev = head;

                    tmp.mNext = tail;
                    tail.mPrev = tmp;
                }
                else
                {
                    insertNodeAfterHead(tmp);
                }

                dict.Add(key, tmp);
                count++;
            }
            // count == cap, remove tail, add new node at head                        
            else
            {
                dict.Remove(tail.mPrev.mKey);
                node prevPrev = tail.mPrev.mPrev;
                prevPrev.mNext = tail;
                tail.mPrev = prevPrev;

                node tmp = new node(key, value);
                insertNodeAfterHead(tmp);
                dict.Add(key, tmp);
            }
        }
        return;
    }
}


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