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