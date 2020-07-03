// Runtime: 160 ms
// Memory Usage: 33.4 MB

public class MyCircularDeque {
    
    private int[] queue;
    private int count;
    private int size;
    private int frontIndex;
    private int lastIndex;

    /** Initialize your data structure here. Set the size of the deque to be k. */
    public MyCircularDeque(int k) {
        
        queue = new int[k];
        size = k;
        count = 0;        
        
        frontIndex = 0;
        lastIndex = size - 1;
    }
    
    /** Adds an item at the front of Deque. Return true if the operation is successful. */
    public bool InsertFront(int value) {
        
        if((count == size)||(frontIndex > lastIndex)) return false;
        
        queue[frontIndex] = value;
        frontIndex++;
        count++;        
        return true;
    }
    
    /** Adds an item at the rear of Deque. Return true if the operation is successful. */
    public bool InsertLast(int value) {
        
        if((count == size)||(frontIndex > lastIndex)) return false;
        
        queue[lastIndex] = value;
        lastIndex--;
        count++;        
        return true;        
    }
    
    /** Deletes an item from the front of Deque. Return true if the operation is successful. */
    public bool DeleteFront() {
        
        if(count == 0) return false;
        
        if(frontIndex == 0)
        {
            if(lastIndex < size - 1)
            {
               for(int i = size - 1; i > lastIndex; i--)
               {
                   queue[i] = queue[i-1];
               }
                lastIndex++;
            }
            else
            {
                return false;
            }
        }
        else
        {
            frontIndex--;            
        }
                    
        count--;         
        return true;        
    }
    
    /** Deletes an item from the rear of Deque. Return true if the operation is successful. */
    public bool DeleteLast() {
        
        if(count == 0) return false;
        if(lastIndex == size - 1 )
        {
            if(frontIndex > 0)
            {
                for(int i = 0; i < frontIndex; i++)
                {
                    queue[i] = queue[i+1];
                }
                frontIndex--;
            }
            else
            {
                return false;
            }
        }
        else
        {
            lastIndex++;
        }
        
        count--;        
        return true;                
    }
    
    /** Get the front item from the deque. */
    public int GetFront() {

        if(frontIndex == 0)
        {
            if(lastIndex < (size - 1))
            {
                return queue[size-1];
            }
            else
            {
                return -1;
            }
        }
        
        return queue[frontIndex-1];
    }
    
    /** Get the last item from the deque. */
    public int GetRear() {
        
        if(lastIndex == (size - 1))
        {
            if(frontIndex > 0)
            {
                return queue[0];
            }
            else
            {
                return -1;
            }
        }
        
        return queue[lastIndex+1];        
    }
    
    /** Checks whether the circular deque is empty or not. */
    public bool IsEmpty() {
        return (count == 0);
    }
    
    /** Checks whether the circular deque is full or not. */
    public bool IsFull() {
        return (count == size);
    }
}

/**
 * Your MyCircularDeque object will be instantiated and called as such:
 * MyCircularDeque obj = new MyCircularDeque(k);
 * bool param_1 = obj.InsertFront(value);
 * bool param_2 = obj.InsertLast(value);
 * bool param_3 = obj.DeleteFront();
 * bool param_4 = obj.DeleteLast();
 * int param_5 = obj.GetFront();
 * int param_6 = obj.GetRear();
 * bool param_7 = obj.IsEmpty();
 * bool param_8 = obj.IsFull();
 */