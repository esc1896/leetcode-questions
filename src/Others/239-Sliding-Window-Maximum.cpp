// Deque
// Runtime: 60 ms
// Memory Usage: 13.5 MB

#include <vector>
#include <deque>
#include <algorithm>

class monoqueue{
    deque<pair<int, int>> m_deque;

    public:
    void push(int val)
    {
        int count = 0;
        while(!m_deque.empty() && m_deque.back().first < val)
        {
            count += (m_deque.back().second + 1);
            m_deque.pop_back();            
        }
        m_deque.emplace_back(val,count);
    }

    int max()
    {
        return m_deque.front().first;        
    }

    void pop()
    {
        if(m_deque.front().second > 0)
        {
            m_deque.front().second--;
            return;
        }

        m_deque.pop_front();        
    }
};

class Solution {
public:        
    vector<int> maxSlidingWindow(vector<int>& nums, int k) {
        
        vector<int> rst;
        monoqueue mq;
        
        k = min(k, (int)nums.size());
        
        int i = 0;
        for(; i < k - 1; i++)
        {
            mq.push(nums[i]);            
        }
        
        for(; i < (int)nums.size(); i++)
        {
            mq.push(nums[i]);
            rst.push_back(mq.max());
            mq.pop();            
        }
        
        return rst;
    }
};