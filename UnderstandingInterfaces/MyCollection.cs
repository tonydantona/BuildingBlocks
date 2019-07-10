namespace UnderstandingInterfaces
{
    public class MyCollection : IIterator
    {
        private readonly int[] _array = new int[6];
       
        private int _position = 0;

        public MyCollection()
        {
            for (int i = 0; i < 6; i++)
            {
                _array[i] = i;
            }
        }

        public bool HasNext()
        {
            if (_position >= _array.Length)
                return false;
            else
            {
                return true;
            }
        }

        public int Next()
        {
            int temp = _array[_position];
            _position += 1;
            return temp;
        }
    }
}