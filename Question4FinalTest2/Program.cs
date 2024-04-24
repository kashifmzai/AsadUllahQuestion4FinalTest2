namespace Question4FinalTest2
{
    public class ValueCollection<T>where T : struct
    {
        private List<T> collection = new List<T>();
        public void AddItem(T item)
        {
            collection.Add(item);
        }
        public T GetItem(int index) {
            if (index <0||index>=collection.Count)
            {
                throw new IndexOutOfRangeException("index is out of range");
            }
            return collection[index];
        }
        public IEnumerable<T> GetSortedDescending() {
            return collection.OrderByDescending(item => item);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
