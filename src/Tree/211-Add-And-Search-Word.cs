public class WordDictionary {
    
    public class TrieNode
    {
        public char data;
        public TrieNode[] childNodes;
        public bool isEnd = false;
        public TrieNode(char input)
        {
            data = input;
            childNodes = new TrieNode[26];
            for(int i = 0; i < 26; i++) childNodes[i] = null;
        }
    }
    
    public TrieNode root;

    /** Initialize your data structure here. */
    public WordDictionary() {
        root = new TrieNode('/');
    }
    
    /** Adds a word into the data structure. */
    public void AddWord(string word) {
        
        if(string.IsNullOrEmpty(word)) return;
        
        var node = root;
        for(int i = 0; i < word.Length; i++)
        {
            if(node.childNodes[word[i]-'a'] == null)
            {
                node.childNodes[word[i]-'a'] = new TrieNode(word[i]);                                
            }            
            node = node.childNodes[word[i]-'a'];            
        }
        
        node.isEnd = true;
        
        return;        
    }
    
    /** Returns if the word is in the data structure. A word could contain the dot character '.' to represent any one letter. */
    public bool Search(string word) {
        return match(word, root, 0);                           
    }
    
    private bool match(string word, TrieNode node, int index)
    {
        if(string.IsNullOrEmpty(word)) return true;                
        
        if(index == word.Length) return node.isEnd;
        
        if(word[index] != '.')
        {            
            return node.childNodes[word[index]-'a'] != null 
            && match(word, node.childNodes[word[index]-'a'], index+1);
        }
        
        for(int i = 0; i < 26; i++)
        {
            if(node.childNodes[i] != null 
               && match(word, node.childNodes[i], index+1))
            {
                return true;
            }                
        }
            
        return false;        
    }
}

/**
 * Your WordDictionary object will be instantiated and called as such:
 * WordDictionary obj = new WordDictionary();
 * obj.AddWord(word);
 * bool param_2 = obj.Search(word);
 */
