namespace GenericsContraints
{
    class CommonFeature<T> where T : class, new()
    {
        public T GetById(int id)
        {
            //Your operation
            T aT = new T();
            return aT;
        }

        public T DeleteById(int id)
        {
            //Your Operation
            return new T();
        }

        public T GetIncetance<T>() where T : class, new()
        {
            return new T();
        }
    }
}