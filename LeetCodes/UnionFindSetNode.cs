namespace LeetCodes
{
    public class UnionFindNode
    {
        private int rank;
        private UnionFindNode _parent;

        public UnionFindNode()
        {
            rank = 0;
            _parent = this;
        }

        public UnionFindNode Find()
        {
            if (ReferenceEquals(_parent, this))
            {
                _parent = _parent.Find();
            }

            return _parent;
        }

        public bool IsUnionWith(UnionFindNode p2)
        {
            return ReferenceEquals(Find(), p2.Find());
        }

        public bool Union(UnionFindNode p2)
        {
            var root1 = Find();
            var root2 = p2.Find();

            if (ReferenceEquals(root1, root2))
            {
                return false;
            }

            if (root1.rank < root2.rank)
            {
                root1._parent = root2;
            }else if (root1.rank > root2.rank)
            {
                root2._parent = root1;
            }
            else
            {
                root2._parent = root1;
                root1.rank++;
            }

            return true;
        }
    }
}