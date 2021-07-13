namespace Algorithms
{
    /// <summary>
    /// </summary>
    public class QuickFindUF
    {
        public QuickFindUF(int n)
        {
            Ids = new int[n];
            for (var i = 0; i < Ids.Length; i++)
                Ids[i] = i;
        }

        private int[] Ids { get; }

        /// <summary>
        /// </summary>
        /// <param name="p"></param>
        /// <param name="q"></param>
        /// <returns></returns>
        public bool IsConnected(int p, int q)
        {
            return Ids[p] == Ids[q];
        }

        /// <summary>
        /// </summary>
        /// <param name="p"></param>
        /// <param name="q"></param>
        public void Union(int p, int q)
        {
            var pId = Ids[p];
            var qId = Ids[q];
            for (var i = 0; i < Ids.Length; i++)
                if (Ids[i] == pId)
                    Ids[i] = qId;
        }
    }
}