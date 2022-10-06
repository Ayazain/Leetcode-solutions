public class Solution {
    public class TrieNode
    {

        public bool isEnd;
        public int index;
        public Dictionary<char, TrieNode> child;

        public TrieNode(bool _isEnd)
        {

            isEnd = _isEnd;
            child = new Dictionary<char, TrieNode>();
        }
    }

    public  void CreateDic(string[] words)
    {
        for (int i = 0; i < words.Length; i++)
        {
            TrieNode copy = root; int index = 0;
            while (index < words[i].Length)
            {
                if (!copy.child.ContainsKey(words[i][index]))
                    copy.child.Add(words[i][index], new TrieNode((index == words[i].Length - 1) ? true : false));

                copy = copy.child[words[i][index]];
                if (index == words[i].Length - 1)
                {
                    copy.isEnd = true; copy.index = i;
                }
                index++;
            }
        }
    }
    public  TrieNode root;
   
    public  IList<string> FindWords(char[][] board, string[] words)
    {
        root = new TrieNode(false);
        CreateDic(words);

        IList<string> res = new List<string>();
        for (int i = 0; i < board.Length; i++)
            for (int j = 0; j < board[0].Length; j++)
                FindWordHelper(board, new KeyValuePair<int, int>(i, j), root);

        for (int i = 0; i < listOfIndeces.Count; i++)
            res.Add(words[listOfIndeces[i]]);
        return res;
    }

    public  List<int> listOfIndeces = new List<int>();
    public  void FindWordHelper(char[][] board, KeyValuePair<int, int> boardindex, TrieNode root)
    {
        if (root == null) return;
       
        int i = boardindex.Key;
        int j = boardindex.Value;
        if (!root.child.ContainsKey(board[i][j])) return;
        root = root.child[board[i][j]];
        if (root.isEnd){ listOfIndeces.Add(root.index); root.isEnd = false  ;} 
        char myC = board[i][j];
        board[i][j] = '$';
        foreach (KeyValuePair<char, TrieNode> ch in root.child)
        {
            char c = ch.Key;

            if (i >= 1 && board[i - 1][j] == c)

                FindWordHelper(board, new KeyValuePair<int, int>(i - 1, j), root);

            if (i < board.Length - 1 && board[i + 1][j] == c)
                FindWordHelper(board, new KeyValuePair<int, int>(i + 1, j),root);

            if (j >= 1 && board[i][j - 1] == c)
                FindWordHelper(board, new KeyValuePair<int, int>(i, j - 1),root);

            if (j < board[0].Length - 1 && board[i][j + 1] == c)
                FindWordHelper(board, new KeyValuePair<int, int>(i, j + 1),root);

        }
        board[i][j] = myC;
        return;
    }
}