// Runtime: 104 ms
// Memory Usage: 26.1 MB

public class Solution {
    public int NumUniqueEmails(string[] emails)
    {
        int rst = 0;
        int emailCnt = emails.Length;

        Dictionary<string, int> uniEmails = new Dictionary<string, int>();
        for (int i = 0; i < emailCnt; i++)
        {
            int atIndex = emails[i].IndexOf('@');

            char[] letters = emails[i].ToCharArray();
            int len = letters.Length;

            char[] tmp = new char[len];
            int tmpIndex = 0;

            for (int j = 0; j < atIndex; j++)
            {
                if (letters[j] == '+')
                {
                    break;
                }
                else if (letters[j] == '.')
                {
                    continue;
                }
                else
                {
                    tmp[tmpIndex++] = letters[j];
                }
            }

            for (int j = atIndex; j < len; j++)
                tmp[tmpIndex++] = letters[j];

            string str = new string(tmp, 0, tmpIndex);
            if (!uniEmails.Keys.Contains(str))
                uniEmails.Add(str, 0);
        }

        rst = uniEmails.Count;
        return rst;
    }
}

// Second edition
// Runtime: 112 ms
// Memory Usage: 26.3 MB
public class Solution {
    public int NumUniqueEmails(string[] emails)
    {
        int rst = 0;
        int emailCnt = emails.Length;

        Dictionary<string, int> uniEmails = new Dictionary<string, int>();
        for (int i = 0; i < emailCnt; i++)
        {            
            int len = emails[i].Length;
            int atIndex = emails[i].IndexOf('@');

            string local = emails[i].Substring(0, atIndex);
            string domain = emails[i].Substring(atIndex + 1, len - atIndex - 1);

            local = local.Replace(".","");
            
            int plusIndex = local.IndexOf('+');
            if(plusIndex >= 0)
            {
                local = local.Substring(0, plusIndex);                           
            }            

            string str = local + "@" + domain;
            if (!uniEmails.Keys.Contains(str))
                uniEmails.Add(str, 0);
        }

        rst = uniEmails.Count;
        return rst;
    }
}

