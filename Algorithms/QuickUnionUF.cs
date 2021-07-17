namespace Algorithms
{
    /// <summary>
    ///     Quick union. Lazy approach.
    /// </summary>
    public class QuickUnionUF
    {
        public QuickUnionUF(int n)
        {
            Ids = new int[n];
            for (var i = 0; i < Ids.Length; i++)
                Ids[i] = i;
        }

        private int[] Ids { get; }

        public bool IsConnected(int p, int q)
        {
            return GetRoot(p) == GetRoot(q);
        }

        public void Union(int p, int q)
        {
            var i = GetRoot(p);
            var j = GetRoot(q);
            Ids[i] = j;
        }

        private int GetRoot(int i)
        {
            while (i != Ids[i])
                i = Ids[i];

            return i;
        }
    }
}